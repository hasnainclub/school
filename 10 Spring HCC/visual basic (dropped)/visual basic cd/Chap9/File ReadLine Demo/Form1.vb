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
    Public WithEvents btnlear As System.Windows.Forms.Button
    Public WithEvents btnRead As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstFriends As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnlear = New System.Windows.Forms.Button
        Me.btnRead = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.lstFriends = New System.Windows.Forms.ListBox
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(270, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 33)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnlear
        '
        Me.btnlear.BackColor = System.Drawing.SystemColors.Control
        Me.btnlear.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnlear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnlear.Location = New System.Drawing.Point(169, 187)
        Me.btnlear.Name = "btnlear"
        Me.btnlear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnlear.Size = New System.Drawing.Size(81, 33)
        Me.btnlear.TabIndex = 12
        Me.btnlear.Text = "C&lear"
        Me.btnlear.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.Control
        Me.btnRead.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRead.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRead.Location = New System.Drawing.Point(47, 186)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRead.Size = New System.Drawing.Size(101, 33)
        Me.btnRead.TabIndex = 11
        Me.btnRead.Text = "&Read From File"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.lstFriends)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(9, 11)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(401, 153)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Data About Three Friends"
        '
        'lstFriends
        '
        Me.lstFriends.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.ItemHeight = 14
        Me.lstFriends.Location = New System.Drawing.Point(16, 24)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(368, 116)
        Me.lstFriends.TabIndex = 0
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(419, 231)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnlear)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "Form1"
        Me.Text = "File ReadLine Demo"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const intNUM_FRIENDS As Integer = 3

    Private Sub btnRead_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnRead.Click




    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnlear.Click

        ' Clear the list box.
        lstFriends.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub
End Class

