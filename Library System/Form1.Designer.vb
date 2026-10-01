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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSetings = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnOverdue = New System.Windows.Forms.Button()
        Me.btnBorrowReturn = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnSetings)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnOverdue)
        Me.Panel1.Controls.Add(Me.btnBorrowReturn)
        Me.Panel1.Controls.Add(Me.btnMembers)
        Me.Panel1.Controls.Add(Me.btnBooks)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 507)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 62)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(206, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(751, 566)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(65, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Noah Academy Inc. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library System"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.Location = New System.Drawing.Point(3, 457)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(208, 47)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnSetings
        '
        Me.btnSetings.BackColor = System.Drawing.Color.Transparent
        Me.btnSetings.FlatAppearance.BorderSize = 0
        Me.btnSetings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnSetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetings.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetings.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnSetings.Image = CType(resources.GetObject("btnSetings.Image"), System.Drawing.Image)
        Me.btnSetings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetings.Location = New System.Drawing.Point(0, 347)
        Me.btnSetings.Name = "btnSetings"
        Me.btnSetings.Size = New System.Drawing.Size(208, 40)
        Me.btnSetings.TabIndex = 1
        Me.btnSetings.Text = "Setings"
        Me.btnSetings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetings.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.Transparent
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.Location = New System.Drawing.Point(0, 301)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(208, 40)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnOverdue
        '
        Me.btnOverdue.BackColor = System.Drawing.Color.Transparent
        Me.btnOverdue.FlatAppearance.BorderSize = 0
        Me.btnOverdue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverdue.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverdue.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnOverdue.Image = CType(resources.GetObject("btnOverdue.Image"), System.Drawing.Image)
        Me.btnOverdue.Location = New System.Drawing.Point(0, 255)
        Me.btnOverdue.Name = "btnOverdue"
        Me.btnOverdue.Size = New System.Drawing.Size(208, 40)
        Me.btnOverdue.TabIndex = 0
        Me.btnOverdue.Text = "Overdue"
        Me.btnOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOverdue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOverdue.UseVisualStyleBackColor = False
        '
        'btnBorrowReturn
        '
        Me.btnBorrowReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrowReturn.FlatAppearance.BorderSize = 0
        Me.btnBorrowReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnBorrowReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowReturn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowReturn.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBorrowReturn.Image = CType(resources.GetObject("btnBorrowReturn.Image"), System.Drawing.Image)
        Me.btnBorrowReturn.Location = New System.Drawing.Point(0, 209)
        Me.btnBorrowReturn.Name = "btnBorrowReturn"
        Me.btnBorrowReturn.Size = New System.Drawing.Size(208, 40)
        Me.btnBorrowReturn.TabIndex = 0
        Me.btnBorrowReturn.Text = "Borrow/Return"
        Me.btnBorrowReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBorrowReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrowReturn.UseVisualStyleBackColor = False
        '
        'btnMembers
        '
        Me.btnMembers.BackColor = System.Drawing.Color.Transparent
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnMembers.Image = CType(resources.GetObject("btnMembers.Image"), System.Drawing.Image)
        Me.btnMembers.Location = New System.Drawing.Point(0, 163)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(208, 40)
        Me.btnMembers.TabIndex = 0
        Me.btnMembers.Text = "Members"
        Me.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMembers.UseVisualStyleBackColor = False
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.Color.Transparent
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBooks.Image = CType(resources.GetObject("btnBooks.Image"), System.Drawing.Image)
        Me.btnBooks.Location = New System.Drawing.Point(0, 117)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(208, 40)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Books"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 71)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(208, 40)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(207, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 507)
        Me.Panel2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(877, 507)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Friend WithEvents btnBorrowReturn As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnOverdue As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Panel3 As Panel



    Friend WithEvents btnReports As Button
    Friend WithEvents btnSetings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
