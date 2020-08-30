Imports System.IO
Imports System.Net
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UN.Text = SystemInformation.UserName ' Pobiera nazwę użytkwnika i wkleja do textbox
        Len1.Text = Len("C:\Users\" & UN.Text & "\Documents\PS Vita\APP\") 'oblicza ilość znaków ścieżki
        Log1.AppendText(Me.Text)
        Log1.AppendText(Environment.NewLine + "")
    End Sub
    Private Sub Check_Dir_Click(sender As Object, e As EventArgs) Handles Check_Dir.Click
        Log1.Clear()
        Log1.AppendText(Me.Text)
        Log1.AppendText(Environment.NewLine + "")
        Log1.AppendText(Environment.NewLine + "Checking system...")
        If Directory.Exists("C:\Users\" & UN.Text & "\Documents\PS Vita") Then
            Log1.AppendText(Environment.NewLine + "Preparing...")
            Log1.AppendText(Environment.NewLine + "Deleting old files...")
            Directory.Delete("C:\Users\" & UN.Text & "\Documents\PS Vita", True)
            Log1.SelectionColor = Color.ForestGreen
            Log1.AppendText("OK")
            Log1.SelectionColor = Color.Empty
            Log1.AppendText(Environment.NewLine + "Done.")
            Log1.SelectionColor = Color.DarkRed
            Log1.AppendText(Environment.NewLine + "Please connect PS VITA and Run QCMA")
            Log1.SelectionColor = Color.Empty
        Else
            Log1.SelectionColor = Color.DarkRed
            Log1.AppendText(Environment.NewLine + "Please connect PS VITA and Run QCMA")
            Log1.SelectionColor = Color.Empty
        End If
        S1.Enabled = True
    End Sub

    Private Sub S1_Click(sender As Object, e As EventArgs) Handles S1.Click
        Log1.Clear()
        Log1.AppendText(Me.Text)
        Log1.AppendText(Environment.NewLine + "")
        Log1.AppendText(Environment.NewLine + "Geting info..")
        If Directory.Exists("C:\Users\" & UN.Text & "\Documents\PS Vita\APP") Then
            For Each Dir As String In Directory.GetDirectories("C:\Users\" & UN.Text & "\Documents\PS Vita\APP") 'pobiera nazwy folderów
                dirName.Text = Mid(Dir, Len1.Text + 1, 20) 'wycina część tekstu ze stringa i wkleja w textbox
            Next
            Log1.SelectionColor = Color.ForestGreen
            Log1.AppendText("OK")
            Log1.SelectionColor = Color.Empty

            Log1.AppendText(Environment.NewLine + "Calculate key...")
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString("http://cma.henkaku.xyz/?aid=" + dirName.Text) 'przechodzi na strone i pobiera treść do stringa
            Str1.AppendText(Environment.NewLine + result) 'wkleja zawartość strony do pola tekstowego
            Key.Text = Mid(Str1.Text, 262, 65) 'pobiera klucz z pola tekstowego
            Log1.SelectionColor = Color.ForestGreen
            Log1.AppendText("OK")
            Log1.SelectionColor = Color.Empty
            Log1.AppendText(Environment.NewLine + "Key: ")
            Log1.SelectionColor = Color.DarkRed
            Log1.AppendText(Key.Text)
            Log1.SelectionColor = Color.Empty

            Log1.AppendText(Environment.NewLine + "")
            Log1.AppendText(Environment.NewLine + "Preparing files, please wait..")
            If Key.Text.Length = 0 Then
                Log1.AppendText(Environment.NewLine + "Error 0x33940") 'Brak wygenerowanego klucza
            Else
                Threading.Thread.Sleep(1000)
                If File.Exists("psvimg-create.exe") = True Then
                    Process.Start("cmd", "/c psvimg-create -n app -K " + Key.Text + " app PCSG90096/app").WaitForExit()
                    Log1.AppendText(Environment.NewLine + "App.. ok")
                    Process.Start("cmd", "/c psvimg-create -n appmeta -K " + Key.Text + " appmeta PCSG90096/appmeta").WaitForExit()
                    Log1.AppendText(Environment.NewLine + "AppMeta.. ok")
                    Process.Start("cmd", "/c psvimg-create -n license -K " + Key.Text + " license PCSG90096/license").WaitForExit()
                    Log1.AppendText(Environment.NewLine + "License.. ok")
                    Process.Start("cmd", "/c psvimg-create -n savedata -K " + Key.Text + " savedata PCSG90096/savedata").WaitForExit()
                    Log1.AppendText(Environment.NewLine + "SaveData.. ok")
                    Log1.AppendText(Environment.NewLine + "Done.")
                Else
                    Log1.AppendText(Environment.NewLine + "Error 0x45950") 'Brak pliku exe w folderze z aplikacją
                End If
            End If
            S2.Enabled = True
        End If
        Log1.SelectionColor = Color.Red
        Log1.AppendText(" False !!")
        Log1.SelectionColor = Color.Empty
        MsgBox("Please connect PS VITA and Run QCMA first !!")
    End Sub

    Private Sub S2_Click(sender As Object, e As EventArgs) Handles S2.Click

        If File.Exists("PCSG90096\app\app.psvimg") = True Then
            Log1.AppendText(Environment.NewLine + "")
            Log1.AppendText(Environment.NewLine + "Moving files..")
            My.Computer.FileSystem.CopyDirectory("PCSG90096", "C:\Users\" & UN.Text & "\Documents\PS Vita\APP\" + dirName.Text + "\PCSG90096", True)
            Log1.AppendText(Environment.NewLine + "Done.")
            S3.Enabled = True
        Else
            Log1.AppendText(Environment.NewLine + "Error 0x64452 !!") 'Brak spatchowanych plików
        End If
    End Sub
    '#############################################################################################################################################
    Private Sub Log1_DoubleClick(sender As Object, e As EventArgs) Handles Log1.DoubleClick
        TB1.Visible = True
        S1.Enabled = True
        S2.Enabled = True
        S3.Enabled = True
    End Sub

    Private Sub TB1_TextChanged(sender As Object, e As EventArgs) Handles TB1.TextChanged
        If TB1.Text = "$admin" Then
            dirName.Visible = True
            UN.Visible = True
            Len1.Visible = True
            Key.Visible = True
            Str1.Visible = True
            Log1.AppendText(Environment.NewLine + "God Mode Enabled")
            TB1.Clear()
        End If
        If TB1.Text = "$info" Then
            TB1.Clear()
            MsgBox("Error 0x64452 - Brak spatchowanych plików" + vbCrLf + "Error 0x45950 - Brak pliku exe w folderze z aplikacją" + vbCrLf + "Error 0x33940 - Brak wygenerowanego klucza")
        End If
        If TB1.Text = "$user" Then
            dirName.Visible = False
            UN.Visible = False
            Len1.Visible = False
            Key.Visible = False
            Str1.Visible = False
            Log1.Clear()
            Log1.AppendText(Me.Text)
            TB1.Clear()
        End If
    End Sub

    Private Sub S3_Click(sender As Object, e As EventArgs) Handles S3.Click
        Form2.Show()
    End Sub
End Class