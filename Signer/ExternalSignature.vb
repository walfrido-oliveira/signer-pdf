Imports System.Security.Cryptography.X509Certificates

Namespace Signer
    Public Class ExternalSignature

        Public Shared Function GetExternalSignature()
            Dim store As X509Store = New X509Store(StoreLocation.CurrentUser)
            store.Open(OpenFlags.ReadOnly)
            Dim sel As X509Certificate2Collection = X509Certificate2UI.SelectFromCollection(store.Certificates, Nothing, Nothing, X509SelectionFlag.SingleSelection)
            If sel.Count > 0 Then Return sel(0)
            Throw New SignerException("Nenhum certificado foi selecionado.")
        End Function

    End Class

End Namespace