Option Strict On
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
    Public WithEvents btnCreateFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnCreateFile = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(129, 79)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCreateFile
        '
        Me.btnCreateFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreateFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCreateFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCreateFile.Location = New System.Drawing.Point(21, 79)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCreateFile.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateFile.TabIndex = 2
        Me.btnCreateFile.Text = "&Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click the Create File button to enter data and save it to a file."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(226, 114)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Name = "Form1"
        Me.Text = "File WriteLine Demo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' This application uses a structure to write
    ' data to a sequential text file.

    Private Const intNUM_FRIENDS As Integer = 3

    ' Declare a structure to hold friend information.
    Structure FriendInfo
        Dim strName As String       ' To hold a name
        Dim intAge As Integer       ' To hold an age
        Dim strAddress As String    ' To hold an address
    End Structure


    Private Sub btnCreateFile_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnCreateFile.Click

        ' This procedure prompts the user for data and
        ' saves it to a file.
        Dim strFilename As String   ' File name
        Dim intCount As Integer     ' Loop counter
        Dim myFriend As FriendInfo ' Structure variable
        Dim friendFile As System.IO.StreamWriter    ' Object variable

        ' Get the file name from the user.
        strFilename = InputBox("Enter the filename.", "Filename Needed")

        ' Open the file.
        friendFile = System.IO.File.CreateText(strFilename)

        ' Get the data for three friends and write it
        ' to the file.
        For intCount = 1 To intNUM_FRIENDS
            ' Get the data.
            MessageBox.Show("Get ready to enter data for friend " & _
                            intCount.ToString)
            myFriend.strName = InputBox("Enter your friend's name.")
            myFriend.intAge = CInt(InputBox("Enter your friend's age."))
            myFriend.strAddress = InputBox("Enter your friend's address.")

            ' Write the data to the file.
            friendFile.WriteLine(myFriend.strName)
            friendFile.WriteLine(myFriend.intAge)
            friendFile.WriteLine(myFriend.strAddress)
        Next intCount

        ' Close the file.
        friendFile.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class
