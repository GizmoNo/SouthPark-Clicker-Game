<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSouthPark
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
        Me.pbKickTheBaby = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnEnergyDrink = New System.Windows.Forms.Button()
        Me.btnKids = New System.Windows.Forms.Button()
        Me.btnNewShoes = New System.Windows.Forms.Button()
        Me.txtCheatBox = New System.Windows.Forms.TextBox()
        Me.lblUpgrades = New System.Windows.Forms.Label()
        Me.btnAchievements = New System.Windows.Forms.Button()
        Me.lblSecondary = New System.Windows.Forms.Label()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblKicks = New System.Windows.Forms.Label()
        Me.lblEnergyDrinksOwned = New System.Windows.Forms.Label()
        Me.lblNewShoesOwned = New System.Windows.Forms.Label()
        Me.lblKidsOwned = New System.Windows.Forms.Label()
        Me.lblScorePerSecond = New System.Windows.Forms.Label()
        Me.TimerCheckPrices = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAutoClicker = New System.Windows.Forms.Timer(Me.components)
        Me.btnCheat = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAllPowerUpsOwned = New System.Windows.Forms.Label()
        Me.btnLoadFromEnemyScreen = New System.Windows.Forms.Button()
        Me.btnAchivement100MileStone = New System.Windows.Forms.Button()
        Me.lblAchivements = New System.Windows.Forms.Label()
        Me.btnAchivement1000MileStone = New System.Windows.Forms.Button()
        Me.btnAchivement500MileStone = New System.Windows.Forms.Button()
        Me.btnAchivementMileStone20PowerUps = New System.Windows.Forms.Button()
        Me.btnAchivementMileStone5PowerUps = New System.Windows.Forms.Button()
        Me.btnAchivementMileStone50PowerUp = New System.Windows.Forms.Button()
        Me.btnAchivementMileStone10000KicksHeld = New System.Windows.Forms.Button()
        Me.btnAchivementMileStone5000KicksHeld = New System.Windows.Forms.Button()
        Me.btnAchivementMileStone1000KicksHeld = New System.Windows.Forms.Button()
        Me.TimerCheckAchivements = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountDownTillEnemyAppears = New System.Windows.Forms.Label()
        Me.lblTimeTillEnemyAppares = New System.Windows.Forms.Label()
        Me.TimerEnemyApparesTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbKickTheBaby, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbKickTheBaby
        '
        Me.pbKickTheBaby.BackgroundImage = Global.Assessment_2_South_Park.My.Resources.Resources.ClickerBox
        Me.pbKickTheBaby.Location = New System.Drawing.Point(350, 121)
        Me.pbKickTheBaby.Name = "pbKickTheBaby"
        Me.pbKickTheBaby.Size = New System.Drawing.Size(240, 226)
        Me.pbKickTheBaby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbKickTheBaby.TabIndex = 0
        Me.pbKickTheBaby.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbKickTheBaby, "Click this to gain points")
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.DarkOrange
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(350, 28)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(240, 46)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblScore, "Your Score")
        '
        'btnEnergyDrink
        '
        Me.btnEnergyDrink.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEnergyDrink.Location = New System.Drawing.Point(908, 70)
        Me.btnEnergyDrink.Name = "btnEnergyDrink"
        Me.btnEnergyDrink.Size = New System.Drawing.Size(199, 118)
        Me.btnEnergyDrink.TabIndex = 3
        Me.btnEnergyDrink.Text = "Energy Drink" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Cost 15 Kicks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Perk your self up with an energy drink" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Incresses y" &
    "our kick rate by 0.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.btnEnergyDrink, "This is a Power up")
        Me.btnEnergyDrink.UseVisualStyleBackColor = False
        '
        'btnKids
        '
        Me.btnKids.BackColor = System.Drawing.Color.DarkOrange
        Me.btnKids.Location = New System.Drawing.Point(903, 194)
        Me.btnKids.Name = "btnKids"
        Me.btnKids.Size = New System.Drawing.Size(204, 118)
        Me.btnKids.TabIndex = 4
        Me.btnKids.Text = "Extra Kids" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost 200 kicks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Call for other kids to help" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Automaticly adds 1 kick " &
    "per second" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.btnKids, "This is a Power up")
        Me.btnKids.UseVisualStyleBackColor = False
        '
        'btnNewShoes
        '
        Me.btnNewShoes.BackColor = System.Drawing.Color.DarkOrange
        Me.btnNewShoes.Location = New System.Drawing.Point(903, 318)
        Me.btnNewShoes.Name = "btnNewShoes"
        Me.btnNewShoes.Size = New System.Drawing.Size(204, 118)
        Me.btnNewShoes.TabIndex = 5
        Me.btnNewShoes.Text = "New Shoes " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost 500 Kicks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Buy some new shoes to replace then old worn out ones." &
    " Incresses your click value by 1"
        Me.ToolTip1.SetToolTip(Me.btnNewShoes, "This is a Power up")
        Me.btnNewShoes.UseVisualStyleBackColor = False
        '
        'txtCheatBox
        '
        Me.txtCheatBox.BackColor = System.Drawing.Color.DarkOrange
        Me.txtCheatBox.Location = New System.Drawing.Point(995, 642)
        Me.txtCheatBox.Name = "txtCheatBox"
        Me.txtCheatBox.Size = New System.Drawing.Size(168, 22)
        Me.txtCheatBox.TabIndex = 0
        '
        'lblUpgrades
        '
        Me.lblUpgrades.BackColor = System.Drawing.Color.DarkOrange
        Me.lblUpgrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgrades.Location = New System.Drawing.Point(908, 9)
        Me.lblUpgrades.Name = "lblUpgrades"
        Me.lblUpgrades.Size = New System.Drawing.Size(189, 46)
        Me.lblUpgrades.TabIndex = 12
        Me.lblUpgrades.Text = "Upgrades"
        Me.ToolTip1.SetToolTip(Me.lblUpgrades, "Upgrades")
        '
        'btnAchievements
        '
        Me.btnAchievements.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchievements.Location = New System.Drawing.Point(355, 642)
        Me.btnAchievements.Name = "btnAchievements"
        Me.btnAchievements.Size = New System.Drawing.Size(199, 63)
        Me.btnAchievements.TabIndex = 14
        Me.btnAchievements.Text = "Achievements"
        Me.ToolTip1.SetToolTip(Me.btnAchievements, "Shows you your Achievements")
        Me.btnAchievements.UseVisualStyleBackColor = False
        '
        'lblSecondary
        '
        Me.lblSecondary.BackColor = System.Drawing.Color.DarkOrange
        Me.lblSecondary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondary.Location = New System.Drawing.Point(703, 9)
        Me.lblSecondary.Name = "lblSecondary"
        Me.lblSecondary.Size = New System.Drawing.Size(199, 44)
        Me.lblSecondary.TabIndex = 13
        Me.lblSecondary.Text = "Secondary"
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.DarkOrange
        Me.btnStatistics.Location = New System.Drawing.Point(59, 642)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(199, 63)
        Me.btnStatistics.TabIndex = 15
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'lblKicks
        '
        Me.lblKicks.AutoSize = True
        Me.lblKicks.BackColor = System.Drawing.Color.DarkOrange
        Me.lblKicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKicks.Location = New System.Drawing.Point(426, 74)
        Me.lblKicks.Name = "lblKicks"
        Me.lblKicks.Size = New System.Drawing.Size(71, 29)
        Me.lblKicks.TabIndex = 16
        Me.lblKicks.Text = "Kicks"
        '
        'lblEnergyDrinksOwned
        '
        Me.lblEnergyDrinksOwned.AutoSize = True
        Me.lblEnergyDrinksOwned.BackColor = System.Drawing.Color.DarkOrange
        Me.lblEnergyDrinksOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnergyDrinksOwned.Location = New System.Drawing.Point(1113, 108)
        Me.lblEnergyDrinksOwned.Name = "lblEnergyDrinksOwned"
        Me.lblEnergyDrinksOwned.Size = New System.Drawing.Size(31, 32)
        Me.lblEnergyDrinksOwned.TabIndex = 17
        Me.lblEnergyDrinksOwned.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblEnergyDrinksOwned, "Amount of power ups you own")
        '
        'lblNewShoesOwned
        '
        Me.lblNewShoesOwned.AutoSize = True
        Me.lblNewShoesOwned.BackColor = System.Drawing.Color.DarkOrange
        Me.lblNewShoesOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewShoesOwned.Location = New System.Drawing.Point(1113, 356)
        Me.lblNewShoesOwned.Name = "lblNewShoesOwned"
        Me.lblNewShoesOwned.Size = New System.Drawing.Size(31, 32)
        Me.lblNewShoesOwned.TabIndex = 18
        Me.lblNewShoesOwned.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblNewShoesOwned, "Amount of power ups you own")
        '
        'lblKidsOwned
        '
        Me.lblKidsOwned.AutoSize = True
        Me.lblKidsOwned.BackColor = System.Drawing.Color.DarkOrange
        Me.lblKidsOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKidsOwned.Location = New System.Drawing.Point(1113, 232)
        Me.lblKidsOwned.Name = "lblKidsOwned"
        Me.lblKidsOwned.Size = New System.Drawing.Size(31, 32)
        Me.lblKidsOwned.TabIndex = 19
        Me.lblKidsOwned.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblKidsOwned, "Amount of power ups you own")
        '
        'lblScorePerSecond
        '
        Me.lblScorePerSecond.AutoSize = True
        Me.lblScorePerSecond.BackColor = System.Drawing.Color.DarkOrange
        Me.lblScorePerSecond.Location = New System.Drawing.Point(444, 103)
        Me.lblScorePerSecond.Name = "lblScorePerSecond"
        Me.lblScorePerSecond.Size = New System.Drawing.Size(28, 17)
        Me.lblScorePerSecond.TabIndex = 20
        Me.lblScorePerSecond.Text = "0.0"
        Me.ToolTip1.SetToolTip(Me.lblScorePerSecond, "Number of auto clicks per second")
        '
        'TimerCheckPrices
        '
        '
        'TimerAutoClicker
        '
        Me.TimerAutoClicker.Interval = 1000
        '
        'btnCheat
        '
        Me.btnCheat.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCheat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCheat.Location = New System.Drawing.Point(1032, 682)
        Me.btnCheat.Name = "btnCheat"
        Me.btnCheat.Size = New System.Drawing.Size(75, 23)
        Me.btnCheat.TabIndex = 21
        Me.btnCheat.Text = "CHEAT"
        Me.ToolTip1.SetToolTip(Me.btnCheat, "Type a number in the text box above and click the button to give yourself free po" &
        "ints")
        Me.btnCheat.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(883, 641)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Save your game")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLoad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLoad.Location = New System.Drawing.Point(883, 680)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 27)
        Me.btnLoad.TabIndex = 26
        Me.btnLoad.Text = "Load"
        Me.ToolTip1.SetToolTip(Me.btnLoad, "Load your game")
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.DarkOrange
        Me.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOpenFile.Location = New System.Drawing.Point(1018, 608)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(117, 28)
        Me.btnOpenFile.TabIndex = 27
        Me.btnOpenFile.Text = "Open Save File"
        Me.ToolTip1.SetToolTip(Me.btnOpenFile, "Click to see your save file")
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 5000
        '
        'lblAllPowerUpsOwned
        '
        Me.lblAllPowerUpsOwned.AutoSize = True
        Me.lblAllPowerUpsOwned.BackColor = System.Drawing.Color.DarkOrange
        Me.lblAllPowerUpsOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllPowerUpsOwned.Location = New System.Drawing.Point(1113, 11)
        Me.lblAllPowerUpsOwned.Name = "lblAllPowerUpsOwned"
        Me.lblAllPowerUpsOwned.Size = New System.Drawing.Size(31, 32)
        Me.lblAllPowerUpsOwned.TabIndex = 52
        Me.lblAllPowerUpsOwned.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblAllPowerUpsOwned, "Total Amount of power ups you own")
        '
        'btnLoadFromEnemyScreen
        '
        Me.btnLoadFromEnemyScreen.BackColor = System.Drawing.Color.DarkOrange
        Me.btnLoadFromEnemyScreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLoadFromEnemyScreen.Location = New System.Drawing.Point(752, 623)
        Me.btnLoadFromEnemyScreen.Name = "btnLoadFromEnemyScreen"
        Me.btnLoadFromEnemyScreen.Size = New System.Drawing.Size(113, 84)
        Me.btnLoadFromEnemyScreen.TabIndex = 55
        Me.btnLoadFromEnemyScreen.Text = "Load Here If You Saved On The Enemy Screen"
        Me.ToolTip1.SetToolTip(Me.btnLoadFromEnemyScreen, "Load Your Games Here If Saved On Enemy Screen")
        Me.btnLoadFromEnemyScreen.UseVisualStyleBackColor = False
        '
        'btnAchivement100MileStone
        '
        Me.btnAchivement100MileStone.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivement100MileStone.Location = New System.Drawing.Point(12, 56)
        Me.btnAchivement100MileStone.Name = "btnAchivement100MileStone"
        Me.btnAchivement100MileStone.Size = New System.Drawing.Size(153, 84)
        Me.btnAchivement100MileStone.TabIndex = 28
        Me.btnAchivement100MileStone.Text = "Achivement Unlocked Reach 100 Kicks Click To Obtain Bouns 50 Kicks"
        Me.ToolTip1.SetToolTip(Me.btnAchivement100MileStone, "Click To Obtain Achivement")
        Me.btnAchivement100MileStone.UseVisualStyleBackColor = False
        '
        'lblAchivements
        '
        Me.lblAchivements.BackColor = System.Drawing.Color.DarkOrange
        Me.lblAchivements.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAchivements.Location = New System.Drawing.Point(75, 11)
        Me.lblAchivements.Name = "lblAchivements"
        Me.lblAchivements.Size = New System.Drawing.Size(199, 44)
        Me.lblAchivements.TabIndex = 37
        Me.lblAchivements.Text = "Achivements"
        Me.ToolTip1.SetToolTip(Me.lblAchivements, "Achivements Will Pop Up Below")
        '
        'btnAchivement1000MileStone
        '
        Me.btnAchivement1000MileStone.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivement1000MileStone.Location = New System.Drawing.Point(12, 232)
        Me.btnAchivement1000MileStone.Name = "btnAchivement1000MileStone"
        Me.btnAchivement1000MileStone.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivement1000MileStone.TabIndex = 44
        Me.btnAchivement1000MileStone.Text = "Achivement Unlocked Reach 1000 Kicks Click To Obtain Bouns 500 Kicks"
        Me.ToolTip1.SetToolTip(Me.btnAchivement1000MileStone, "Click To Obtain Achivement")
        Me.btnAchivement1000MileStone.UseVisualStyleBackColor = False
        '
        'btnAchivement500MileStone
        '
        Me.btnAchivement500MileStone.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivement500MileStone.Location = New System.Drawing.Point(12, 146)
        Me.btnAchivement500MileStone.Name = "btnAchivement500MileStone"
        Me.btnAchivement500MileStone.Size = New System.Drawing.Size(153, 80)
        Me.btnAchivement500MileStone.TabIndex = 45
        Me.btnAchivement500MileStone.Text = "Achivement Unlocked Reach 500 Kicks Click To Obtain Bouns 200 Kicks"
        Me.ToolTip1.SetToolTip(Me.btnAchivement500MileStone, "Click To Obtain Achivement")
        Me.btnAchivement500MileStone.UseVisualStyleBackColor = False
        '
        'btnAchivementMileStone20PowerUps
        '
        Me.btnAchivementMileStone20PowerUps.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivementMileStone20PowerUps.Location = New System.Drawing.Point(171, 144)
        Me.btnAchivementMileStone20PowerUps.Name = "btnAchivementMileStone20PowerUps"
        Me.btnAchivementMileStone20PowerUps.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivementMileStone20PowerUps.TabIndex = 46
        Me.btnAchivementMileStone20PowerUps.Text = "Achivement Unlocked Own 20 Power Ups Click To Obtain 1 Extra Kid"
        Me.ToolTip1.SetToolTip(Me.btnAchivementMileStone20PowerUps, "Click To Obtain Achivement")
        Me.btnAchivementMileStone20PowerUps.UseVisualStyleBackColor = False
        '
        'btnAchivementMileStone5PowerUps
        '
        Me.btnAchivementMileStone5PowerUps.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivementMileStone5PowerUps.Location = New System.Drawing.Point(171, 58)
        Me.btnAchivementMileStone5PowerUps.Name = "btnAchivementMileStone5PowerUps"
        Me.btnAchivementMileStone5PowerUps.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivementMileStone5PowerUps.TabIndex = 47
        Me.btnAchivementMileStone5PowerUps.Text = "Achivement Unlocked Own 5 power ups Click To Obtain 1 Free Energy Drink "
        Me.ToolTip1.SetToolTip(Me.btnAchivementMileStone5PowerUps, "Click To Obtain Achivement")
        Me.btnAchivementMileStone5PowerUps.UseVisualStyleBackColor = False
        '
        'btnAchivementMileStone50PowerUp
        '
        Me.btnAchivementMileStone50PowerUp.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivementMileStone50PowerUp.Location = New System.Drawing.Point(171, 232)
        Me.btnAchivementMileStone50PowerUp.Name = "btnAchivementMileStone50PowerUp"
        Me.btnAchivementMileStone50PowerUp.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivementMileStone50PowerUp.TabIndex = 48
        Me.btnAchivementMileStone50PowerUp.Text = "Achivements Unlocked Own 50 Power Ups Click To Obtain 1 New Shoes"
        Me.ToolTip1.SetToolTip(Me.btnAchivementMileStone50PowerUp, "Click To Obtain Achivement")
        Me.btnAchivementMileStone50PowerUp.UseVisualStyleBackColor = False
        '
        'btnAchivementMileStone10000KicksHeld
        '
        Me.btnAchivementMileStone10000KicksHeld.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivementMileStone10000KicksHeld.Location = New System.Drawing.Point(12, 496)
        Me.btnAchivementMileStone10000KicksHeld.Name = "btnAchivementMileStone10000KicksHeld"
        Me.btnAchivementMileStone10000KicksHeld.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivementMileStone10000KicksHeld.TabIndex = 49
        Me.btnAchivementMileStone10000KicksHeld.Text = "Achivement Unlocked Hold 10000 Kicks At One Time Click To Obtain 5000 Kicks"
        Me.ToolTip1.SetToolTip(Me.btnAchivementMileStone10000KicksHeld, "Click To Obtain Achivement")
        Me.btnAchivementMileStone10000KicksHeld.UseVisualStyleBackColor = False
        '
        'btnAchivementMileStone5000KicksHeld
        '
        Me.btnAchivementMileStone5000KicksHeld.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivementMileStone5000KicksHeld.Location = New System.Drawing.Point(12, 408)
        Me.btnAchivementMileStone5000KicksHeld.Name = "btnAchivementMileStone5000KicksHeld"
        Me.btnAchivementMileStone5000KicksHeld.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivementMileStone5000KicksHeld.TabIndex = 50
        Me.btnAchivementMileStone5000KicksHeld.Text = "Achivement Unlocked Hold 5000 Kicks At One Time Click To Obtain 1000 Kicks"
        Me.ToolTip1.SetToolTip(Me.btnAchivementMileStone5000KicksHeld, "Click To Obtain Achivement")
        Me.btnAchivementMileStone5000KicksHeld.UseVisualStyleBackColor = False
        '
        'btnAchivementMileStone1000KicksHeld
        '
        Me.btnAchivementMileStone1000KicksHeld.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAchivementMileStone1000KicksHeld.Location = New System.Drawing.Point(12, 320)
        Me.btnAchivementMileStone1000KicksHeld.Name = "btnAchivementMileStone1000KicksHeld"
        Me.btnAchivementMileStone1000KicksHeld.Size = New System.Drawing.Size(153, 82)
        Me.btnAchivementMileStone1000KicksHeld.TabIndex = 51
        Me.btnAchivementMileStone1000KicksHeld.Text = "Achivement Unlocked Hold 1000 Kicks At One Time Click To Obtain 500 Kicks"
        Me.ToolTip1.SetToolTip(Me.btnAchivementMileStone1000KicksHeld, "Click To Obtain Achivement")
        Me.btnAchivementMileStone1000KicksHeld.UseVisualStyleBackColor = False
        '
        'TimerCheckAchivements
        '
        '
        'lblCountDownTillEnemyAppears
        '
        Me.lblCountDownTillEnemyAppears.AutoSize = True
        Me.lblCountDownTillEnemyAppears.BackColor = System.Drawing.Color.DarkOrange
        Me.lblCountDownTillEnemyAppears.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountDownTillEnemyAppears.Location = New System.Drawing.Point(465, 426)
        Me.lblCountDownTillEnemyAppears.Name = "lblCountDownTillEnemyAppears"
        Me.lblCountDownTillEnemyAppears.Size = New System.Drawing.Size(52, 29)
        Me.lblCountDownTillEnemyAppears.TabIndex = 53
        Me.lblCountDownTillEnemyAppears.Text = "300"
        Me.ToolTip1.SetToolTip(Me.lblCountDownTillEnemyAppears, "Time Before Enemy Appares")
        '
        'lblTimeTillEnemyAppares
        '
        Me.lblTimeTillEnemyAppares.AutoSize = True
        Me.lblTimeTillEnemyAppares.BackColor = System.Drawing.Color.DarkOrange
        Me.lblTimeTillEnemyAppares.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeTillEnemyAppares.Location = New System.Drawing.Point(350, 397)
        Me.lblTimeTillEnemyAppares.Name = "lblTimeTillEnemyAppares"
        Me.lblTimeTillEnemyAppares.Size = New System.Drawing.Size(305, 29)
        Me.lblTimeTillEnemyAppares.TabIndex = 54
        Me.lblTimeTillEnemyAppares.Text = "Time Until Enemy Appears!"
        '
        'TimerEnemyApparesTimer
        '
        Me.TimerEnemyApparesTimer.Interval = 1000
        '
        'frmSouthPark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assessment_2_South_Park.My.Resources.Resources.BackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 717)
        Me.Controls.Add(Me.btnLoadFromEnemyScreen)
        Me.Controls.Add(Me.lblTimeTillEnemyAppares)
        Me.Controls.Add(Me.lblCountDownTillEnemyAppears)
        Me.Controls.Add(Me.lblAllPowerUpsOwned)
        Me.Controls.Add(Me.btnAchivementMileStone1000KicksHeld)
        Me.Controls.Add(Me.btnAchivementMileStone5000KicksHeld)
        Me.Controls.Add(Me.btnAchivementMileStone10000KicksHeld)
        Me.Controls.Add(Me.btnAchivementMileStone50PowerUp)
        Me.Controls.Add(Me.btnAchivementMileStone5PowerUps)
        Me.Controls.Add(Me.btnAchivementMileStone20PowerUps)
        Me.Controls.Add(Me.btnAchivement500MileStone)
        Me.Controls.Add(Me.btnAchivement1000MileStone)
        Me.Controls.Add(Me.lblAchivements)
        Me.Controls.Add(Me.btnAchivement100MileStone)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCheat)
        Me.Controls.Add(Me.lblScorePerSecond)
        Me.Controls.Add(Me.lblKidsOwned)
        Me.Controls.Add(Me.lblNewShoesOwned)
        Me.Controls.Add(Me.lblEnergyDrinksOwned)
        Me.Controls.Add(Me.lblKicks)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnAchievements)
        Me.Controls.Add(Me.lblSecondary)
        Me.Controls.Add(Me.lblUpgrades)
        Me.Controls.Add(Me.txtCheatBox)
        Me.Controls.Add(Me.btnNewShoes)
        Me.Controls.Add(Me.btnKids)
        Me.Controls.Add(Me.btnEnergyDrink)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pbKickTheBaby)
        Me.Name = "frmSouthPark"
        Me.Text = "South Park"
        CType(Me.pbKickTheBaby, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbKickTheBaby As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents btnEnergyDrink As Button
    Friend WithEvents btnKids As Button
    Friend WithEvents btnNewShoes As Button
    Friend WithEvents txtCheatBox As TextBox
    Friend WithEvents lblUpgrades As Label
    Friend WithEvents btnAchievements As Button
    Friend WithEvents lblSecondary As Label
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblKicks As Label
    Friend WithEvents lblEnergyDrinksOwned As Label
    Friend WithEvents lblNewShoesOwned As Label
    Friend WithEvents lblKidsOwned As Label
    Friend WithEvents lblScorePerSecond As Label
    Friend WithEvents TimerCheckPrices As Timer
    Friend WithEvents TimerAutoClicker As Timer
    Friend WithEvents btnCheat As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnAchivement100MileStone As Button
    Friend WithEvents lblAchivements As Label
    Friend WithEvents btnAchivement1000MileStone As Button
    Friend WithEvents btnAchivement500MileStone As Button
    Friend WithEvents btnAchivementMileStone20PowerUps As Button
    Friend WithEvents btnAchivementMileStone5PowerUps As Button
    Friend WithEvents btnAchivementMileStone50PowerUp As Button
    Friend WithEvents btnAchivementMileStone10000KicksHeld As Button
    Friend WithEvents btnAchivementMileStone5000KicksHeld As Button
    Friend WithEvents btnAchivementMileStone1000KicksHeld As Button
    Friend WithEvents lblAllPowerUpsOwned As Label
    Friend WithEvents TimerCheckAchivements As Timer
    Friend WithEvents lblCountDownTillEnemyAppears As Label
    Friend WithEvents lblTimeTillEnemyAppares As Label
    Friend WithEvents TimerEnemyApparesTimer As Timer
    Friend WithEvents btnLoadFromEnemyScreen As Button
End Class
