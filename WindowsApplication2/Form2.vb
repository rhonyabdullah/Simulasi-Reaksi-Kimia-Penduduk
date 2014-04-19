Public Class FrmPenduduk

    Dim JumlahPenduduk() As Double
    Dim LajuPenduduk As Double

    Private Sub FrmPenduduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        LstPenduduk.Items.Clear()

        ReDim JumlahPenduduk(0)
        JumlahPenduduk(0) = Val(TxtP2000.Text)

        For I As Integer = 0 To Val(TxtWaktu.Text) Step Val(TxtInterval.Text)
            ReDim Preserve JumlahPenduduk(JumlahPenduduk.GetUpperBound(0) + 1)
            If I > 0 And I < 10 Then
                JumlahPenduduk(I) = JumlahPenduduk(I - 1) + (Val(TxtLP20002010.Text) / 100 * JumlahPenduduk(I - 1)) * Val(TxtInterval.Text)
            ElseIf I = 10 Then
                JumlahPenduduk(I) = Val(TxtP2010.Text)
            ElseIf I > 10 Then
                JumlahPenduduk(I) = JumlahPenduduk(I - 1) + (Val(TxtLP20002010.Text) / 100 * JumlahPenduduk(I - 1)) * Val(TxtInterval.Text)
            End If
        Next

        LstPenduduk.Items.Add("   Tahun" & vbTab & "Jumlah Penduduk")
        For i As Integer = 0 To JumlahPenduduk.GetUpperBound(0) - 1 Step Val(TxtInterval.Text)
            LstPenduduk.Items.Add("   " & i + 2000 & " " & vbTab & Math.Round(JumlahPenduduk(i)))
            Me.Chart1.Series("Jumlah Penduduk").Points.AddXY((i + 2000), Math.Round(JumlahPenduduk(i)))
        Next


        'ReDim JumlahPenduduk(0)
        'JumlahPenduduk(0) = Val(TxtP1980.Text)

        'For I As Integer = 0 To Val(TxtWaktu.Text) Step Val(TxtInterval.Text)
        '    ReDim Preserve JumlahPenduduk(JumlahPenduduk.GetUpperBound(0) + 1)
        '    If I > 0 And I < 10 Then
        '        JumlahPenduduk(I) = JumlahPenduduk(I - 1) + (Val(TxtLP19801990.Text) / 100 * JumlahPenduduk(I - 1)) * Val(TxtInterval.Text)
        '    ElseIf I = 10 Then
        '        JumlahPenduduk(I) = Val(TxtP1990.Text)
        '    ElseIf I > 10 And I < 20 Then
        '        JumlahPenduduk(I) = JumlahPenduduk(I - 1) + (Val(TxtLP19902000.Text) / 100 * JumlahPenduduk(I - 1)) * Val(TxtInterval.Text)
        '    ElseIf I = 20 Then
        '        JumlahPenduduk(I) = Val(TxtP2000.Text)
        '    ElseIf I > 20 And I < 30 Then
        '        JumlahPenduduk(I) = JumlahPenduduk(I - 1) + (Val(TxtLP20002010.Text) / 100 * JumlahPenduduk(I - 1)) * Val(TxtInterval.Text)
        '    ElseIf I = 30 Then
        '        JumlahPenduduk(I) = Val(TxtP2010.Text)
        '    ElseIf I > 30 Then
        '        JumlahPenduduk(I) = JumlahPenduduk(I - 1) + (Val(TxtLP20002010.Text) / 100 * JumlahPenduduk(I - 1)) * Val(TxtInterval.Text)
        '    End If
        'Next

        'LstPenduduk.Items.Add("   Tahun" & vbTab & "Jumlah Penduduk")
        'For i As Integer = 0 To JumlahPenduduk.GetUpperBound(0) - 1 Step Val(TxtInterval.Text)
        '    LstPenduduk.Items.Add("   " & i + 1980 & " " & vbTab & Math.Round(JumlahPenduduk(i)))
        'Next

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Main_Form.Show()
        Me.Hide()
        LstPenduduk.Items.Clear()
    End Sub

End Class