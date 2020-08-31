Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnRead As System.Windows.Forms.Button
    Public WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(197, 232)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnRead.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRead.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRead.Location = New System.Drawing.Point(109, 232)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRead.TabIndex = 4
        Me.btnRead.Text = "&Read File"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCreate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCreate.Location = New System.Drawing.Point(21, 232)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "&Create File"
        '
        'lstOutput
        '
        Me.lstOutput.Location = New System.Drawing.Point(8, 8)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(272, 199)
        Me.lstOutput.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lstOutput, Me.btnExit, Me.btnRead, Me.btnCreate})
        Me.Name = "Form1"
        Me.Text = "File Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const strFILENAME As String = "Numbers.txt"

    Private Sub btnCreate_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnCreate.Click

        ' This procedure creates the file and stores
        ' the numbers entered by the user.

        Dim outputFile As StreamWriter
        Dim intMaxNumbers As Integer   ' The number of values
        Dim intCount As Integer        ' Loop counter
        Dim intNumber As Integer       ' User input

        ' Get the number of numbers from the user.
        Integer.TryParse(InputBox("How many integers " _
            & "do you want to enter?"), intMaxNumbers)

        ' Create the file.
        outputFile = File.CreateText(strFILENAME)

        ' Get the numbers and write them to the file.
        For intCount = 1 To intMaxNumbers

            Integer.TryParse(InputBox("Enter an integer."), intNumber)

            outputFile.WriteLine(intNumber)

        Next intCount

        ' Close the file.
        outputFile.Close()
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnRead.Click

        ' This procedure opens the file, reads all the values
        ' from the file, and adds them to the list box.

        Dim inputFile As StreamReader

        If File.Exists(strFILENAME) Then
            inputFile = File.OpenText(strFILENAME)
            lstOutput.Items.Clear()
            Do Until inputFile.Peek = -1
                lstOutput.Items.Add(inputFile.ReadLine)
            Loop
            inputFile.Close()
        Else
            MessageBox.Show("File not found: " & strFILENAME, _
                "Error")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class
