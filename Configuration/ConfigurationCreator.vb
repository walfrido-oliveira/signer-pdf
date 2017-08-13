Namespace Configuration
    Public Class ConfigurationCreator

        Public Property Overlap() As Boolean
            Get
                Return CBool(Configuration.Read(Configuration.Keys.overlap))
            End Get
            Set(ByVal value As Boolean)
                Configuration.Write(Configuration.Keys.overlap, value.ToString())
            End Set
        End Property

        Public Property OutputFolder() As String
            Get
                Return Configuration.Read(Configuration.Keys.outputFolder)
            End Get
            Set(ByVal value As String)
                Configuration.Write(Configuration.Keys.outputFolder, value)
            End Set
        End Property

        Public Property SignerText() As String
            Get
                Return Configuration.Read(Configuration.Keys.signerText)
            End Get
            Set(value As String)
                Configuration.Write(Configuration.Keys.signerText, value)
            End Set
        End Property

        Public Property SignerVisible() As Boolean
            Get
                Return CBool(Configuration.Read(Configuration.Keys.signerVisible))
            End Get
            Set(value As Boolean)
                Configuration.Write(Configuration.Keys.signerVisible, value.ToString())
            End Set
        End Property

        Public Property TextSignerVisible() As Boolean
            Get
                Return CBool(Configuration.Read(Configuration.Keys.textSignerVisible))
            End Get
            Set(value As Boolean)
                Configuration.Write(Configuration.Keys.textSignerVisible, value.ToString())
            End Set
        End Property

        Public Property NumberPage() As Integer
            Get
                Return CInt(Configuration.Read(Configuration.Keys.numberPage))
            End Get
            Set(value As Integer)
                Configuration.Write(Configuration.Keys.numberPage, value.ToString())
            End Set
        End Property

        Public Property FirstPage() As Boolean
            Get
                Return CBool(Configuration.Read(Configuration.Keys.firstPage))
            End Get
            Set(value As Boolean)
                Configuration.Write(Configuration.Keys.firstPage, value.ToString())
            End Set
        End Property

        Public Property LastPage() As Boolean
            Get
                Return CBool(Configuration.Read(Configuration.Keys.lastPage))
            End Get
            Set(value As Boolean)
                Configuration.Write(Configuration.Keys.lastPage, value.ToString())
            End Set
        End Property

        Public Property Img() As String
            Get
                Return Configuration.Read(Configuration.Keys.img)
            End Get
            Set(value As String)
                Configuration.Write(Configuration.Keys.img, value)
            End Set
        End Property

        Public Property sizeImg() As Single
            Get
                Return CSng(Configuration.Read(Configuration.Keys.sizeImg))
            End Get
            Set(value As Single)
                Configuration.Write(Configuration.Keys.sizeImg, value.ToString())
            End Set
        End Property

        Public Property X() As Integer
            Get
                Return CInt(Configuration.Read(Configuration.Keys.x))
            End Get
            Set(value As Integer)
                Configuration.Write(Configuration.Keys.x, value.ToString())
            End Set
        End Property

        Public Property Y() As Single
            Get
                Return CInt(Configuration.Read(Configuration.Keys.y))
            End Get
            Set(value As Single)
                Configuration.Write(Configuration.Keys.y, value.ToString())
            End Set
        End Property

        Public Property FontSize() As Single
            Get
                Return CInt(Configuration.Read(Configuration.Keys.fontSize))
            End Get
            Set(value As Single)
                Configuration.Write(Configuration.Keys.fontSize, value.ToString())
            End Set
        End Property

        Public ReadOnly Property Folders() As Generic.List(Of System.IO.DirectoryInfo)
            Get
                Dim list As New Generic.List(Of System.IO.DirectoryInfo)
                Dim listFolders As String() = Configuration.Read(Configuration.Keys.folders).Split(";")
                For Each s As String In listFolders
                    list.Add(New System.IO.DirectoryInfo(s))
                Next
                Return list
            End Get
        End Property

        Public Function AddCustomFolder(ByVal directory As System.IO.DirectoryInfo) As Boolean
            Try
                Dim s As String = Configuration.Read(Configuration.Keys.folders)
                If Not String.IsNullOrEmpty(s) Then s += ";"
                s += directory.FullName
                Configuration.Write(Configuration.Keys.folders, s)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Function RemoveCustomFolder(ByVal directory As System.IO.DirectoryInfo) As Boolean
            Try
                Dim s As String = Configuration.Read(Configuration.Keys.folders)
                s = s.Replace(directory.FullName, "")
                If s.Length > 0 Then
                    If s.Substring(s.Length - 1).Equals(";") Then s = s.Substring(0, s.Length - 1)
                End If
                Configuration.Write(Configuration.Keys.folders, s)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Function GetStringFolders() As String
            Return Configuration.Read(Configuration.Keys.folders)
        End Function

        Public Sub SetStringFolders(ByVal str As String)
            Configuration.Write(Configuration.Keys.folders, str)
        End Sub
    End Class
End Namespace
