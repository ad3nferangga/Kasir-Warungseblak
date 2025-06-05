Public Class MenuUtama
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim from As New DataAdmin
        from.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim from As New Pesanan
        from.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim from As New Stok
        from.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim from As New Laporan
        from.Show()
    End Sub
End Class