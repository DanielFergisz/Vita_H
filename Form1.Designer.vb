<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Log1 = New System.Windows.Forms.RichTextBox()
        Me.Check_Dir = New System.Windows.Forms.Button()
        Me.S1 = New System.Windows.Forms.Button()
        Me.S2 = New System.Windows.Forms.Button()
        Me.dirName = New System.Windows.Forms.TextBox()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.UN = New System.Windows.Forms.TextBox()
        Me.Len1 = New System.Windows.Forms.TextBox()
        Me.Str1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Log1
        '
        Me.Log1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log1.Location = New System.Drawing.Point(12, 12)
        Me.Log1.Name = "Log1"
        Me.Log1.ReadOnly = True
        Me.Log1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Log1.Size = New System.Drawing.Size(315, 325)
        Me.Log1.TabIndex = 0
        Me.Log1.Text = ""
        '
        'Check_Dir
        '
        Me.Check_Dir.Enabled = False
        Me.Check_Dir.Location = New System.Drawing.Point(333, 12)
        Me.Check_Dir.Name = "Check_Dir"
        Me.Check_Dir.Size = New System.Drawing.Size(133, 23)
        Me.Check_Dir.TabIndex = 1
        Me.Check_Dir.Text = "Check"
        Me.Check_Dir.UseVisualStyleBackColor = True
        '
        'S1
        '
        Me.S1.Location = New System.Drawing.Point(333, 54)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(133, 35)
        Me.S1.TabIndex = 2
        Me.S1.Text = "Step 1"
        Me.S1.UseVisualStyleBackColor = True
        '
        'S2
        '
        Me.S2.Location = New System.Drawing.Point(333, 95)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(133, 33)
        Me.S2.TabIndex = 3
        Me.S2.Text = "Step 2"
        Me.S2.UseVisualStyleBackColor = True
        '
        'dirName
        '
        Me.dirName.Location = New System.Drawing.Point(12, 343)
        Me.dirName.Name = "dirName"
        Me.dirName.Size = New System.Drawing.Size(111, 20)
        Me.dirName.TabIndex = 4
        Me.dirName.Visible = False
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(12, 369)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(454, 20)
        Me.Key.TabIndex = 5
        Me.Key.Visible = False
        '
        'UN
        '
        Me.UN.Location = New System.Drawing.Point(129, 343)
        Me.UN.Name = "UN"
        Me.UN.Size = New System.Drawing.Size(100, 20)
        Me.UN.TabIndex = 6
        Me.UN.Visible = False
        '
        'Len1
        '
        Me.Len1.Location = New System.Drawing.Point(235, 343)
        Me.Len1.Name = "Len1"
        Me.Len1.Size = New System.Drawing.Size(36, 20)
        Me.Len1.TabIndex = 7
        Me.Len1.Visible = False
        '
        'Str1
        '
        Me.Str1.Location = New System.Drawing.Point(334, 160)
        Me.Str1.Name = "Str1"
        Me.Str1.Size = New System.Drawing.Size(132, 177)
        Me.Str1.TabIndex = 8
        Me.Str1.Text = ""
        Me.Str1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Alef", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "VITA"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(334, 134)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(132, 20)
        Me.TB1.TabIndex = 10
        Me.TB1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(478, 395)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.UN)
        Me.Controls.Add(Me.Str1)
        Me.Controls.Add(Me.Len1)
        Me.Controls.Add(Me.dirName)
        Me.Controls.Add(Me.S2)
        Me.Controls.Add(Me.S1)
        Me.Controls.Add(Me.Check_Dir)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vita_H 3.73 v1.00"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Log1 As RichTextBox
    Friend WithEvents Check_Dir As Button
    Friend WithEvents S1 As Button
    Friend WithEvents S2 As Button
    Friend WithEvents dirName As TextBox
    Friend WithEvents Key As TextBox
    Friend WithEvents UN As TextBox
    Friend WithEvents Len1 As TextBox
    Friend WithEvents Str1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB1 As TextBox
End Class
