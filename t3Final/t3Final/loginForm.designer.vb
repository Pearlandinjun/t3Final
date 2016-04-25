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
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.enterUsernameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Location = New System.Drawing.Point(58, 98)
        Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.usernameTextBox.MaxLength = 25
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(212, 31)
        Me.usernameTextBox.TabIndex = 0
        '
        'guestRadioButton
        '
        Me.guestRadioButton.AutoSize = True
        Me.guestRadioButton.Location = New System.Drawing.Point(58, 181)
        Me.guestRadioButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.guestRadioButton.Name = "guestRadioButton"
        Me.guestRadioButton.Size = New System.Drawing.Size(106, 29)
        Me.guestRadioButton.TabIndex = 1
        Me.guestRadioButton.TabStop = True
        Me.guestRadioButton.Text = "Guest "
        Me.guestRadioButton.UseVisualStyleBackColor = True
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(345, 208)
        Me.enterButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(112, 50)
        Me.enterButton.TabIndex = 4
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backButton.Location = New System.Drawing.Point(345, 47)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(112, 47)
        Me.backButton.TabIndex = 5
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'errorLabel
        '
        Me.errorLabel.AutoSize = True
        Me.errorLabel.Location = New System.Drawing.Point(58, 147)
        Me.errorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(181, 25)
        Me.errorLabel.TabIndex = 6
        Me.errorLabel.Text = "Invalid username "
        Me.errorLabel.Visible = False
        '
        'enterUsernameLabel
        '
        Me.enterUsernameLabel.AutoSize = True
        Me.enterUsernameLabel.Location = New System.Drawing.Point(63, 69)
        Me.enterUsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.enterUsernameLabel.Name = "enterUsernameLabel"
        Me.enterUsernameLabel.Size = New System.Drawing.Size(164, 25)
        Me.enterUsernameLabel.TabIndex = 7
        Me.enterUsernameLabel.Text = "Enter username"
        '
        'loginMenuForm
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.backButton
        Me.ClientSize = New System.Drawing.Size(561, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.enterUsernameLabel)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.guestRadioButton)
        Me.Controls.Add(Me.usernameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents errorLabel As System.Windows.Forms.Label
    Friend WithEvents enterUsernameLabel As System.Windows.Forms.Label
End Class
