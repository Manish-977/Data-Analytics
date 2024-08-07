' MetroPad v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Imports System.Drawing.Printing
Public Class frmDocument
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public WithEvents fontDialog1 As System.Windows.Forms.FontDialog
    Private WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
    Private WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Private WithEvents printDialog1 As System.Windows.Forms.PrintDialog
    Private WithEvents pageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Public WithEvents rtfText As System.Windows.Forms.RichTextBox

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocument))
        Me.rtfText = New System.Windows.Forms.RichTextBox()
        Me.fontDialog1 = New System.Windows.Forms.FontDialog()
        Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.SuspendLayout()
        '
        'rtfText
        '
        Me.rtfText.BackColor = System.Drawing.Color.Black
        Me.rtfText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtfText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfText.ForeColor = System.Drawing.Color.White
        Me.rtfText.HideSelection = False
        Me.rtfText.Location = New System.Drawing.Point(0, 0)
        Me.rtfText.Name = "rtfText"
        Me.rtfText.Size = New System.Drawing.Size(217, 154)
        Me.rtfText.TabIndex = 0
        Me.rtfText.Text = ""
        '
        'fontDialog1
        '
        Me.fontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'printDocument1
        '
        '
        'printPreviewDialog1
        '
        Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog1.Document = Me.printDocument1
        Me.printPreviewDialog1.Enabled = True
        Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog1.Name = "printPreviewDialog1"
        Me.printPreviewDialog1.Visible = False
        '
        'printDialog1
        '
        Me.printDialog1.Document = Me.printDocument1
        Me.printDialog1.UseEXDialog = True
        '
        'pageSetupDialog1
        '
        Me.pageSetupDialog1.Document = Me.printDocument1
        '
        'frmDocument
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(217, 154)
        Me.Controls.Add(Me.rtfText)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDocument"
        Me.ShowIcon = False
        Me.Text = "frmDocument"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public FileName As String = ""
    Public DocumentChanged As Boolean = False
    Public currentCharacter As Integer = 0

    Public Sub ExecuteCommand(ByVal cmd As String, ByVal data As Object)
        Select Case cmd
            ' Edit Menu
            Case "bUndo"
                rtfText.Undo()
            Case "bRedo"
                rtfText.Redo()
            Case "bCut"
                rtfText.Cut()
            Case "bCopy"
                rtfText.Copy()
            Case "bPaste"
                rtfText.Paste()
            Case "bDelete"
                rtfText.SelectedText = ""
            Case "bSelectAll"
                rtfText.SelectAll()
            Case "bFind"
                If Not data Is Nothing Then
                    Dim searchText As String = data.ToString()
                    rtfText.Find(searchText, rtfText.SelectionStart + rtfText.SelectionLength, RichTextBoxFinds.None)
                End If
            Case "bFindNext"
                MessageBox.Show("Not implemented yet.")
            Case "bReplace"
                MessageBox.Show("Not implemented yet.")
                ' Format menu
            Case "bBold"
                If rtfText.SelectionFont.Bold Then
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Bold)))
                Else
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Bold))
                End If
            Case "bItalic"
                If rtfText.SelectionFont.Italic Then
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Italic)))
                Else
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Italic))
                End If
            Case "bUnderline"
                If rtfText.SelectionFont.Underline Then
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Underline)))
                Else
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Underline))
                End If
            Case "bStrikethrough"
                If rtfText.SelectionFont.Strikeout Then
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style And Not (rtfText.SelectionFont.Style And FontStyle.Strikeout)))
                Else
                    rtfText.SelectionFont = New Font(rtfText.SelectionFont, (rtfText.SelectionFont.Style Or FontStyle.Strikeout))
                End If
            Case "bAlignLeft"
                rtfText.SelectionAlignment = HorizontalAlignment.Left
            Case "bAlignCenter"
                rtfText.SelectionAlignment = HorizontalAlignment.Center
            Case "bAlignRight"
                rtfText.SelectionAlignment = HorizontalAlignment.Right
            Case "bTextFont"
                If fontDialog1.ShowDialog() = DialogResult.OK Then
                    Me.rtfText.Font = fontDialog1.Font
                    'MainForm.Properties.Settings.Default.textboxFont = MainForm.fontDialog1.Font
                End If
            Case "bTextColor"
                If Not data Is Nothing And TypeOf (data) Is Color Then
                    rtfText.SelectionColor = CType(data, Color)
                End If
            Case "bPrintPreview"
                printPreviewDialog1.ShowDialog()
            Case "bPrint"
                If printDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    printDocument1.Print()
                End If
        End Select
        DocumentChanged = True
        EnableSelectionItems()
    End Sub

#Region " Procedures and Functions "

    Public Sub OpenFile(ByVal filename As String)
        Try
            If filename.Substring(filename.Length - 4, 4).ToLower() = ".txt" Then
                rtfText.LoadFile(filename, RichTextBoxStreamType.PlainText)
            Else
                rtfText.LoadFile(filename, RichTextBoxStreamType.RichText)
            End If
            Me.FileName = filename
            DocumentChanged = False
        Catch ex As Exception
            MessageBox.Show("File Format is not Valid")
        End Try
    End Sub

    Private Sub UpdateStatusBar()
        Dim mdi As MainForm = CType(Me.ParentForm, MainForm)
        mdi.labelPosition.Text = "Ln " + (rtfText.GetLineFromCharIndex(rtfText.SelectionStart) + 1).ToString() + Chr(9) + "Ch " + rtfText.SelectionStart.ToString()
    End Sub

    Private Sub EnableSelectionItems()
        Dim m As MainForm = CType(Me.ParentForm, MainForm)

        UpdateStatusBar()

        If rtfText.SelectionLength = 0 Then
            m.bCut.Enabled = False
            m.bCutTool.Enabled = False
            m.bCutContext.Enabled = False
            m.bCopy.Enabled = False
            m.bCopyTool.Enabled = False
            m.bCopyContext.Enabled = False
            m.bDelete.Enabled = False
            m.bDeleteTool.Enabled = False
        Else
            m.bCut.Enabled = True
            m.bCutTool.Enabled = True
            m.bCutContext.Enabled = True
            m.bCopy.Enabled = True
            m.bCopyTool.Enabled = True
            m.bCopyContext.Enabled = True
            m.bDelete.Enabled = True
            m.bDeleteTool.Enabled = True
        End If

        m.bBold.Checked = rtfText.SelectionFont.Bold
        m.bBoldTool.Checked = rtfText.SelectionFont.Bold
        m.bItalic.Checked = rtfText.SelectionFont.Italic
        m.bItalicTool.Checked = rtfText.SelectionFont.Italic
        m.bUnderline.Checked = rtfText.SelectionFont.Underline
        m.bUnderlineTool.Checked = rtfText.SelectionFont.Underline
        m.bStrikeThrough.Checked = rtfText.SelectionFont.Strikeout
        'm.bStrikeThroughTool.Checked = rtfText.SelectionFont.Strikeout
        m.bAlignLeft.Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Left)
        m.bAlignLeftTool.Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Left)
        m.bAlignRight.Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Right)
        m.bAlignRightTool.Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Right)
        m.bAlignCenter.Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Center)
        m.bAlignCenterTool.Checked = (rtfText.SelectionAlignment = HorizontalAlignment.Center)
    End Sub

    Private Sub EnableDocMenuItems()
        If Not Me.Visible Then Exit Sub

        Dim m As MainForm = CType(Me.ParentForm, MainForm)

        ' Disabled Edit items
        m.bPaste.Enabled = True
        m.bPasteTool.Enabled = True
        m.bPasteContext.Enabled = True
        m.bSelectAll.Enabled = True
        m.bSelectAllContext.Enabled = True
        m.bFind.Enabled = True
        m.bFindTool.Enabled = True
        m.bReplace.Enabled = True

        ' Disable Format items
        m.bAlignLeft.Enabled = True
        m.bAlignLeftTool.Enabled = True
        m.bAlignRight.Enabled = True
        m.bAlignRightTool.Enabled = True
        m.bAlignCenter.Enabled = True
        m.bAlignCenterTool.Enabled = True

        m.bBold.Enabled = True
        m.bBoldTool.Enabled = True
        m.bItalic.Enabled = True
        m.bItalicTool.Enabled = True
        m.bUnderline.Enabled = True
        m.bUnderlineTool.Enabled = True
        m.bStrikeThrough.Enabled = True

        'm.bTextColor.Enabled = True
        'm.bTextColorTool.Enabled = True
        m.bTextFont.Enabled = True
        m.bTextFontTool.Enabled = True

        EnableSelectionItems()
    End Sub

    Private Sub DisableDocMenuItems()
        Dim m As MainForm = CType(Me.ParentForm, MainForm)

        ' Disabled Edit items
        m.bCut.Enabled = False
        m.bCutTool.Enabled = False
        m.bCutContext.Enabled = False
        m.bCopy.Enabled = False
        m.bCopyTool.Enabled = False
        m.bCopyContext.Enabled = False
        m.bPaste.Enabled = False
        m.bPasteTool.Enabled = False
        m.bPasteContext.Enabled = False
        m.bDelete.Enabled = False
        m.bDeleteTool.Enabled = False
        m.bSelectAll.Enabled = False
        m.bSelectAllContext.Enabled = False
        m.bFind.Enabled = False
        m.bFindTool.Enabled = False
        m.bReplace.Enabled = False

        ' Disable Format items
        m.bBold.Enabled = False
        m.bBoldTool.Enabled = False
        m.bItalic.Enabled = False
        m.bItalicTool.Enabled = False
        m.bUnderline.Enabled = False
        m.bUnderlineTool.Enabled = False
        m.bStrikeThrough.Enabled = False
        m.bAlignLeft.Enabled = False
        m.bAlignLeftTool.Enabled = False
        m.bAlignRight.Enabled = False
        m.bAlignRightTool.Enabled = False
        m.bAlignCenter.Enabled = False
        m.bAlignCenterTool.Enabled = False
        'm.bTextColor.Enabled = False
        'm.bTextColorTool.Enabled = False
        m.bTextFont.Enabled = False
        m.bTextFontTool.Enabled = False
    End Sub

    Public Sub SaveFile()
        If Me.FileName.Substring(Me.FileName.Length - 4, 4).ToLower() = ".txt" Then
            rtfText.SaveFile(Me.FileName, RichTextBoxStreamType.PlainText)
        Else
            rtfText.SaveFile(Me.FileName, RichTextBoxStreamType.RichText)
        End If
        DocumentChanged = False
    End Sub

#End Region

    Private Sub frmDocument_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim mdi As MainForm = CType(Me.ParentForm, MainForm)
        mdi.labelPosition.Text = ""
        DisableDocMenuItems()
    End Sub

    Private Sub frmDocument_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.DocumentChanged Then
            Dim dlg As System.Windows.Forms.DialogResult = MessageBox.Show(Me, "Document '" + Me.FileName + "' has changed. Save changes?", "Notepad", MessageBoxButtons.YesNoCancel)
            If dlg = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            ElseIf dlg = System.Windows.Forms.DialogResult.Yes Then
                If Me.FileName = "" Then CType(Me.MdiParent, MainForm).SaveDocument(Me)
                If Me.FileName <> "" Then SaveFile()
            End If
        End If
    End Sub

    Private Sub frmDocument_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        EnableDocMenuItems()
        UpdateStatusBar()
    End Sub

    Private Sub frmDocument_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        DisableDocMenuItems()
    End Sub

    Private Sub frmDocument_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            EnableDocMenuItems()
        Else
            DisableDocMenuItems()
        End If
    End Sub

    Private Sub rtfText_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtfText.SelectionChanged
        EnableSelectionItems()
    End Sub

    Private Sub rtfText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtfText.TextChanged
        DocumentChanged = True
    End Sub

    Private Sub rtfText_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtfText.MouseDown
        If e.Button <> MouseButtons.Right Then Exit Sub

        Dim mdi As MainForm = CType(Me.ParentForm, MainForm)
        mdi.EditContextMenu()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim printFont As Font = rtfText.Font
        Dim leftMargin As Integer = printDocument1.DefaultPageSettings.Margins.Left
        Dim rightMargin As Integer = printDocument1.DefaultPageSettings.Margins.Right
        Dim topMargin As Integer = printDocument1.DefaultPageSettings.Margins.Top
        Dim bottomMargin As Integer = printDocument1.DefaultPageSettings.Margins.Bottom
        Dim printAreaHeight As Integer = printDocument1.DefaultPageSettings.PaperSize.Height - (topMargin + bottomMargin)
        Dim printAreaWidth As Integer = printDocument1.DefaultPageSettings.PaperSize.Width - (leftMargin + rightMargin) + 200

        If printDocument1.DefaultPageSettings.Landscape = False Then
            Dim tempPrintArea As Integer = printAreaHeight
            printAreaHeight = printAreaWidth
            printAreaWidth = tempPrintArea - 300

            Dim linesPerPage As Double = printAreaHeight / printFont.Height
            Dim linesFilled As Integer
            Dim charactersFitted As Integer

            Dim printTextFormate As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            Dim printAreaRectangle As RectangleF = New RectangleF(leftMargin, topMargin, printAreaWidth, printAreaHeight)

            Dim tempTextForPrint As String = rtfText.Text.Substring(currentCharacter)
            e.Graphics.MeasureString(tempTextForPrint,
                                     printFont,
                                     New SizeF(printAreaWidth, printAreaHeight),
                                     printTextFormate,
                                      charactersFitted,
                                      linesFilled)

            tempTextForPrint = rtfText.Text.Substring(currentCharacter, charactersFitted)
            e.Graphics.DrawString(tempTextForPrint,
                                  printFont,
                                  Brushes.Black,
                                  printAreaRectangle,
                                  printTextFormate)

            currentCharacter += charactersFitted
            If (currentCharacter < ((rtfText.Text.Length) - 1)) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
                currentCharacter = 0
            End If
        End If
    End Sub

End Class
