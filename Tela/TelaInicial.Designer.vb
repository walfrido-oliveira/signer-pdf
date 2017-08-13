Namespace Tela
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class TelaInicial
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.FunçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AssinarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ConfigurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ExportarConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSigning = New System.Windows.Forms.Button()
            Me.btnConf = New System.Windows.Forms.Button()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.TreeView1 = New System.Windows.Forms.TreeView()
            Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.RemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
            Me.tsmSigning = New System.Windows.Forms.ToolStripMenuItem()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.sfd = New System.Windows.Forms.SaveFileDialog()
            Me.ofd = New System.Windows.Forms.OpenFileDialog()
            Me.MenuStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.ContextMenuStrip2.SuspendLayout()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.StatusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.BackColor = System.Drawing.Color.White
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.FunçõesToolStripMenuItem, Me.AjudaToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(1030, 24)
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'ArquivoToolStripMenuItem
            '
            Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
            Me.ArquivoToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
            Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
            Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
            Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
            '
            'SairToolStripMenuItem
            '
            Me.SairToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!)
            Me.SairToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.close
            Me.SairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
            Me.SairToolStripMenuItem.Size = New System.Drawing.Size(138, 54)
            Me.SairToolStripMenuItem.Text = "&Sair"
            Me.SairToolStripMenuItem.ToolTipText = "Sair"
            '
            'FunçõesToolStripMenuItem
            '
            Me.FunçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssinarToolStripMenuItem, Me.ConfigurToolStripMenuItem, Me.ExportarConfiguraçõesToolStripMenuItem, Me.ToolStripMenuItem1})
            Me.FunçõesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FunçõesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.LightGray
            Me.FunçõesToolStripMenuItem.Name = "FunçõesToolStripMenuItem"
            Me.FunçõesToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
            Me.FunçõesToolStripMenuItem.Text = "&Funções"
            '
            'AssinarToolStripMenuItem
            '
            Me.AssinarToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.AssinarToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AssinarToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.signature
            Me.AssinarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.AssinarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
            Me.AssinarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
            Me.AssinarToolStripMenuItem.Name = "AssinarToolStripMenuItem"
            Me.AssinarToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
            Me.AssinarToolStripMenuItem.Size = New System.Drawing.Size(299, 54)
            Me.AssinarToolStripMenuItem.Text = "Assinar"
            Me.AssinarToolStripMenuItem.ToolTipText = "Assinar documento(s)"
            '
            'ConfigurToolStripMenuItem
            '
            Me.ConfigurToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!)
            Me.ConfigurToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.painel
            Me.ConfigurToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ConfigurToolStripMenuItem.Name = "ConfigurToolStripMenuItem"
            Me.ConfigurToolStripMenuItem.Size = New System.Drawing.Size(299, 54)
            Me.ConfigurToolStripMenuItem.Text = "Configurar"
            Me.ConfigurToolStripMenuItem.ToolTipText = "Configurar assinador"
            '
            'ExportarConfiguraçõesToolStripMenuItem
            '
            Me.ExportarConfiguraçõesToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!)
            Me.ExportarConfiguraçõesToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.exportar
            Me.ExportarConfiguraçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ExportarConfiguraçõesToolStripMenuItem.Name = "ExportarConfiguraçõesToolStripMenuItem"
            Me.ExportarConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(299, 54)
            Me.ExportarConfiguraçõesToolStripMenuItem.Text = "Exportar Configurações"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Verdana", 12.0!)
            Me.ToolStripMenuItem1.Image = Global.Com.SignerPDF.My.Resources.Resources.import
            Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(299, 54)
            Me.ToolStripMenuItem1.Text = "Importar Configurações"
            '
            'AjudaToolStripMenuItem
            '
            Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
            Me.AjudaToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
            Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
            Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
            Me.AjudaToolStripMenuItem.Text = "&Ajuda"
            '
            'SobreToolStripMenuItem
            '
            Me.SobreToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 12.0!)
            Me.SobreToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.help
            Me.SobreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
            Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(153, 54)
            Me.SobreToolStripMenuItem.Text = "Sobre"
            Me.SobreToolStripMenuItem.ToolTipText = "Sobre"
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.btnSigning)
            Me.Panel1.Controls.Add(Me.btnConf)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 24)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1030, 69)
            Me.Panel1.TabIndex = 1
            '
            'btnSigning
            '
            Me.btnSigning.AutoSize = True
            Me.btnSigning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnSigning.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSigning.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnSigning.FlatAppearance.BorderSize = 0
            Me.btnSigning.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnSigning.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
            Me.btnSigning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSigning.Image = Global.Com.SignerPDF.My.Resources.Resources.signature
            Me.btnSigning.Location = New System.Drawing.Point(70, 9)
            Me.btnSigning.Name = "btnSigning"
            Me.btnSigning.Size = New System.Drawing.Size(54, 54)
            Me.btnSigning.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnSigning, "Assinar documento(s)")
            Me.btnSigning.UseVisualStyleBackColor = True
            '
            'btnConf
            '
            Me.btnConf.AutoSize = True
            Me.btnConf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.btnConf.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnConf.FlatAppearance.BorderColor = System.Drawing.Color.White
            Me.btnConf.FlatAppearance.BorderSize = 0
            Me.btnConf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnConf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
            Me.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConf.Image = Global.Com.SignerPDF.My.Resources.Resources.painel
            Me.btnConf.Location = New System.Drawing.Point(10, 9)
            Me.btnConf.Name = "btnConf"
            Me.btnConf.Size = New System.Drawing.Size(54, 54)
            Me.btnConf.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnConf, "Configurar assinador")
            Me.btnConf.UseVisualStyleBackColor = True
            '
            'SplitContainer1
            '
            Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 93)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
            Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
            Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
            Me.SplitContainer1.Size = New System.Drawing.Size(1030, 448)
            Me.SplitContainer1.SplitterDistance = 427
            Me.SplitContainer1.TabIndex = 2
            '
            'TreeView1
            '
            Me.TreeView1.AllowDrop = True
            Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip2
            Me.TreeView1.HotTracking = True
            Me.TreeView1.ImageIndex = 0
            Me.TreeView1.ImageList = Me.ImageList1
            Me.TreeView1.Location = New System.Drawing.Point(0, 0)
            Me.TreeView1.Name = "TreeView1"
            Me.TreeView1.SelectedImageIndex = 5
            Me.TreeView1.Size = New System.Drawing.Size(423, 421)
            Me.TreeView1.TabIndex = 1
            '
            'ContextMenuStrip2
            '
            Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.RemoverToolStripMenuItem})
            Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip2.Size = New System.Drawing.Size(122, 48)
            '
            'AbrirToolStripMenuItem
            '
            Me.AbrirToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.open
            Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
            Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
            Me.AbrirToolStripMenuItem.Text = "Abrir"
            '
            'RemoverToolStripMenuItem
            '
            Me.RemoverToolStripMenuItem.Image = Global.Com.SignerPDF.My.Resources.Resources.remove
            Me.RemoverToolStripMenuItem.Name = "RemoverToolStripMenuItem"
            Me.RemoverToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
            Me.RemoverToolStripMenuItem.Text = "Remover"
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "folder.png")
            Me.ImageList1.Images.SetKeyName(1, "doc.png")
            Me.ImageList1.Images.SetKeyName(2, "drive.png")
            Me.ImageList1.Images.SetKeyName(3, "drive-cd.png")
            Me.ImageList1.Images.SetKeyName(4, "Network_Drive.png")
            Me.ImageList1.Images.SetKeyName(5, "folder-open.png")
            Me.ImageList1.Images.SetKeyName(6, "desktop.ico")
            Me.ImageList1.Images.SetKeyName(7, "pc.png")
            Me.ImageList1.Images.SetKeyName(8, "win-drive.png")
            Me.ImageList1.Images.SetKeyName(9, "my-documents.png")
            Me.ImageList1.Images.SetKeyName(10, "adobe-pdf-icon.png")
            '
            'ListView1
            '
            Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
            Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
            Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
            Me.ListView1.HotTracking = True
            Me.ListView1.HoverSelection = True
            Me.ListView1.Location = New System.Drawing.Point(0, 0)
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(595, 421)
            Me.ListView1.SmallImageList = Me.ImageList1
            Me.ListView1.StateImageList = Me.ImageList1
            Me.ListView1.TabIndex = 0
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Nome"
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Tipo"
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Data de Modificação"
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Tamanho"
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOpen, Me.tsmSigning})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(113, 48)
            '
            'tsmOpen
            '
            Me.tsmOpen.Image = Global.Com.SignerPDF.My.Resources.Resources.open
            Me.tsmOpen.Name = "tsmOpen"
            Me.tsmOpen.Size = New System.Drawing.Size(112, 22)
            Me.tsmOpen.Text = "Abrir"
            '
            'tsmSigning
            '
            Me.tsmSigning.Image = Global.Com.SignerPDF.My.Resources.Resources.signature
            Me.tsmSigning.Name = "tsmSigning"
            Me.tsmSigning.Size = New System.Drawing.Size(112, 22)
            Me.tsmSigning.Text = "Assinar"
            '
            'StatusStrip1
            '
            Me.StatusStrip1.BackColor = System.Drawing.Color.White
            Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus})
            Me.StatusStrip1.Location = New System.Drawing.Point(0, 519)
            Me.StatusStrip1.Name = "StatusStrip1"
            Me.StatusStrip1.Size = New System.Drawing.Size(1030, 22)
            Me.StatusStrip1.TabIndex = 3
            Me.StatusStrip1.Text = "StatusStrip1"
            '
            'tsslStatus
            '
            Me.tsslStatus.Name = "tsslStatus"
            Me.tsslStatus.Size = New System.Drawing.Size(120, 17)
            Me.tsslStatus.Text = "ToolStripStatusLabel1"
            '
            'sfd
            '
            Me.sfd.Filter = "Arquivo XML|*.xml"
            '
            'ofd
            '
            Me.ofd.Filter = "Arquivo XML|*.xml"
            '
            'TelaInicial
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1030, 541)
            Me.Controls.Add(Me.StatusStrip1)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.MenuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.MinimumSize = New System.Drawing.Size(1046, 580)
            Me.Name = "TelaInicial"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Signer PDF"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.ContextMenuStrip2.ResumeLayout(False)
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents ImageList1 As System.Windows.Forms.ImageList
        Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
        Private WithEvents tsmOpen As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Private WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents FunçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents Panel1 As System.Windows.Forms.Panel
        Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Private WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
        Private WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents AssinarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ConfigurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TreeView1 As System.Windows.Forms.TreeView
        Private WithEvents ListView1 As System.Windows.Forms.ListView
        Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Private WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Private WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Private WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Private WithEvents btnSigning As Button
        Private WithEvents tsmSigning As ToolStripMenuItem
        Private WithEvents btnConf As Button
        Private WithEvents ToolTip1 As ToolTip
        Friend WithEvents tsslStatus As ToolStripStatusLabel
        Private WithEvents ContextMenuStrip2 As ContextMenuStrip
        Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents RemoverToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ExportarConfiguraçõesToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents sfd As SaveFileDialog
        Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
        Friend WithEvents ofd As OpenFileDialog
    End Class
End Namespace
