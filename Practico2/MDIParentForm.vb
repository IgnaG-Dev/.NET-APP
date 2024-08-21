Public Class MDIParentForm

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frmPequeno As New Form1()

        frmPequeno.MdiParent = Me

        frmPequeno.Show()
    End Sub

    Private Sub MDIParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class