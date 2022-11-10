Public Class frm_mainmenu_a187806
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub

    Private Sub frm_mainmenu_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
    End Sub
End Class