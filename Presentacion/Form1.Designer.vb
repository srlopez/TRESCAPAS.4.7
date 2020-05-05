<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlLEft = New System.Windows.Forms.Panel()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.GrayText
        Me.pnlTop.Controls.Add(Me.lbl1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(877, 30)
        Me.pnlTop.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl1.Location = New System.Drawing.Point(37, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(33, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "menu"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.Green
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 432)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(877, 35)
        Me.pnlBottom.TabIndex = 2
        '
        'pnlLEft
        '
        Me.pnlLEft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlLEft.BackColor = System.Drawing.Color.Honeydew
        Me.pnlLEft.Location = New System.Drawing.Point(0, 25)
        Me.pnlLEft.Name = "pnlLEft"
        Me.pnlLEft.Size = New System.Drawing.Size(177, 430)
        Me.pnlLEft.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 467)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLEft)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlLEft As Panel
End Class
