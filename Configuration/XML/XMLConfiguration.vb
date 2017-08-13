Imports System.Xml

Namespace Configuration.XML
    Public Class XMLConfiguration

        Public Shared Function SaveCurrentConfiguration(ByVal fileName As String, ByVal name As String) As Boolean
            Try
                Dim xml As New XmlTextWriter(fileName, Nothing)
                Dim conf As New ConfigurationCreator()
                xml.WriteStartDocument()
                xml.WriteStartElement("root")
                xml.WriteAttributeString("name", name)
                xml.WriteElementString(Configuration.Keys.outputFolder.ToString(), conf.OutputFolder)
                xml.WriteElementString(Configuration.Keys.overlap.ToString(), conf.Overlap.ToString)
                xml.WriteElementString(Configuration.Keys.signerText.ToString(), conf.SignerText)
                xml.WriteElementString(Configuration.Keys.signerVisible.ToString(), conf.SignerVisible.ToString())
                xml.WriteElementString(Configuration.Keys.textSignerVisible.ToString(), conf.TextSignerVisible.ToString())
                xml.WriteElementString(Configuration.Keys.numberPage.ToString(), conf.NumberPage.ToString())
                xml.WriteElementString(Configuration.Keys.firstPage.ToString(), conf.FirstPage.ToString())
                xml.WriteElementString(Configuration.Keys.lastPage.ToString(), conf.LastPage.ToString())
                xml.WriteElementString(Configuration.Keys.img.ToString(), conf.Img)
                xml.WriteElementString(Configuration.Keys.sizeImg.ToString(), conf.sizeImg.ToString())
                xml.WriteElementString(Configuration.Keys.x.ToString(), conf.X.ToString())
                xml.WriteElementString(Configuration.Keys.y.ToString(), conf.Y.ToString())
                xml.WriteElementString(Configuration.Keys.fontSize.ToString(), conf.FontSize.ToString())
                xml.WriteElementString(Configuration.Keys.folders.ToString(), conf.GetStringFolders())
                xml.WriteEndElement()
                xml.Close()
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        Public Shared Function OpenXMLConfiguration(ByVal fileName As String) As Boolean
            Try
                Dim xml As New XmlDocument()
                Dim conf As New ConfigurationCreator()
                Dim b As Boolean = False
                xml.Load(fileName)
                If xml.SelectSingleNode("root") IsNot Nothing Then
                    conf.OutputFolder = xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.outputFolder).InnerText
                    conf.Overlap = CBool(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.overlap).InnerText)
                    conf.SignerText = xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.signerText).InnerText
                    conf.SignerVisible = CBool(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.signerVisible).InnerText)
                    conf.TextSignerVisible = CBool(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.textSignerVisible).InnerText)
                    conf.NumberPage = CInt(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.numberPage).InnerText)
                    conf.FirstPage = CBool(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.firstPage).InnerText)
                    conf.LastPage = CBool(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.lastPage).InnerText)
                    conf.Img = xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.img).InnerText
                    conf.sizeImg = CSng(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.sizeImg).InnerText)
                    conf.X = CSng(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.x).InnerText)
                    conf.Y = CSng(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.y).InnerText)
                    conf.FontSize = CSng(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.fontSize).InnerText)
                    conf.SetStringFolders(xml.SelectSingleNode("root").ChildNodes(Configuration.Keys.folders).InnerText)
                    b = True
                Else
                    MessageBox.Show("O arquivo está formatado de forma incorreta.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    b = False
                End If
                xml.Clone()
                Return b
            Catch ex As Exception
                MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Function
    End Class

End Namespace