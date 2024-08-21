<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParentForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        NuevoClienteToolStripMenuItem = New ToolStripMenuItem()
        NuevoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NuevoClienteToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1258, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' NuevoClienteToolStripMenuItem
        ' 
        NuevoClienteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoToolStripMenuItem})
        NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        NuevoClienteToolStripMenuItem.Size = New Size(81, 29)
        NuevoClienteToolStripMenuItem.Text = "Cliente"
        ' 
        ' NuevoToolStripMenuItem
        ' 
        NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        NuevoToolStripMenuItem.Size = New Size(166, 34)
        NuevoToolStripMenuItem.Text = "Nuevo"
        ' 
        ' MDIParentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 664)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "MDIParentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pequeño Sistema"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
End Class
