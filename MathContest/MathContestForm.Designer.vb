<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CurrentMathGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MathTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.CurrentMathGroupBox.SuspendLayout()
        Me.MathTypeGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(22, 10)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(516, 144)
        Me.StudentInfoGroupBox.TabIndex = 0
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(347, 73)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(45, 16)
        Me.GradeLabel.TabIndex = 7
        Me.GradeLabel.Text = "Grade"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(350, 92)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GradeTextBox.TabIndex = 6
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(197, 92)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AgeTextBox.TabIndex = 5
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(194, 73)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(32, 16)
        Me.AgeLabel.TabIndex = 4
        Me.AgeLabel.Text = "Age"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(6, 92)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 2
        '
        'NameLabel
        '
        Me.NameLabel.AccessibleDescription = "NameLabel"
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(3, 73)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(44, 16)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Name"
        '
        'CurrentMathGroupBox
        '
        Me.CurrentMathGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathGroupBox.Location = New System.Drawing.Point(22, 160)
        Me.CurrentMathGroupBox.Name = "CurrentMathGroupBox"
        Me.CurrentMathGroupBox.Size = New System.Drawing.Size(276, 245)
        Me.CurrentMathGroupBox.TabIndex = 1
        Me.CurrentMathGroupBox.TabStop = False
        Me.CurrentMathGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(36, 150)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(99, 16)
        Me.StudentAnswerLabel.TabIndex = 12
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(36, 91)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(105, 16)
        Me.SecondNumberLabel.TabIndex = 11
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(36, 28)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(83, 16)
        Me.FirstNumberLabel.TabIndex = 8
        Me.FirstNumberLabel.Text = "First Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(39, 169)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(149, 22)
        Me.StudentAnswerTextBox.TabIndex = 10
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(39, 110)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(149, 22)
        Me.SecondNumberTextBox.TabIndex = 9
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(39, 47)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(149, 22)
        Me.FirstNumberTextBox.TabIndex = 8
        '
        'MathTypeGroupBox
        '
        Me.MathTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathTypeGroupBox.Location = New System.Drawing.Point(304, 160)
        Me.MathTypeGroupBox.Name = "MathTypeGroupBox"
        Me.MathTypeGroupBox.Size = New System.Drawing.Size(234, 245)
        Me.MathTypeGroupBox.TabIndex = 4
        Me.MathTypeGroupBox.TabStop = False
        Me.MathTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(15, 169)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(67, 20)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(15, 126)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(73, 20)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(15, 87)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(77, 20)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(15, 47)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(53, 20)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(544, 12)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(188, 393)
        Me.ButtonsGroupBox.TabIndex = 5
        Me.ButtonsGroupBox.TabStop = False
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(6, 36)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(176, 66)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 123)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(176, 66)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(6, 210)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(176, 66)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(6, 298)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(176, 66)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 417)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.MathTypeGroupBox)
        Me.Controls.Add(Me.CurrentMathGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Form1"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.CurrentMathGroupBox.ResumeLayout(False)
        Me.CurrentMathGroupBox.PerformLayout()
        Me.MathTypeGroupBox.ResumeLayout(False)
        Me.MathTypeGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents CurrentMathGroupBox As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents MathTypeGroupBox As GroupBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
End Class
