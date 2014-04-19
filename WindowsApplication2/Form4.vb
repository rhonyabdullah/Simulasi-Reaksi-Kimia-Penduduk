Public Class Main_Form

#Region "Desain"
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Me.BackColor = Color.Indigo
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Me.BackColor = Color.Indigo
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Me.BackColor = Color.SlateBlue
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles MetroLabel2.MouseEnter
        Me.BackColor = Color.SlateBlue
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles MetroLabel2.MouseLeave
        Me.BackColor = Color.LightGray
    End Sub
#End Region

#Region "Klik"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FrmKimia.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmKimia.Show()
        Me.Hide()
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click
        FrmPenduduk.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmPenduduk.Show()
        Me.Hide()
    End Sub

#End Region

End Class