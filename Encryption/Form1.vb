Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography

Public Class Form1

    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

    Dim filename As String

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        Dim sPlainText As String = Me.TextBox1.Text
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(Me.enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            Me.TextBox1.Text = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        Dim cypherTextBytes As Byte() = Convert.FromBase64String(Me.TextBox1.Text)
        Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes(cypherTextBytes.Length) As Byte
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Me.TextBox1.Text = Me.enc.GetString(plainTextBytes, 0, decryptedByteCount)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        Me.enc = New System.Text.UTF8Encoding
        Me.encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        Me.decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clrButton.Click
        TextBox1.Text = ""
    End Sub

    Private Sub dupButton_Click(sender As Object, e As EventArgs) Handles dupButton.Click
        Dim astr As String
        Dim bstr As String
        astr = TextBox1.Text
        bstr = astr + astr
        TextBox1.Text = bstr
    End Sub

    Private Sub Save(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dr As DialogResult
        dlgSave.FileName = filename
        dr = dlgSave.ShowDialog()
        If dr = DialogResult.OK Then
            Try
                Dim writerVar As StreamWriter
                writerVar = New StreamWriter(filename, False)
                writerVar.WriteLine(TextBox1.Text)
                writerVar.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim readerVar As StreamReader
        Dim dr As DialogResult
        dr = dlgOpen.ShowDialog()
        If dr = DialogResult.OK Then
            filename = dlgOpen.FileName
            readerVar = New StreamReader(dlgOpen.FileName)
            TextBox1.Text = readerVar.ReadToEnd()
            readerVar.Close()
            btnSave.Enabled = True
            btnOpen.Enabled = False
        End If
    End Sub
End Class