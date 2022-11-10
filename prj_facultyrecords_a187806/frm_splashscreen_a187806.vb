Public Class frm_splashscreen_a187806
    Private Sub lbl_name_Click(sender As Object, e As EventArgs) Handles lbl_name.Click, lbl_title.Click

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        frm_mainmenu_a187806.Show()
        Me.Hide()
    End Sub

    Private Sub frm_splashscreen_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
