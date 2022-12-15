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
        Me.isCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btGreet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'isCountry
        '
        Me.isCountry.AutoSize = True
        Me.isCountry.Location = New System.Drawing.Point(99, 131)
        Me.isCountry.Name = "isCountry"
        Me.isCountry.Size = New System.Drawing.Size(118, 13)
        Me.isCountry.TabIndex = 0
        Me.isCountry.Text = "What country are from?"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(223, 124)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(171, 20)
        Me.txtCountry.TabIndex = 1
        '
        'btGreet
        '
        Me.btGreet.Location = New System.Drawing.Point(250, 221)
        Me.btGreet.Name = "btGreet"
        Me.btGreet.Size = New System.Drawing.Size(116, 69)
        Me.btGreet.TabIndex = 2
        Me.btGreet.Text = "Greeting"
        Me.btGreet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btGreet)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.isCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents isCountry As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btGreet As Button
End Class
