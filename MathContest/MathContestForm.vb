Option Strict On
Option Explicit On
Option Compare Text
'Malachi Marlow
'Spring 2025
'RCET2265
'MathContest
'https://github.com/MalachiMarlow/MathContest.git

Imports System.Security.Cryptography

Public Class MathContestForm


    Sub SetDefaults()
        NameTextBox.Text = " "
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        StudentAnswerTextBox.Enabled = ""
        FirstNumberTextBox.Text = CStr(RandomNumberGenerator(0, 100))

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
            FirstNumberTextBox.Text = CStr()
        End If
    End Sub

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
                message &= "Student is not eligible to compete" & vbNewLine
                AgeTextBox.Focus()
            ElseIf CInt(AgeTextBox.Text) > 11 Then
                valid = False
                message &= "Student is not eligible to compete" & vbNewLine
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

    Sub MathTime()
        If AddRadioButton.Checked Then
            Try
                If CInt(StudentAnswerTextBox.Text) = Add() Then
                    MsgBox("Correct")
                    ScoreC
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Function RandomNumberGenerator(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt(Math.Ceiling(max - min) * Rnd() + min)
    End Function

End Class
