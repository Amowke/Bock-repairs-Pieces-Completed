Imports System.ComponentModel
Public Class Form1
    Private TotalPieces As Decimal = 0
    Private TotalPay As Decimal = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Focus()
        PiecesTextBox.TextAlign = HorizontalAlignment.Right
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        NameTextBox.Clear()
        PiecesTextBox.Clear()
        NameTextBox.Focus()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click, CloseToolStripMenuItem.Click
        Dim closeForSure As String = "Do you want to close the form?"
        Dim result As DialogResult = MessageBox.Show(closeForSure, "Quit?", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click
        Try
            Dim amountEarned As Decimal
            Dim piecesCompleted As Integer = PiecesTextBox.Text
            Dim RATE1 As Single = 80
            Dim RATE2 As Single = 85
            Dim RATE3 As Single = 90
            Dim RATE4 As Single = 95

            Select Case piecesCompleted
                Case 1 To 200
                    amountEarned = PiecesTextBox.Text * RATE1
                Case 201 To 400
                    amountEarned = PiecesTextBox.Text * RATE2
                Case 401 To 600
                    amountEarned = PiecesTextBox.Text * RATE3
                Case Else
                    amountEarned = PiecesTextBox.Text * RATE4
            End Select
            TotalPay += amountEarned
            TotalPieces += piecesCompleted

            Dim message As String = "Amount Earned: " & amountEarned
            MessageBox.Show(message, "Amount Earned", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Quantity must be numbers only", "Input Error !", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click, SummaryToolStripMenuItem.Click
        Dim averagepay As Decimal = 0

        ' Check if TotalPieces is not zero to avoid division by zero error
        If TotalPieces <> 0 Then
            averagepay = TotalPay / TotalPieces
        End If
        Dim message As String = "Total number of pieces: " & TotalPieces.ToString("N") &
            ControlChars.NewLine & "Total Pay: " & TotalPay.ToString("C2") & ControlChars.NewLine & "Average Pay: " & averagepay.ToString("C2")
        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub NameTextBox_Valdating(sender As Object, e As CancelEventArgs) Handles NameTextBox.Validating
        'Validate the NameTexbox
        If NameTextBox.Text = String.Empty Then
            e.Cancel = True
            ErrorProvider1.SetError(NameTextBox, "Name is required")
        Else
            ErrorProvider1.SetError(NameTextBox, "")
        End If
    End Sub

    Private Sub PiecesTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PiecesTextBox.Validating
        'Validate the PiecesTextbox
        Dim value As Integer

        If Not Integer.TryParse(PiecesTextBox.Text, value) Then
            e.Cancel = True
            ErrorProvider1.SetError(PiecesTextBox, "Only numeric values are allowed.")
        Else
            ErrorProvider1.SetError(PiecesTextBox, "")

        End If
    End Sub

End Class
