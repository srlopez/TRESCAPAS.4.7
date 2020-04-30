<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lstUsuarios = New System.Windows.Forms.ListBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.cmbSelect = New System.Windows.Forms.ComboBox()
        Me.flPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblBotones = New System.Windows.Forms.Label()
        Me.lblClicks = New System.Windows.Forms.Label()
        Me.gridUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnTodos = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(123, 206)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(244, 26)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(52, 209)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(69, 260)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(123, 254)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(244, 26)
        Me.txtEmail.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(63, 233)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(54, 20)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(123, 230)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(244, 26)
        Me.txtFecha.TabIndex = 2
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(91, 185)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 20)
        Me.lblID.TabIndex = 10
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(123, 182)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(244, 26)
        Me.txtID.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(288, 286)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(79, 35)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(124, 98)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(202, 26)
        Me.txtBuscar.TabIndex = 11
        '
        'lstUsuarios
        '
        Me.lstUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.ItemHeight = 20
        Me.lstUsuarios.Location = New System.Drawing.Point(415, 97)
        Me.lstUsuarios.MultiColumn = True
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.ScrollAlwaysVisible = True
        Me.lstUsuarios.Size = New System.Drawing.Size(184, 224)
        Me.lstUsuarios.TabIndex = 12
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(332, 97)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(35, 31)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = ">>"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(207, 286)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(120, 75)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(59, 20)
        Me.lblBuscar.TabIndex = 16
        Me.lblBuscar.Text = "Buscar"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(122, 286)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(79, 35)
        Me.btnNuevo.TabIndex = 17
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'cmbSelect
        '
        Me.cmbSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelect.FormattingEnabled = True
        Me.cmbSelect.Location = New System.Drawing.Point(124, 130)
        Me.cmbSelect.Name = "cmbSelect"
        Me.cmbSelect.Size = New System.Drawing.Size(243, 28)
        Me.cmbSelect.TabIndex = 18
        '
        'flPanel
        '
        Me.flPanel.AutoScroll = True
        Me.flPanel.Location = New System.Drawing.Point(124, 367)
        Me.flPanel.Name = "flPanel"
        Me.flPanel.Size = New System.Drawing.Size(475, 158)
        Me.flPanel.TabIndex = 20
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Access.WinForm.My.Resources.Resources.pnglogo2
        Me.picLogo.Location = New System.Drawing.Point(124, 13)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(214, 59)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 21
        Me.picLogo.TabStop = False
        '
        'lblBotones
        '
        Me.lblBotones.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblBotones.AutoSize = True
        Me.lblBotones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotones.Location = New System.Drawing.Point(120, 344)
        Me.lblBotones.Name = "lblBotones"
        Me.lblBotones.Size = New System.Drawing.Size(144, 20)
        Me.lblBotones.TabIndex = 22
        Me.lblBotones.Text = "Botones dinámicos"
        '
        'lblClicks
        '
        Me.lblClicks.AutoSize = True
        Me.lblClicks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicks.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblClicks.Location = New System.Drawing.Point(415, 13)
        Me.lblClicks.Name = "lblClicks"
        Me.lblClicks.Size = New System.Drawing.Size(152, 21)
        Me.lblClicks.TabIndex = 23
        Me.lblClicks.Text = "Contador de Clicks"
        '
        'gridUsuarios
        '
        Me.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUsuarios.Location = New System.Drawing.Point(638, 98)
        Me.gridUsuarios.Name = "gridUsuarios"
        Me.gridUsuarios.Size = New System.Drawing.Size(240, 427)
        Me.gridUsuarios.TabIndex = 24
        '
        'btnTodos
        '
        Me.btnTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.Location = New System.Drawing.Point(415, 51)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(103, 31)
        Me.btnTodos.TabIndex = 25
        Me.btnTodos.Text = "Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'FormBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 594)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.gridUsuarios)
        Me.Controls.Add(Me.lblClicks)
        Me.Controls.Add(Me.lblBotones)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.flPanel)
        Me.Controls.Add(Me.cmbSelect)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lstUsuarios)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "FormBase"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lstUsuarios As ListBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cmbSelect As ComboBox
    Friend WithEvents flPanel As FlowLayoutPanel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblBotones As Label
    Friend WithEvents lblClicks As Label
    Friend WithEvents gridUsuarios As DataGridView
    Friend WithEvents btnTodos As Button
End Class
