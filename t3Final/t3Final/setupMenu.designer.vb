<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setupMenuForm
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
        Me.backButton = New System.Windows.Forms.Button()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.chooseDifficultyGroupBox = New System.Windows.Forms.GroupBox()
        Me.hardRadioButton = New System.Windows.Forms.RadioButton()
        Me.medRadioButton = New System.Windows.Forms.RadioButton()
        Me.easyRadioButton = New System.Windows.Forms.RadioButton()
        Me.chooseColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.redRadioButton = New System.Windows.Forms.RadioButton()
        Me.greenRadioButton = New System.Windows.Forms.RadioButton()
        Me.yellowRadioButton = New System.Windows.Forms.RadioButton()
        Me.blueRadioButton = New System.Windows.Forms.RadioButton()
        Me.chooseFirstplayerGroupBox = New System.Windows.Forms.GroupBox()
        Me.player2RadioButton = New System.Windows.Forms.RadioButton()
        Me.player1RadioButton = New System.Windows.Forms.RadioButton()
        Me.chooseDifficultyGroupBox.SuspendLayout()
        Me.chooseColorGroupBox.SuspendLayout()
        Me.chooseFirstplayerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.backButton.Location = New System.Drawing.Point(250, 48)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(91, 35)
        Me.backButton.TabIndex = 12
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(250, 136)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(91, 35)
        Me.enterButton.TabIndex = 13
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'chooseDifficultyGroupBox
        '
        Me.chooseDifficultyGroupBox.Controls.Add(Me.hardRadioButton)
        Me.chooseDifficultyGroupBox.Controls.Add(Me.medRadioButton)
        Me.chooseDifficultyGroupBox.Controls.Add(Me.easyRadioButton)
        Me.chooseDifficultyGroupBox.Location = New System.Drawing.Point(0, 3)
        Me.chooseDifficultyGroupBox.Name = "chooseDifficultyGroupBox"
        Me.chooseDifficultyGroupBox.Size = New System.Drawing.Size(211, 126)
        Me.chooseDifficultyGroupBox.TabIndex = 14
        Me.chooseDifficultyGroupBox.TabStop = False
        Me.chooseDifficultyGroupBox.Text = "Difficulty"
        Me.chooseDifficultyGroupBox.Visible = False
        '
        'hardRadioButton
        '
        Me.hardRadioButton.AutoSize = True
        Me.hardRadioButton.Location = New System.Drawing.Point(49, 87)
        Me.hardRadioButton.Name = "hardRadioButton"
        Me.hardRadioButton.Size = New System.Drawing.Size(60, 21)
        Me.hardRadioButton.TabIndex = 3
        Me.hardRadioButton.TabStop = True
        Me.hardRadioButton.Text = "Hard"
        Me.hardRadioButton.UseVisualStyleBackColor = True
        '
        'medRadioButton
        '
        Me.medRadioButton.AutoSize = True
        Me.medRadioButton.Location = New System.Drawing.Point(49, 60)
        Me.medRadioButton.Name = "medRadioButton"
        Me.medRadioButton.Size = New System.Drawing.Size(78, 21)
        Me.medRadioButton.TabIndex = 2
        Me.medRadioButton.TabStop = True
        Me.medRadioButton.Text = "Medium"
        Me.medRadioButton.UseVisualStyleBackColor = True
        '
        'easyRadioButton
        '
        Me.easyRadioButton.AutoSize = True
        Me.easyRadioButton.Location = New System.Drawing.Point(49, 33)
        Me.easyRadioButton.Name = "easyRadioButton"
        Me.easyRadioButton.Size = New System.Drawing.Size(60, 21)
        Me.easyRadioButton.TabIndex = 1
        Me.easyRadioButton.TabStop = True
        Me.easyRadioButton.Text = "Easy"
        Me.easyRadioButton.UseVisualStyleBackColor = True
        '
        'chooseColorGroupBox
        '
        Me.chooseColorGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.chooseColorGroupBox.Controls.Add(Me.redRadioButton)
        Me.chooseColorGroupBox.Controls.Add(Me.greenRadioButton)
        Me.chooseColorGroupBox.Controls.Add(Me.yellowRadioButton)
        Me.chooseColorGroupBox.Controls.Add(Me.blueRadioButton)
        Me.chooseColorGroupBox.Location = New System.Drawing.Point(21, 35)
        Me.chooseColorGroupBox.Name = "chooseColorGroupBox"
        Me.chooseColorGroupBox.Size = New System.Drawing.Size(223, 162)
        Me.chooseColorGroupBox.TabIndex = 15
        Me.chooseColorGroupBox.TabStop = False
        Me.chooseColorGroupBox.Text = "Choose your color"
        Me.chooseColorGroupBox.Visible = False
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Location = New System.Drawing.Point(56, 116)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(55, 21)
        Me.redRadioButton.TabIndex = 3
        Me.redRadioButton.TabStop = True
        Me.redRadioButton.Text = "Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'greenRadioButton
        '
        Me.greenRadioButton.AutoSize = True
        Me.greenRadioButton.Location = New System.Drawing.Point(56, 89)
        Me.greenRadioButton.Name = "greenRadioButton"
        Me.greenRadioButton.Size = New System.Drawing.Size(69, 21)
        Me.greenRadioButton.TabIndex = 2
        Me.greenRadioButton.TabStop = True
        Me.greenRadioButton.Text = "Green"
        Me.greenRadioButton.UseVisualStyleBackColor = True
        '
        'yellowRadioButton
        '
        Me.yellowRadioButton.AutoSize = True
        Me.yellowRadioButton.Location = New System.Drawing.Point(56, 62)
        Me.yellowRadioButton.Name = "yellowRadioButton"
        Me.yellowRadioButton.Size = New System.Drawing.Size(69, 21)
        Me.yellowRadioButton.TabIndex = 1
        Me.yellowRadioButton.TabStop = True
        Me.yellowRadioButton.Text = "Yellow"
        Me.yellowRadioButton.UseVisualStyleBackColor = True
        '
        'blueRadioButton
        '
        Me.blueRadioButton.AutoSize = True
        Me.blueRadioButton.Location = New System.Drawing.Point(56, 35)
        Me.blueRadioButton.Name = "blueRadioButton"
        Me.blueRadioButton.Size = New System.Drawing.Size(57, 21)
        Me.blueRadioButton.TabIndex = 0
        Me.blueRadioButton.TabStop = True
        Me.blueRadioButton.Text = "Blue"
        Me.blueRadioButton.UseVisualStyleBackColor = True
        '
        'chooseFirstplayerGroupBox
        '
        Me.chooseFirstplayerGroupBox.Controls.Add(Me.player2RadioButton)
        Me.chooseFirstplayerGroupBox.Controls.Add(Me.player1RadioButton)
        Me.chooseFirstplayerGroupBox.Controls.Add(Me.chooseDifficultyGroupBox)
        Me.chooseFirstplayerGroupBox.Location = New System.Drawing.Point(21, 35)
        Me.chooseFirstplayerGroupBox.Name = "chooseFirstplayerGroupBox"
        Me.chooseFirstplayerGroupBox.Size = New System.Drawing.Size(202, 135)
        Me.chooseFirstplayerGroupBox.TabIndex = 16
        Me.chooseFirstplayerGroupBox.TabStop = False
        Me.chooseFirstplayerGroupBox.Text = "Who will go first?"
        '
        'player2RadioButton
        '
        Me.player2RadioButton.AutoSize = True
        Me.player2RadioButton.Location = New System.Drawing.Point(49, 60)
        Me.player2RadioButton.Name = "player2RadioButton"
        Me.player2RadioButton.Size = New System.Drawing.Size(80, 21)
        Me.player2RadioButton.TabIndex = 5
        Me.player2RadioButton.TabStop = True
        Me.player2RadioButton.Text = "player 2"
        Me.player2RadioButton.UseVisualStyleBackColor = True
        '
        'player1RadioButton
        '
        Me.player1RadioButton.AutoSize = True
        Me.player1RadioButton.Location = New System.Drawing.Point(49, 33)
        Me.player1RadioButton.Name = "player1RadioButton"
        Me.player1RadioButton.Size = New System.Drawing.Size(80, 21)
        Me.player1RadioButton.TabIndex = 4
        Me.player1RadioButton.TabStop = True
        Me.player1RadioButton.Text = "player 1"
        Me.player1RadioButton.UseVisualStyleBackColor = True
        '
        'setupMenuForm
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.backButton
        Me.ClientSize = New System.Drawing.Size(440, 257)
        Me.ControlBox = False
        Me.Controls.Add(Me.chooseFirstplayerGroupBox)
        Me.Controls.Add(Me.chooseColorGroupBox)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.backButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "setupMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings "
        Me.chooseDifficultyGroupBox.ResumeLayout(False)
        Me.chooseDifficultyGroupBox.PerformLayout()
        Me.chooseColorGroupBox.ResumeLayout(False)
        Me.chooseColorGroupBox.PerformLayout()
        Me.chooseFirstplayerGroupBox.ResumeLayout(False)
        Me.chooseFirstplayerGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents chooseDifficultyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents hardRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents medRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents easyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents chooseColorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents redRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents greenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents yellowRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blueRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents chooseFirstplayerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents player2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents player1RadioButton As System.Windows.Forms.RadioButton
End Class
