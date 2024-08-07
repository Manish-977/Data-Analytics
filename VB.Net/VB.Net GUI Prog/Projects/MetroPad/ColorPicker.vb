' MetroPad v1.0
'
' Programmed by: Sergio Galvez (galvezsergio19@yahoo.com)
' Website: http://galvezsergio.url.ph
' 
' A simple VB.net system developed for personal
' project folio. 
' 
' Hope you'll like this .... Thanks!

Public Class ColorPicker
    Inherits System.Windows.Forms.UserControl

    Private m_CustomColors(48) As Color
    Private m_CustomColorsPos(48) As Rectangle
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents colorPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents customTab As DevComponents.DotNetBar.TabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents webTab As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents systemTab As DevComponents.DotNetBar.TabItem
    Friend WithEvents listWeb As System.Windows.Forms.ListBox
    Friend WithEvents colorPanel As System.Windows.Forms.Panel
    Friend WithEvents listSystem As System.Windows.Forms.ListBox

    Public SelectedColor As Color = Color.Empty

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitCustomColors()
        InitOtherColors()
    End Sub

    'UserControl overrides dispose to clean up the component list.
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.colorPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.colorPanel = New System.Windows.Forms.Panel()
        Me.customTab = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.listSystem = New System.Windows.Forms.ListBox()
        Me.systemTab = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.listWeb = New System.Windows.Forms.ListBox()
        Me.webTab = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.colorPanel2.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.colorPanel2)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ForeColor = System.Drawing.Color.White
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(192, 174)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document
        Me.TabControl1.TabIndex = 1
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.customTab)
        Me.TabControl1.Tabs.Add(Me.webTab)
        Me.TabControl1.Tabs.Add(Me.systemTab)
        Me.TabControl1.Text = "TabControl2"
        '
        'colorPanel2
        '
        Me.colorPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colorPanel2.Controls.Add(Me.colorPanel)
        Me.colorPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.colorPanel2.Location = New System.Drawing.Point(0, 25)
        Me.colorPanel2.Name = "colorPanel2"
        Me.colorPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.colorPanel2.Size = New System.Drawing.Size(192, 149)
        Me.colorPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.colorPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.colorPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.colorPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.colorPanel2.Style.GradientAngle = 90
        Me.colorPanel2.TabIndex = 1
        Me.colorPanel2.TabItem = Me.customTab
        '
        'colorPanel
        '
        Me.colorPanel.BackColor = System.Drawing.Color.White
        Me.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colorPanel.Location = New System.Drawing.Point(1, 1)
        Me.colorPanel.Name = "colorPanel"
        Me.colorPanel.Size = New System.Drawing.Size(190, 147)
        Me.colorPanel.TabIndex = 2
        '
        'customTab
        '
        Me.customTab.AttachedControl = Me.colorPanel2
        Me.customTab.Name = "customTab"
        Me.customTab.Text = "Custom"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.listSystem)
        Me.TabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(192, 149)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 3
        Me.TabControlPanel2.TabItem = Me.systemTab
        '
        'listSystem
        '
        Me.listSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listSystem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.listSystem.IntegralHeight = False
        Me.listSystem.Location = New System.Drawing.Point(1, 1)
        Me.listSystem.Name = "listSystem"
        Me.listSystem.Size = New System.Drawing.Size(190, 147)
        Me.listSystem.TabIndex = 2
        '
        'systemTab
        '
        Me.systemTab.AttachedControl = Me.TabControlPanel2
        Me.systemTab.Name = "systemTab"
        Me.systemTab.Text = "System"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.listWeb)
        Me.TabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(192, 149)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 2
        Me.TabControlPanel1.TabItem = Me.webTab
        '
        'listWeb
        '
        Me.listWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listWeb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.listWeb.IntegralHeight = False
        Me.listWeb.Location = New System.Drawing.Point(1, 1)
        Me.listWeb.Name = "listWeb"
        Me.listWeb.Size = New System.Drawing.Size(190, 147)
        Me.listWeb.TabIndex = 1
        '
        'webTab
        '
        Me.webTab.AttachedControl = Me.TabControlPanel1
        Me.webTab.Name = "webTab"
        Me.webTab.Text = "Web"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'ColorPicker
        '
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ColorPicker"
        Me.Size = New System.Drawing.Size(192, 174)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.colorPanel2.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub InitCustomColors()
        m_CustomColors(0) = Color.FromArgb(255, 255, 255)
        m_CustomColors(1) = Color.FromArgb(255, 195, 198)
        m_CustomColors(2) = Color.FromArgb(255, 227, 198)
        m_CustomColors(3) = Color.FromArgb(255, 255, 198)
        m_CustomColors(4) = Color.FromArgb(198, 255, 198)
        m_CustomColors(5) = Color.FromArgb(198, 255, 255)
        m_CustomColors(6) = Color.FromArgb(198, 195, 255)
        m_CustomColors(7) = Color.FromArgb(255, 195, 255)

        m_CustomColors(8) = Color.FromArgb(231, 227, 231)
        m_CustomColors(9) = Color.FromArgb(255, 130, 132)
        m_CustomColors(10) = Color.FromArgb(255, 195, 132)
        m_CustomColors(11) = Color.FromArgb(255, 255, 132)
        m_CustomColors(12) = Color.FromArgb(132, 255, 132)
        m_CustomColors(13) = Color.FromArgb(132, 255, 255)
        m_CustomColors(14) = Color.FromArgb(132, 130, 255)
        m_CustomColors(15) = Color.FromArgb(255, 130, 255)

        m_CustomColors(16) = Color.FromArgb(198, 195, 198)
        m_CustomColors(17) = Color.FromArgb(255, 0, 0)
        m_CustomColors(18) = Color.FromArgb(255, 130, 0)
        m_CustomColors(19) = Color.FromArgb(255, 255, 0)
        m_CustomColors(20) = Color.FromArgb(0, 255, 0)
        m_CustomColors(21) = Color.FromArgb(0, 255, 255)
        m_CustomColors(22) = Color.FromArgb(0, 0, 255)
        m_CustomColors(23) = Color.FromArgb(255, 0, 255)

        m_CustomColors(24) = Color.FromArgb(132, 130, 132)
        m_CustomColors(25) = Color.FromArgb(198, 0, 0)
        m_CustomColors(26) = Color.FromArgb(198, 65, 0)
        m_CustomColors(27) = Color.FromArgb(198, 195, 0)
        m_CustomColors(28) = Color.FromArgb(0, 195, 0)
        m_CustomColors(29) = Color.FromArgb(0, 195, 198)
        m_CustomColors(30) = Color.FromArgb(0, 0, 198)
        m_CustomColors(31) = Color.FromArgb(198, 0, 198)

        m_CustomColors(32) = Color.FromArgb(66, 65, 66)
        m_CustomColors(33) = Color.FromArgb(132, 0, 0)
        m_CustomColors(34) = Color.FromArgb(132, 65, 0)
        m_CustomColors(35) = Color.FromArgb(132, 130, 0)
        m_CustomColors(36) = Color.FromArgb(0, 130, 0)
        m_CustomColors(37) = Color.FromArgb(0, 130, 132)
        m_CustomColors(38) = Color.FromArgb(0, 0, 132)
        m_CustomColors(39) = Color.FromArgb(132, 0, 132)

        m_CustomColors(40) = Color.FromArgb(0, 0, 0)
        m_CustomColors(41) = Color.FromArgb(66, 0, 0)
        m_CustomColors(42) = Color.FromArgb(132, 65, 66)
        m_CustomColors(43) = Color.FromArgb(66, 65, 0)
        m_CustomColors(44) = Color.FromArgb(0, 65, 0)
        m_CustomColors(45) = Color.FromArgb(0, 65, 66)
        m_CustomColors(46) = Color.FromArgb(0, 0, 66)
        m_CustomColors(47) = Color.FromArgb(66, 0, 66)
    End Sub

    Private Sub InitOtherColors()
        Dim type As Type
        Dim fields() As System.Reflection.PropertyInfo
        Dim clr As Color
        Dim pi As System.Reflection.PropertyInfo
        listWeb.BeginUpdate()
        listWeb.Items.Clear()

        type = GetType(Color)
        fields = type.GetProperties(Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static)
        clr = New Color()
        For Each pi In fields
            listWeb.Items.Add(pi.GetValue(clr, Nothing))
        Next
        listWeb.EndUpdate()

        listSystem.BeginUpdate()
        listSystem.Items.Clear()
        type = GetType(SystemColors)
        fields = type.GetProperties(Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static)
        For Each pi In fields
            listSystem.Items.Add(pi.GetValue(clr, Nothing))
        Next
        listSystem.EndUpdate()
    End Sub

    Private Sub listWeb_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles listWeb.DrawItem
        Dim r As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        Dim rClr As Rectangle = New Rectangle(r.X + 1, r.Y + 2, 24, r.Height - 4)
        Dim textbrush As Brush = SystemBrushes.ControlText
        If (e.State And DrawItemState.Selected) <> 0 Then
            textbrush = SystemBrushes.HighlightText
            e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds)
        Else
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds)
        End If

        Dim clr As Color = CType(listWeb.Items(e.Index), Color)
        e.Graphics.FillRectangle(New SolidBrush(clr), rClr)
        e.Graphics.DrawRectangle(SystemPens.ControlText, rClr)
        r.Offset(30, 0)
        r.Width -= 30
        e.Graphics.DrawString(clr.Name, listWeb.Font, textbrush, r, StringFormat.GenericTypographic)
    End Sub

    Private Sub listWeb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listWeb.SelectedIndexChanged
        If Not listWeb.SelectedItem Is Nothing Then
            SelectedColor = CType(listWeb.SelectedItem, Color)
            ColorSelected()
        End If
    End Sub

    Private Sub colorPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colorPanel.Paint
        Dim r As Rectangle = Rectangle.Empty
        Dim x As Integer, y As Integer
        Dim g As Graphics = e.Graphics
        Dim side As Border3DSide = (Border3DSide.Left Or Border3DSide.Right Or Border3DSide.Top Or Border3DSide.Bottom)
        Dim width As Integer = Me.TabControl1.ClientRectangle.Width
        Dim iIndex As Integer = 0
        Dim clr As Color

        For Each clr In m_CustomColors
            r = New Rectangle(x, y, 21, 21)
            If r.Right > width Then
                y += 25
                x = 0
                r.X = x
                r.Y = y
            End If

            'ControlPaint.DrawBorder3D(g, x, y, 21, 21, Border3DStyle.Sunken, side)
            r.Inflate(-2, -2)
            g.FillRectangle(New SolidBrush(clr), r)

            m_CustomColorsPos(iIndex) = r
            iIndex = iIndex + 1
            x += 24
        Next
    End Sub

    Private Sub listSystem_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles listSystem.DrawItem
        Dim r As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        Dim rClr As Rectangle = New Rectangle(r.X + 1, r.Y + 2, 24, r.Height - 4)

        Dim textbrush As Brush = SystemBrushes.ControlText
        If (e.State And DrawItemState.Selected) <> 0 Then
            textbrush = SystemBrushes.HighlightText
            e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds)
        Else
            e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds)

            Dim clr As Color = CType(listSystem.Items(e.Index), Color)
            e.Graphics.FillRectangle(New SolidBrush(clr), rClr)
            e.Graphics.DrawRectangle(SystemPens.ControlText, rClr)
            r.Offset(30, 0)
            r.Width -= 30
            e.Graphics.DrawString(clr.Name, listWeb.Font, textbrush, r, StringFormat.GenericTypographic)
        End If
    End Sub

    Private Sub colorPanel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles colorPanel.MouseUp
        Dim i As Integer
        For i = 0 To 47
            If m_CustomColorsPos(i).Contains(e.X, e.Y) Then
                SelectedColor = m_CustomColors(i)
                ColorSelected()
                Exit For
            End If
        Next
    End Sub

    Private Sub ColorSelected()
        Dim ctrl As DevComponents.DotNetBar.PopupContainerControl = CType(Me.Parent, DevComponents.DotNetBar.PopupContainerControl)
        If ctrl Is Nothing Then Exit Sub
        ctrl.ParentItem.Expanded = False
    End Sub

    Private Sub listSystem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listSystem.SelectedIndexChanged
        If Not listSystem.SelectedItem Is Nothing Then
            SelectedColor = CType(listSystem.SelectedItem, Color)
            ColorSelected()
        End If
    End Sub
End Class
