'Malachi Marlow
'Spring 2025
'RCET2265
'MathContest
'https://github.com/MalachiMarlow/MathContest.git

Option Strict On
Option Explicit On
Option Compare Text


Imports System.Net.Security
Imports System.Security.Cryptography

Public Class MathContestForm
    ''' <summary>
    ''' Sets the default function for each text box and button.
    ''' </summary>
    Sub SetDefaults()
        NameTextBox.Text = " "
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        StudentAnswerTextBox.Enabled = False
        FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        SecondNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        MathTypeGroupBox.Enabled = False
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        AddRadioButton.Checked = True
        ScoreCounter(True, True)
        AttemptCounter(True, True)

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If CheckValid() = True Then
            StudentAnswerTextBox.Enabled = True
            SubmitButton.Enabled = True
            MathTypeGroupBox.Enabled = True
            If StudentAnswerTextBox.Text = "" Then

            Else
                MathTime()
            End If
            FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
            SecondNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        End If
    End Sub

    ''' <summary>
    ''' Checks if the student is between age of 7 & 11, and that grade is between 1 & 4
    ''' </summary>
    ''' <returns></returns>
    Function CheckValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If NameTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "Please enter your name." & vbNewLine
        End If

        Try
            If CInt(AgeTextBox.Text) < 7 Then
                valid = False
                message &= "Student not eligible to compete" & vbNewLine
                AgeTextBox.Focus()
            ElseIf CInt(AgeTextBox.Text) > 11 Then
                valid = False
                message &= "Student not eligible to compete" & vbNewLine
                AgeTextBox.Focus()
            End If
        Catch ex As Exception
            valid = False
            message &= "Please enter an age number" & vbNewLine
            AgeTextBox.Focus()
        End Try

        Try
            If CInt(GradeTextBox.Text) < 1 Then
                valid = False
                message &= "Student not eligible to compete" & vbNewLine
                GradeTextBox.Focus()
            ElseIf CInt(GradeTextBox.Text) > 4 Then
                valid = False
                message &= "Student not eligibile to compete" & vbNewLine
                GradeTextBox.Focus()
            End If
        Catch ex As Exception
            valid = False
            message &= "Please enter an age number" & vbNewLine
            GradeTextBox.Focus()
        End Try

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Critical, "Please enter your name, age and grade.")
        End If

        Return valid
    End Function

    Function add() As Integer
        Dim _add As Integer
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)

        _add = firstNumber + secondNumber

        Return _add
    End Function
    Function subtract() As Integer
        Dim _subtract As Integer
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)

        _subtract = firstNumber - secondNumber

        Return _subtract
    End Function
    Function multiply() As Integer
        Dim _multiply As Integer
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)

        _multiply = firstNumber * secondNumber

        Return _multiply
    End Function
    Function divide() As Integer
        Dim _divide As Integer
        Dim firstNumber As Integer = CInt(FirstNumberTextBox.Text)
        Dim secondNumber As Integer = CInt(SecondNumberTextBox.Text)

        _divide = firstNumber \ secondNumber

        Return _divide
    End Function
    ''' <summary>
    ''' Calculates the functions for each math button. ex, Addition, subtraction, ect. If wrong, displays an incorrect message.
    ''' </summary>
    Sub MathTime()
        If AddRadioButton.Checked Then
            Try
                If CInt(StudentAnswerTextBox.Text) = add() Then
                    MsgBox("Correct")
                    ScoreCounter()
                Else
                    MsgBox($"Incorrect, answer was {add()}")
                End If
                AttemptCounter()
            Catch ex As Exception
                MsgBox("Please enter a numeric value.")
                StudentAnswerTextBox.Focus()
            End Try
        ElseIf SubtractRadioButton.Focus Then
            Try
                If CInt(StudentAnswerTextBox.Text) = subtract() Then
                    MsgBox("Correct")
                    ScoreCounter()
                Else
                    MsgBox($"Incorrect, answer was {subtract()}")
                End If
                AttemptCounter()
            Catch ex As Exception
                MsgBox("Please enter a numeric value")
                StudentAnswerTextBox.Focus()
            End Try
        ElseIf MultiplyRadioButton.Checked Then
            Try
                If CInt(StudentAnswerTextBox.Text) = multiply() Then
                    MsgBox("Correct")
                    ScoreCounter()
                Else
                    MsgBox($"Incorrect, answer was {multiply()}")
                End If
                AttemptCounter()
            Catch ex As Exception
                MsgBox("Please enter a numeric value")
                StudentAnswerTextBox.Focus()
            End Try
        ElseIf DivideRadioButton.Checked Then
            Try
                If CInt(StudentAnswerTextBox.Text) = divide() Then
                    MsgBox("Correct")
                    ScoreCounter()
                Else
                    MsgBox($"Incorrect, answer was {divide()}")
                End If
                AttemptCounter()
            Catch ex As Exception
                MsgBox("Please enter a numeric value")
                StudentAnswerTextBox.Focus()
            End Try
        End If
    End Sub
    ''' <summary>
    ''' Generates a random number
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Function RandomNumberGenerator(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Math.Ceiling(max - min) * Rnd() + min)
    End Function

    Function ScoreCounter(Optional clear As Boolean = False, Optional reference As Boolean = False) As Integer
        Static _scoreCounter As Integer

        If clear = False And reference = False Then
            _scoreCounter += 1
        ElseIf clear = True Then
            _scoreCounter = 0
        End If
        Return _scoreCounter
    End Function

    Function AttemptCounter(Optional clear As Boolean = False, Optional reference As Boolean = False) As Integer
        Static _attemptCounter As Integer
        If _attemptCounter >= 1 Then
            SummaryButton.Enabled = True
        End If

        If clear = False And reference = False Then
            _attemptCounter += 1
        ElseIf clear = True Then
            _attemptCounter = 0
        End If

        Return _attemptCounter
    End Function

    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        SubmitButton.Enabled = True
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim currentCorrect As Integer = ScoreCounter(, True)
        Dim currentAttemps As Integer = AttemptCounter(, True)

        MsgBox($"{NameTextBox.Text} has gotten {currentCorrect} out of {currentAttemps}")
    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        SecondNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        SecondNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        SecondNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
        SecondNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))
    End Sub


End Class
