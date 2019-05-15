<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAchievements
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
        Me.lbAchivements = New System.Windows.Forms.ListBox()
        Me.btnBackToGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbAchivements
        '
        Me.lbAchivements.BackColor = System.Drawing.Color.DarkOrange
        Me.lbAchivements.FormattingEnabled = True
        Me.lbAchivements.ItemHeight = 16
        Me.lbAchivements.Location = New System.Drawing.Point(154, 148)
        Me.lbAchivements.Name = "lbAchivements"
        Me.lbAchivements.Size = New System.Drawing.Size(664, 308)
        Me.lbAchivements.TabIndex = 0
        '
        'btnBackToGame
        '
        Me.btnBackToGame.Location = New System.Drawing.Point(731, 462)
        Me.btnBackToGame.Name = "btnBackToGame"
        Me.btnBackToGame.Size = New System.Drawing.Size(110, 23)
        Me.btnBackToGame.TabIndex = 1
        Me.btnBackToGame.Text = "Back To Game"
        Me.btnBackToGame.UseVisualStyleBackColor = True
        '
        'frmAchievements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.BackgroundImage = Global.Assessment_2_South_Park.My.Resources.Resources.Achivements_back_ground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 645)
        Me.Controls.Add(Me.btnBackToGame)
        Me.Controls.Add(Me.lbAchivements)
        Me.Name = "frmAchievements"
        Me.Text = "Achievements"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbAchivements As ListBox
    Friend WithEvents btnBackToGame As Button
End Class
