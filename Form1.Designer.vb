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
        Me.S3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Log1
        '
        Me.Log1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log1.Location = New System.Drawing.Point(16, 15)
        Me.Log1.Margin = New System.Windows.Forms.Padding(4)
        Me.Log1.Name = "Log1"
        Me.Log1.ReadOnly = True
        Me.Log1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Log1.Size = New System.Drawing.Size(419, 399)
        Me.Log1.TabIndex = 0
        Me.Log1.Text = ""
        '
        'Check_Dir
        '
        Me.Check_Dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Check_Dir.Location = New System.Drawing.Point(444, 15)
        Me.Check_Dir.Margin = New System.Windows.Forms.Padding(4)
        Me.Check_Dir.Name = "Check_Dir"
        Me.Check_Dir.Size = New System.Drawing.Size(177, 28)
        Me.Check_Dir.TabIndex = 1
        Me.Check_Dir.Text = "Check"
        Me.Check_Dir.UseVisualStyleBackColor = True
        '
        'S1
        '
        Me.S1.Enabled = False
        Me.S1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.S1.Location = New System.Drawing.Point(444, 51)
        Me.S1.Margin = New System.Windows.Forms.Padding(4)
        Me.S1.Name = "S1"
        Me.S1.Size = New System.Drawing.Size(177, 43)
        Me.S1.TabIndex = 2
        Me.S1.Text = "Step 1"
        Me.S1.UseVisualStyleBackColor = True
        '
        'S2
        '
        Me.S2.Enabled = False
        Me.S2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.S2.Location = New System.Drawing.Point(443, 102)
        Me.S2.Margin = New System.Windows.Forms.Padding(4)
        Me.S2.Name = "S2"
        Me.S2.Size = New System.Drawing.Size(178, 41)
        Me.S2.TabIndex = 3
        Me.S2.Text = "Step 2"
        Me.S2.UseVisualStyleBackColor = True
        '
        'dirName
        '
        Me.dirName.Location = New System.Drawing.Point(16, 422)
        Me.dirName.Margin = New System.Windows.Forms.Padding(4)
        Me.dirName.Name = "dirName"
        Me.dirName.Size = New System.Drawing.Size(147, 22)
        Me.dirName.TabIndex = 4
        Me.dirName.Visible = False
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(16, 454)
        Me.Key.Margin = New System.Windows.Forms.Padding(4)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(604, 22)
        Me.Key.TabIndex = 5
        Me.Key.Visible = False
        '
        'UN
        '
        Me.UN.Location = New System.Drawing.Point(172, 422)
        Me.UN.Margin = New System.Windows.Forms.Padding(4)
        Me.UN.Name = "UN"
        Me.UN.Size = New System.Drawing.Size(132, 22)
        Me.UN.TabIndex = 6
        Me.UN.Visible = False
        '
        'Len1
        '
        Me.Len1.Location = New System.Drawing.Point(313, 422)
        Me.Len1.Margin = New System.Windows.Forms.Padding(4)
        Me.Len1.Name = "Len1"
        Me.Len1.Size = New System.Drawing.Size(47, 22)
        Me.Len1.TabIndex = 7
        Me.Len1.Visible = False
        '
        'Str1
        '
        Me.Str1.Location = New System.Drawing.Point(445, 229)
        Me.Str1.Margin = New System.Windows.Forms.Padding(4)
        Me.Str1.Name = "Str1"
        Me.Str1.Size = New System.Drawing.Size(175, 217)
        Me.Str1.TabIndex = 8
        Me.Str1.Text = ""
        Me.Str1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Alef", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 423)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 57)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "VITA"
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(444, 199)
        Me.TB1.Margin = New System.Windows.Forms.Padding(4)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(175, 22)
        Me.TB1.TabIndex = 10
        Me.TB1.Visible = False
        '
        'S3
        '
        Me.S3.Enabled = False
        Me.S3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.S3.Location = New System.Drawing.Point(445, 150)
        Me.S3.Name = "S3"
        Me.S3.Size = New System.Drawing.Size(176, 42)
        Me.S3.TabIndex = 11
        Me.S3.Text = "Step 3"
        Me.S3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(637, 486)
        Me.Controls.Add(Me.S3)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vita_H 3.73 v1.04"
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
    Friend WithEvents S3 As Button
End Class
