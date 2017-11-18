Public Class Form1
    Dim height As Decimal
    Dim height_in_metre As Decimal
    Dim weight As Decimal
    Dim BMIValue As Decimal
    Dim BMI_Final_Value As Decimal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Text = BMI(Text1.Text, Text2.Text)
        Status(Label4.Text)

    End Sub
    Private Function BMI(ByVal height, ByVal weight)

        height_in_metre = height / 100
        BMIValue = (weight) / (height_in_metre ^ 2)
        BMI = Format(BMIValue, "0.00")

    End Function

    Private Function Status(ByVal BMI_Final_Value)
        If (BMI_Final_Value <= 18.5) Then
            MessageBox.Show("Your BMI is Underweight")
        ElseIf (BMI_Final_Value <= 24.9) Then
            MessageBox.Show("Your BMI is Normal")
        ElseIf (BMI_Final_Value <= 29.9) Then
            MessageBox.Show("Your BMI is Overweight")
        Else
            MessageBox.Show("Your BMI is Obese")
        End If
    End Function
End Class
