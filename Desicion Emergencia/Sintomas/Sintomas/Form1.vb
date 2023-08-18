Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim nombre As String = txtNombre.Text
        Dim sintoma As String = ""
        Dim nivel As String = ""

        If rbMareado.Checked Then
            sintoma = "mareado"
        ElseIf rbGanasDeVomitar.Checked Then
            sintoma = "ganas de vomitar"
        ElseIf rbFiebre.Checked Then
            sintoma = "fiebre"
        ElseIf rbDoloresMusculares.Checked Then
            sintoma = "dolores musculares"
        ElseIf rbFatiga.Checked Then
            sintoma = "fatiga"
        ElseIf rbJaqueca.Checked Then
            sintoma = "jaqueca"
        End If

        If rbBajo.Checked Then
            nivel = "bajo"
        ElseIf rbMedio.Checked Then
            nivel = "medio"
        ElseIf rbAlto.Checked Then
            nivel = "alto"
        End If

        Dim resultado As String = ""

        Select Case sintoma
            Case "mareado"
                Select Case nivel
                    Case "bajo"
                        resultado = "Tomar un descanso en casa."
                    Case "medio"
                        resultado = "Tome un acetaminofén y descanse."
                    Case "alto"
                        resultado = "Evitar todo tipo de movimiento y descansar."
                End Select

            Case "ganas de vomitar"
                Select Case nivel
                    Case "bajo"
                        resultado = "Oler alcohol."
                    Case "medio"
                        resultado = "Tomar una pastilla gástrica."
                    Case "alto"
                        resultado = "Tomar una pastilla y estar en supervisión."
                End Select
            Case "fiebre"
                Select Case nivel
                    Case "bajo"
                        resultado = "Tomar una aspirina."
                    Case "medio"
                        resultado = "Que se le aplique una inyección."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select
            Case "dolores musculares"
                Select Case nivel
                    Case "bajo"
                        resultado = "Hacer uso de una crema."
                    Case "medio"
                        resultado = "Tomar un calmante."
                    Case "alto"
                        resultado = "Recibir sesiones de masajes."
                End Select
            Case "fatiga"
                Select Case nivel
                    Case "bajo"
                        resultado = "Proporcionar oxígeno."
                    Case "medio"
                        resultado = "Usar un respirador."
                    Case "alto"
                        resultado = "Acudir a un centro Hospital."
                End Select
            Case "jaqueca"
                Select Case nivel
                    Case "bajo"
                        resultado = "Evitar la exposicion a pantallas e Hidratate."
                    Case "medio"
                        resultado = "Consultar a un medico para receta de medicamentos."
                    Case "alto"
                        resultado = "Necesita atencion medica urgente."
                End Select
        End Select

        lblResultado.Text = $"Apreciado/a {nombre}, con relacion a su síntoma de {sintoma} , junto a su nivel de molestia {nivel}, se le recomienda: {resultado}"

        ' Asegurarse de establecer el valor máximo de ProgressBar1 (puede ser 100 o cualquier otro valor deseado)
        ProgressBar1.Maximum = 100

        ' Establecer el valor de ProgressBar1 en función del nivel
        Select Case nivel
            Case "bajo"
                ProgressBar1.Value = 30
            Case "medio"
                ProgressBar1.Value = 60
            Case "alto"
                ProgressBar1.Value = 100
        End Select

        ' Mostrar la barra de progreso
        ProgressBar1.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
    End Sub

    Private Sub tabChequeo_Click(sender As Object, e As EventArgs) Handles tabChequeo.Click

    End Sub
End Class
