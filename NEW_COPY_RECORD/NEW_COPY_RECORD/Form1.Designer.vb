<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.txtStandbyInfor = New System.Windows.Forms.TextBox()
        Me.txtMainInfor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboSourcePath = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDestPath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.clbChannel = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPeriodic = New System.Windows.Forms.Button()
        Me.chkPeriodic = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkDate1 = New System.Windows.Forms.CheckBox()
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker()
        Me.cboFrom = New System.Windows.Forms.ComboBox()
        Me.cboTo = New System.Windows.Forms.ComboBox()
        Me.chkDate2 = New System.Windows.Forms.CheckBox()
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.blinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDefault
        '
        Me.btnDefault.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefault.Location = New System.Drawing.Point(225, 925)
        Me.btnDefault.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(198, 52)
        Me.btnDefault.TabIndex = 55
        Me.btnDefault.Text = "DEFAULT"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'txtStandbyInfor
        '
        Me.txtStandbyInfor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStandbyInfor.Location = New System.Drawing.Point(196, 110)
        Me.txtStandbyInfor.Margin = New System.Windows.Forms.Padding(6)
        Me.txtStandbyInfor.Name = "txtStandbyInfor"
        Me.txtStandbyInfor.Size = New System.Drawing.Size(1008, 44)
        Me.txtStandbyInfor.TabIndex = 3
        '
        'txtMainInfor
        '
        Me.txtMainInfor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMainInfor.Location = New System.Drawing.Point(196, 48)
        Me.txtMainInfor.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMainInfor.Name = "txtMainInfor"
        Me.txtMainInfor.Size = New System.Drawing.Size(1008, 44)
        Me.txtMainInfor.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "FLC_26:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 36)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "FLC_027:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 146)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1199, 36)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "__________________________________________________________________________"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtStandbyInfor)
        Me.GroupBox3.Controls.Add(Me.txtMainInfor)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 707)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(1234, 206)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMPARE"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(762, 925)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 52)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboSourcePath
        '
        Me.cboSourcePath.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSourcePath.FormattingEnabled = True
        Me.cboSourcePath.Items.AddRange(New Object() {"\\Flc_027\vrs", "\\Flc_26\vrs"})
        Me.cboSourcePath.Location = New System.Drawing.Point(220, 37)
        Me.cboSourcePath.Margin = New System.Windows.Forms.Padding(6)
        Me.cboSourcePath.Name = "cboSourcePath"
        Me.cboSourcePath.Size = New System.Drawing.Size(994, 44)
        Me.cboSourcePath.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 36)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Destination:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 36)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Source:"
        '
        'txtDestPath
        '
        Me.txtDestPath.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestPath.Location = New System.Drawing.Point(220, 94)
        Me.txtDestPath.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDestPath.Name = "txtDestPath"
        Me.txtDestPath.Size = New System.Drawing.Size(994, 44)
        Me.txtDestPath.TabIndex = 39
        '
        'clbChannel
        '
        Me.clbChannel.CheckOnClick = True
        Me.clbChannel.ColumnWidth = 150
        Me.clbChannel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbChannel.FormattingEnabled = True
        Me.clbChannel.Location = New System.Drawing.Point(278, 196)
        Me.clbChannel.Margin = New System.Windows.Forms.Padding(6)
        Me.clbChannel.MultiColumn = True
        Me.clbChannel.Name = "clbChannel"
        Me.clbChannel.Size = New System.Drawing.Size(928, 250)
        Me.clbChannel.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnPeriodic)
        Me.GroupBox1.Controls.Add(Me.chkPeriodic)
        Me.GroupBox1.Controls.Add(Me.clbChannel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkDate1)
        Me.GroupBox1.Controls.Add(Me.dtpDate1)
        Me.GroupBox1.Controls.Add(Me.cboFrom)
        Me.GroupBox1.Controls.Add(Me.cboTo)
        Me.GroupBox1.Controls.Add(Me.chkDate2)
        Me.GroupBox1.Controls.Add(Me.dtpDate2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 204)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(1236, 492)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COPY THEO YÊU CẦU"
        '
        'btnPeriodic
        '
        Me.btnPeriodic.BackgroundImage = Global.NEW_COPY_RECORD.My.Resources.Resources.check_mark_png_45026
        Me.btnPeriodic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPeriodic.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPeriodic.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPeriodic.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnPeriodic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeriodic.Location = New System.Drawing.Point(1100, 92)
        Me.btnPeriodic.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPeriodic.Name = "btnPeriodic"
        Me.btnPeriodic.Size = New System.Drawing.Size(90, 77)
        Me.btnPeriodic.TabIndex = 44
        Me.btnPeriodic.UseVisualStyleBackColor = True
        Me.btnPeriodic.Visible = False
        '
        'chkPeriodic
        '
        Me.chkPeriodic.AutoSize = True
        Me.chkPeriodic.Location = New System.Drawing.Point(714, 123)
        Me.chkPeriodic.Margin = New System.Windows.Forms.Padding(6)
        Me.chkPeriodic.Name = "chkPeriodic"
        Me.chkPeriodic.Size = New System.Drawing.Size(390, 40)
        Me.chkPeriodic.TabIndex = 43
        Me.chkPeriodic.Text = "LẤY GHI ÂM ĐỊNH KỲ"
        Me.chkPeriodic.UseVisualStyleBackColor = True
        Me.chkPeriodic.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TIME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CHANNEL:"
        '
        'chkDate1
        '
        Me.chkDate1.AutoSize = True
        Me.chkDate1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDate1.Location = New System.Drawing.Point(278, 56)
        Me.chkDate1.Margin = New System.Windows.Forms.Padding(6)
        Me.chkDate1.Name = "chkDate1"
        Me.chkDate1.Size = New System.Drawing.Size(147, 40)
        Me.chkDate1.TabIndex = 1
        Me.chkDate1.Text = "Ngày 1:"
        Me.chkDate1.UseVisualStyleBackColor = True
        '
        'dtpDate1
        '
        Me.dtpDate1.CalendarMonthBackground = System.Drawing.SystemColors.MenuText
        Me.dtpDate1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate1.Location = New System.Drawing.Point(434, 46)
        Me.dtpDate1.Margin = New System.Windows.Forms.Padding(6)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(194, 44)
        Me.dtpDate1.TabIndex = 10
        '
        'cboFrom
        '
        Me.cboFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.Items.AddRange(New Object() {"00:00:00", "01:00:00", "02:00:00", "03:00:00", "04:00:00", "05:00:00", "06:00:00", "07:00:00", "08:00:00", "09:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00", "20:00:00", "21:00:00", "22:00:00", "23:00:00"})
        Me.cboFrom.Location = New System.Drawing.Point(278, 119)
        Me.cboFrom.Margin = New System.Windows.Forms.Padding(6)
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(182, 44)
        Me.cboFrom.TabIndex = 12
        Me.cboFrom.Text = "From:"
        '
        'cboTo
        '
        Me.cboTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.Items.AddRange(New Object() {"00:00:00", "01:00:00", "02:00:00", "03:00:00", "04:00:00", "05:00:00", "06:00:00", "07:00:00", "08:00:00", "09:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00", "20:00:00", "21:00:00", "22:00:00", "23:00:00"})
        Me.cboTo.Location = New System.Drawing.Point(476, 119)
        Me.cboTo.Margin = New System.Windows.Forms.Padding(6)
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(182, 44)
        Me.cboTo.TabIndex = 13
        Me.cboTo.Text = "To:"
        '
        'chkDate2
        '
        Me.chkDate2.AutoSize = True
        Me.chkDate2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDate2.Location = New System.Drawing.Point(714, 50)
        Me.chkDate2.Margin = New System.Windows.Forms.Padding(6)
        Me.chkDate2.Name = "chkDate2"
        Me.chkDate2.Size = New System.Drawing.Size(147, 40)
        Me.chkDate2.TabIndex = 15
        Me.chkDate2.Text = "Ngày 2:"
        Me.chkDate2.UseVisualStyleBackColor = True
        '
        'dtpDate2
        '
        Me.dtpDate2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate2.Location = New System.Drawing.Point(870, 40)
        Me.dtpDate2.Margin = New System.Windows.Forms.Padding(6)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(194, 44)
        Me.dtpDate2.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 435)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1199, 36)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "__________________________________________________________________________"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(624, 925)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(126, 52)
        Me.btnOK.TabIndex = 49
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCompare
        '
        Me.btnCompare.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompare.Location = New System.Drawing.Point(15, 925)
        Me.btnCompare.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(198, 52)
        Me.btnCompare.TabIndex = 54
        Me.btnCompare.Text = "COMPARE"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboSourcePath)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDestPath)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(1234, 169)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SET PATH"
        '
        'tmrExit
        '
        Me.tmrExit.Interval = 5000
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(435, 925)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 52)
        Me.btnClear.TabIndex = 56
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'blinkTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1261, 985)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COPY RECORD"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDefault As Button
    Friend WithEvents txtStandbyInfor As TextBox
    Friend WithEvents txtMainInfor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cboSourcePath As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDestPath As TextBox
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents clbChannel As CheckedListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkDate1 As CheckBox
    Friend WithEvents dtpDate1 As DateTimePicker
    Friend WithEvents cboFrom As ComboBox
    Friend WithEvents cboTo As ComboBox
    Friend WithEvents chkDate2 As CheckBox
    Friend WithEvents dtpDate2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCompare As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPeriodic As Button
    Friend WithEvents chkPeriodic As CheckBox
    Friend WithEvents tmrExit As Timer
    Friend WithEvents btnClear As Button
    Friend WithEvents blinkTimer As Timer
End Class
