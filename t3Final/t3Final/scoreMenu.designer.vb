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
        Me.List_Score = New System.Windows.Forms.ListBox()
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
        'List_Score
        '
        Me.List_Score.FormattingEnabled = True
        Me.List_Score.ItemHeight = 16
        Me.List_Score.Location = New System.Drawing.Point(0, 0)
        Me.List_Score.Margin = New System.Windows.Forms.Padding(4)
        Me.List_Score.Name = "List_Score"
        Me.List_Score.Size = New System.Drawing.Size(309, 164)
        Me.List_Score.TabIndex = 3
        '
        'scoreMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Back
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.List_Score)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.Btn_View)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "scoreMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Score"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_View As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents List_Score As System.Windows.Forms.ListBox
End Class
