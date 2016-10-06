
Partial Class _Default
    Inherits System.Web.UI.Page

  Protected Sub btnReportBug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReportBug.Click
    Response.Redirect("BugReporter.aspx")
  End Sub

  Protected Sub btnViewBugs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewBugs.Click
    Response.Redirect("BugViewer.aspx")
  End Sub
End Class
