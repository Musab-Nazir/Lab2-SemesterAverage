'******************************************************************************
'Author:        Musab Nazir
'Date Written:  20 Feb 2018
'Project Name:  Semester Average Calculator
'Description:   The form lets a user input grades for 6 different courses and
'               calculates the grade average of the student
'******************************************************************************
Option Strict On
Public Class frmSemesterAverage

    Const TOTAL_COURSES As Integer = 6
    Const MINIMUM_GRADE As Integer = 0
    Const MAXIMUM_GRADE As Integer = 100

    'An array to store the grade values
    Dim GradesInput(TOTAL_COURSES - 1) As Double
    'An array to store which input passed or failed validation
    Dim InputTracker(TOTAL_COURSES - 1) As Boolean

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    'A validation function that returns an empty string if the input is valid or an
    'error message string depending on the error
    Private Function Validate_Input(ByVal input As String) As String
        Dim message As String
        Dim Temporary As Double
        If (Double.TryParse(input, Temporary)) Then
            If (Temporary >= MINIMUM_GRADE And Temporary <= MAXIMUM_GRADE) Then
                message = ""
            Else
                message = "INVALID RANGE: Please enter a number between " &
                MINIMUM_GRADE & " and " & MAXIMUM_GRADE
            End If
        Else
            message = "NOT A NUMBER: Please ensure that the input is a number"
        End If
        Return message
    End Function
    'The following function takes in the text input of a textbox and returns a letter grade
    'the argument passed to the function must already be validated
    Private Function Grade_Check(ByVal grade As Double) As String
        Dim gradeLetter As String = "NA"
        If (grade >= 90) Then
            gradeLetter = "A+"
        ElseIf (grade >= 80) Then
            gradeLetter = "A"
        ElseIf (grade >= 75) Then
            gradeLetter = "B+"
        ElseIf (grade >= 70) Then
            gradeLetter = "B"
        ElseIf (grade >= 65) Then
            gradeLetter = "C+"
        ElseIf (grade >= 60) Then
            gradeLetter = "C"
        ElseIf (grade >= 55) Then
            gradeLetter = "D+"
        ElseIf (grade >= 50) Then
            gradeLetter = "D"
        ElseIf (grade < 50) Then
            gradeLetter = "F"
        End If
        Return gradeLetter
    End Function
    Private Sub TextBox_LostFocus(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles tbCourse1Input.LostFocus, tbCourse2Input.LostFocus, tbCourse3Input.LostFocus,
    tbCourse4Input.LostFocus, tbCourse5Input.LostFocus, tbCourse6Input.LostFocus
        'Initialize the index for the grades array
        Dim Index As Integer = 0

        'Check which textbox is activating the event and if its text is valid
        'if both checks are passed, the input number is saved in the grades array and marked
        'as true for the input tracking array and the grade letter is displayed
        If (sender.Equals(tbCourse1Input)) Then
            Index = 0
            If (Validate_Input(tbCourse1Input.Text) = "") Then
                InputTracker(Index) = True
                GradesInput(Index) = Double.Parse(tbCourse1Input.Text)
                lblCourse1Grade.Text = Grade_Check(Double.Parse(tbCourse1Input.Text))
            Else
                'display error message if validation failed and select the text in the box
                InputTracker(Index) = False
                tbCourse1Input.Focus()
                tbCourse1Input.SelectAll()
                tbOutput.Text = "Course 1: " + Environment.NewLine + Validate_Input(tbCourse1Input.Text)
            End If

        End If

        If (sender.Equals(tbCourse2Input)) Then
            Index = 1
            If (Validate_Input(tbCourse2Input.Text) = "") Then
                InputTracker(Index) = True
                GradesInput(Index) = Double.Parse(tbCourse2Input.Text)
                lblCourse2Grade.Text = Grade_Check(Double.Parse(tbCourse2Input.Text))
            Else
                InputTracker(Index) = False
                tbCourse2Input.Focus()
                tbCourse2Input.SelectAll()
                tbOutput.Text = "Course 2: " + Environment.NewLine + Validate_Input(tbCourse2Input.Text)
            End If

        End If

        If (sender.Equals(tbCourse3Input)) Then
            Index = 2
            If (Validate_Input(tbCourse3Input.Text) = "") Then
                InputTracker(Index) = True
                GradesInput(Index) = Double.Parse(tbCourse3Input.Text)
                lblCourse3Grade.Text = Grade_Check(Double.Parse(tbCourse3Input.Text))
            Else
                InputTracker(Index) = False
                tbCourse3Input.Focus()
                tbCourse3Input.SelectAll()
                tbOutput.Text = "Course 3: " + Environment.NewLine + Validate_Input(tbCourse3Input.Text)
            End If

        End If

        If (sender.Equals(tbCourse4Input)) Then
            Index = 3
            If (Validate_Input(tbCourse4Input.Text) = "") Then
                InputTracker(Index) = True
                GradesInput(Index) = Double.Parse(tbCourse4Input.Text)
                lblCourse4Grade.Text = Grade_Check(Double.Parse(tbCourse4Input.Text))
            Else
                InputTracker(Index) = False
                tbCourse4Input.Focus()
                tbCourse4Input.SelectAll()
                tbOutput.Text = "Course 4: " + Environment.NewLine + Validate_Input(tbCourse4Input.Text)
            End If

        End If

        If (sender.Equals(tbCourse5Input)) Then
            Index = 4
            If (Validate_Input(tbCourse5Input.Text) = "") Then
                InputTracker(Index) = True
                GradesInput(Index) = Double.Parse(tbCourse5Input.Text)
                lblCourse5Grade.Text = Grade_Check(Double.Parse(tbCourse5Input.Text))
            Else
                InputTracker(Index) = False
                tbCourse5Input.Focus()
                tbCourse5Input.SelectAll()
                tbOutput.Text = "Course 5: " + Environment.NewLine + Validate_Input(tbCourse5Input.Text)
            End If

        End If

        If (sender.Equals(tbCourse6Input)) Then
            Index = 5
            If (Validate_Input(tbCourse6Input.Text) = "") Then
                InputTracker(Index) = True
                GradesInput(Index) = Double.Parse(tbCourse6Input.Text)
                lblCourse6Grade.Text = Grade_Check(Double.Parse(tbCourse6Input.Text))
            Else
                InputTracker(Index) = False
                tbCourse6Input.Focus()
                tbCourse6Input.SelectAll()
                tbOutput.Text = "Course 6: " + Environment.NewLine + Validate_Input(tbCourse6Input.Text)
            End If

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset all text boes and labels
        tbCourse1Input.ResetText()
        tbCourse2Input.ResetText()
        tbCourse3Input.ResetText()
        tbCourse4Input.ResetText()
        tbCourse5Input.ResetText()
        tbCourse6Input.ResetText()
        tbSemesterAverage.ResetText()

        tbCourse1Input.ReadOnly = False
        tbCourse2Input.ReadOnly = False
        tbCourse3Input.ReadOnly = False
        tbCourse4Input.ReadOnly = False
        tbCourse5Input.ReadOnly = False
        tbCourse6Input.ReadOnly = False

        lblCourse1Grade.ResetText()
        lblCourse2Grade.ResetText()
        lblCourse3Grade.ResetText()
        lblCourse4Grade.ResetText()
        lblCourse5Grade.ResetText()
        lblCourse6Grade.ResetText()
        lblSemesterGrade.ResetText()
        tbOutput.ResetText()

        'reset the array storing the grades
        Array.Clear(GradesInput, index:=0, length:=TOTAL_COURSES)
        Array.Clear(InputTracker, index:=0, length:=TOTAL_COURSES)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Create a flag so check if all inputs were valid
        Dim haveAllInputs As Boolean = True

        'Make all input text boxes read only
        tbCourse1Input.ReadOnly = True
        tbCourse2Input.ReadOnly = True
        tbCourse3Input.ReadOnly = True
        tbCourse4Input.ReadOnly = True
        tbCourse5Input.ReadOnly = True
        tbCourse6Input.ReadOnly = True
        tbOutput.ResetText()

        'Iterate through the input tracking array to ensure all inputs were valid
        For counter As Integer = 0 To (InputTracker.Length - 1)
            If (InputTracker(counter) = False) Then
                'if an input is not valid, display which course grade is causing the issue
                haveAllInputs = False
                tbOutput.AppendText("Please ensure what you input in " & "Course " & (counter + 1) &
                                    " is a number between " & MINIMUM_GRADE & " and " & MAXIMUM_GRADE &
                                     Environment.NewLine)
            End If
        Next

        'if all inputs were valid, iterate through the grades array and calulate average
        If (haveAllInputs = True) Then
            Dim average As Double
            For counter As Integer = 0 To (GradesInput.Length - 1)
                average += GradesInput(counter) / TOTAL_COURSES
            Next

            'display average to 2 decimal points and letter grade
            tbSemesterAverage.Text = average.ToString("n2")
            lblSemesterGrade.Text = Grade_Check(average)
        End If
    End Sub
End Class
