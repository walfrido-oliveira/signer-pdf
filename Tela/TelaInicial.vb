Imports System.IO

Namespace Tela

    Public Class TelaInicial

        Public Sub New()
            InitializeComponent()
            PopulateTreeViewWithDesktopFolders()
            PopulateTreeViewWithMyDocumentsFolder()
            PopulateTreeViewWithDrives()
            PopulateTreeWiewWithCustomFolders()
        End Sub

        Private Sub PopulateTreeViewWithDrives()
            On Error Resume Next
            Dim aNode As TreeNode
            Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
            Dim d As DriveInfo
            Dim info As DirectoryInfo
            For Each d In allDrives
                info = New DirectoryInfo(d.Name)
                aNode = New TreeNode(d.Name, 0, 0)
                aNode.Tag = info
                Select Case d.DriveType
                    Case DriveType.CDRom
                        aNode.ImageIndex = 3
                        aNode.SelectedImageIndex = 3
                    Case DriveType.Network
                        aNode.ImageIndex = 4
                        aNode.SelectedImageIndex = 4
                    Case Else
                        If Path.GetPathRoot(Environment.SystemDirectory).Equals(d.Name) Then
                            aNode.ImageIndex = 8
                            aNode.SelectedImageIndex = 8
                        Else
                            aNode.ImageIndex = 2
                            aNode.SelectedImageIndex = 2
                        End If
                End Select
                If d.IsReady Then aNode.Nodes.Add("...")
                TreeView1.Nodes.Add(aNode)
            Next
        End Sub

        Private Sub PopulateTreeViewWithDesktopFolders()
            On Error Resume Next
            Dim info As DirectoryInfo
            Dim aNode As TreeNode
            info = New DirectoryInfo(System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory))
            aNode = New TreeNode(info.Name, 6, 6)
            aNode.Tag = info
            If info.GetDirectories().Count > 0 Then aNode.Nodes.Add("...")
            TreeView1.Nodes.Add(aNode)
        End Sub

        Private Sub PopulateTreeViewWithMyDocumentsFolder()
            On Error Resume Next
            Dim info As DirectoryInfo
            Dim aNode As TreeNode
            info = New DirectoryInfo(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments))
            aNode = New TreeNode(info.Name, 9, 9)
            aNode.Tag = info
            aNode.Name = info.Name
            If info.GetDirectories().Count > 0 Then aNode.Nodes.Add("...")
            TreeView1.Nodes.Add(aNode)
        End Sub

        Private Sub PopulateTreeWiewWithCustomFolders()
            On Error Resume Next
            Dim aNode As TreeNode
            Dim conf As New Configuration.ConfigurationCreator()
            For Each d As DirectoryInfo In conf.Folders
                aNode = New TreeNode(d.Name, 0, 5)
                aNode.Name = d.Name
                aNode.Tag = d
                If TreeView1.Nodes.ContainsKey(d.Name) Then Continue For
                If d.GetDirectories().Count > 0 Then aNode.Nodes.Add("...")
                TreeView1.Nodes.Add(aNode)
            Next
        End Sub

        Private Sub PopulateTreeView(ByVal folder As String, ByVal treeNode As TreeNodeCollection)
            On Error Resume Next
            Dim rootNode As TreeNode
            Dim info As New DirectoryInfo(folder)
            If info.Exists Then
                rootNode = New TreeNode(info.Name)
                rootNode.Tag = info
                rootNode.Name = info.Name
                GetDirectories(info.GetDirectories(), rootNode)
                treeNode.Add(rootNode)
            End If
        End Sub

        Private Sub PopulateTreeView(ByVal treeNode As TreeNodeCollection, ByVal node As TreeNode)
            On Error Resume Next
            Dim nodeDirInfo As DirectoryInfo = CType(node.Tag, DirectoryInfo)
            Dim rootNode As TreeNode
            Dim info As New DirectoryInfo(nodeDirInfo.FullName)
            If info.Exists Then
                rootNode = New TreeNode(info.Name)
                rootNode.Tag = info
                rootNode.Name = info.Name
                GetDirectories(info.GetDirectories(), node)
            End If
        End Sub

        Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)
            On Error Resume Next
            Dim aNode As TreeNode
            Dim subSubDirs() As DirectoryInfo
            Dim subDir As DirectoryInfo
            For Each subDir In subDirs
                aNode = New TreeNode(subDir.Name)
                aNode.ImageIndex = 0
                aNode.SelectedImageIndex = 5
                aNode.Tag = subDir
                aNode.Name = subDir.Name
                subSubDirs = subDir.GetDirectories()
                If subDir.GetDirectories.Count > 0 Then aNode.Nodes.Add("...")
                nodeToAddTo.Nodes.Add(aNode)
            Next subDir
        End Sub

        Private Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
            Try
                Dim newSelected As TreeNode = e.Node
                ListView1.Items.Clear()
                Dim nodeDirInfo As DirectoryInfo = CType(newSelected.Tag, DirectoryInfo)
                Dim subItems() As ListViewItem.ListViewSubItem
                Dim item As ListViewItem = Nothing
                Dim file As FileInfo
                Dim iconForFile As Icon = SystemIcons.WinLogo
                For Each file In nodeDirInfo.GetFiles("*.pdf")
                    item = New ListViewItem(file.Name, 10)
                    item.Tag = file
                    subItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(item, file.Extension),
                                                                   New ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()),
                                                                   New ListViewItem.ListViewSubItem(item, (file.Length / 1000).ToString() & "K")}
                    item.SubItems.AddRange(subItems)
                    ListView1.Items.Add(item)
                Next file
                ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                UpdateStatus()
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub SelectedNode()
            Try
                TreeView1.SelectedNode = TreeView1.Nodes.Item(0)
                If TreeView1.SelectedNode IsNot Nothing Then
                    Dim newSelected As TreeNode = TreeView1.SelectedNode
                    ListView1.Items.Clear()
                    Dim nodeDirInfo As DirectoryInfo = CType(newSelected.Tag, DirectoryInfo)
                    Dim subItems() As ListViewItem.ListViewSubItem
                    Dim item As ListViewItem = Nothing
                    Dim file As FileInfo
                    Dim iconForFile As Icon = SystemIcons.WinLogo
                    For Each file In nodeDirInfo.GetFiles("*.pdf")
                        item = New ListViewItem(file.Name, 10)
                        item.Tag = file
                        subItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(item, file.Extension),
                                                                       New ListViewItem.ListViewSubItem(item, file.LastAccessTime.ToShortDateString()),
                                                                       New ListViewItem.ListViewSubItem(item, (file.Length / 1000).ToString() & "K")}
                        item.SubItems.AddRange(subItems)
                        ListView1.Items.Add(item)
                    Next file
                    ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
            tsmOpen.Enabled = ListView1.SelectedItems.Count > 0
            tsmSigning.Enabled = ListView1.SelectedItems.Count > 0
        End Sub

        Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOpen.Click
            For Each item As ListViewItem In ListView1.SelectedItems
                If TypeOf item.Tag Is FileInfo Then
                    Dim file As FileInfo = CType(item.Tag, FileInfo)
                    System.Diagnostics.Process.Start(file.FullName)
                End If
                If TypeOf item.Tag Is DirectoryInfo Then
                    Dim directory As DirectoryInfo = CType(item.Tag, DirectoryInfo)
                    System.Diagnostics.Process.Start(directory.FullName)
                End If
            Next
        End Sub

        Private Sub TreeView1_BeforeExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
            If e.Node.Nodes.Count > 0 Then
                If e.Node.Nodes(0).Text = "..." And e.Node.Nodes(0).Tag Is Nothing Then
                    e.Node.Nodes.Clear()
                    PopulateTreeView(e.Node.Nodes, e.Node)
                End If
            End If
        End Sub

#Region "MenuStrip"
        Private Sub AssinarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsmSigning.Click
            Signin()
        End Sub

        Private Sub Signin()
            Try
                Dim signers As New Signer.SignerCollection()
                For Each item As ListViewItem In ListView1.SelectedItems
                    If TypeOf item.Tag Is FileInfo Then
                        Dim file As FileInfo = CType(item.Tag, FileInfo)
                        signers.Items.Add(New Com.SignerPDF.Signer.Signer(file.FullName, file.FullName & "_", New Configuration.ConfigurationCreator()))
                    End If
                Next
                signers.SigninColletion()
                For Each item As Signer.Signer In signers.Items
                    System.Diagnostics.Process.Start(item.OutputFile)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ConfigurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurToolStripMenuItem.Click
            Dim telaConfiguracao = New Popup.ConfiguraAssinador()
            telaConfiguracao.Show()
        End Sub

        Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
            Application.Exit()
        End Sub

        Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
            Dim frm As New AboutBoxSignerPDF()
            frm.Show()
        End Sub

        Private Sub ExportarConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarConfiguraçõesToolStripMenuItem.Click
            If sfd.ShowDialog() = DialogResult.OK Then
                If Configuration.XML.XMLConfiguration.SaveCurrentConfiguration(sfd.FileName, "custom_configuration") Then
                    MessageBox.Show("Exportação realizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim file As New FileInfo(sfd.FileName)
                    System.Diagnostics.Process.Start("explorer.exe", " /select, " & sfd.FileName)
                End If
            End If
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
            If ofd.ShowDialog() = DialogResult.OK Then
                If Configuration.XML.XMLConfiguration.OpenXMLConfiguration(ofd.FileName) Then
                    MessageBox.Show("Importação realizada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End Sub
#End Region

        Private Sub TelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            SelectedNode()
            UpdateStatus()
        End Sub

        Private Sub AssinarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssinarToolStripMenuItem.Click
            Signin()
        End Sub

        Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
            Dim telaConfiguracao = New Popup.ConfiguraAssinador()
            telaConfiguracao.Show()
        End Sub

        Private Sub btnSigning_Click(sender As Object, e As EventArgs) Handles btnSigning.Click
            Signin()
        End Sub

        Private Sub UpdateStatus()
            tsslStatus.Text = String.Format("{0} item(s)    {1} item(s) selecionado(s)", ListView1.Items.Count, ListView1.SelectedItems.Count)
        End Sub

        Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
            UpdateStatus()
        End Sub

        Private Sub TreeView1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragEnter
            If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End Sub

        Private Sub TreeView1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TreeView1.DragDrop
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim s() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
                Dim conf As New Configuration.ConfigurationCreator()
                For Each c As String In s
                    If Directory.Exists(c) Then
                        conf.AddCustomFolder(New DirectoryInfo(c))
                    End If
                Next
                PopulateTreeWiewWithCustomFolders()
            End If
        End Sub

#Region "ContextMenuStrp2"

        Private Sub AbrirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
            Dim d As DirectoryInfo = CType(TreeView1.SelectedNode.Tag, DirectoryInfo)
            If Directory.Exists(d.FullName) Then Process.Start(d.FullName)
        End Sub

        Private Sub RemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverToolStripMenuItem.Click
            Dim conf As New Configuration.ConfigurationCreator()
            Dim d As DirectoryInfo = CType(TreeView1.SelectedNode.Tag, DirectoryInfo)
            If Directory.Exists(d.FullName) Then
                If conf.RemoveCustomFolder(d) Then
                    PopulateTreeWiewWithCustomFolders()
                    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                End If
            End If
        End Sub

        Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
            If TreeView1.SelectedNode IsNot Nothing Then
                AbrirToolStripMenuItem.Enabled = True
                RemoverToolStripMenuItem.Enabled = False
                Dim d As DirectoryInfo = CType(TreeView1.SelectedNode.Tag, DirectoryInfo)
                Dim conf As New Configuration.ConfigurationCreator()
                For Each l As DirectoryInfo In conf.Folders
                    If l.FullName.Equals(d.FullName) Then
                        RemoverToolStripMenuItem.Enabled = True
                        Exit For
                    End If
                Next
            Else
                AbrirToolStripMenuItem.Enabled = False
                RemoverToolStripMenuItem.Enabled = False
            End If
        End Sub
#End Region

    End Class
End Namespace
