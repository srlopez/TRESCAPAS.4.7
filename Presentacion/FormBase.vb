Imports System.Globalization
Imports Dominio

Public Class FormBase

    Dim usuarios As DataTable
    Dim usuario As Modelos.Usuario
    Dim nClicks = 0

    Sub ClearForm()
        txtID.Text = ""
        txtNombre.Text = ""
        txtFecha.Text = ""
        txtEmail.Text = ""
        txtMAP.Text = ""
        txtNotas.Text = ""

        lstUsuarios.Items.Clear()
        cmbSelect.Items.Clear()
        cmbSelect.Text = ""
        flPanel.Controls.Clear()

        btnDelete.Enabled = False

        usuarios = Nothing
        usuario = Nothing
        gridUsuarios.DataSource = Nothing
    End Sub

    Sub SetForm(id As String)
        Dim tab = UseCase.ObtenerUsuarioByID(id)
        If tab.Rows.Count = 1 Then
            usuario = New Modelos.Usuario(tab.Rows(0))

            txtID.Text = usuario.id
            txtNombre.Text = usuario.nombre
            txtFecha.Text = usuario.fnac '.ToString("d", DateTimeFormatInfo.InvariantInfo)
            txtEmail.Text = usuario.email
            txtMAP.Text = usuario.map
            txtNotas.Text = usuario.notas

            btnDelete.Enabled = True

            'Establecemos el elemento seleccionado
            cmbSelect.SelectedItem = usuario.nombre
            lstUsuarios.SelectedItem = usuario.nombre
            For Each btn In flPanel.Controls
                If btn.Text = usuario.nombre Then btn.Select()
            Next

            gridUsuarios.ClearSelection()
            gridUsuarios.Rows(lstUsuarios.SelectedIndex).Selected = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim fnac As Date = Date.ParseExact(txtFecha.Text, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim map As Decimal = Decimal.Parse(txtMAP.Text).ToString("##.##")


            If txtID.Text <> "" Then
                Dim u = usuario.Clone()
                u.nombre = txtNombre.Text
                u.fnac = fnac
                u.email = txtEmail.Text
                u.notas = txtNotas.Text
                u.map = map
                UseCase.ActualizarUsuario(u)
            Else
                Dim u = New Modelos.Usuario() With
                    {.id = -1,
                    .nombre = txtNombre.Text,
                    .fnac = fnac,
                    .email = txtEmail.Text,
                    .notas = txtNotas.Text,
                    .map = map}
                u.id = UseCase.CrearUsuario(u)
            End If
            ClearForm()
        Catch ex As Exception
            Dim s = "Error:" + vbCrLf _
                + ex.Message
            MsgBox(s)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        nClicks += 1
        lblClicks.Text = $"número de Clicks = {nClicks}"
        usuarios = Nothing

        lstUsuarios.Items.Clear()
        cmbSelect.Items.Clear()
        flPanel.Controls.Clear()

        usuarios = UseCase.ObtenerUsuariosByFiltro(txtBuscar.Text)
        gridUsuarios.DataSource = usuarios

        For Each row In usuarios.Rows
            lstUsuarios.Items.Add(row("NOMBRE"))
            cmbSelect.Items.Add(row("NOMBRE"))
            flPanel.Controls.Add(CreateButton(row("NOMBRE"), row("ID")))
        Next

    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        usuarios = Nothing

        lstUsuarios.Items.Clear()
        cmbSelect.Items.Clear()
        flPanel.Controls.Clear()

        usuarios = UseCase.ObtenerUsuarios()
        gridUsuarios.DataSource = usuarios

        For Each row In usuarios.Rows
            lstUsuarios.Items.Add(row("NOMBRE"))
            cmbSelect.Items.Add(row("NOMBRE"))
            flPanel.Controls.Add(CreateButton(row("NOMBRE"), row("ID")))
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            UseCase.EliminiarUsuario(usuario)
            ClearForm()
        Catch ex As Exception
            Dim s = "Error:" + vbCrLf _
                + ex.Message
            MsgBox(s)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ClearForm()
    End Sub

    Private Sub cmbSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelect.SelectedIndexChanged
        Dim id = usuarios.Rows(cmbSelect.SelectedIndex)("ID")
        SetForm(id)
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsuarios.SelectedIndexChanged
        Dim id = usuarios.Rows(lstUsuarios.SelectedIndex)("ID")
        SetForm(id)
    End Sub

    Private Sub gridUsuarios_Click(sender As Object, e As EventArgs) Handles gridUsuarios.Click
        Console.WriteLine(gridUsuarios.CurrentRow.Cells("ID").Value)
        SetForm(gridUsuarios.CurrentRow.Cells("ID").Value)
    End Sub

    Private Sub theButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("HOLA SOY EL BOTON" + vbCrLf +
        '       sender.Text + vbCrLf +
        '       "ID: " + sender.tag)
        'Console.WriteLine(sender)
        'Console.WriteLine(e)
        SetForm(sender.tag)
    End Sub

    Function CreateButton(nombre As String, id As String) As Button
        Dim myCrtl As New Button
        With myCrtl
            .Size = New Size(100, 100)
            .Text = nombre
            .TextAlign = ContentAlignment.BottomCenter
            .Font = lblBuscar.Font
            .ForeColor = Color.IndianRed
            .Tag = id
            '.Image = Access.WinForm.My.Resources.Resources.pnglogo2
            '.ImageAlign = ContentAlignment.BottomCenter
            .BackgroundImageLayout = ImageLayout.Zoom
            .BackgroundImage = PresentacionUI.My.Resources.Resources.pnglogo2
        End With
        AddHandler myCrtl.Click, AddressOf Me.theButton_Click
        Dim myToolTip As New ToolTip
        myToolTip.SetToolTip(myCrtl, $"{nombre}")

        Return myCrtl
    End Function

    Private Sub btnOtro_Click(sender As Object, e As EventArgs) Handles btnOtro.Click
        Dim miString As String
        Form2.ShowDialog(Me)
    End Sub
End Class