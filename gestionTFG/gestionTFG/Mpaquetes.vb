Public Class Mpaquetes
    Dim qr_generador As New MessagingToolkit.QRCode.Codec.QRCodeEncoder

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = qr_generador.Encode(TextBox1.Text)
    End Sub

End Class