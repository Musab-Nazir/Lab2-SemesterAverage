<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSemesterAverage))
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse1Grade = New System.Windows.Forms.Label()
        Me.tbCourse1Input = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbCourse2Input = New System.Windows.Forms.TextBox()
        Me.tbCourse3Input = New System.Windows.Forms.TextBox()
        Me.tbCourse4Input = New System.Windows.Forms.TextBox()
        Me.tbCourse5Input = New System.Windows.Forms.TextBox()
        Me.tbCourse6Input = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCourse2Grade = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse3Grade = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse4Grade = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse5Grade = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse6Grade = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.tbSemesterAverage = New System.Windows.Forms.TextBox()
        Me.lblSemesterGrade = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.tbOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblCourse1
        '
        Me.lblCourse1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCourse1.Location = New System.Drawing.Point(0, 30)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course &1"
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse1Grade
        '
        Me.lblCourse1Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse1Grade.Location = New System.Drawing.Point(241, 30)
        Me.lblCourse1Grade.Name = "lblCourse1Grade"
        Me.lblCourse1Grade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourse1Grade.TabIndex = 2
        Me.lblCourse1Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbCourse1Input
        '
        Me.tbCourse1Input.Location = New System.Drawing.Point(119, 30)
        Me.tbCourse1Input.Name = "tbCourse1Input"
        Me.tbCourse1Input.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse1Input.TabIndex = 1
        Me.tbCourse1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse1Input, "Input Grade for Course")
        '
        'tbCourse2Input
        '
        Me.tbCourse2Input.Location = New System.Drawing.Point(119, 70)
        Me.tbCourse2Input.Name = "tbCourse2Input"
        Me.tbCourse2Input.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse2Input.TabIndex = 4
        Me.tbCourse2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse2Input, "Input Grade for Course")
        '
        'tbCourse3Input
        '
        Me.tbCourse3Input.Location = New System.Drawing.Point(119, 110)
        Me.tbCourse3Input.Name = "tbCourse3Input"
        Me.tbCourse3Input.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse3Input.TabIndex = 7
        Me.tbCourse3Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse3Input, "Input Grade for Course")
        '
        'tbCourse4Input
        '
        Me.tbCourse4Input.Location = New System.Drawing.Point(119, 150)
        Me.tbCourse4Input.Name = "tbCourse4Input"
        Me.tbCourse4Input.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse4Input.TabIndex = 10
        Me.tbCourse4Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse4Input, "Input Grade for Course")
        '
        'tbCourse5Input
        '
        Me.tbCourse5Input.Location = New System.Drawing.Point(119, 190)
        Me.tbCourse5Input.Name = "tbCourse5Input"
        Me.tbCourse5Input.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse5Input.TabIndex = 13
        Me.tbCourse5Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse5Input, "Input Grade for Course")
        '
        'tbCourse6Input
        '
        Me.tbCourse6Input.Location = New System.Drawing.Point(119, 230)
        Me.tbCourse6Input.Name = "tbCourse6Input"
        Me.tbCourse6Input.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse6Input.TabIndex = 16
        Me.tbCourse6Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse6Input, "Input Grade for Course")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(25, 464)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 18
        Me.btnEnter.Text = "En&ter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Press to calculate Semester Average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(129, 464)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Press to reset form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(241, 464)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Press to close form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCourse2Grade
        '
        Me.lblCourse2Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse2Grade.Location = New System.Drawing.Point(241, 70)
        Me.lblCourse2Grade.Name = "lblCourse2Grade"
        Me.lblCourse2Grade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourse2Grade.TabIndex = 5
        Me.lblCourse2Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse2
        '
        Me.lblCourse2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCourse2.Location = New System.Drawing.Point(0, 70)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course &2"
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse3Grade
        '
        Me.lblCourse3Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse3Grade.Location = New System.Drawing.Point(241, 110)
        Me.lblCourse3Grade.Name = "lblCourse3Grade"
        Me.lblCourse3Grade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourse3Grade.TabIndex = 8
        Me.lblCourse3Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse3
        '
        Me.lblCourse3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCourse3.Location = New System.Drawing.Point(0, 110)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course &3"
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse4Grade
        '
        Me.lblCourse4Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse4Grade.Location = New System.Drawing.Point(241, 150)
        Me.lblCourse4Grade.Name = "lblCourse4Grade"
        Me.lblCourse4Grade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourse4Grade.TabIndex = 11
        Me.lblCourse4Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse4
        '
        Me.lblCourse4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCourse4.Location = New System.Drawing.Point(0, 150)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course &4"
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse5Grade
        '
        Me.lblCourse5Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse5Grade.Location = New System.Drawing.Point(241, 190)
        Me.lblCourse5Grade.Name = "lblCourse5Grade"
        Me.lblCourse5Grade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourse5Grade.TabIndex = 14
        Me.lblCourse5Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse5
        '
        Me.lblCourse5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCourse5.Location = New System.Drawing.Point(0, 190)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course &5"
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourse6Grade
        '
        Me.lblCourse6Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse6Grade.Location = New System.Drawing.Point(241, 230)
        Me.lblCourse6Grade.Name = "lblCourse6Grade"
        Me.lblCourse6Grade.Size = New System.Drawing.Size(100, 20)
        Me.lblCourse6Grade.TabIndex = 17
        Me.lblCourse6Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCourse6
        '
        Me.lblCourse6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCourse6.Location = New System.Drawing.Point(0, 230)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course &6"
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbSemesterAverage
        '
        Me.tbSemesterAverage.Location = New System.Drawing.Point(119, 268)
        Me.tbSemesterAverage.Name = "tbSemesterAverage"
        Me.tbSemesterAverage.ReadOnly = True
        Me.tbSemesterAverage.Size = New System.Drawing.Size(100, 20)
        Me.tbSemesterAverage.TabIndex = 23
        Me.tbSemesterAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbSemesterAverage, "Input Grade for Course")
        '
        'lblSemesterGrade
        '
        Me.lblSemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterGrade.Location = New System.Drawing.Point(241, 268)
        Me.lblSemesterGrade.Name = "lblSemesterGrade"
        Me.lblSemesterGrade.Size = New System.Drawing.Size(100, 20)
        Me.lblSemesterGrade.TabIndex = 24
        Me.lblSemesterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSemester
        '
        Me.lblSemester.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSemester.Location = New System.Drawing.Point(0, 268)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(100, 23)
        Me.lblSemester.TabIndex = 22
        Me.lblSemester.Text = "&Semester"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(25, 305)
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ReadOnly = True
        Me.tbOutput.Size = New System.Drawing.Size(291, 142)
        Me.tbOutput.TabIndex = 25
        Me.tbOutput.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbOutput, "Displays Errors")
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(365, 505)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.tbSemesterAverage)
        Me.Controls.Add(Me.lblSemesterGrade)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbCourse6Input)
        Me.Controls.Add(Me.lblCourse6Grade)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.tbCourse5Input)
        Me.Controls.Add(Me.lblCourse5Grade)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.tbCourse4Input)
        Me.Controls.Add(Me.lblCourse4Grade)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.tbCourse3Input)
        Me.Controls.Add(Me.lblCourse3Grade)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.tbCourse2Input)
        Me.Controls.Add(Me.lblCourse2Grade)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.tbCourse1Input)
        Me.Controls.Add(Me.lblCourse1Grade)
        Me.Controls.Add(Me.lblCourse1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse1Grade As Label
    Friend WithEvents tbCourse1Input As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tbCourse2Input As TextBox
    Friend WithEvents lblCourse2Grade As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents tbCourse3Input As TextBox
    Friend WithEvents lblCourse3Grade As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents tbCourse4Input As TextBox
    Friend WithEvents lblCourse4Grade As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents tbCourse5Input As TextBox
    Friend WithEvents lblCourse5Grade As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents tbCourse6Input As TextBox
    Friend WithEvents lblCourse6Grade As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbSemesterAverage As TextBox
    Friend WithEvents lblSemesterGrade As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents tbOutput As RichTextBox
End Class
