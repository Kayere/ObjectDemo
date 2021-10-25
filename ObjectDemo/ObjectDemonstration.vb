Public Class ObjectDemonstration

    Private Sub ObjectDemonstration_load(sender As Object, e As EventArgs) Handles Me.Load
        CenterToScreen()
    End Sub

    Dim CurrentStyle As FontStyle
    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        DisplayTextBox.Font = New Font("Garamond", 11)
        setFontStyle(CurrentStyle)
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        DisplayTextBox.Font = New Font("Magneto", 11)
        setFontStyle(CurrentStyle)
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        DisplayTextBox.Font = New Font("Tahoma", 11)
        setFontStyle(CurrentStyle)
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        DisplayTextBox.ForeColor = Color.Green
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        DisplayTextBox.ForeColor = Color.Blue
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        DisplayTextBox.ForeColor = Color.Red
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged
        If ItalicCheckBox.Checked Then
            If BoldCheckBox.Checked Or BoldItalicCheckBox.Checked Then
                setFontStyle(FontStyle.Italic, FontStyle.Bold)
            Else
                setFontStyle(FontStyle.Italic)
            End If
        Else
            removeFontStyle()
        End If
    End Sub

    Private Sub BoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldCheckBox.CheckedChanged
        If BoldCheckBox.Checked Then
            If ItalicCheckBox.Checked Or BoldItalicCheckBox.Checked Then
                setFontStyle(FontStyle.Bold, FontStyle.Italic)
            Else
                setFontStyle(FontStyle.Bold)
            End If
        Else
            removeFontStyle()
        End If
    End Sub

    Private Sub BoldItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicCheckBox.CheckedChanged
        If BoldItalicCheckBox.Checked Then
            setFontStyle(FontStyle.Bold, FontStyle.Italic)
        Else
            removeFontStyle()
        End If
    End Sub

    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        PictureBox.Image = Image.FromFile("C:\Users\brain\Downloads\pexels-oleg-magni-1005644.jpg")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub ObjectDemonstration_Close(sender As Object, e As EventArgs) Handles Me.Closing
        WelcomingForm.Show()
    End Sub

    Private Sub setFontStyle(style1 As FontStyle, Optional style2 As FontStyle = FontStyle.Regular)
        Dim fontStyle As FontStyle
        If style2 <> FontStyle.Regular Then
            fontStyle = style1 Or style2
        Else
            fontStyle = style1
        End If

        CurrentStyle = fontStyle

        If GaramondRadioButton.Checked Then
            DisplayTextBox.Font = New Font("Garamond", 11, fontStyle)
        ElseIf MagnetoRadioButton.Checked Then
            DisplayTextBox.Font = New Font("Magneto", 11, fontStyle)
        ElseIf TahomaRadioButton.Checked Then
            DisplayTextBox.Font = New Font("Tahoma", 11, fontStyle)
        Else
            DisplayTextBox.Font = New Font("Sitka", 11, fontStyle)
        End If
    End Sub

    Private Sub removeFontStyle()
        If BoldItalicCheckBox.Checked Or (BoldCheckBox.Checked And ItalicCheckBox.Checked) Then
            setFontStyle(FontStyle.Bold, FontStyle.Italic)
        ElseIf ItalicCheckBox.Checked Then
            setFontStyle(FontStyle.Italic)
        ElseIf BoldCheckBox.Checked Then
            setFontStyle(FontStyle.Bold)
        Else
            setFontStyle(FontStyle.Regular)
        End If
    End Sub

End Class