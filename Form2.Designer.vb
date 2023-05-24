<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.CuteCalc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenSourceCode = New System.Windows.Forms.LinkLabel()
        Me.ReadMore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CuteCalc
        '
        Me.CuteCalc.AutoSize = True
        Me.CuteCalc.BackColor = System.Drawing.Color.Bisque
        Me.CuteCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CuteCalc.Cursor = System.Windows.Forms.Cursors.No
        Me.CuteCalc.Font = New System.Drawing.Font("VCR OSD Mono", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuteCalc.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.CuteCalc.Location = New System.Drawing.Point(47, 20)
        Me.CuteCalc.Name = "CuteCalc"
        Me.CuteCalc.Size = New System.Drawing.Size(134, 27)
        Me.CuteCalc.TabIndex = 18
        Me.CuteCalc.Text = "CuteCalc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Peru
        Me.Label1.Font = New System.Drawing.Font("Victor's Pixel Font", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Location = New System.Drawing.Point(163, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 9)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "V1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Peru
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Cursor = System.Windows.Forms.Cursors.No
        Me.Label2.Font = New System.Drawing.Font("VCR OSD Mono", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PapayaWhip
        Me.Label2.Location = New System.Drawing.Point(22, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "About "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Source Code Pro Semibold", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 77)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  This is an open source calculator  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  with a funky and cute design.    " &
    "  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  It is developed by Salman Tariq" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  ( Apptic Labs )  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Peru
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.No
        Me.Label4.Font = New System.Drawing.Font("VCR OSD Mono", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.PapayaWhip
        Me.Label4.Location = New System.Drawing.Point(23, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Theme"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 52)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Victor's Pixel Font", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(36, 173)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 20)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Light Mode"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 39)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                        " &
    "                             "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Peru
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Cursor = System.Windows.Forms.Cursors.No
        Me.Label7.Font = New System.Drawing.Font("VCR OSD Mono", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.PapayaWhip
        Me.Label7.Location = New System.Drawing.Point(23, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Github"
        '
        'OpenSourceCode
        '
        Me.OpenSourceCode.AutoSize = True
        Me.OpenSourceCode.Font = New System.Drawing.Font("Victor's Pixel Font", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenSourceCode.LinkVisited = True
        Me.OpenSourceCode.Location = New System.Drawing.Point(32, 97)
        Me.OpenSourceCode.Name = "OpenSourceCode"
        Me.OpenSourceCode.Size = New System.Drawing.Size(151, 12)
        Me.OpenSourceCode.TabIndex = 27
        Me.OpenSourceCode.TabStop = True
        Me.OpenSourceCode.Text = "Open Source Code"
        '
        'ReadMore
        '
        Me.ReadMore.BackColor = System.Drawing.Color.Peru
        Me.ReadMore.Font = New System.Drawing.Font("Victor's Pixel Font", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadMore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ReadMore.Location = New System.Drawing.Point(54, 311)
        Me.ReadMore.Name = "ReadMore"
        Me.ReadMore.Size = New System.Drawing.Size(127, 20)
        Me.ReadMore.TabIndex = 28
        Me.ReadMore.Text = "Read More"
        Me.ReadMore.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(256, 358)
        Me.Controls.Add(Me.ReadMore)
        Me.Controls.Add(Me.OpenSourceCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CuteCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CuteCalc As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenSourceCode As LinkLabel
    Friend WithEvents ReadMore As Button
End Class
