Public Class MessageBox

    Public Shared Sub Show(ByVal mensagem As String, ByVal typeButtons As System.Windows.Forms.MessageBoxButtons,
                   ByVal typeIcon As System.Windows.Forms.MessageBoxIcon)
        System.Windows.Forms.MessageBox.Show(mensagem, "Signer PDF", typeButtons, typeIcon)
    End Sub
End Class
