<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnHigher = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Think of a number between 1 and 100"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(776, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "My guess is:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(776, 56)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnYes.Location = New System.Drawing.Point(12, 228)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(383, 210)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        Me.btnYes.Visible = False
        '
        'btnHigher
        '
        Me.btnHigher.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHigher.Location = New System.Drawing.Point(12, 228)
        Me.btnHigher.Name = "btnHigher"
        Me.btnHigher.Size = New System.Drawing.Size(383, 210)
        Me.btnHigher.TabIndex = 4
        Me.btnHigher.Text = "Higher"
        Me.btnHigher.UseVisualStyleBackColor = True
        Me.btnHigher.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNo.Location = New System.Drawing.Point(405, 228)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(383, 210)
        Me.btnNo.TabIndex = 5
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        Me.btnNo.Visible = False
        '
        'btnLower
        '
        Me.btnLower.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLower.Location = New System.Drawing.Point(405, 228)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(383, 210)
        Me.btnLower.TabIndex = 6
        Me.btnLower.Text = "Lower"
        Me.btnLower.UseVisualStyleBackColor = True
        Me.btnLower.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseMnemonic = False
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.Location = New System.Drawing.Point(193, 142)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(399, 256)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLower)
        Me.Controls.Add(Me.btnHigher)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnHigher As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnLower As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStart As Button


    Public GuessNumber As Integer = 50
    Public range As Integer = 50

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Label3.Text = "50"
        btnNo.Visible = True
        btnYes.Visible = True
        btnHigher.Visible = True
        btnLower.Visible = True
        btnStart.Visible = False

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        MessageBox.Show("WOO I FOUND IT!")

        End

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Label2.Text = "Is it higher or lower?"
        btnNo.Visible = False
        btnYes.Visible = False
    End Sub

    Private Sub btnHigher_Click(sender As Object, e As EventArgs) Handles btnHigher.Click
        range = range / 2
        GuessNumber = GuessNumber + range
        Label3.Text = GuessNumber
        btnNo.Visible = True
        btnYes.Visible = True

    End Sub

    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        range = range / 2
        GuessNumber = GuessNumber - range
        Label3.Text = GuessNumber
        btnNo.Visible = True
        btnYes.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub



End Class
