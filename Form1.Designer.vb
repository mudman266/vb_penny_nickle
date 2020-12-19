<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNumDays = New System.Windows.Forms.Label()
        Me.txtNumDays = New System.Windows.Forms.TextBox()
        Me.radPenny = New System.Windows.Forms.RadioButton()
        Me.radNickle = New System.Windows.Forms.RadioButton()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(-2, 23)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(572, 428)
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(141, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(284, 38)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Penny or Nickle"
        '
        'lblNumDays
        '
        Me.lblNumDays.AutoSize = True
        Me.lblNumDays.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDays.Location = New System.Drawing.Point(28, 120)
        Me.lblNumDays.Name = "lblNumDays"
        Me.lblNumDays.Size = New System.Drawing.Size(282, 28)
        Me.lblNumDays.TabIndex = 3
        Me.lblNumDays.Text = "Number of Work Days"
        '
        'txtNumDays
        '
        Me.txtNumDays.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDays.Location = New System.Drawing.Point(325, 121)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.Size = New System.Drawing.Size(100, 26)
        Me.txtNumDays.TabIndex = 4
        '
        'radPenny
        '
        Me.radPenny.AutoSize = True
        Me.radPenny.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPenny.Location = New System.Drawing.Point(242, 171)
        Me.radPenny.Name = "radPenny"
        Me.radPenny.Size = New System.Drawing.Size(77, 24)
        Me.radPenny.TabIndex = 5
        Me.radPenny.TabStop = True
        Me.radPenny.Text = "Penny"
        Me.radPenny.UseVisualStyleBackColor = True
        '
        'radNickle
        '
        Me.radNickle.AutoSize = True
        Me.radNickle.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNickle.Location = New System.Drawing.Point(242, 201)
        Me.radNickle.Name = "radNickle"
        Me.radNickle.Size = New System.Drawing.Size(76, 24)
        Me.radNickle.TabIndex = 6
        Me.radNickle.TabStop = True
        Me.radNickle.Text = "Nickle"
        Me.radNickle.UseVisualStyleBackColor = True
        '
        'lblTotalPay
        '
        Me.lblTotalPay.AutoSize = True
        Me.lblTotalPay.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.Location = New System.Drawing.Point(100, 264)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(146, 28)
        Me.lblTotalPay.TabIndex = 7
        Me.lblTotalPay.Text = "Total Pay: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 450)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.radNickle)
        Me.Controls.Add(Me.radPenny)
        Me.Controls.Add(Me.txtNumDays)
        Me.Controls.Add(Me.lblNumDays)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBackground)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNumDays As Label
    Friend WithEvents txtNumDays As TextBox
    Friend WithEvents radPenny As RadioButton
    Friend WithEvents radNickle As RadioButton
    Friend WithEvents lblTotalPay As Label
End Class
