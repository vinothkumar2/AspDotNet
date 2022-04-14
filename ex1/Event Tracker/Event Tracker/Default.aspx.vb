Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBox1.Items.Add("<<Page Loaded>>")
    End Sub
    Public Sub Event_Tracked(ByVal Sender As Object, ByVal e As EventArgs) Handles Button1.Click, CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, TextBox1.TextChanged
        Dim t As String = CType(Sender, Control).ID
        ListBox1.Items.Add("<" & t & "> Event Triggered")
    End Sub
    Private Sub WebForm1_PreRender(ByVal Sender As Object, ByVal e As EventArgs) Handles Me.Load
        ListBox1.Items.Add("<<Page Rendered>>")
    End Sub
End Class