Public Class Form2
    Private sidebarExpanded As Boolean = False
    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        If sidebarExpanded Then
            PanelSideBar.Width = 51 ' Collapse sidebar
            ShowButton.Text = "➤"
        Else
            PanelSideBar.Width = 300 ' Expand sidebar
            ShowButton.Text = "➖"
        End If
        sidebarExpanded = Not sidebarExpanded
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class