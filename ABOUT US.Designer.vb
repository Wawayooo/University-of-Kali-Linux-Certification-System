<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pdf5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pdf5))
        ab_us = New GroupBox()
        goback = New LinkLabel()
        PictureBox8 = New PictureBox()
        ab_us.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ab_us
        ' 
        ab_us.BackColor = SystemColors.Desktop
        ab_us.Controls.Add(goback)
        ab_us.Controls.Add(PictureBox8)
        ab_us.Font = New Font("Stencil", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ab_us.ForeColor = SystemColors.ControlLightLight
        ab_us.Location = New Point(12, 4)
        ab_us.Name = "ab_us"
        ab_us.Size = New Size(1620, 878)
        ab_us.TabIndex = 3
        ab_us.TabStop = False
        ab_us.Text = "ABOUT UNIVERSITY OF KALI LINUX"
        ' 
        ' goback
        ' 
        goback.AutoSize = True
        goback.Font = New Font("Stencil", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        goback.LinkColor = Color.White
        goback.Location = New Point(116, 784)
        goback.Name = "goback"
        goback.Size = New Size(241, 38)
        goback.TabIndex = 29
        goback.TabStop = True
        goback.Text = "  ◀️  GO BACK   "
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(27, 72)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(1574, 788)
        PictureBox8.TabIndex = 0
        PictureBox8.TabStop = False
        ' 
        ' pdf5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1644, 894)
        Controls.Add(ab_us)
        Name = "pdf5"
        Text = "ABOUT US PAGE"
        ab_us.ResumeLayout(False)
        ab_us.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ab_us As GroupBox
    Friend WithEvents goback As LinkLabel
    Friend WithEvents PictureBox8 As PictureBox
End Class
