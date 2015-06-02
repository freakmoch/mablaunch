Public Class begin

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.FileExists("C:\Nexon\Mabinogi\Mabinogi.exe") Then
            Process.Start("C:\Nexon\Mabinogi\Mabinogi.exe")
        Else
            MsgBox("Mabinogi.exe not found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim response = MsgBox("Run Mabinogi Directly?", MsgBoxStyle.YesNo, "Confirm")

        If response = MsgBoxResult.Yes Then
            If My.Computer.FileSystem.FileExists("_mabinogi.exe") Then
                If My.Computer.FileSystem.FileExists("hslaunch.exe") Then
                    Process.Start("HSLaunch.exe")
                    Process.Start("_mabinogi.exe")
                    If My.Computer.FileSystem.FileExists("mlog.exe") Then
                        Form3.Show()
                        Me.Close()
                    Else
                        Application.Exit()
                    End If
                Else
                    MsgBox("HSLaunch not found.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("_mabinogi.exe not found.", MsgBoxStyle.Critical, "Error")
            End If

        Else
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AboutBox1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim response = MsgBox("Code Problems? HMU!" & vbNewLine & "Would you like to visit my askbox?", MsgBoxStyle.YesNo, "Confirm")

        If response = MsgBoxResult.Yes Then
            Dim oForm As Form2
            oForm = New Form2()
            oForm.Show()
            oForm = Nothing
        Else

        End If

    End Sub
End Class