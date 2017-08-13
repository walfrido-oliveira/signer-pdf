Imports System.Configuration

Namespace Configuration
    Public Class Configuration

        Public Enum Keys As Integer
            outputFolder
            overlap
            signerText
            signerVisible
            textSignerVisible
            numberPage
            firstPage
            lastPage
            img
            sizeImg
            x
            y
            fontSize
            folders
        End Enum

        Public Shared Function Read(ByVal key As Keys) As String
            Return ConfigurationManager.AppSettings(key.ToString)
        End Function

        Public Shared Sub Write(ByVal key As Keys, ByVal value As String)
            Try
                Dim conf As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
                If conf.AppSettings.Settings(key.ToString()).Value Is Nothing Then
                    conf.AppSettings.Settings.Add(key.ToString, value)
                Else
                    conf.AppSettings.Settings(key.ToString()).Value = value
                End If
                conf.Save(ConfigurationSaveMode.Modified)
                ConfigurationManager.RefreshSection(conf.AppSettings.SectionInformation.Name)
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace

