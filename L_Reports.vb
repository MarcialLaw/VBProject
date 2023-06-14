Public Class L_Reports
    Private Sub BtnPrintPDD_Click(sender As Object, e As EventArgs) Handles BtnPrintPDD.Click
        R_PDD.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        R_Senior_Report.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        R_PWD_Report.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        R_MaternalCare.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        R_Immunization.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        R_ChildNutrition.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        R_Covid19.Show()
    End Sub

    Private Sub Btn_DeathReport_Click(sender As Object, e As EventArgs) Handles Btn_DeathReport.Click
        R_Deaths.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub L_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class