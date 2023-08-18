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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabChequeo = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbBajo = New System.Windows.Forms.RadioButton()
        Me.rbMedio = New System.Windows.Forms.RadioButton()
        Me.rbAlto = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbJaqueca = New System.Windows.Forms.RadioButton()
        Me.rbMareado = New System.Windows.Forms.RadioButton()
        Me.rbFiebre = New System.Windows.Forms.RadioButton()
        Me.rbGanasDeVomitar = New System.Windows.Forms.RadioButton()
        Me.rbDoloresMusculares = New System.Windows.Forms.RadioButton()
        Me.rbFatiga = New System.Windows.Forms.RadioButton()
        Me.tabBajo = New System.Windows.Forms.TabPage()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabControl1.SuspendLayout()
        Me.tabChequeo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabBajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabChequeo)
        Me.TabControl1.Controls.Add(Me.tabBajo)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 426)
        Me.TabControl1.TabIndex = 0
        '
        'tabChequeo
        '
        Me.tabChequeo.BackColor = System.Drawing.Color.DimGray
        Me.tabChequeo.Controls.Add(Me.TextBox1)
        Me.tabChequeo.Controls.Add(Me.Label1)
        Me.tabChequeo.Controls.Add(Me.txtNombre)
        Me.tabChequeo.Controls.Add(Me.lblNombre)
        Me.tabChequeo.Controls.Add(Me.btnCheck)
        Me.tabChequeo.Controls.Add(Me.GroupBox2)
        Me.tabChequeo.Controls.Add(Me.GroupBox1)
        Me.tabChequeo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tabChequeo.Location = New System.Drawing.Point(4, 22)
        Me.tabChequeo.Name = "tabChequeo"
        Me.tabChequeo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChequeo.Size = New System.Drawing.Size(768, 400)
        Me.tabChequeo.TabIndex = 0
        Me.tabChequeo.Text = "Chequeo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(531, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(92, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(30, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Lime
        Me.btnCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCheck.Location = New System.Drawing.Point(602, 227)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Guardar"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.rbBajo)
        Me.GroupBox2.Controls.Add(Me.rbMedio)
        Me.GroupBox2.Controls.Add(Me.rbAlto)
        Me.GroupBox2.Location = New System.Drawing.Point(477, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nivel de Sintoma"
        '
        'rbBajo
        '
        Me.rbBajo.AutoSize = True
        Me.rbBajo.Location = New System.Drawing.Point(18, 88)
        Me.rbBajo.Name = "rbBajo"
        Me.rbBajo.Size = New System.Drawing.Size(46, 17)
        Me.rbBajo.TabIndex = 5
        Me.rbBajo.TabStop = True
        Me.rbBajo.Text = "Bajo"
        Me.rbBajo.UseVisualStyleBackColor = True
        '
        'rbMedio
        '
        Me.rbMedio.AutoSize = True
        Me.rbMedio.Location = New System.Drawing.Point(18, 54)
        Me.rbMedio.Name = "rbMedio"
        Me.rbMedio.Size = New System.Drawing.Size(54, 17)
        Me.rbMedio.TabIndex = 4
        Me.rbMedio.TabStop = True
        Me.rbMedio.Text = "Medio"
        Me.rbMedio.UseVisualStyleBackColor = True
        '
        'rbAlto
        '
        Me.rbAlto.AutoSize = True
        Me.rbAlto.Location = New System.Drawing.Point(18, 19)
        Me.rbAlto.Name = "rbAlto"
        Me.rbAlto.Size = New System.Drawing.Size(43, 17)
        Me.rbAlto.TabIndex = 3
        Me.rbAlto.TabStop = True
        Me.rbAlto.Text = "Alto"
        Me.rbAlto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.rbJaqueca)
        Me.GroupBox1.Controls.Add(Me.rbMareado)
        Me.GroupBox1.Controls.Add(Me.rbFiebre)
        Me.GroupBox1.Controls.Add(Me.rbGanasDeVomitar)
        Me.GroupBox1.Controls.Add(Me.rbDoloresMusculares)
        Me.GroupBox1.Controls.Add(Me.rbFatiga)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sintomas que Presenta:"
        '
        'rbJaqueca
        '
        Me.rbJaqueca.AutoSize = True
        Me.rbJaqueca.Location = New System.Drawing.Point(6, 134)
        Me.rbJaqueca.Name = "rbJaqueca"
        Me.rbJaqueca.Size = New System.Drawing.Size(66, 17)
        Me.rbJaqueca.TabIndex = 7
        Me.rbJaqueca.TabStop = True
        Me.rbJaqueca.Text = "Jaqueca"
        Me.rbJaqueca.UseVisualStyleBackColor = True
        '
        'rbMareado
        '
        Me.rbMareado.AutoSize = True
        Me.rbMareado.Location = New System.Drawing.Point(6, 111)
        Me.rbMareado.Name = "rbMareado"
        Me.rbMareado.Size = New System.Drawing.Size(55, 17)
        Me.rbMareado.TabIndex = 6
        Me.rbMareado.TabStop = True
        Me.rbMareado.Text = "Mareo"
        Me.rbMareado.UseVisualStyleBackColor = True
        '
        'rbFiebre
        '
        Me.rbFiebre.AutoSize = True
        Me.rbFiebre.Location = New System.Drawing.Point(6, 88)
        Me.rbFiebre.Name = "rbFiebre"
        Me.rbFiebre.Size = New System.Drawing.Size(54, 17)
        Me.rbFiebre.TabIndex = 5
        Me.rbFiebre.TabStop = True
        Me.rbFiebre.Text = "Fiebre"
        Me.rbFiebre.UseVisualStyleBackColor = True
        '
        'rbGanasDeVomitar
        '
        Me.rbGanasDeVomitar.AutoSize = True
        Me.rbGanasDeVomitar.Location = New System.Drawing.Point(6, 65)
        Me.rbGanasDeVomitar.Name = "rbGanasDeVomitar"
        Me.rbGanasDeVomitar.Size = New System.Drawing.Size(68, 17)
        Me.rbGanasDeVomitar.TabIndex = 4
        Me.rbGanasDeVomitar.TabStop = True
        Me.rbGanasDeVomitar.Text = "Nauceas"
        Me.rbGanasDeVomitar.UseVisualStyleBackColor = True
        '
        'rbDoloresMusculares
        '
        Me.rbDoloresMusculares.AutoSize = True
        Me.rbDoloresMusculares.Location = New System.Drawing.Point(6, 42)
        Me.rbDoloresMusculares.Name = "rbDoloresMusculares"
        Me.rbDoloresMusculares.Size = New System.Drawing.Size(96, 17)
        Me.rbDoloresMusculares.TabIndex = 3
        Me.rbDoloresMusculares.TabStop = True
        Me.rbDoloresMusculares.Text = "Dolor Muscular"
        Me.rbDoloresMusculares.UseVisualStyleBackColor = True
        '
        'rbFatiga
        '
        Me.rbFatiga.AutoSize = True
        Me.rbFatiga.Location = New System.Drawing.Point(6, 19)
        Me.rbFatiga.Name = "rbFatiga"
        Me.rbFatiga.Size = New System.Drawing.Size(54, 17)
        Me.rbFatiga.TabIndex = 2
        Me.rbFatiga.TabStop = True
        Me.rbFatiga.Text = "Fatiga"
        Me.rbFatiga.UseVisualStyleBackColor = True
        '
        'tabBajo
        '
        Me.tabBajo.BackColor = System.Drawing.Color.RosyBrown
        Me.tabBajo.Controls.Add(Me.lblResultado)
        Me.tabBajo.Controls.Add(Me.ProgressBar1)
        Me.tabBajo.Location = New System.Drawing.Point(4, 22)
        Me.tabBajo.Name = "tabBajo"
        Me.tabBajo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBajo.Size = New System.Drawing.Size(768, 400)
        Me.tabBajo.TabIndex = 1
        Me.tabBajo.Text = "Resultado"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(19, 79)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(39, 13)
        Me.lblResultado.TabIndex = 1
        Me.lblResultado.Text = "Label2"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 175)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(756, 150)
        Me.ProgressBar1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabChequeo.ResumeLayout(False)
        Me.tabChequeo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabBajo.ResumeLayout(False)
        Me.tabBajo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabChequeo As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tabBajo As TabPage
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents rbBajo As RadioButton
    Friend WithEvents rbMedio As RadioButton
    Friend WithEvents rbAlto As RadioButton
    Friend WithEvents rbJaqueca As RadioButton
    Friend WithEvents rbMareado As RadioButton
    Friend WithEvents rbFiebre As RadioButton
    Friend WithEvents rbGanasDeVomitar As RadioButton
    Friend WithEvents rbDoloresMusculares As RadioButton
    Friend WithEvents rbFatiga As RadioButton
    Friend WithEvents lblResultado As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
