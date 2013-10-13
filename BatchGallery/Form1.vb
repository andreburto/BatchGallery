Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim batch As frmBatch = New frmBatch
        batch.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim gallery As frmGalleryThing = New frmGalleryThing
        gallery.ShowDialog()
    End Sub
End Class
