Public Class frmCalculator
    Private Const APP_TITLE = "My Calculator"
    Private num1 As Double
    Private num2 As Double
    Private result As Double
    Private strFormattedCalculation As String
    Private strFormat As String

    Private Sub Calculate(ByRef objButton As Button)
        'Perform the specified calculation on the operands, format the result
        'and update txtResult.
        'Need to get the tag of the button to compose the text for txtResults.
        Dim strTag As String = objButton.Tag

        Select Case objButton.Text
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "X"
                result = num1 * num2
            Case "÷"
                result = num1 / num2
        End Select

        strFormattedCalculation = String.Format(strFormat, result)
        txtResult.Text = $"{strTag} {num1} and {num2} is {strFormattedCalculation}"
    End Sub
    Private Function ValidateOperands() As Boolean
        'Both operands must be valid numeric values.
        'Additionally, if the selected operation is division, the
        'second operand must not be 0
        'If both operands are valid, store in form level variables as
        'actual numbers so that all procedures can access them

        Dim strButtonName As String = Me.ActiveControl.Name

        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            If strButtonName = "btnDivide" Then
                If CDbl(txtSecondNum.Text) = 0 Then
                    MessageBox.Show("Denominator cannot be 0.", APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End If

            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            Return True
        Else
            MessageBox.Show("One or more operands is not a valid number.", APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set default precision
        cboDecimals.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Cast the sender object as a Button so that Calculate() can extract
        'various properties such as Text and Tag, which determine the operation
        'to be performed and the precision of the result, respectively.

        Dim objButton As Button = CType(sender, Button)

        If ValidateOperands() Then
            Calculate(objButton)
        End If
    End Sub

    Private Sub cboDecimals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDecimals.SelectedIndexChanged
        'Update the format string
        strFormat = $"{{0:f{cboDecimals.Text}}}"
        'If txtResult has a value, update the calculated result using the updated
        'format string
        If txtResult.Text <> "" Then
            Dim strNewFormattedCalculation As String = String.Format(strFormat, result)
            txtResult.Text = Replace(txtResult.Text, "is " & strFormattedCalculation, "is " & strNewFormattedCalculation)
            strFormattedCalculation = strNewFormattedCalculation
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        'Cast the sender object as a Button so that Calculate() can extract
        'various properties such as Text and Tag, which determine the operation
        'to be performed and the precision of the result, respectively.

        Dim objButton As Button = CType(sender, Button)

        If ValidateOperands() Then
            Calculate(objButton)
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'Cast the sender object as a Button so that Calculate() can extract
        'various properties such as Text and Tag, which determine the operation
        'to be performed and the precision of the result, respectively.

        Dim objButton As Button = CType(sender, Button)

        If ValidateOperands() Then
            Calculate(objButton)
        End If
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'Cast the sender object as a Button so that Calculate() can extract
        'various properties such as Text and Tag, which determine the operation
        'to be performed and the precision of the result, respectively.

        Dim objButton As Button = CType(sender, Button)

        If ValidateOperands() Then
            Calculate(objButton)
        End If
    End Sub

    Private Sub TextChangedEvent(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged, txtSecondNum.TextChanged
        txtResult.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim arTextBoxes As New ArrayList()
        With arTextBoxes
            .Add(txtFirstNum)
            .Add(txtSecondNum)
            .Add(txtResult)
        End With

        For Each obj As TextBox In arTextBoxes
            obj.Clear()
        Next
    End Sub
End Class
