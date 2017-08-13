Namespace Tela.Popup
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ConfiguraAssinador
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguraAssinador))
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.GroupBox8 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtFontSize = New System.Windows.Forms.TextBox()
            Me.GroupBox7 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtPositionY = New System.Windows.Forms.TextBox()
            Me.txtPositionX = New System.Windows.Forms.TextBox()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtSizeImg = New System.Windows.Forms.TextBox()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.btnImgBrowser = New System.Windows.Forms.Button()
            Me.picImg = New System.Windows.Forms.PictureBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtNumberPage = New System.Windows.Forms.TextBox()
            Me.rbNumberPage = New System.Windows.Forms.RadioButton()
            Me.rbLastPage = New System.Windows.Forms.RadioButton()
            Me.rbFirstPage = New System.Windows.Forms.RadioButton()
            Me.chkSignerText = New System.Windows.Forms.CheckBox()
            Me.rbSignerVisible = New System.Windows.Forms.RadioButton()
            Me.rbSignerInVisible = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtSignerText = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnOutputFolderBrowser = New System.Windows.Forms.Button()
            Me.txtOutputFolder = New System.Windows.Forms.TextBox()
            Me.rbNoOverlap = New System.Windows.Forms.RadioButton()
            Me.rbOverlap = New System.Windows.Forms.RadioButton()
            Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
            Me.ofd = New System.Windows.Forms.OpenFileDialog()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox8.SuspendLayout()
            Me.GroupBox7.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(0, 0)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(668, 409)
            Me.TabControl1.TabIndex = 0
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.GroupBox8)
            Me.TabPage1.Controls.Add(Me.GroupBox7)
            Me.TabPage1.Controls.Add(Me.GroupBox6)
            Me.TabPage1.Controls.Add(Me.GroupBox5)
            Me.TabPage1.Controls.Add(Me.GroupBox3)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(660, 383)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Geral"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'GroupBox8
            '
            Me.GroupBox8.Controls.Add(Me.Label4)
            Me.GroupBox8.Controls.Add(Me.txtFontSize)
            Me.GroupBox8.Location = New System.Drawing.Point(4, 297)
            Me.GroupBox8.Name = "GroupBox8"
            Me.GroupBox8.Size = New System.Drawing.Size(333, 78)
            Me.GroupBox8.TabIndex = 6
            Me.GroupBox8.TabStop = False
            Me.GroupBox8.Text = "Tamanho da Fonte"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(92, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(52, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Tamanho"
            '
            'txtFontSize
            '
            Me.txtFontSize.Location = New System.Drawing.Point(7, 19)
            Me.txtFontSize.Name = "txtFontSize"
            Me.txtFontSize.Size = New System.Drawing.Size(79, 20)
            Me.txtFontSize.TabIndex = 7
            Me.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'GroupBox7
            '
            Me.GroupBox7.Controls.Add(Me.Label5)
            Me.GroupBox7.Controls.Add(Me.Label3)
            Me.GroupBox7.Controls.Add(Me.Label2)
            Me.GroupBox7.Controls.Add(Me.txtPositionY)
            Me.GroupBox7.Controls.Add(Me.txtPositionX)
            Me.GroupBox7.Location = New System.Drawing.Point(343, 220)
            Me.GroupBox7.Name = "GroupBox7"
            Me.GroupBox7.Size = New System.Drawing.Size(309, 70)
            Me.GroupBox7.TabIndex = 5
            Me.GroupBox7.TabStop = False
            Me.GroupBox7.Text = "Possição da Assinatura"
            '
            'Label5
            '
            Me.Label5.Image = Global.Com.SignerPDF.My.Resources.Resources.xy_axes_512
            Me.Label5.Location = New System.Drawing.Point(119, 8)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(184, 59)
            Me.Label5.TabIndex = 5
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(91, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(22, 13)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "%X"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(91, 48)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(22, 13)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "%Y"
            '
            'txtPositionY
            '
            Me.txtPositionY.Location = New System.Drawing.Point(6, 45)
            Me.txtPositionY.Name = "txtPositionY"
            Me.txtPositionY.Size = New System.Drawing.Size(79, 20)
            Me.txtPositionY.TabIndex = 8
            Me.txtPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'txtPositionX
            '
            Me.txtPositionX.Location = New System.Drawing.Point(6, 19)
            Me.txtPositionX.Name = "txtPositionX"
            Me.txtPositionX.Size = New System.Drawing.Size(79, 20)
            Me.txtPositionX.TabIndex = 7
            Me.txtPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'GroupBox6
            '
            Me.GroupBox6.Controls.Add(Me.Label1)
            Me.GroupBox6.Controls.Add(Me.txtSizeImg)
            Me.GroupBox6.Location = New System.Drawing.Point(4, 220)
            Me.GroupBox6.Name = "GroupBox6"
            Me.GroupBox6.Size = New System.Drawing.Size(333, 70)
            Me.GroupBox6.TabIndex = 4
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "Tamanho da Assinatura"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(91, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(183, 13)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "% em relação ao tamanho da imagem"
            '
            'txtSizeImg
            '
            Me.txtSizeImg.Location = New System.Drawing.Point(6, 19)
            Me.txtSizeImg.Name = "txtSizeImg"
            Me.txtSizeImg.Size = New System.Drawing.Size(79, 20)
            Me.txtSizeImg.TabIndex = 6
            Me.txtSizeImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.btnImgBrowser)
            Me.GroupBox5.Controls.Add(Me.picImg)
            Me.GroupBox5.Location = New System.Drawing.Point(343, 113)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(309, 100)
            Me.GroupBox5.TabIndex = 3
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Imagem"
            '
            'btnImgBrowser
            '
            Me.btnImgBrowser.Location = New System.Drawing.Point(221, 74)
            Me.btnImgBrowser.Name = "btnImgBrowser"
            Me.btnImgBrowser.Size = New System.Drawing.Size(82, 20)
            Me.btnImgBrowser.TabIndex = 4
            Me.btnImgBrowser.Text = "Procurar"
            Me.btnImgBrowser.UseVisualStyleBackColor = True
            '
            'picImg
            '
            Me.picImg.Location = New System.Drawing.Point(6, 19)
            Me.picImg.Name = "picImg"
            Me.picImg.Size = New System.Drawing.Size(209, 75)
            Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picImg.TabIndex = 0
            Me.picImg.TabStop = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.GroupBox4)
            Me.GroupBox3.Controls.Add(Me.chkSignerText)
            Me.GroupBox3.Controls.Add(Me.rbSignerVisible)
            Me.GroupBox3.Controls.Add(Me.rbSignerInVisible)
            Me.GroupBox3.Location = New System.Drawing.Point(4, 113)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(333, 100)
            Me.GroupBox3.TabIndex = 2
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Configuração da assinatura"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtNumberPage)
            Me.GroupBox4.Controls.Add(Me.rbNumberPage)
            Me.GroupBox4.Controls.Add(Me.rbLastPage)
            Me.GroupBox4.Controls.Add(Me.rbFirstPage)
            Me.GroupBox4.Location = New System.Drawing.Point(152, 11)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(175, 83)
            Me.GroupBox4.TabIndex = 5
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Página"
            '
            'txtNumberPage
            '
            Me.txtNumberPage.Location = New System.Drawing.Point(86, 60)
            Me.txtNumberPage.Name = "txtNumberPage"
            Me.txtNumberPage.Size = New System.Drawing.Size(79, 20)
            Me.txtNumberPage.TabIndex = 5
            Me.txtNumberPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'rbNumberPage
            '
            Me.rbNumberPage.AutoSize = True
            Me.rbNumberPage.Location = New System.Drawing.Point(6, 60)
            Me.rbNumberPage.Name = "rbNumberPage"
            Me.rbNumberPage.Size = New System.Drawing.Size(74, 17)
            Me.rbNumberPage.TabIndex = 4
            Me.rbNumberPage.TabStop = True
            Me.rbNumberPage.Text = "Especifica"
            Me.rbNumberPage.UseVisualStyleBackColor = True
            '
            'rbLastPage
            '
            Me.rbLastPage.AutoSize = True
            Me.rbLastPage.Location = New System.Drawing.Point(6, 42)
            Me.rbLastPage.Name = "rbLastPage"
            Me.rbLastPage.Size = New System.Drawing.Size(54, 17)
            Me.rbLastPage.TabIndex = 3
            Me.rbLastPage.TabStop = True
            Me.rbLastPage.Text = "Última"
            Me.rbLastPage.UseVisualStyleBackColor = True
            '
            'rbFirstPage
            '
            Me.rbFirstPage.AutoSize = True
            Me.rbFirstPage.Location = New System.Drawing.Point(6, 19)
            Me.rbFirstPage.Name = "rbFirstPage"
            Me.rbFirstPage.Size = New System.Drawing.Size(62, 17)
            Me.rbFirstPage.TabIndex = 2
            Me.rbFirstPage.TabStop = True
            Me.rbFirstPage.Text = "Primiera"
            Me.rbFirstPage.UseVisualStyleBackColor = True
            '
            'chkSignerText
            '
            Me.chkSignerText.AutoSize = True
            Me.chkSignerText.Location = New System.Drawing.Point(24, 65)
            Me.chkSignerText.Name = "chkSignerText"
            Me.chkSignerText.Size = New System.Drawing.Size(53, 17)
            Me.chkSignerText.TabIndex = 3
            Me.chkSignerText.Text = "Texto"
            Me.chkSignerText.UseVisualStyleBackColor = True
            '
            'rbSignerVisible
            '
            Me.rbSignerVisible.AutoSize = True
            Me.rbSignerVisible.Location = New System.Drawing.Point(7, 42)
            Me.rbSignerVisible.Name = "rbSignerVisible"
            Me.rbSignerVisible.Size = New System.Drawing.Size(57, 17)
            Me.rbSignerVisible.TabIndex = 2
            Me.rbSignerVisible.TabStop = True
            Me.rbSignerVisible.Text = "Visível"
            Me.rbSignerVisible.UseVisualStyleBackColor = True
            '
            'rbSignerInVisible
            '
            Me.rbSignerInVisible.AutoSize = True
            Me.rbSignerInVisible.Location = New System.Drawing.Point(7, 19)
            Me.rbSignerInVisible.Name = "rbSignerInVisible"
            Me.rbSignerInVisible.Size = New System.Drawing.Size(116, 17)
            Me.rbSignerInVisible.TabIndex = 1
            Me.rbSignerInVisible.TabStop = True
            Me.rbSignerInVisible.Text = "Assinatura invisível"
            Me.rbSignerInVisible.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtSignerText)
            Me.GroupBox2.Location = New System.Drawing.Point(343, 7)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(309, 100)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Texto de justificativa"
            '
            'txtSignerText
            '
            Me.txtSignerText.Location = New System.Drawing.Point(6, 13)
            Me.txtSignerText.Multiline = True
            Me.txtSignerText.Name = "txtSignerText"
            Me.txtSignerText.Size = New System.Drawing.Size(297, 81)
            Me.txtSignerText.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.btnOutputFolderBrowser)
            Me.GroupBox1.Controls.Add(Me.txtOutputFolder)
            Me.GroupBox1.Controls.Add(Me.rbNoOverlap)
            Me.GroupBox1.Controls.Add(Me.rbOverlap)
            Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(333, 100)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Local de Armazenagem do documento assinado"
            '
            'btnOutputFolderBrowser
            '
            Me.btnOutputFolderBrowser.Location = New System.Drawing.Point(285, 67)
            Me.btnOutputFolderBrowser.Name = "btnOutputFolderBrowser"
            Me.btnOutputFolderBrowser.Size = New System.Drawing.Size(32, 20)
            Me.btnOutputFolderBrowser.TabIndex = 3
            Me.btnOutputFolderBrowser.Text = "..."
            Me.btnOutputFolderBrowser.UseVisualStyleBackColor = True
            '
            'txtOutputFolder
            '
            Me.txtOutputFolder.Location = New System.Drawing.Point(7, 67)
            Me.txtOutputFolder.Name = "txtOutputFolder"
            Me.txtOutputFolder.Size = New System.Drawing.Size(272, 20)
            Me.txtOutputFolder.TabIndex = 2
            '
            'rbNoOverlap
            '
            Me.rbNoOverlap.AutoSize = True
            Me.rbNoOverlap.Location = New System.Drawing.Point(7, 43)
            Me.rbNoOverlap.Name = "rbNoOverlap"
            Me.rbNoOverlap.Size = New System.Drawing.Size(128, 17)
            Me.rbNoOverlap.TabIndex = 1
            Me.rbNoOverlap.TabStop = True
            Me.rbNoOverlap.Text = "Gerar novo doumento"
            Me.rbNoOverlap.UseVisualStyleBackColor = True
            '
            'rbOverlap
            '
            Me.rbOverlap.AutoSize = True
            Me.rbOverlap.Location = New System.Drawing.Point(7, 20)
            Me.rbOverlap.Name = "rbOverlap"
            Me.rbOverlap.Size = New System.Drawing.Size(124, 17)
            Me.rbOverlap.TabIndex = 0
            Me.rbOverlap.TabStop = True
            Me.rbOverlap.Text = "Sobrepor documento"
            Me.rbOverlap.UseVisualStyleBackColor = True
            '
            'ofd
            '
            Me.ofd.Filter = "Arquivos de Imagem|*.jpg;*.png"
            '
            'ConfiguraAssinador
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(668, 409)
            Me.Controls.Add(Me.TabControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "ConfiguraAssinador"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Configurar Assinador"
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.GroupBox8.ResumeLayout(False)
            Me.GroupBox8.PerformLayout()
            Me.GroupBox7.ResumeLayout(False)
            Me.GroupBox7.PerformLayout()
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Private WithEvents fbd As FolderBrowserDialog
        Private WithEvents TabControl1 As TabControl
        Private WithEvents TabPage1 As TabPage
        Private WithEvents GroupBox1 As GroupBox
        Private WithEvents rbNoOverlap As RadioButton
        Private WithEvents rbOverlap As RadioButton
        Private WithEvents btnOutputFolderBrowser As Button
        Private WithEvents txtOutputFolder As TextBox
        Private WithEvents GroupBox2 As GroupBox
        Private WithEvents txtSignerText As TextBox
        Private WithEvents GroupBox3 As GroupBox
        Private WithEvents rbSignerVisible As RadioButton
        Private WithEvents rbSignerInVisible As RadioButton
        Private WithEvents chkSignerText As CheckBox
        Private WithEvents GroupBox4 As GroupBox
        Private WithEvents txtNumberPage As TextBox
        Private WithEvents rbNumberPage As RadioButton
        Private WithEvents rbLastPage As RadioButton
        Private WithEvents rbFirstPage As RadioButton
        Private WithEvents GroupBox5 As GroupBox
        Private WithEvents btnImgBrowser As Button
        Private WithEvents picImg As PictureBox
        Private WithEvents GroupBox6 As GroupBox
        Private WithEvents Label1 As Label
        Private WithEvents txtSizeImg As TextBox
        Private WithEvents GroupBox7 As GroupBox
        Private WithEvents Label3 As Label
        Private WithEvents Label2 As Label
        Private WithEvents txtPositionY As TextBox
        Private WithEvents txtPositionX As TextBox
        Private WithEvents GroupBox8 As GroupBox
        Private WithEvents Label4 As Label
        Private WithEvents txtFontSize As TextBox
        Private WithEvents Label5 As Label
        Private WithEvents ofd As OpenFileDialog
    End Class
End Namespace

