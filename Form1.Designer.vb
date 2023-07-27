<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        PiecesTextBox = New TextBox()
        NameTextBox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CalculateButton = New Button()
        SummaryButton = New Button()
        ClearButton = New Button()
        CloseButton = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ClearToolStripMenuItem = New ToolStripMenuItem()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        DisplayToolStripMenuItem = New ToolStripMenuItem()
        CalculateToolStripMenuItem = New ToolStripMenuItem()
        SummaryToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PiecesTextBox)
        GroupBox1.Controls.Add(NameTextBox)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.Highlight
        GroupBox1.Location = New Point(32, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(319, 160)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee Information"
        ' 
        ' PiecesTextBox
        ' 
        PiecesTextBox.Location = New Point(126, 90)
        PiecesTextBox.Name = "PiecesTextBox"
        PiecesTextBox.Size = New Size(100, 23)
        PiecesTextBox.TabIndex = 3
        ' 
        ' NameTextBox
        ' 
        NameTextBox.ForeColor = SystemColors.ControlText
        NameTextBox.Location = New Point(70, 30)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(198, 23)
        NameTextBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(6, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 1
        Label2.Text = "Pieces completed:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(6, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(53, 261)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(114, 56)
        CalculateButton.TabIndex = 0
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(210, 261)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(114, 56)
        SummaryButton.TabIndex = 1
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(53, 357)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(114, 56)
        ClearButton.TabIndex = 2
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(210, 357)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(114, 56)
        CloseButton.TabIndex = 3
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DisplayToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(384, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClearToolStripMenuItem, CloseToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ClearToolStripMenuItem
        ' 
        ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        ClearToolStripMenuItem.Size = New Size(103, 22)
        ClearToolStripMenuItem.Text = "Clear"
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(103, 22)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' DisplayToolStripMenuItem
        ' 
        DisplayToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CalculateToolStripMenuItem, SummaryToolStripMenuItem})
        DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        DisplayToolStripMenuItem.Size = New Size(57, 20)
        DisplayToolStripMenuItem.Text = "&Display"
        ' 
        ' CalculateToolStripMenuItem
        ' 
        CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        CalculateToolStripMenuItem.Size = New Size(125, 22)
        CalculateToolStripMenuItem.Text = "Calculate"
        ' 
        ' SummaryToolStripMenuItem
        ' 
        SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        SummaryToolStripMenuItem.Size = New Size(125, 22)
        SummaryToolStripMenuItem.Text = "Summary"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 450)
        Controls.Add(CloseButton)
        Controls.Add(ClearButton)
        Controls.Add(SummaryButton)
        Controls.Add(CalculateButton)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BOCK REPAIRS"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PiecesTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
End Class
