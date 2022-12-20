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
        Me.btnRowWise = New System.Windows.Forms.Button()
        Me.btnColumnWise = New System.Windows.Forms.Button()
        Me.btnOutputAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRowWise
        '
        Me.btnRowWise.Location = New System.Drawing.Point(83, 53)
        Me.btnRowWise.Name = "btnRowWise"
        Me.btnRowWise.Size = New System.Drawing.Size(194, 50)
        Me.btnRowWise.TabIndex = 0
        Me.btnRowWise.Text = "Display data terms row wise"
        Me.btnRowWise.UseVisualStyleBackColor = True
        '
        'btnColumnWise
        '
        Me.btnColumnWise.Location = New System.Drawing.Point(83, 133)
        Me.btnColumnWise.Name = "btnColumnWise"
        Me.btnColumnWise.Size = New System.Drawing.Size(194, 50)
        Me.btnColumnWise.TabIndex = 1
        Me.btnColumnWise.Text = "Display data terms column wise"
        Me.btnColumnWise.UseVisualStyleBackColor = True
        '
        'btnOutputAll
        '
        Me.btnOutputAll.Location = New System.Drawing.Point(83, 225)
        Me.btnOutputAll.Name = "btnOutputAll"
        Me.btnOutputAll.Size = New System.Drawing.Size(194, 50)
        Me.btnOutputAll.TabIndex = 2
        Me.btnOutputAll.Text = "Display all data terms  at once"
        Me.btnOutputAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(83, 316)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(194, 50)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search for a person"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 450)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnOutputAll)
        Me.Controls.Add(Me.btnColumnWise)
        Me.Controls.Add(Me.btnRowWise)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRowWise As Button
    Friend WithEvents btnColumnWise As Button
    Friend WithEvents btnOutputAll As Button
    Friend WithEvents btnSearch As Button
End Class
