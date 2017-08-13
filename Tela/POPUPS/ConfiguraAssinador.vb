
Namespace Tela.Popup
    Public Class ConfiguraAssinador

        Private valid As New Visomes.Validation.Validating()
        Private conf As New Configuration.ConfigurationCreator()

        Public Sub New()
            InitializeComponent()
            LoadConfigurations()
        End Sub

        Private Sub LoadConfigurations()
            Dim overlap As Boolean = conf.Overlap
            Dim signerVisible As Boolean = conf.SignerVisible
            Dim firstPage As Boolean = conf.FirstPage
            Dim lastPage As Boolean = conf.LastPage
            Dim img As String = conf.Img
            Me.rbOverlap.Checked = overlap
            Me.rbNoOverlap.Checked = Not overlap
            Me.txtOutputFolder.Text = conf.OutputFolder
            Me.txtSignerText.Text = conf.SignerText
            Me.rbSignerInVisible.Checked = Not signerVisible
            Me.rbSignerVisible.Checked = signerVisible
            Me.chkSignerText.Checked = conf.TextSignerVisible
            Me.rbFirstPage.Checked = firstPage
            Me.rbLastPage.Checked = lastPage
            Me.rbNumberPage.Checked = Not firstPage And Not lastPage
            Me.txtNumberPage.Text = conf.NumberPage
            Me.txtSizeImg.Text = conf.sizeImg
            Me.txtFontSize.Text = conf.FontSize
            Me.txtPositionX.Text = conf.X
            Me.txtPositionY.Text = conf.Y
            If System.IO.File.Exists(img) Then Me.picImg.Image = Image.FromFile(conf.Img)
        End Sub

        Private Sub rbOverlap_CheckedChanged(sender As Object, e As EventArgs) Handles rbOverlap.CheckedChanged
            conf.Overlap = rbOverlap.Checked
            EnablaedNoOverlapsFilds(rbNoOverlap.Checked)
        End Sub

        Private Sub rbNoOverlap_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoOverlap.CheckedChanged
            conf.Overlap = rbOverlap.Checked
            EnablaedNoOverlapsFilds(rbNoOverlap.Checked)
        End Sub

        Private Sub EnablaedNoOverlapsFilds(ByVal b As Boolean)
            txtOutputFolder.Enabled = b
            btnOutputFolderBrowser.Enabled = b
        End Sub

        Private Sub txtOutputFolder_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOutputFolder.Validating
            conf.OutputFolder = txtOutputFolder.Text
        End Sub

        Private Sub txtSignerText_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSignerText.Validating
            conf.SignerText = txtSignerText.Text
        End Sub

        Private Sub rbSignerInVisible_CheckedChanged(sender As Object, e As EventArgs) Handles rbSignerInVisible.CheckedChanged
            conf.SignerVisible = rbSignerVisible.Checked
            EnabledSignerVisibleFilds(rbSignerVisible.Checked)
        End Sub

        Private Sub rbSignerVisible_CheckedChanged(sender As Object, e As EventArgs) Handles rbSignerVisible.CheckedChanged
            conf.SignerVisible = rbSignerVisible.Checked
            EnabledSignerVisibleFilds(rbSignerVisible.Checked)
        End Sub

        Private Sub EnabledSignerVisibleFilds(ByVal b)
            chkSignerText.Enabled = b
        End Sub

        Private Sub chkSignerText_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignerText.CheckedChanged
            conf.TextSignerVisible = chkSignerText.Checked
        End Sub

        Private Sub rbFirstPage_CheckedChanged(sender As Object, e As EventArgs) Handles rbFirstPage.CheckedChanged
            conf.FirstPage = rbFirstPage.Checked
            EnabledNumberPage(rbNumberPage.Checked)
        End Sub

        Private Sub rbLastPage_CheckedChanged(sender As Object, e As EventArgs) Handles rbLastPage.CheckedChanged
            conf.LastPage = rbLastPage.Checked
            EnabledNumberPage(rbNumberPage.Checked)
        End Sub

        Private Sub rbNumberPage_CheckedChanged(sender As Object, e As EventArgs) Handles rbNumberPage.CheckedChanged
            EnabledNumberPage(rbNumberPage.Checked)
        End Sub

        Private Sub EnabledNumberPage(ByVal b As Boolean)
            txtNumberPage.Enabled = b
        End Sub

        Private Sub txtNumberPage_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumberPage.Validating
            conf.NumberPage = CInt(txtNumberPage.Text)
        End Sub

        Private Sub txtSizeImg_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSizeImg.Validating
            conf.sizeImg = CSng(txtSizeImg.Text)
        End Sub

        Private Sub txtFontSize_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFontSize.Validating
            conf.FontSize = CInt(txtFontSize.Text)
        End Sub

        Private Sub txtPositionX_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPositionX.Validating
            conf.X = CInt(txtPositionX.Text)
        End Sub

        Private Sub txtPositionY_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPositionY.Validating
            conf.Y = CInt(txtPositionY.Text)
        End Sub

        Private Sub btnOutputFolderBrowser_Click(sender As Object, e As EventArgs) Handles btnOutputFolderBrowser.Click
            If fbd.ShowDialog() = DialogResult.OK Then
                txtOutputFolder.Text = fbd.SelectedPath
                conf.OutputFolder = fbd.SelectedPath
            End If
        End Sub

        Private Sub btnImgBrowser_Click(sender As Object, e As EventArgs) Handles btnImgBrowser.Click
            If ofd.ShowDialog() = DialogResult.OK Then
                If System.IO.File.Exists(ofd.FileName) Then
                    picImg.Image = Image.FromFile(ofd.FileName)
                    conf.Img = ofd.FileName
                End If
            End If
        End Sub

        Private Sub txtSizeImg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSizeImg.KeyPress, txtFontSize.KeyPress, txtNumberPage.KeyPress, txtPositionX.KeyPress, txtPositionY.KeyPress
            valid.InputDecimal(sender, e)
        End Sub
    End Class
End Namespace
