Imports System.Security.Cryptography.X509Certificates

Namespace Signer
    Public Class SignerCollection

        Private itemValue As New Generic.List(Of Signer)

        Public Property Items As Generic.List(Of Signer)
            Get
                Return itemValue
            End Get
            Set(value As Generic.List(Of Signer))
                Me.itemValue = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub SigninColletion()
            If itemValue.Count = 0 Then Throw New SignerException("A coleção está vazia. Adicione itens a lista para concluir a opeção.")
            Dim cert As X509Certificate2 = ExternalSignature.GetExternalSignature()
            For Each i As Signer In Me.itemValue
                i.Signin(cert)
            Next
        End Sub

    End Class

End Namespace