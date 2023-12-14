Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private WithEvents timer1 As New Timer()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(900, 450)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point((screenWidth - Me.Width) \ 2, (screenHeight - Me.Height) \ 2)
        'Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        SetTimeCombobox()

        timer1.Interval = 1000 ' 1秒ごとに更新
        timer1.Start()
        AddHandler timer1.Tick, AddressOf Timer1_Tick
        UpdateClock()
    End Sub
    Private Sub SetTimeCombobox()
        Dim i As Int16
        For i = 0 To 59
            ComboBox1.Items.Add(i.ToString().PadLeft(2, "0"c))
            ComboBox2.Items.Add(i.ToString().PadLeft(2, "0"c))
            ComboBox3.Items.Add(i.ToString().PadLeft(2, "0"c))
        Next
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("本当に閉じますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        UpdateClock()
    End Sub

    Private Sub UpdateClock()
        Label5.Text = $"現在日時：{DateTime.Now.ToString("yyyy年M月dd日 HH時mm分ss秒")}"
        Label5.Location = New Point((Me.Width - Label5.Width) \ 2, Label5.Top)
        'Dim myDateTime As New DateTime(Integer.Parse(ComboBox1.SelectedItem),
        '                              Integer.Parse(ComboBox2.SelectedItem),
        '                              Integer.Parse(ComboBox3.SelectedItem),
        '                              Integer.Parse(ComboBox4.SelectedItem),
        '                              Integer.Parse(ComboBox5.SelectedItem),
        '                              Integer.Parse(ComboBox5.SelectedItem))
        'Dim timeDifference As TimeSpan = myDateTime - DateTime.Now
        'Label12.Text = $"{timeDifference.Days}日{timeDifference.Hours.ToString().PadLeft(2, "0"c)}時間{timeDifference.Minutes.ToString().PadLeft(2, "0"c)}分{timeDifference.Seconds.ToString().PadLeft(2, "0"c)}秒"
        'Label12.Location = New Point((Me.Width - Label12.Width) \ 2, Label12.Top)
    End Sub
End Class
