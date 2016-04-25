<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenuForm
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
        Me.tictactoeLabel = New System.Windows.Forms.Label()
        Me.vsPlayerBtn = New System.Windows.Forms.Button()
        Me.vsVaderBtn = New System.Windows.Forms.Button()
        Me.registerBtn = New System.Windows.Forms.Button()
        Me.historyBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tictactoeLabel
        '
        Me.tictactoeLabel.AutoSize = True
        Me.tictactoeLabel.Location = New System.Drawing.Point(116, 36)
        Me.tictactoeLabel.Name = "tictactoeLabel"
        Me.tictactoeLabel.Size = New System.Drawing.Size(99, 34)
        Me.tictactoeLabel.TabIndex = 0
        Me.tictactoeLabel.Text = "  Tic Tac Toe " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Dark Side" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'vsPlayerBtn
        '
        Me.vsPlayerBtn.Location = New System.Drawing.Point(119, 101)
        Me.vsPlayerBtn.Name = "vsPlayerBtn"
        Me.vsPlayerBtn.Size = New System.Drawing.Size(96, 33)
        Me.vsPlayerBtn.TabIndex = 1
        Me.vsPlayerBtn.Text = "vs Player"
        Me.vsPlayerBtn.UseVisualStyleBackColor = True
        '
        'vsVaderBtn
        '
        Me.vsVaderBtn.Location = New System.Drawing.Point(119, 140)
        Me.vsVaderBtn.Name = "vsVaderBtn"
        Me.vsVaderBtn.Size = New System.Drawing.Size(96, 33)
        Me.vsVaderBtn.TabIndex = 2
        Me.vsVaderBtn.Text = "vs Vader"
        Me.vsVaderBtn.UseVisualStyleBackColor = True
        '
        'registerBtn
        '
        Me.registerBtn.Location = New System.Drawing.Point(119, 179)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(96, 33)
        Me.registerBtn.TabIndex = 3
        Me.registerBtn.Text = "Register"
        Me.registerBtn.UseVisualStyleBackColor = True
        '
        'historyBtn
        '
        Me.historyBtn.Location = New System.Drawing.Point(119, 218)
        Me.historyBtn.Name = "historyBtn"
        Me.historyBtn.Size = New System.Drawing.Size(96, 33)
        Me.historyBtn.TabIndex = 4
        Me.historyBtn.Text = "History"
        Me.historyBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitBtn.Location = New System.Drawing.Point(266, 260)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(62, 33)
        Me.exitBtn.TabIndex = 5
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'mainMenuForm
        '
        Me.AcceptButton = Me.vsPlayerBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.exitBtn
        Me.ClientSize = New System.Drawing.Size(367, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.historyBtn)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.vsVaderBtn)
        Me.Controls.Add(Me.vsPlayerBtn)
        Me.Controls.Add(Me.tictactoeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "mainMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tictactoeLabel As System.Windows.Forms.Label
    Friend WithEvents vsPlayerBtn As System.Windows.Forms.Button
    Friend WithEvents vsVaderBtn As System.Windows.Forms.Button
    Friend WithEvents registerBtn As System.Windows.Forms.Button
    Friend WithEvents historyBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button

End Class
