<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginMenuForm
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
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.guestRadioButton = New System.Windows.Forms.RadioButton()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.enterUsernameLabel = New System.Windows.Forms.Label()
        Me.errorLabel2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(39, 63)
        Me.usernameTextBox.MaxLength = 25
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(143, 22)
        Me.usernameTextBox.TabIndex = 0
        '
        'guestRadioButton
        '
        Me.guestRadioButton.AutoSize = True
        Me.guestRadioButton.Location = New System.Drawing.Point(39, 100)
        Me.guestRadioButton.Name = "guestRadioButton"
        Me.guestRadioButton.Size = New System.Drawing.Size(71, 21)
        Me.guestRadioButton.TabIndex = 1
        Me.guestRadioButton.TabStop = True
        Me.guestRadioButton.Text = "Guest "
        Me.guestRadioButton.UseVisualStyleBackColor = True
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(230, 133)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(75, 32)
        Me.enterButton.TabIndex = 4
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backButton.Location = New System.Drawing.Point(230, 30)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 30)
        Me.backButton.TabIndex = 5
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'enterUsernameLabel
        '
        Me.enterUsernameLabel.AutoSize = True
        Me.enterUsernameLabel.Location = New System.Drawing.Point(42, 44)
        Me.enterUsernameLabel.Name = "enterUsernameLabel"
        Me.enterUsernameLabel.Size = New System.Drawing.Size(109, 17)
        Me.enterUsernameLabel.TabIndex = 7
        Me.enterUsernameLabel.Text = "Enter username"
        '
        'errorLabel2
        '
        Me.errorLabel2.AutoSize = True
        Me.errorLabel2.Location = New System.Drawing.Point(36, 141)
        Me.errorLabel2.Name = "errorLabel2"
        Me.errorLabel2.Size = New System.Drawing.Size(76, 17)
        Me.errorLabel2.TabIndex = 8
        Me.errorLabel2.Text = "                 "
        '
        'loginMenuForm
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.backButton
        Me.ClientSize = New System.Drawing.Size(374, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.errorLabel2)
        Me.Controls.Add(Me.enterUsernameLabel)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.guestRadioButton)
        Me.Controls.Add(Me.usernameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "loginMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents guestRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents enterUsernameLabel As System.Windows.Forms.Label
    Friend WithEvents errorLabel2 As System.Windows.Forms.Label
End Class
