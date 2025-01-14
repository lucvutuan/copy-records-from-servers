Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Text
Imports Microsoft.VisualBasic.FileIO

Public Class Form1

    Dim tfp As New TextFieldParser(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Lich lay ghi am.csv")
    'Private WithEvents blinkTimer As New Timer()
    Private tuanlayghiam As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Copy Ghi Âm Version 2.0" & " - " & "Ngày " & Date.Now.Day & " Tháng " & Date.Now.Month

        'read the text file contains channels
        Dim channelFile As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Channels.txt"

        'populate channels to the checkboxlist
        Dim lines As String() = IO.File.ReadAllLines(channelFile)
        clbChannel.Items.AddRange(lines)

        cboSourcePath.SelectedIndex = 0
        dtpDate1.Value = Date.Now.AddDays(-1)
        chkDate1.Checked = True
        chkDate2.Checked = True

        'set channels 1, 2, 6 and 7 to default selected
        'For i As Integer = 0 To clbChannel.Items.Count - 1
        '    If clbChannel.Items(i) = "118.5 MAIN" Or clbChannel.Items(i) = "118.5 STANDBY" Or
        '                    clbChannel.Items(i) = "HOTLINE VTN" Or clbChannel.Items(i) = "HOTLINE VSAT" Then
        '        clbChannel.SetItemChecked(i, True)
        '    End If
        'Next

        Dim defaultIndices As Integer() = {0, 1, 5, 6}
        For Each index As Integer In defaultIndices
            If index < clbChannel.Items.Count Then
                clbChannel.SetItemChecked(index, True)
            End If
        Next


        tfp.Delimiters = New String() {","}
        tfp.TextFieldType = FieldType.Delimited

        Dim today As String = Date.Now.ToString("dd/MM/yyyy")

        'start reading csv file
        tfp.ReadLine()
        Dim currentRow As String()
        While Not tfp.EndOfData
            currentRow = tfp.ReadFields()
            Dim thanglayghiam As String = currentRow(0)
            tuanlayghiam = currentRow(1)
            Dim ngaylayghiam As String = currentRow(2)
            Dim giolayghiam As String = currentRow(3)
            Dim ngayguighiam As String = currentRow(4)
            If today = ngayguighiam Then
                chkPeriodic.Checked = True
                chkPeriodic.Visible = True
                txtDestPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" & tuanlayghiam & " " & thanglayghiam
                btnPeriodic.Visible = True
                dtpDate1.Value = ngaylayghiam.Substring(0, 5) & "/" & ngayguighiam.Substring(ngayguighiam.Length - 4)
                dtpDate2.Value = ngaylayghiam.Substring(ngaylayghiam.Length - 5) & "/" & ngayguighiam.Substring(ngayguighiam.Length - 4)
                cboFrom.Text = giolayghiam.Substring(0, 5).Replace("h", ":") & ":00"
                cboTo.Text = giolayghiam.Substring(giolayghiam.Length - 5).Replace("h", ":") & ":00"
                chkDate1.BackColor = Color.Violet
                chkDate2.BackColor = Color.Violet
                cboFrom.BackColor = Color.YellowGreen
                cboTo.BackColor = Color.YellowGreen

                ' Start the blink timer
                blinkTimer.Interval = 500 ' Set the interval to 500 milliseconds
                blinkTimer.Start()
                Exit Sub
            End If
        End While

        If Environment.GetCommandLineArgs.Length = 1 Then
            tmrExit.Start()
        Else
            tmrExit.Stop()
        End If
    End Sub

    Private Sub blinkTimer_Tick(sender As Object, e As EventArgs) Handles blinkTimer.Tick
        ToggleCheckboxBackColor(chkDate1)
        ToggleCheckboxBackColor(chkDate2)
        ToggleCheckboxBackColor(chkPeriodic)
    End Sub

    Private Sub ToggleCheckboxBackColor(chkBox As CheckBox)
        If chkBox.BackColor = Color.Violet Then
            chkBox.BackColor = Color.OrangeRed
        Else
            chkBox.BackColor = Color.Violet
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim DateToSend As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        blinkTimer.Stop()

        'compare start hour to end hour
        If Convert.ToInt32(cboFrom.Text.Substring(0, 2)) > Convert.ToInt32(cboTo.Text.Substring(0, 2)) Then
            MsgBox("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", MsgBoxStyle.Information, "Thông báo!")
            Exit Sub
        End If

        Dim strChannel As String = GetSelectedChannels()

        'loop through all the date and create folder for each date
        Dim sourceMain As String = cboSourcePath.Items(0)
        Dim sourceStb As String = cboSourcePath.Items(1)
        Dim startHour As Integer = Convert.ToInt32(cboFrom.Text.Substring(0, 2))
        Dim endHour As Integer = Convert.ToInt32(cboTo.Text.Substring(0, 2))
        Dim destPath As String = txtDestPath.Text

        If Not chkDate2.Checked Or Not chkDate1.Checked Then
            dtpDate2.Value = dtpDate1.Value
        End If

        Try
            tfp.Delimiters = New String() {","}
            tfp.TextFieldType = FieldType.Delimited
            tfp.ReadLine()
            Dim currentRow As String()
            While Not tfp.EndOfData
                currentRow = tfp.ReadFields()
                tuanlayghiam = currentRow(1)
                If tuanlayghiam = "Tuan 4" Then
                    ' Copy exactly only 2 days: dtpDate1 and dtpDate2
                    CopyForSpecificDate(dtpDate1.Value, sourceMain, sourceStb, startHour, endHour, destPath, strChannel, DateToSend)
                    CopyForSpecificDate(dtpDate2.Value, sourceMain, sourceStb, startHour, endHour, destPath, strChannel, DateToSend)
                Else
                    ' Copy from dtpDate1 to dtpDate2
                    For offset As Integer = 0 To (dtpDate2.Value - dtpDate1.Value).Days
                        Dim currentDate As DateTime = dtpDate1.Value.AddDays(offset)
                        CopyForSpecificDate(currentDate, sourceMain, sourceStb, startHour, endHour, destPath, strChannel, DateToSend)
                    Next
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        MessageBox.Show("Đã copy xong!", "Information", MessageBoxButtons.OK)
    End Sub

    Private Sub CopyForSpecificDate(currentDate As DateTime, sourceMain As String, sourceStb As String, startHour As Integer, endHour As Integer, destPath As String, strChannel As String, DateToSend As String)
        Dim folderPath As String = CreateFolderPath(destPath, currentDate)

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
            For j As Integer = 0 To clbChannel.Items.Count - 1 'loop through all channel selected
                If clbChannel.GetItemChecked(j) Then
                    Dim channelFolderPath As String = Path.Combine(folderPath, clbChannel.Items(j).ToString())
                    Directory.CreateDirectory(channelFolderPath)
                    Dim channelIndex As Integer = clbChannel.Items.IndexOf(clbChannel.Items(j)) + 1

                    For k As Integer = startHour To endHour 'loop through all subfolder has the name starts with startHour to endHour
                        CopyFiles(sourceMain, sourceStb, currentDate, k, channelIndex, channelFolderPath)
                    Next
                End If
            Next
        End If

        'write to the log file
        WriteToLogFile(DateToSend, currentDate)
    End Sub

    Private Function GetSelectedChannels() As String
        Dim strChannel As New StringBuilder()
        For i As Integer = 0 To clbChannel.Items.Count - 1
            If clbChannel.GetItemChecked(i) Then
                strChannel.Append(clbChannel.Items(i) & ", ")
            End If
        Next
        If strChannel.Length > 0 Then
            strChannel.Length -= 2 ' Remove the trailing comma and space
        End If
        Return strChannel.ToString()
    End Function

    Private Function CreateFolderPath(destPath As String, currentDate As DateTime) As String
        Dim day_part As String = currentDate.ToString("dd")
        Dim month_part As String = currentDate.ToString("MM")
        Return Path.Combine(destPath, $"{day_part}{month_part}_{cboFrom.Text.Substring(0, 5).Replace(":", "")}_{cboTo.Text.Substring(0, 5).Replace(":", "")}")
    End Function

    Private Sub CopyFiles(sourceMain As String, sourceStb As String, currentDate As DateTime, hour As Integer,
                          channelIndex As Integer, channelFolderPath As String)
        Dim countFromMain As String = Path.Combine(sourceMain, currentDate.Day.ToString(), hour.ToString())
        Dim countFromStb As String = Path.Combine(sourceStb, currentDate.Day.ToString(), hour.ToString())
        Dim dirInforMain As New DirectoryInfo(countFromMain)
        Dim dirInforStb As New DirectoryInfo(countFromStb)

        Dim files_main As IO.FileInfo() = dirInforMain.GetFiles("*.*", IO.SearchOption.AllDirectories)
        Dim files_stb As IO.FileInfo() = dirInforStb.GetFiles("*.*", IO.SearchOption.AllDirectories)

        Dim countForMain As Integer = files_main.Count(Function(f) f.Name.StartsWith(channelIndex & "_") _
                                        AndAlso f.CreationTimeUtc.Date = currentDate.Date _
                                        AndAlso f.CreationTimeUtc.TimeOfDay >= TimeSpan.Parse(cboFrom.Text) _
                                        AndAlso f.CreationTimeUtc.TimeOfDay <= TimeSpan.Parse(cboTo.Text))

        Dim countForStb As Integer = files_stb.Count(Function(f) f.Name.StartsWith(channelIndex & "_") _
                                       AndAlso f.CreationTimeUtc.Date = currentDate.Date _
                                       AndAlso f.CreationTimeUtc.TimeOfDay >= TimeSpan.Parse(cboFrom.Text) _
                                       AndAlso f.CreationTimeUtc.TimeOfDay <= TimeSpan.Parse(cboTo.Text))


        Dim filesToCopy As IO.FileInfo() = If(countForMain >= countForStb, files_main, files_stb)

        For Each file In filesToCopy
            If file.Name.StartsWith(channelIndex & "_") AndAlso file.CreationTimeUtc.Date = currentDate.Date _
                    AndAlso file.CreationTimeUtc.TimeOfDay >= TimeSpan.Parse(cboFrom.Text) _
                    AndAlso file.CreationTimeUtc.TimeOfDay <= TimeSpan.Parse(cboTo.Text) Then
                file.CopyTo(Path.Combine(channelFolderPath, file.Name), True)
            End If
        Next
    End Sub

    Private Sub WriteToLogFile(DateToSend As String, currentDate As DateTime)
        Dim strWriteToLogFile As String
        Dim _hhFrom As String = cboFrom.Text.Substring(0, 2)
        Dim _mmFrom As String = cboFrom.Text.Substring(3, 2)
        Dim _hhTo As String = cboTo.Text.Substring(0, 2)
        Dim _mmTo As String = cboTo.Text.Substring(3, 2)
        Dim strFile As String = "D:\LogFileGhiAmTheoYeuCau.txt"
        ' Create a file to write to.
        Using sw As New System.IO.StreamWriter(strFile, True)
            strWriteToLogFile = $"{DateToSend}: Lay ghi am ngay {currentDate.Day} thang {currentDate.Month}, tu {_hhFrom}h{_mmFrom} den {_hhTo}h{_mmTo}."
            sw.WriteLine(strWriteToLogFile)
        End Using
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim sourceMain As String = cboSourcePath.Items(0)
        Dim sourceStb As String = cboSourcePath.Items(1)
        Dim startHour As Integer = Convert.ToInt32(cboFrom.Text.Substring(0, 2))
        Dim endHour As Integer = Convert.ToInt32(cboTo.Text.Substring(0, 2))

        If Not chkDate2.Checked Then
            dtpDate2.Value = dtpDate1.Value
        End If

        txtMainInfor.Text = ""
        txtStandbyInfor.Text = ""
        Try
            For offset As Integer = 0 To (dtpDate2.Value - dtpDate1.Value).Days
                Dim currentDate As DateTime = dtpDate1.Value.AddDays(offset)
                Dim day_part As String = currentDate.ToString("dd")
                Dim month_part As String = currentDate.ToString("MM")

                For j As Integer = 0 To clbChannel.Items.Count - 1 'loop through all channel selected
                    If clbChannel.GetItemChecked(j) Then
                        Dim channelIndex As Integer = clbChannel.Items.IndexOf(clbChannel.Items(j)) + 1
                        Dim countForMain As Integer = 0
                        Dim countForStb As Integer = 0
                        For k As Integer = startHour To endHour 'loop through all subfolder has the name starts with startHour to endHour
                            countForMain += CountFiles(sourceMain, currentDate, k, channelIndex)
                            countForStb += CountFiles(sourceStb, currentDate, k, channelIndex)
                        Next
                        txtMainInfor.Text &= $"{clbChannel.Items(j)}: {countForMain} files; "
                        txtStandbyInfor.Text &= $"{clbChannel.Items(j)}: {countForStb} files; "
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function CountFiles(sourcePath As String, currentDate As DateTime, hour As Integer, channelIndex As Integer) As Integer
        Dim countFromPath As String = Path.Combine(sourcePath, currentDate.Day.ToString(), hour.ToString())
        Dim dirInfo As New DirectoryInfo(countFromPath)
        Dim files As IO.FileInfo() = dirInfo.GetFiles("*.*", IO.SearchOption.AllDirectories)

        Return files.Count(Function(f) f.Name.StartsWith(channelIndex & "_") _
                           AndAlso f.CreationTimeUtc.Date = currentDate.Date _
                           AndAlso f.CreationTimeUtc.TimeOfDay >= TimeSpan.Parse(cboFrom.Text) _
                           AndAlso f.CreationTimeUtc.TimeOfDay <= TimeSpan.Parse(cboTo.Text))
    End Function

    Private Sub chkDate1_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate1.CheckedChanged
        dtpDate1.Enabled = chkDate1.Checked
    End Sub
    Private Sub cboSourcePath_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSourcePath.SelectedIndexChanged
        Dim strFolder As String = If(cboSourcePath.SelectedIndex = 0, "Máy MAIN", "Máy STANDBY")
        txtDestPath.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), strFolder)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For i As Integer = 0 To clbChannel.Items.Count - 1
            clbChannel.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        'set channels 1, 2, 6 and 7 to default selected
        For i As Integer = 0 To clbChannel.Items.Count - 1
            If clbChannel.Items(i) = "118.5 MAIN" Or clbChannel.Items(i) = "118.5 STANDBY" Or
                            clbChannel.Items(i) = "HOTLINE VTN" Or clbChannel.Items(i) = "HOTLINE VSAT" Then
                clbChannel.SetItemChecked(i, True)
            Else
                clbChannel.SetItemChecked(i, False)
            End If
        Next
    End Sub

End Class
