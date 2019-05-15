<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndGame
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
        Me.pbEnemy = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblHealthPoints = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.btnPowerUpArrows = New System.Windows.Forms.Button()
        Me.btnProtectPowerUp = New System.Windows.Forms.Button()
        Me.lblEnemyKicks = New System.Windows.Forms.Label()
        Me.lblKicksLeft = New System.Windows.Forms.Label()
        Me.TmrTakesAwayPoints = New System.Windows.Forms.Timer(Me.components)
        Me.btnLoadFromEnemyScreen = New System.Windows.Forms.Button()
        Me.btnSaveFromEnemyScreen = New System.Windows.Forms.Button()
        Me.lblArrowsOwned = New System.Windows.Forms.Label()
        Me.lblProtectOwned = New System.Windows.Forms.Label()
        Me.TmrCheckPricesEnemy = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEnemy
        '
        Me.pbEnemy.BackgroundImage = Global.Assessment_2_South_Park.My.Resources.Resources.Enemy
        Me.pbEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEnemy.Location = New System.Drawing.Point(12, 79)
        Me.pbEnemy.Name = "pbEnemy"
        Me.pbEnemy.Size = New System.Drawing.Size(255, 457)
        Me.pbEnemy.TabIndex = 0
        Me.pbEnemy.TabStop = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInstructions.Font = New System.Drawing.Font("Goudy Stout", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblInstructions.Location = New System.Drawing.Point(32, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(855, 26)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Click The Enemy Before she catches you"
        '
        'lblHealthPoints
        '
        Me.lblHealthPoints.AutoSize = True
        Me.lblHealthPoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHealthPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthPoints.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblHealthPoints.Location = New System.Drawing.Point(97, 56)
        Me.lblHealthPoints.Name = "lblHealthPoints"
        Me.lblHealthPoints.Size = New System.Drawing.Size(36, 20)
        Me.lblHealthPoints.TabIndex = 2
        Me.lblHealthPoints.Text = "100"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblHealth.Location = New System.Drawing.Point(33, 56)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(58, 20)
        Me.lblHealth.TabIndex = 3
        Me.lblHealth.Text = "Health"
        '
        'btnPowerUpArrows
        '
        Me.btnPowerUpArrows.BackColor = System.Drawing.Color.DarkOrange
        Me.btnPowerUpArrows.ForeColor = System.Drawing.Color.Black
        Me.btnPowerUpArrows.Location = New System.Drawing.Point(713, 79)
        Me.btnPowerUpArrows.Name = "btnPowerUpArrows"
        Me.btnPowerUpArrows.Size = New System.Drawing.Size(197, 104)
        Me.btnPowerUpArrows.TabIndex = 4
        Me.btnPowerUpArrows.Text = "Arrow Barrage: 1000 Get The Other Kids To Send In A Arrow Barrage To Fend Off The" &
    " Enemy.Upgrades Dammage Per Click By 1"
        Me.btnPowerUpArrows.UseVisualStyleBackColor = False
        '
        'btnProtectPowerUp
        '
        Me.btnProtectPowerUp.BackColor = System.Drawing.Color.DarkOrange
        Me.btnProtectPowerUp.ForeColor = System.Drawing.Color.Black
        Me.btnProtectPowerUp.Location = New System.Drawing.Point(713, 186)
        Me.btnProtectPowerUp.Name = "btnProtectPowerUp"
        Me.btnProtectPowerUp.Size = New System.Drawing.Size(197, 104)
        Me.btnProtectPowerUp.TabIndex = 5
        Me.btnProtectPowerUp.Text = "Protect: 50000.567 Get Kids To Protect Your Points. Decreases Cost Per Click By 0" &
    ".1."
        Me.btnProtectPowerUp.UseVisualStyleBackColor = False
        '
        'lblEnemyKicks
        '
        Me.lblEnemyKicks.AutoSize = True
        Me.lblEnemyKicks.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEnemyKicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyKicks.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblEnemyKicks.Location = New System.Drawing.Point(412, 67)
        Me.lblEnemyKicks.Name = "lblEnemyKicks"
        Me.lblEnemyKicks.Size = New System.Drawing.Size(97, 29)
        Me.lblEnemyKicks.TabIndex = 6
        Me.lblEnemyKicks.Text = "000.000"
        '
        'lblKicksLeft
        '
        Me.lblKicksLeft.AutoSize = True
        Me.lblKicksLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblKicksLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKicksLeft.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblKicksLeft.Location = New System.Drawing.Point(392, 35)
        Me.lblKicksLeft.Name = "lblKicksLeft"
        Me.lblKicksLeft.Size = New System.Drawing.Size(138, 32)
        Me.lblKicksLeft.TabIndex = 7
        Me.lblKicksLeft.Text = "Kicks Left"
        '
        'TmrTakesAwayPoints
        '
        Me.TmrTakesAwayPoints.Interval = 1000
        '
        'btnLoadFromEnemyScreen
        '
        Me.btnLoadFromEnemyScreen.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLoadFromEnemyScreen.Location = New System.Drawing.Point(867, 494)
        Me.btnLoadFromEnemyScreen.Name = "btnLoadFromEnemyScreen"
        Me.btnLoadFromEnemyScreen.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadFromEnemyScreen.TabIndex = 8
        Me.btnLoadFromEnemyScreen.Text = "Load"
        Me.btnLoadFromEnemyScreen.UseVisualStyleBackColor = False
        '
        'btnSaveFromEnemyScreen
        '
        Me.btnSaveFromEnemyScreen.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSaveFromEnemyScreen.Location = New System.Drawing.Point(745, 494)
        Me.btnSaveFromEnemyScreen.Name = "btnSaveFromEnemyScreen"
        Me.btnSaveFromEnemyScreen.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveFromEnemyScreen.TabIndex = 9
        Me.btnSaveFromEnemyScreen.Text = "Save"
        Me.btnSaveFromEnemyScreen.UseVisualStyleBackColor = False
        '
        'lblArrowsOwned
        '
        Me.lblArrowsOwned.AutoSize = True
        Me.lblArrowsOwned.BackColor = System.Drawing.Color.DarkOrange
        Me.lblArrowsOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrowsOwned.Location = New System.Drawing.Point(916, 121)
        Me.lblArrowsOwned.Name = "lblArrowsOwned"
        Me.lblArrowsOwned.Size = New System.Drawing.Size(31, 32)
        Me.lblArrowsOwned.TabIndex = 18
        Me.lblArrowsOwned.Text = "0"
        '
        'lblProtectOwned
        '
        Me.lblProtectOwned.AutoSize = True
        Me.lblProtectOwned.BackColor = System.Drawing.Color.DarkOrange
        Me.lblProtectOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtectOwned.Location = New System.Drawing.Point(916, 217)
        Me.lblProtectOwned.Name = "lblProtectOwned"
        Me.lblProtectOwned.Size = New System.Drawing.Size(31, 32)
        Me.lblProtectOwned.TabIndex = 19
        Me.lblProtectOwned.Text = "0"
        '
        'frmEndGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment_2_South_Park.My.Resources.Resources.EndGameBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(954, 548)
        Me.Controls.Add(Me.lblProtectOwned)
        Me.Controls.Add(Me.lblArrowsOwned)
        Me.Controls.Add(Me.btnSaveFromEnemyScreen)
        Me.Controls.Add(Me.btnLoadFromEnemyScreen)
        Me.Controls.Add(Me.lblKicksLeft)
        Me.Controls.Add(Me.lblEnemyKicks)
        Me.Controls.Add(Me.btnProtectPowerUp)
        Me.Controls.Add(Me.btnPowerUpArrows)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.lblHealthPoints)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.pbEnemy)
        Me.Name = "frmEndGame"
        Me.Text = "End_Game_Enemy"
        CType(Me.pbEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbEnemy As PictureBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblHealthPoints As Label
    Friend WithEvents lblHealth As Label
    Friend WithEvents btnPowerUpArrows As Button
    Friend WithEvents btnProtectPowerUp As Button
    Friend WithEvents lblEnemyKicks As Label
    Friend WithEvents lblKicksLeft As Label
    Friend WithEvents TmrTakesAwayPoints As Timer
    Friend WithEvents btnLoadFromEnemyScreen As Button
    Friend WithEvents btnSaveFromEnemyScreen As Button
    Friend WithEvents lblArrowsOwned As Label
    Friend WithEvents lblProtectOwned As Label
    Friend WithEvents TmrCheckPricesEnemy As Timer
End Class
