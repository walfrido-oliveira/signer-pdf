Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports iTextSharp.text.pdf.security
Imports iTextSharp.text

Namespace Signer
    Public Class Signer

#Region "Variaveis"
        Private inputPDF As String
        Private outputPDF As String
        Private conf As New Configuration.ConfigurationCreator()

        Private Const lly As Single = 67.36F
        Private Const urx As Single = 90.0F
        Private Const llx As Single = 350.0F
        Private Const ury As Single = 141.0F
#End Region

#Region "Propertys"

        Public Property InputFile() As String
            Get
                Return inputPDF
            End Get
            Set(ByVal value As String)
                inputPDF = value
            End Set
        End Property

        Public Property OutputFile() As String
            Get
                Return outputPDF
            End Get
            Set(ByVal value As String)
                outputPDF = value
            End Set
        End Property
#End Region

        Public Sub New(ByVal input As String, ByVal output As String, ByVal conf As Configuration.ConfigurationCreator)
            Me.inputPDF = input
            Me.outputPDF = output
            Me.conf = conf
            ConfigOutputFolder()
        End Sub

        Public Function Signin() As Boolean
            Try
                Dim cert As X509Certificate2 = SignerPDF.Signer.ExternalSignature.GetExternalSignature()
                If cert Is Nothing Then Exit Function
                Dim cp As New Org.BouncyCastle.X509.X509CertificateParser()
                Dim chain As Org.BouncyCastle.X509.X509Certificate() = New Org.BouncyCastle.X509.X509Certificate() {cp.ReadCertificate(cert.RawData)}
                Dim externalSignature As IExternalSignature = New X509Certificate2Signature(cert, "SHA-1")

                Dim reader As New PdfReader(Me.inputPDF)
                Dim st As PdfStamper = PdfStamper.CreateSignature(reader, New FileStream(Me.outputPDF, FileMode.Create, FileAccess.Write), ControlChars.NullChar, Nothing, True)
                Dim sap As PdfSignatureAppearance = st.SignatureAppearance
                ConfigPDFSignatureAppearance(sap, reader)

                MakeSignature.SignDetached(sap, externalSignature, chain, Nothing, Nothing, Nothing, 0, CryptoStandard.CMS)

                If conf.Overlap Then
                    Dim s As String = inputPDF
                    File.Delete(inputPDF)
                    File.Copy(outputPDF, s)
                    File.Delete(outputPDF)
                End If
                st.Close()
                Return True
            Catch ex As Exception
                Throw New SignerException(ex.Message)
            End Try
        End Function

        Public Function Signin(ByVal signature As X509Certificate2) As Boolean
            Try
                Dim cert As X509Certificate2 = signature
                If cert Is Nothing Then Exit Function
                Dim cp As New Org.BouncyCastle.X509.X509CertificateParser()
                Dim chain As Org.BouncyCastle.X509.X509Certificate() = New Org.BouncyCastle.X509.X509Certificate() {cp.ReadCertificate(cert.RawData)}
                Dim externalSignature As IExternalSignature = New X509Certificate2Signature(cert, "SHA-1")

                Dim reader As New PdfReader(Me.inputPDF)
                Dim st As PdfStamper = PdfStamper.CreateSignature(reader, New FileStream(Me.outputPDF, FileMode.Create, FileAccess.Write), ControlChars.NullChar, Nothing, True)
                Dim sap As PdfSignatureAppearance = st.SignatureAppearance
                ConfigPDFSignatureAppearance(sap, reader)

                MakeSignature.SignDetached(sap, externalSignature, chain, Nothing, Nothing, Nothing, 0, CryptoStandard.CMS)

                If conf.Overlap Then
                    Dim s As String = inputPDF
                    File.Delete(inputPDF)
                    File.Copy(outputPDF, s)
                    File.Delete(outputPDF)
                End If
                st.Close()
                Return True
            Catch ex As Exception
                Throw New SignerException(ex.Message)
            End Try
        End Function

        Private Sub ConfigPDFSignatureAppearance(ByRef sap As PdfSignatureAppearance, ByRef reader As PdfReader)
            Dim llx As Single = 0
            Dim lly As Single = 0
            Dim urx As Single = 0
            Dim ury As Single = 0
            Dim numberPage As Integer = 0

            If conf.FirstPage Then numberPage = 1
            If conf.LastPage Then numberPage = reader.NumberOfPages
            If Not conf.LastPage And Not conf.FirstPage Then numberPage = conf.NumberPage

            If conf.SignerVisible Then
                sap.Layer2Text = ""
                If conf.TextSignerVisible Then
                    sap.Layer2Text = conf.SignerText
                    sap.Layer2Font = New Font(Font.FontFamily.TIMES_ROMAN, conf.FontSize)
                End If
                If Not File.Exists(conf.Img) Then Throw New SignerException(String.Format("A imagem {0} que compõe o corpo da assinatura não foi localizada. Operacação cancelada.", conf.Img))
                Dim signatureFieldImage As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(conf.Img)
                sap.Image = signatureFieldImage
                ury = ((conf.X / 100) * reader.GetPageSize(numberPage).Height)
                lly = ury + (sap.Image.Height) * (conf.sizeImg / 100)
                llx = ((conf.Y / 100) * reader.GetPageSize(numberPage).Width)
                urx = llx + (sap.Image.Width) * (conf.sizeImg / 100)
                Dim rectangle As New Rectangle(llx, lly, urx, ury)
                sap.SetVisibleSignature(rectangle, numberPage, Nothing)
            End If
        End Sub

        Private Sub ConfigOutputFolder()
            If Not File.Exists(Me.inputPDF) Then Throw New SignerException(String.Format("O arquivo {0} não foi localizado. Operação cancelada.", Me.inputPDF))
            If conf.Overlap Then
                Me.outputPDF = Me.inputPDF & "-"
            Else
                Me.outputPDF = conf.OutputFolder & Me.inputPDF.Substring(Me.inputPDF.LastIndexOf("\"))
            End If
        End Sub

        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub
    End Class
End Namespace

