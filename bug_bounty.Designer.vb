<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bug_bounty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bug_bounty))
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(26, 4)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(1373, 789)
        AxWindowsMediaPlayer1.TabIndex = 0
        ' 
        ' bug_bounty
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1425, 728)
        Controls.Add(AxWindowsMediaPlayer1)
        Name = "bug_bounty"
        Text = "UNIVERSITY OF KALI LINUX"
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
