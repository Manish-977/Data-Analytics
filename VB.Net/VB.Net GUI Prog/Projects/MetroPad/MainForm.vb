' MetroPad v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Imports DevComponents.DotNetBar
Imports System.IO
Imports System.Drawing
Public Class MainForm
    Private m_Search As BalloonSearch

#Region " Procedures and Functions "

    Private Sub CreateNewDocument()
        Dim doc As frmDocument = New frmDocument()
        doc.MdiParent = Me
        doc.Show()
        doc.WindowState = FormWindowState.Maximized
        doc.Update()
        doc.Text = "New Document " + Me.MdiChildren.Length.ToString()
    End Sub

    Private Sub OpenDocument()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        Dim doc As frmDocument = New frmDocument()
        doc.Text = OpenFileDialog1.FileName
        doc.MdiParent = Me
        doc.Show()
        doc.WindowState = FormWindowState.Maximized
        doc.OpenFile(OpenFileDialog1.FileName)
    End Sub

    Private Function TabItemFromPoint(ByVal pClient As Point) As TabItem
        TabItemFromPoint = Nothing
        If Not TabStrip1.ClientRectangle.Contains(pClient) Then Exit Function

        Dim tab As TabItem
        For Each tab In TabStrip1.Tabs
            If tab.Visible And tab.DisplayRectangle.Contains(pClient) Then
                TabItemFromPoint = tab
                Exit Function
            End If
        Next
    End Function

    Private Sub EnableFileItems()
        ' Accessing items through the Items collection and setting the properties on them
        ' will propagate certain properties to all items with the same name...
        If Me.ActiveMdiChild Is Nothing Then
            bSave.Enabled = False
            bSaveTool.Enabled = False
            bSaveAs.Enabled = False
            bSaveAsTool.Enabled = False
            bPrint.Enabled = False
            bPrintTool.Enabled = False
            bPrintPreview.Enabled = False
            bPrintPreviewTool.Enabled = False
        Else
            bSave.Enabled = True
            bSaveTool.Enabled = True
            bSaveAs.Enabled = True
            bSaveAsTool.Enabled = True
            bPrint.Enabled = True
            bPrintTool.Enabled = True
            bPrintPreview.Enabled = True
            bPrintPreviewTool.Enabled = True
        End If
    End Sub

    Public Sub SaveDocument()
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Dim doc As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        If doc Is Nothing Then Exit Sub
        If Not doc.DocumentChanged Then Exit Sub
        SaveDocument(doc)
    End Sub

    Public Sub SaveDocument(ByVal doc As frmDocument)
        If doc.FileName = "" Then
            Dim dr As System.Windows.Forms.DialogResult = saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName = "" Then Exit Sub
            If dr = System.Windows.Forms.DialogResult.OK Then doc.FileName = saveFileDialog1.FileName
        End If
        If doc.FileName <> "" Then doc.SaveFile()
    End Sub

    Private Sub SaveDocumentAs()
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Dim doc As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        If doc Is Nothing Then Exit Sub
        If Not doc.DocumentChanged Then Exit Sub
        If doc.FileName = "" Then
            SaveDocument(doc)
            Exit Sub
        End If

        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName = "" Then Exit Sub

        doc.FileName = saveFileDialog1.FileName
        doc.SaveFile()
    End Sub

    Public Sub EditContextMenu()
        bEditPopUp.Displayed = False
        bEditPopUp.PopupMenu(Control.MousePosition)
    End Sub

    Private Sub CloseSearch()
        If (Not m_Search Is Nothing) Then
            m_Search.Close()
            m_Search.Dispose()
            m_Search = Nothing
        End If
    End Sub

    Public Sub SearchActiveDocument(ByVal text As String)
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand("bFind", text)
        End If
    End Sub

#End Region

#Region " Form Events "

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabStrip1.MdiForm = Me
        EnableFileItems()
    End Sub

    Private Sub MainForm_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        EnableFileItems()
    End Sub

    Private Sub ContextMenuBar1_PopupContainerLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuBar1.PopupContainerLoad
        Dim item As ButtonItem = CType(sender, ButtonItem)

        If item Is Nothing Then Exit Sub

        If item.Name = "bTextColorTool" Or item.Name = "bTabColor" Then
            Dim container As PopupContainerControl = CType(item.PopupContainerControl, PopupContainerControl)
            Dim clr As ColorPicker = New ColorPicker()
            container.Controls.Add(clr)
            clr.Location = container.ClientRectangle.Location
            container.ClientSize = clr.Size
        End If

    End Sub

    Private Sub ContextMenuBar1_PopupOpen(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.PopupOpenEventArgs) Handles ContextMenuBar1.PopupOpen
        Dim item As ButtonItem = CType(sender, ButtonItem)
        Dim clr As ColorPicker
        Dim container As PopupContainerControl

        If item Is Nothing Then Exit Sub

        If item.Name = "bTextColorTool" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
                If Not activedocument Is Nothing Then
                    activedocument.ExecuteCommand(item.GlobalName, clr.SelectedColor)
                End If
            End If
        ElseIf item.Name = "bTabColor" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                TabStrip1.ColorScheme.TabBackground = ControlPaint.LightLight(clr.SelectedColor)
                TabStrip1.ColorScheme.TabBackground2 = clr.SelectedColor
                TabStrip1.Refresh()
            End If
            ' Close popup menu, since it is not closed when Popup Container is closed...
            item.Parent.Expanded = False
        End If
    End Sub

    Private Sub ContextMenuBar1_PopupContainerUnload(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuBar1.PopupContainerUnload
        Dim item As ButtonItem = CType(sender, ButtonItem)
        Dim clr As ColorPicker
        Dim container As PopupContainerControl

        If item Is Nothing Then Exit Sub

        If item.Name = "bTextColorTool" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
                If Not activedocument Is Nothing Then
                    activedocument.ExecuteCommand(item.GlobalName, clr.SelectedColor)
                End If
            End If
        ElseIf item.Name = "bTabColor" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                TabStrip1.ColorScheme.TabBackground = ControlPaint.LightLight(clr.SelectedColor)
                TabStrip1.ColorScheme.TabBackground2 = clr.SelectedColor
                TabStrip1.Refresh()
            End If
            ' Close popup menu, since it is not closed when Popup Container is closed...
            item.Parent.Expanded = False
        End If
    End Sub

#End Region

#Region " Button's Events "

    Private Sub bItem_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNewTool.MouseLeave, _
        bOpenTool.MouseLeave, bSaveTool.MouseLeave, bSaveAsTool.MouseLeave, bPrintPreviewTool.MouseLeave, bPrintTool.MouseLeave, _
        bUndoTool.MouseLeave, bRedoTool.MouseLeave, bCutTool.MouseLeave, bCopyTool.MouseLeave, bPasteTool.MouseLeave, _
        bDeleteTool.MouseLeave, bFindTool.MouseLeave, bBoldTool.MouseLeave, bItalicTool.MouseLeave, bUnderlineTool.MouseLeave, _
        bAlignLeftTool.MouseLeave, bAlignCenterTool.MouseLeave, bAlignRightTool.MouseLeave, bTextFontTool.MouseLeave
        ' Sync Status-bar with the item tooltip...
        Dim item As ButtonItem = CType(sender, ButtonItem)
        If item Is Nothing Then Exit Sub

        labelStatus.Text = ""
    End Sub

    Private Sub bItem_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNewTool.MouseEnter, _
        bOpenTool.MouseEnter, bSaveTool.MouseEnter, bSaveAsTool.MouseEnter, bPrintPreviewTool.MouseEnter, bPrintTool.MouseEnter, _
        bUndoTool.MouseEnter, bRedoTool.MouseEnter, bCutTool.MouseEnter, bCopyTool.MouseEnter, bPasteTool.MouseEnter, _
        bDeleteTool.MouseEnter, bFindTool.MouseEnter, bBoldTool.MouseEnter, bItalicTool.MouseEnter, bUnderlineTool.MouseEnter, _
        bAlignLeftTool.MouseEnter, bAlignCenterTool.MouseEnter, bAlignRightTool.MouseEnter, bTextFontTool.MouseEnter
        ' Sync Status-bar with the item tooltip...
        Dim item As ButtonItem = CType(sender, ButtonItem)
        If item Is Nothing Then Exit Sub

        labelStatus.Text = item.Tooltip
    End Sub

    Private Sub bNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNew.Click, bNewTool.Click, bNewWindow.Click
        CreateNewDocument()
    End Sub

    Private Sub bOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOpen.Click, bOpenTool.Click
        OpenDocument()
    End Sub

    Private Sub bClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClose.Click, cmdContextClose.Click
        Try
            Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
            If Not activedocument Is Nothing Then
                activedocument.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click, bSaveTool.Click, cmdContextSave.Click
        Try
            SaveDocument()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSaveAs.Click, bSaveAsTool.Click
        Try
            SaveDocumentAs()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub bArrangeAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bArrangeAll.Click
        Try
            Me.LayoutMdi(MdiLayout.Cascade)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUndo.Click, bUndoTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bUndo.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRedo.Click, bRedoTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bRedo.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCut.Click, bCutTool.Click, bCutContext.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bCut.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCopy.Click, bCopyTool.Click, bCopyContext.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bCopy.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPaste.Click, bPasteTool.Click, bPasteContext.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bPaste.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDelete.Click, bDeleteTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bDelete.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSelectAll.Click, bSelectAllContext.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bSelectAll.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBold.Click, bBoldTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bBold.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bItalic.Click, bItalic.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bItalic.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUnderline.Click, bUnderlineTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bUnderline.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bStrikeThrough_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStrikeThrough.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bStrikeThrough.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bAlignLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAlignLeft.Click, bAlignLeftTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bAlignLeft.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bAlignCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAlignCenter.Click, bAlignCenterTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bAlignCenter.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bAlignRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAlignRight.Click, bAlignRightTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bAlignRight.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bTextFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTextFont.Click, bTextFontTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bTextFont.GlobalName, Nothing)
        End If
    End Sub

    'Private Sub bTextColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
    '    If Not activedocument Is Nothing Then
    '        activedocument.ExecuteCommand(bTextColor.GlobalName, Nothing)
    '    End If
    'End Sub

    Private Sub bFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFind.Click, bFindTool.Click
        Try
            Dim objItem As BaseItem = CType(sender, BaseItem)
            If m_Search Is Nothing OrElse m_Search.IsDisposed Then
                m_Search = New BalloonSearch()
                m_Search.Owner = Me
                m_Search.Show(objItem, True)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAbout.Click
        Dim c As FrmAbout = New FrmAbout
        c.ShowDialog()
    End Sub

    Private Sub bPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrintPreview.Click, bPrintPreviewTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bPrintPreview.GlobalName, Nothing)
        End If
    End Sub

    Private Sub bPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click, bPrintTool.Click
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand(bPrint.GlobalName, Nothing)
        End If
    End Sub

#End Region

    Private Sub bToolbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bToolbar.Click
        If bToolbar.Checked = True Then
            bar3.Visible = True
        Else
            bar3.Visible = False
        End If
    End Sub

End Class