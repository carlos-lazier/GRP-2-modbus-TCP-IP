Imports EasyModbus

Public Class Form1

    Dim ModClient As New ModbusClient

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        ModClient.IPAddress = txtIp.Text
        ModClient.Port = txtPorta.Text
        Try
            ModClient.Connect()
            If ModClient.Connected Then
                lblSituação.Text = "Conectado."
                btnConectar.Enabled = False
                btnDesconectar.Enabled = True
                grpLeitura.Enabled = True
            End If
        Catch ex As Exception
            lblSituação.Text = " erro de Conecção !"
        End Try
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        ModClient.Disconnect()
        lblSituação.Text = "Disconectado."
        btnConectar.Enabled = True
        btnDesconectar.Enabled = False
        grpLeitura.Enabled = False
    End Sub

    Private Sub btnleitura_Click(sender As Object, e As EventArgs) Handles btnleitura.Click
        Try
            Dim RegVals As Integer()
            RegVals = ModClient.ReadHoldingRegisters(txtinicio.Text, txtcomprimento.Text)
            If RegVals.Length > 0 Then
                lstregisvalores.Items.Clear()
                For Each value As Integer In RegVals
                    lstregisvalores.Items.Add(value)
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
