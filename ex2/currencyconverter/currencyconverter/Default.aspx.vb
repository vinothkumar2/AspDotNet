Partial Public Class _Default
    Inherits System.Web.UI.Page
    Public ccr_usd_inr As Double = 68.9
    Public ccr_jpy_inr As Double = 1.67
    Public result As Double

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If TextBox1.Text = "" Then
            MsgBox("Please Enter a Value before Converting Currency")
        Else
            If DropDownList1.SelectedItem.Value = "INR_USD" Then
                result = Math.Round(Convert.ToDouble(TextBox1.Text) / ccr_usd_inr, 2)
                TextBox2.Text = result.ToString() + " USD"
            ElseIf DropDownList1.SelectedItem.Value = "USD_INR" Then
                result = Math.Round(Convert.ToDouble(TextBox1.Text) * ccr_usd_inr, 2)
                TextBox2.Text = result.ToString() + " INR"
            ElseIf DropDownList1.SelectedItem.Value = "INR_JPY" Then
                result = Math.Round(Convert.ToDouble(TextBox1.Text) / ccr_jpy_inr, 2)
                TextBox2.Text = result.ToString() + " JPY"
            ElseIf DropDownList1.SelectedItem.Value = "JPY_INR" Then
                result = Math.Round(Convert.ToDouble(TextBox1.Text) * ccr_jpy_inr, 2)
                TextBox2.Text = result.ToString() + " INR"
            End If
        End If
    End Sub
End Class