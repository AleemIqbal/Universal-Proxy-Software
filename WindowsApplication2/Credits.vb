Public Class Credits
    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        e.Link.Visited = True
        Dim URL As String = CType(e.Link.LinkData, String)
        Process.Start(URL)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        LinkLabel1.Links.Add(0, 0, "https://skillsacademy.pk/")
        LinkLabel2.Links.Add(0, 0, "https://www.facebook.com/aleem.marketing/")
        LinkLabel3.Links.Add(0, 0, "https://www.facebook.com/groups/seomastersacademy/")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        e.Link.Visited = True
        Dim URL As String = CType(e.Link.LinkData, String)
        Process.Start(URL)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        e.Link.Visited = True
        Dim URL As String = CType(e.Link.LinkData, String)
        Process.Start(URL)
    End Sub
End Class