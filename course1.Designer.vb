<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class course1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(course1))
        GroupBox1 = New GroupBox()
        hiddencode = New Label()
        greetings2 = New GroupBox()
        LinkLabel3 = New LinkLabel()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox5 = New PictureBox()
        GroupBox4 = New GroupBox()
        PictureBox2 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        GroupBox3 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox2 = New GroupBox()
        LinkLabel2 = New LinkLabel()
        GroupBox1.SuspendLayout()
        greetings2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(hiddencode)
        GroupBox1.Controls.Add(greetings2)
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Font = New Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 63)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1401, 637)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "BUG BOUNTY HUNTING"
        ' 
        ' hiddencode
        ' 
        hiddencode.AutoSize = True
        hiddencode.Font = New Font("SimSun", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        hiddencode.Location = New Point(665, 28)
        hiddencode.Name = "hiddencode"
        hiddencode.Size = New Size(69, 20)
        hiddencode.TabIndex = 2
        hiddencode.Text = "Label3"
        hiddencode.Visible = False
        ' 
        ' greetings2
        ' 
        greetings2.BackColor = SystemColors.ActiveCaptionText
        greetings2.Controls.Add(LinkLabel3)
        greetings2.Controls.Add(Label2)
        greetings2.Controls.Add(Label1)
        greetings2.Controls.Add(PictureBox3)
        greetings2.Controls.Add(PictureBox5)
        greetings2.ForeColor = SystemColors.ControlLightLight
        greetings2.Location = New Point(328, 83)
        greetings2.Name = "greetings2"
        greetings2.Size = New Size(745, 470)
        greetings2.TabIndex = 6
        greetings2.TabStop = False
        greetings2.Text = "GREETINGS"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel3.LinkColor = Color.White
        LinkLabel3.Location = New Point(150, 379)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(444, 42)
        LinkLabel3.TabIndex = 6
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "⏪BACK TO HOMEPAGE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(214, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(302, 30)
        Label2.TabIndex = 4
        Label2.Text = "SUCCESSFULLY ENROLLED"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Image = My.Resources.Resources.Screenshot_2024_03_27_152637
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(47, 175)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 19)
        Label1.TabIndex = 3
        Label1.Text = "Get certified as Kali University Certified Bug Bounty Hunter"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ActiveCaptionText
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(47, 86)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(140, 88)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(28, 82)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(690, 251)
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackgroundImageLayout = ImageLayout.Center
        GroupBox4.Controls.Add(PictureBox2)
        GroupBox4.Font = New Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(89, 358)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(526, 263)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "MODULE SECTIONS"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(6, 37)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(514, 220)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), Image)
        LinkLabel1.ImageAlign = ContentAlignment.BottomCenter
        LinkLabel1.LinkColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        LinkLabel1.Location = New Point(1075, 499)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(279, 50)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "ENROLL NOW"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), Image)
        GroupBox3.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox3.Controls.Add(PictureBox1)
        GroupBox3.Font = New Font("Stencil", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(656, 356)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(336, 265)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "CERTIFICATE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(38, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(264, 210)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.BackgroundImageLayout = ImageLayout.None
        GroupBox2.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ControlLightLight
        GroupBox2.Location = New Point(73, 60)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1281, 288)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "MODULE SUMMARY"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel2.LinkColor = Color.White
        LinkLabel2.Location = New Point(12, 18)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(161, 42)
        LinkLabel2.TabIndex = 1
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "⏪BACK"
        ' 
        ' course1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1425, 728)
        Controls.Add(LinkLabel2)
        Controls.Add(GroupBox1)
        Name = "course1"
        Text = "UNIVERSITY OF KALI LINUX"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        greetings2.ResumeLayout(False)
        greetings2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents greetings2 As GroupBox
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents hiddencode As Label
End Class
