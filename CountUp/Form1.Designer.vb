<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCountUpTask = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCountUpTask
        '
        Me.btnCountUpTask.Location = New System.Drawing.Point(215, 194)
        Me.btnCountUpTask.Name = "btnCountUpTask"
        Me.btnCountUpTask.Size = New System.Drawing.Size(174, 88)
        Me.btnCountUpTask.TabIndex = 0
        Me.btnCountUpTask.Text = "Count up Odd or Even"
        Me.btnCountUpTask.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.btnCountUpTask)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCountUpTask As Button
End Class
