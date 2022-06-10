Public Class Form1
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameBox.Text = ""
        miBox.Text = ""
        lastNameBox.Text = ""
        studentNumberBox.Text = ""
        yrSecBox.Text = ""
        mobileNumberBox.Text = ""
        courseBox.Text = ""
        birthdateBox.Text = ""
        genderBox.Text = ""
        addressRichBox.Text = ""

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim studentFile As System.IO.StreamWriter

        Dim fileName As String
        fileName = lastNameBox.Text.ToUpper() + ".txt" ' file text creator





        MessageBox.Show(lastNameBox.Text.ToUpper() + " text file successfully create.", "Information", MessageBoxButtons.OK
                        )
        If lastNameBox.Text <> "" Then
            If System.IO.File.Exists(fileName) Then
                MessageBox.Show("file already exist, create another text file.")
            Else
                ' file path at \vb_contract_tracing\vb_contract_tracing\bin\Debug\<filename>.txt
                studentFile = My.Computer.FileSystem.OpenTextFileWriter(fileName, True)
                studentFile.WriteLine("FullName: " + lastNameBox.Text + ", " + nameBox.Text + " " + miBox.Text)
                studentFile.WriteLine("Student Number: " + studentNumberBox.Text)
                studentFile.WriteLine("Course: " + courseBox.Text + vbTab + "Year/Section: " + yrSecBox.Text)
                studentFile.WriteLine("Mobile Number: " + mobileNumberBox.Text)
                studentFile.WriteLine("Birthdate: " + birthdateBox.Text + vbTab + "Gender: " + yrSecBox.Text.ToUpper())
                studentFile.WriteLine("Address: " + vbNewLine + addressRichBox.Text)
                studentFile.Close()
            End If
        Else
            MessageBox.Show("Fill-up missing form.")
        End If

    End Sub
End Class
