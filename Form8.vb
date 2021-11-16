Option Strict On
Imports System.IO
Imports System.Collections.Generic
Public Class lblasteriscofechadenacimiento
    Dim valido As Boolean
    Dim dni, nombre, apellidos, correo, fechadenacimiento As String
    Dim edad As Double
    Dim registros(99) As String
    Dim listaregistros As List(Of String) = New List(Of String)()
    Dim posicion As Integer
    Dim rutaFichero As String = Directory.GetCurrentDirectory + "\datosusuario.txt"

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim lector As StreamReader = New StreamReader(rutaFichero)
            While Not lector.EndOfStream
                Dim i As Integer
                Dim registroLocal As String = lector.ReadLine()
                registros(i) = registroLocal
                listaregistros.Add(registroLocal)
                i += 1
            End While
            lector.Close()
        Catch
            Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(rutaFichero, False)
        End Try

    End Sub

    Private Sub Form8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuestas As DialogResult = MessageBox.Show("A que mola el proyecto UwU", "Te vas a ir ya :(?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If respuestas = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BotonBuscarUsuario_Click(sender As Object, e As EventArgs) Handles BotonBuscarUsuario.Click
        For Each registro In listaregistros
            Dim trozos() As String = registro.Split("*"c)
            If trozos(4) = dnibuscar.Text Then
                nombre2txt.Text = trozos(0)
                apellidos2txt.Text = trozos(1)
                edad2txt.Text = trozos(2)
                correo2txt.Text = trozos(3)
                dni2txt.Text = trozos(4)
                fechadenacimiento2txt.Text = trozos(5)
            End If
        Next

    End Sub

    Private Sub BotonAvanzar_Click(sender As Object, e As EventArgs) Handles BotonAvanzar.Click
        If posicion < listaregistros.Count - 1 Then
            posicion += 1
            Dim registro As String = listaregistros(posicion)
            Dim trozos() As String = registro.Split("*"c)

            nombre2txt.Text = trozos(0)
            apellidos2txt.Text = trozos(1)
            edad2txt.Text = trozos(2)
            correo2txt.Text = trozos(3)
            dni2txt.Text = trozos(4)
            fechadenacimiento2txt.Text = trozos(5)
        Else
            posicion = listaregistros.Count - 1
            Dim registro As String = listaregistros(posicion)
            Dim trozos() As String = registro.Split("*"c)

            nombre2txt.Text = trozos(0)
            apellidos2txt.Text = trozos(1)
            edad2txt.Text = trozos(2)
            correo2txt.Text = trozos(3)
            dni2txt.Text = trozos(4)
            fechadenacimiento2txt.Text = trozos(5)
        End If

    End Sub

    Private Sub BotonRetrocederAlPrincipio_Click(sender As Object, e As EventArgs) Handles BotonRetrocederAlPrincipio.Click
        posicion = listaregistros.Count - 1
        Dim ultimoRegistro As String = listaregistros(posicion)
        Dim trozos() As String = ultimoRegistro.Split("*"c)

        nombre2txt.Text = trozos(0)
        apellidos2txt.Text = trozos(1)
        edad2txt.Text = trozos(2)
        correo2txt.Text = trozos(3)
        dni2txt.Text = trozos(4)
        fechadenacimiento2txt.Text = trozos(5)
    End Sub

    Private Sub BotonVerRegistro_Click(sender As Object, e As EventArgs) Handles BotonVerRegistro.Click
        posicion = 0
        Dim primerRegistro As String = registros(posicion)
        Dim trozos() As String = primerRegistro.Split("*"c)

        nombre2txt.Text = trozos(0)
        apellidos2txt.Text = trozos(1)
        edad2txt.Text = trozos(2)
        correo2txt.Text = trozos(3)
        dni2txt.Text = trozos(4)
        fechadenacimiento2txt.Text = trozos(5)
    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Close()
    End Sub

    Private Sub BotonLimpiar_Click(sender As Object, e As EventArgs) Handles BotonLimpiar.Click
        nombretxt.Text = " "
        apellidostxt.Text = " "
        edadtxt.Text = " "
        correotxt.Text = " "
        dnitxt.Text = " "


        nombre2txt.Text = " "
        apellidos2txt.Text = " "
        edad2txt.Text = " "
        correo2txt.Text = " "
        dni2txt.Text = " "
        fechadenacimiento2txt.Text = " "

        dnibuscar.Text = " "
        dnieliminar.Text = " "
    End Sub

    Private Sub BotonEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BotonEliminarUsuario.Click
        For Each registro In listaregistros
            Dim trozos() As String = registro.Split("*"c)
            If trozos(4) = dnibuscar.Text Then
                listaregistros.Remove(registro)
            End If
        Next
    End Sub

    Private Sub BotonRetroceder_Click(sender As Object, e As EventArgs) Handles BotonRetroceder.Click
        If posicion > 0 Then
            posicion -= 1
            Dim registro As String = listaregistros(posicion)
            Dim trozos() As String = registro.Split("*"c)

            nombre2txt.Text = trozos(0)
            apellidos2txt.Text = trozos(1)
            edad2txt.Text = trozos(2)
            correo2txt.Text = trozos(3)
            dni2txt.Text = trozos(4)
            fechadenacimiento2txt.Text = trozos(5)
        Else
            posicion = 0
            Dim registro As String = listaregistros(posicion)
            Dim trozos() As String = registro.Split("*"c)

            nombre2txt.Text = trozos(0)
            apellidos2txt.Text = trozos(1)
            edad2txt.Text = trozos(2)
            correo2txt.Text = trozos(3)
            dni2txt.Text = trozos(4)
            fechadenacimiento2txt.Text = trozos(5)
        End If
    End Sub

    Private Sub Form8_FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MessageBox.Show("Gracias a los videos hice esta cosa tan de chicomontecastelo")
    End Sub
    Private Sub BotonGuardarUsuario_Click(sender As Object, e As EventArgs) Handles BotonGuardarUsuario.Click

        BotonValidarUsuario.PerformClick()

        If valido Then
            Dim escritor As StreamWriter = New StreamWriter(rutaFichero, True)
            Dim registro As String = nombre + "*" + apellidos + "*" + edad.ToString() + "*" + correo + "*" + dni.ToString + "*" + fechadenacimiento
            escritor.WriteLine(registro)
            escritor.Close()
            MessageBox.Show("Sacada de Montecastelo Hermano", "Tabien:)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Hermano algo te falla", "Cagaste", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BotonValidarUsuario_Click(sender As Object, e As EventArgs) Handles BotonValidarUsuario.Click
        If nombretxt.Text = "" Then
            nombretxt.Focus()
            lblasterisco.Visible = True
            nombretxt.BackColor = Color.Red
            valido = False
            Exit Sub
        Else
            nombre = nombretxt.Text
            lblasterisco.Visible = False
            nombretxt.BackColor = Color.White
            valido = True
        End If

        If apellidostxt.Text = "" Then
            apellidostxt.Focus()
            lblasteriscoapellidos.Visible = True
            apellidostxt.BackColor = Color.Red
            valido = False
            Exit Sub
        Else
            apellidos = apellidostxt.Text
            lblasteriscoapellidos.Visible = False
            apellidostxt.BackColor = Color.White
            valido = True
        End If

        If edadtxt.Text = "" Then
            edadtxt.Focus()
            lblasteriscoedad.Visible = True
            edadtxt.BackColor = Color.Red
            valido = False
            Exit Sub
        Else
            If Convert.ToInt32(edadtxt.Text) < 18 Then
                MessageBox.Show("Eres menor xD", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                edadtxt.Focus()
                lblasteriscoedad.Visible = True
                edadtxt.BackColor = Color.Red
                valido = False
                Exit Sub
            End If
            edad = CInt(edadtxt.Text)
            lblasteriscoedad.Visible = False
            apellidostxt.BackColor = Color.White
            valido = True
        End If

        If correotxt.Text = "" Then
            correotxt.Focus()
            lblasteriscocorreo.Visible = True
            correotxt.BackColor = Color.Red
            valido = False
            Exit Sub
        Else
            If correotxt.Text.Contains("@") And (correotxt.Text.Contains(".es") Or correotxt.Text.Contains(".com") Or correotxt.Text.Contains(".io") Or correotxt.Text.Contains(".org")) Then
                correo = correotxt.Text
                lblasteriscocorreo.Visible = False
                correotxt.BackColor = Color.White
                valido = True
            Else
                correotxt.Focus()
                lblasteriscocorreo.Visible = True
                correotxt.BackColor = Color.Red
                valido = False
                Exit Sub
            End If


        End If

            If dnitxt.Text = "" Then
            dnitxt.Focus()
            lblasteriscoDNI.Visible = True
            dnitxt.BackColor = Color.Red
            valido = False

            Exit Sub
        Else
            dni = dnitxt.Text

            If dni.Length <> 9 Then
            Else
                For i As Integer = 0 To dni.Length - 2 Step 1
                    If Not Char.IsDigit(dni(i)) Then
                        dnitxt.Focus()
                        lblasteriscoDNI.Visible = True
                        dnitxt.BackColor = Color.Red
                        valido = False
                        Exit Sub
                    End If
                Next

                'Validar si el último caracter es una letra
                If Not Char.IsLetter(dni(dni.Length - 1)) Then
                    dnitxt.Focus()
                    lblasteriscoDNI.Visible = True
                    dnitxt.BackColor = Color.Red
                    valido = False
                    Exit Sub
                End If

            End If


            Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
                'Obtener el número del dni
                Dim numeroDNI As String = dni.Substring(0, 8)
                Dim numeroDNIInteger As Integer = Convert.ToInt32(numeroDNI)

                Dim resto As Integer = numeroDNIInteger Mod 23

                dni = dni.ToUpper()

                If dni(dni.Length - 1) = letras(resto) Then
                lblasteriscoDNI.Visible = False
                dnitxt.BackColor = Color.White
                valido = True
            Else
                dnitxt.Focus()
                lblasteriscoDNI.Visible = True
                dnitxt.BackColor = Color.Red
                valido = False
                Exit Sub

                End If
            End If

        If apellidostxt.Text = "" Then
            apellidostxt.Focus()
            lblasteriscoapellidos.Visible = True
            apellidostxt.BackColor = Color.Red
            valido = False
            Exit Sub
        Else
            apellidos = apellidostxt.Text
            lblasteriscoapellidos.Visible = False
            apellidostxt.BackColor = Color.White
            valido = True
        End If


    End Sub
End Class