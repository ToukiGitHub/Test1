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
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(245, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 65)
        Label1.TabIndex = 0
        Label1.Text = "カウントダウンツール"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        DateTimePicker1.Location = New Point(196, 175)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(243, 43)
        DateTimePicker1.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownHeight = 110
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.ItemHeight = 37
        ComboBox1.Location = New Point(448, 174)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(75, 45)
        ComboBox1.TabIndex = 2
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownHeight = 110
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        ComboBox2.FormattingEnabled = True
        ComboBox2.IntegralHeight = False
        ComboBox2.ItemHeight = 37
        ComboBox2.Location = New Point(585, 174)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(75, 45)
        ComboBox2.TabIndex = 3
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownHeight = 110
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        ComboBox3.FormattingEnabled = True
        ComboBox3.IntegralHeight = False
        ComboBox3.ItemHeight = 37
        ComboBox3.Location = New Point(722, 174)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(75, 45)
        ComboBox3.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(532, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 37)
        Label2.TabIndex = 5
        Label2.Text = "時"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(669, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 37)
        Label3.TabIndex = 6
        Label3.Text = "分"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(806, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 37)
        Label4.TabIndex = 7
        Label4.Text = "秒"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(366, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 37)
        Label5.TabIndex = 8
        Label5.Text = "現在日時："
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(35, 178)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 37)
        Label7.TabIndex = 10
        Label7.Text = "指定日時："
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(322, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(241, 37)
        Label6.TabIndex = 11
        Label6.Text = "指定日時まで残り："
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label8.ForeColor = Color.Lime
        Label8.Location = New Point(284, 315)
        Label8.Name = "Label8"
        Label8.Size = New Size(316, 65)
        Label8.TabIndex = 12
        Label8.Text = "x日x時x分x秒"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(884, 461)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "株式会社Bloom Basis"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

End Class
