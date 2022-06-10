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
        ' text file create at \vb_contract_tracing\vb_contract_tracing\bin\Debug\<filename>.txt
        studentFile = My.Computer.FileSystem.OpenTextFileWriter(lastNameBox.Text.ToUpper() + ".txt", True)
        studentFile.WriteLine("FullName: " + lastNameBox.Text + ", " + nameBox.Text + " " + miBox.Text)
        studentFile.WriteLine("Student Number: " + studentNumberBox.Text)
        studentFile.WriteLine("Course: " + courseBox.Text + vbTab + "Year/Section: " + yrSecBox.Text)
        studentFile.WriteLine("Mobile Number: " + mobileNumberBox.Text)
        studentFile.WriteLine("Birthdate: " + birthdateBox.Text + vbTab + "Gender: " + yrSecBox.Text.ToUpper())
        studentFile.WriteLine("Address: " + vbNewLine + addressRichBox.Text)
        studentFile.Close()

        MessageBox.Show(lastNameBox.Text.ToUpper() + " text file successfully create.", "Information", MessageBoxButtons.OK
                        )


    End Sub
End Class
