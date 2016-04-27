<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scoreMenuForm
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
        Me.Btn_View = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.historyTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_View
        '
        Me.Btn_View.Location = New System.Drawing.Point(16, 244)
        Me.Btn_View.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_View.Name = "Btn_View"
        Me.Btn_View.Size = New System.Drawing.Size(100, 28)
        Me.Btn_View.TabIndex = 0
        Me.Btn_View.Text = "View"
        Me.Btn_View.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(152, 244)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(100, 28)
        Me.btn_Clear.TabIndex = 1
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Back.Location = New System.Drawing.Point(276, 244)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(100, 28)
        Me.btn_Back.TabIndex = 2
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'historyTextBox
        '
        Me.historyTextBox.Enabled = False
        Me.historyTextBox.Location = New System.Drawing.Point(16, 98)
        Me.historyTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.historyTextBox.Name = "historyTextBox"
        Me.historyTextBox.Size = New System.Drawing.Size(328, 22)
        Me.historyTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "W"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "T"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "L"
        '
        'scoreMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Back
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.historyTextBox)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.Btn_View)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "scoreMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_View As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents historyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
