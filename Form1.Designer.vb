<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.txtPorta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSituação = New System.Windows.Forms.Label()
        Me.grpLeitura = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtinicio = New System.Windows.Forms.TextBox()
        Me.txtcomprimento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnleitura = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstregisvalores = New System.Windows.Forms.ListBox()
        Me.grpLeitura.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(130, 29)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(100, 20)
        Me.txtIp.TabIndex = 1
        Me.txtIp.Text = "127.0.0.1"
        '
        'txtPorta
        '
        Me.txtPorta.Location = New System.Drawing.Point(130, 84)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(100, 20)
        Me.txtPorta.TabIndex = 3
        Me.txtPorta.Text = "502"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Porta"
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(289, 36)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(90, 41)
        Me.btnConectar.TabIndex = 4
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Enabled = False
        Me.btnDesconectar.Location = New System.Drawing.Point(447, 36)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(90, 41)
        Me.btnDesconectar.TabIndex = 5
        Me.btnDesconectar.Text = "Desconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Situação"
        '
        'lblSituação
        '
        Me.lblSituação.AutoSize = True
        Me.lblSituação.Location = New System.Drawing.Point(347, 95)
        Me.lblSituação.Name = "lblSituação"
        Me.lblSituação.Size = New System.Drawing.Size(10, 13)
        Me.lblSituação.TabIndex = 7
        Me.lblSituação.Text = "-"
        '
        'grpLeitura
        '
        Me.grpLeitura.Controls.Add(Me.lstregisvalores)
        Me.grpLeitura.Controls.Add(Me.Label6)
        Me.grpLeitura.Controls.Add(Me.btnleitura)
        Me.grpLeitura.Controls.Add(Me.txtcomprimento)
        Me.grpLeitura.Controls.Add(Me.Label5)
        Me.grpLeitura.Controls.Add(Me.txtinicio)
        Me.grpLeitura.Controls.Add(Me.Label4)
        Me.grpLeitura.Enabled = False
        Me.grpLeitura.Location = New System.Drawing.Point(95, 150)
        Me.grpLeitura.Name = "grpLeitura"
        Me.grpLeitura.Size = New System.Drawing.Size(200, 285)
        Me.grpLeitura.TabIndex = 8
        Me.grpLeitura.TabStop = False
        Me.grpLeitura.Text = "Leitura de Registros de Retenção"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Inicio"
        '
        'txtinicio
        '
        Me.txtinicio.Location = New System.Drawing.Point(80, 47)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(100, 20)
        Me.txtinicio.TabIndex = 1
        Me.txtinicio.Text = "0"
        '
        'txtcomprimento
        '
        Me.txtcomprimento.Location = New System.Drawing.Point(80, 73)
        Me.txtcomprimento.Name = "txtcomprimento"
        Me.txtcomprimento.Size = New System.Drawing.Size(100, 20)
        Me.txtcomprimento.TabIndex = 3
        Me.txtcomprimento.Text = "10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Comprimento"
        '
        'btnleitura
        '
        Me.btnleitura.Location = New System.Drawing.Point(80, 108)
        Me.btnleitura.Name = "btnleitura"
        Me.btnleitura.Size = New System.Drawing.Size(100, 23)
        Me.btnleitura.TabIndex = 4
        Me.btnleitura.Text = "Leitura"
        Me.btnleitura.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "valores"
        '
        'lstregisvalores
        '
        Me.lstregisvalores.FormattingEnabled = True
        Me.lstregisvalores.Location = New System.Drawing.Point(60, 146)
        Me.lstregisvalores.Name = "lstregisvalores"
        Me.lstregisvalores.Size = New System.Drawing.Size(120, 95)
        Me.lstregisvalores.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 447)
        Me.Controls.Add(Me.grpLeitura)
        Me.Controls.Add(Me.lblSituação)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.txtPorta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModBus TCP Cliente"
        Me.grpLeitura.ResumeLayout(False)
        Me.grpLeitura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIp As TextBox
    Friend WithEvents txtPorta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConectar As Button
    Friend WithEvents btnDesconectar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSituação As Label
    Friend WithEvents grpLeitura As GroupBox
    Friend WithEvents lstregisvalores As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnleitura As Button
    Friend WithEvents txtcomprimento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtinicio As TextBox
    Friend WithEvents Label4 As Label
End Class
