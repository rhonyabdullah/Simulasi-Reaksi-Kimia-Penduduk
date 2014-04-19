Public Class FrmKimia
    Structure Zat
        Dim a As Single
        Dim b As Single
        Dim c As Single
    End Structure

    Dim Data() As Zat

    Private Sub FrmKimia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LstProses.Items.Add("t" & vbTab & "a" & vbTab & vbTab & "b" & vbTab & vbTab & "c")

    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        LstProses.Items.Clear()

        Dim k1 As Single = TxtK1.Text
        Dim k2 As Single = TxtK2.Text

        ReDim Data(0)
        Data(0).a = TxtA.Text
        Data(0).b = TxtB.Text
        Data(0).c = TxtC.Text

        'LstProses.Items.Add("t" & vbTab & "a" & vbTab & vbTab & "b" & vbTab & vbTab & "c")
        LstProses.Items.Add("-----------------------------------------------------------")


        For t As Integer = 1 To Val(TxtT.Text) Step Val(TxtDT.Text)
            ReDim Preserve Data(Data.GetUpperBound(0) + 1)
            With Data(Data.GetUpperBound(0))
                .a = Data(t - 1).a + ((k2 * Data(t - 1).c) - (k1 * Data(t - 1).a * Data(t - 1).b) * Val(TxtDT.Text))
                .b = Data(t - 1).b + ((k2 * Data(t - 1).c) - (k1 * Data(t - 1).a * Data(t - 1).b) * Val(TxtDT.Text))
                .c = Data(t - 1).c + (((2 * k1 * Data(t - 1).a * Data(t - 1).b) - (2 * k2 * Data(t - 1).c)) * Val(TxtDT.Text))
            End With
        Next

        For i As Integer = 0 To Data.GetUpperBound(0)
            LstProses.Items.Add(i & vbTab & FormatNumber(Math.Round(Data(i).a, 6), 6) & vbTab & FormatNumber(Math.Round(Data(i).b, 6), 6) & vbTab & FormatNumber(Math.Round(Data(i).c, 6), 6))
        Next
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles Btn_kembali.Click
        Main_Form.Show()
        LstProses.Items.Clear()
        Me.Hide()
    End Sub
End Class
