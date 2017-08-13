Namespace Signer
    Public Class SignerException
        Inherits Exception

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal mensagem As String)
            MyBase.New(mensagem)
        End Sub

    End Class

End Namespace