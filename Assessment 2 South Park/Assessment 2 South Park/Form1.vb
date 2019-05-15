Public Class frmSouthPark
    Private Sub frmSouthPark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Message box shows when form opens
        MessageBox.Show("Welcome to my clicker game. If you are confused on how to play place you mouse over the area and a message will tell you what it does",
        "Welcome",
        MessageBoxButtons.OK,
        MessageBoxIcon.Asterisk)

        '################    ALL TIMERS START AND HIDES ACHIVEMENT BUTTONS  #####################
        TimerCheckPrices.Start()

        TimerCheckAchivements.Start()
        TimerEnemyApparesTimer.Start()
        HideButtons()

        'Plays Audio When Form Opens
        My.Computer.Audio.Play(My.Resources.KickTheBaby, AudioPlayMode.Background)
    End Sub
    Private Sub pbBaby_mousedown(sender As Object, e As EventArgs) Handles pbKickTheBaby.MouseDown

        '#################   CLICKING ON MAIN ENEMY #####################

        Dim lcKicks As Decimal
        Dim lcClickValue As Decimal

        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateClicker(lcKicks, lcClickValue)

        'Adds Value to score board
        lcKicks = lcKicks + lcClickValue 'Click = 1 point

        'Send Updated Values Back
        Module_lvl_Varibles.ReturnValuesClicker(lcKicks, lcClickValue)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lcKicks)
    End Sub
    Private Sub TimerCheckPrices_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCheckPrices.Tick

        '###################    TIMER TO CHECK POWER UP BUTTONS PRICES TO ENABLE THEM OR DISABLE THEM    ################

        Dim lcDrinkCost As Single
        Dim lcKicks As Decimal
        Dim lcKidsCost As Single
        Dim lcNewShoesCost As Single
        Dim lcArrowCost As Decimal
        Dim lcProtectCost As Decimal

        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateCheckPrices(lcKicks, lcDrinkCost, lcKidsCost, lcNewShoesCost, lcArrowCost, lcProtectCost)

        'Checks all the prices to see if you have enought points to buy power up
        Reuseable_Code.CheckPrices(btnEnergyDrink, lcDrinkCost, lcKicks)
        Reuseable_Code.CheckPrices(btnKids, lcKidsCost, lcKicks)
        Reuseable_Code.CheckPrices(btnNewShoes, lcNewShoesCost, lcKicks)
        Reuseable_Code.CheckPrices(frmEndGame.btnPowerUpArrows, lcArrowCost, lcKicks)
        Reuseable_Code.CheckPrices(frmEndGame.btnProtectPowerUp, lcProtectCost, lcKicks)

        'Send Updated values back
        Module_lvl_Varibles.ReturnValuesCheckPrices(lcKicks, lcDrinkCost, lcKidsCost, lcNewShoesCost, lcArrowCost, lcProtectCost)
    End Sub
    Private Sub TimerAutoClicker_Tick(sender As Object, e As EventArgs) Handles TimerAutoClicker.Tick

        '######################   TIMER TO CONTROL AUTO CLICKER POWER UP    ############################

        Dim lcKicksPerSecond As UShort
        Dim lcKicks As Decimal

        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateTimer2(lcKicksPerSecond, lcKicks)

        'Auto clicks on a timer adds value to score
        lcKicks = lcKicks + lcKicksPerSecond

        'Sends Updated values back
        Module_lvl_Varibles.ReturnValuesTimer2(lcKicksPerSecond, lcKicks)

        'Update Screen
        Reuseable_Code.UpdateScreen(lblScore, lcKicks)
    End Sub
    Private Sub TimerCheckAchivements_Tick(sender As Object, e As EventArgs) Handles TimerCheckAchivements.Tick

        '##############   TIMER TO CHECK IF ACHIVEMENTS HAVE BEEN EARNT AND DISPLAYS BUTTONS   ##########

        Reuseable_Code.CheckAchivementButtons()


    End Sub
    Private Sub TimerEnemyApparesTimer_Tick(sender As Object, e As EventArgs) Handles TimerEnemyApparesTimer.Tick

        '#################   TIMER TO COUNT DOWN BEFORE ENEMY APARES   ################

        Dim lcTime As UShort

        'Sends Varibles To Get Updated
        Module_lvl_Varibles.UpdateEnemyTimer(lcTime)

        'Starts Counting Down
        lcTime = lcTime - 1

        'Returns Updated Varibles
        Module_lvl_Varibles.ReturnEnemyTimer(lcTime)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblCountDownTillEnemyAppears, lcTime)

        ' Once The Timer Hits 0 Then Stops Timers And Opens New Form
        If lcTime = 0 Then
            frmEndGame.Show()
            TimerEnemyApparesTimer.Stop()
            TimerEnemyApparesTimer.Enabled = False
        End If

        'Returns Updated Varibles
        Module_lvl_Varibles.ReturnEnemyTimer(lcTime)

    End Sub
    Private Sub btnEnergyDrink_Click(sender As Object, e As EventArgs) Handles btnEnergyDrink.Click

        '##################### ENERGYDRINK POWER UP BUTTON   #######################


        Dim lcDrinkCost As Single
        Dim lcKicks As Decimal
        Dim lcClickValue As Decimal
        Dim lcEnergyDrinksOwned As UShort
        Dim lcValue As Decimal = 0.1
        Dim lcAllPowerUpsOwned As UShort

        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateEnergyDrink(lcDrinkCost, lcKicks, lcClickValue, lcEnergyDrinksOwned, lcAllPowerUpsOwned)

        'Incresses Click Value
        Reuseable_Code.IncressClickValue(lcClickValue, lcValue)

        'Takes away cost of power up off of score
        Reuseable_Code.TakeAwayCost(lcKicks, lcDrinkCost)

        'Incresses cost of power up
        Reuseable_Code.IncressCost(lcDrinkCost)

        'Updates button text
        btnEnergyDrink.Text = "Energy Drink Cost " & (lcDrinkCost) & " Kicks Perk your self up with an energy drink Incresses your kick rate by 0.1"

        'Adds One When Power Up Is Brought
        lcEnergyDrinksOwned = lblEnergyDrinksOwned.Text + 1
        lcAllPowerUpsOwned = lblAllPowerUpsOwned.Text + 1

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblEnergyDrinksOwned, lcEnergyDrinksOwned)
        Reuseable_Code.UpdateScreen(lblAllPowerUpsOwned, lcAllPowerUpsOwned)

        'Send updated values back
        Module_lvl_Varibles.ReturnValuesEnergyDrink(lcDrinkCost, lcKicks, lcClickValue, lcEnergyDrinksOwned, lcAllPowerUpsOwned)
    End Sub
    Private Sub btnKids_Click(sender As Object, e As EventArgs) Handles btnKids.Click

        '###################   KIDS POWER UP BUTTON   #########################

        Dim lcKicksPerSecond As UShort
        Dim lcKicks As Decimal
        Dim lcKidsCost As Single
        Dim lcKidsOwned As UShort
        Dim lcCountPerSecond As Decimal
        Dim lcAllPowerUpsOwned As UShort


        TimerAutoClicker.Start()


        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateKids(lcKicks, lcKidsCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcAllPowerUpsOwned)

        'Incresses about of auto clicks pr second
        lcKicksPerSecond = lcKicksPerSecond + 1

        'Takes away cost of power up
        Reuseable_Code.TakeAwayCost(lcKicks, lcKidsCost)

        'Incresse power up cost
        Reuseable_Code.IncressCost(lcKidsCost)

        'Updates button with new cost
        btnKids.Text = "Extra Kids Cost " & (lcKidsCost) & " Kicks Call For Other Kids To Help Automaticly Adds 1 Kick Per Second"

        'Adds One When Power Up Is Brought
        lcKidsOwned = lblKidsOwned.Text + 1
        lcAllPowerUpsOwned = lcAllPowerUpsOwned + 1

        'Sets value for auto clicker
        lcCountPerSecond = lcKicksPerSecond

        'Sends Updated values back
        Module_lvl_Varibles.ReturnValuesKids(lcKicks, lcKidsCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcAllPowerUpsOwned)

        'Update Screen
        Reuseable_Code.UpdateScreen(lblKidsOwned, lcKidsOwned)
        Reuseable_Code.UpdateScreen(lblAllPowerUpsOwned, lcAllPowerUpsOwned)
        Reuseable_Code.UpdateScreen(lblScorePerSecond, lcCountPerSecond)
        Reuseable_Code.UpdateScreen(lblScore, lcKicksPerSecond)
    End Sub
    Private Sub btnNewShoes_Click(sender As Object, e As EventArgs) Handles btnNewShoes.Click

        '######################   NEW SHOES POWER UP BUTTON   ###########################

        Dim lcNewShoesCost As Single
        Dim lcKicks As Decimal
        Dim lcClickValue As Decimal
        Dim lcNewShoesOwned As UShort
        Dim lcAllPowerUpsOwned As UShort

        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateNewShoes(lcNewShoesCost, lcKicks, lcClickValue, lcNewShoesOwned, lcAllPowerUpsOwned)

        'What the power up is worth
        Dim lcValueOfPowerUp As Decimal = 1

        'Updates Click value with an extra click
        Reuseable_Code.IncressClickValue(lcClickValue, lcValueOfPowerUp)

        'Takes away cost of power up
        Reuseable_Code.TakeAwayCost(lcKicks, lcNewShoesCost)

        'Incresses cost of power up
        Reuseable_Code.IncressCost(lcNewShoesCost)

        'updates button with new cost
        btnNewShoes.Text = "New Shoes Cost" & (lcNewShoesCost) & " Kicks Buy some new shoes to replace your old worn out ones. Incresses your click value by 1"

        'Adds One When Power Up Is Brought
        lcNewShoesOwned = lblNewShoesOwned.Text + 1
        lcAllPowerUpsOwned = lblAllPowerUpsOwned.Text + 1

        'Sends updates values back
        Module_lvl_Varibles.ReturnValuesNewShoes(lcNewShoesCost, lcKicks, lcClickValue, lcNewShoesOwned, lcAllPowerUpsOwned)

        'Update screen
        Reuseable_Code.UpdateScreen(lblNewShoesOwned, lcNewShoesOwned)
        Reuseable_Code.UpdateScreen(lblAllPowerUpsOwned, lcAllPowerUpsOwned)
    End Sub
    Private Sub btnCheat_Click(sender As Object, e As EventArgs) Handles btnCheat.Click

        '#######################   BUTTON TO LET YOU CHEAT   ########################

        Dim lcKicks As Decimal
        Dim lcCheat As Double

        'Sends Varibles to get updated
        Module_lvl_Varibles.UpdateCheats(lcKicks)

        'Varible = number in text box
        lcCheat = txtCheatBox.Text

        'Adds number to score
        lcKicks = lcCheat + lcKicks

        'sends values back
        Module_lvl_Varibles.ReturnValuesCheats(lcKicks)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lcKicks)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '####################### SAVES THE GAME AND ALL VARIBLES   ###########################

        Dim lcKicks As Decimal
        Dim lcClickValue As Decimal
        Dim lcDrinkCost As Single
        Dim lcEnergyDrinksOwned As UShort
        Dim lcKidsCost As Single
        Dim lcNewShoesCost As Single
        Dim lcKicksPerSecond As UShort
        Dim lcKidsOwned As UShort
        Dim lcCountPerSecond As Decimal
        Dim lcNewShoesOwned As UShort
        Dim lcTime As UShort
        Dim lcEnemyHeathPoints As Short
        Dim lcEnemyClickValue As Decimal
        Dim lcArrowsCost As Decimal
        Dim lcProtectCost As Decimal
        Dim lcDammageToEnemy As Decimal
        Dim lcAllPowerUpsOwned As UShort
        Dim lcArrowPowerUpsOwned As UShort
        Dim lcProtectPowerUpsOwned As UShort

        'Sends Varibles To Get Updated
        Module_lvl_Varibles.UpdateSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Saves All Varibles
        Saveing.SaveFileAs(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends Varibles To Get Updated
        Module_lvl_Varibles.ReturnValuesSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        '######################   LOADS THE GAME AND ALL VARIBLES   #########################

        Dim lcKicks As Decimal
        Dim lcClickValue As Decimal
        Dim lcDrinkCost As Single
        Dim lcEnergyDrinksOwned As UShort
        Dim lcKidsCost As Single
        Dim lcNewShoesCost As Single
        Dim lcKicksPerSecond As UShort
        Dim lcKidsOwned As UShort
        Dim lcCountPerSecond As Decimal
        Dim lcNewShoesOwned As UShort
        Dim lcTime As UShort
        Dim lcEnemyHeathPoints As Short
        Dim lcEnemyClickValue As Decimal
        Dim lcArrowsCost As Decimal
        Dim lcProtectCost As Decimal
        Dim lcDammageToEnemy As Decimal
        Dim lcAllPowerUpsOwned As UShort
        Dim lcArrowPowerUpsOwned As UShort
        Dim lcProtectPowerUpsOwned As UShort


        'Sends varibles to get updated
        Module_lvl_Varibles.UpdateSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Loads games with saves varibles
        Saveing.Load(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.ReturnValuesSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.UpdateSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Updates screen with saved Varibles
        Reuseable_Code.UpdateScreenSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.ReturnValuesSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

    End Sub
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        '##########################   LETS YOU SEE YOUR SAVE FILE   ##############################

        'Open to see save file
        Saveing.OpenFile()
    End Sub
    Private Sub btnAchievements_Click(sender As Object, e As EventArgs) Handles btnAchievements.Click

        '#######################   BUTTON TO SHOW ALL ACHIVEMENTS EARNT ON ANOTHER FORM   ####################

        'Opens Achivement Form
        frmAchievements.Show()

        'Hides Main Form
        Me.Hide()
    End Sub
    Private Sub btnAchivements100Milestone_Click(sender As Object, e As EventArgs) Handles btnAchivement100MileStone.Click

        '#######################   100 KICKS ACHIVEMENT BUTTON   ##########################

        Dim lckicks As Decimal
        Dim lcReward100 = 50

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(0))

        'Rewards The Player
        lckicks = lckicks + lcReward100

        'Adds Achivement To A List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(0))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lckicks)

        'Disables Button So User Can't Claim It Twise
        btnAchivement100MileStone.Enabled = False

    End Sub
    Private Sub btnAchivement500MileStone_Click(sender As Object, e As EventArgs) Handles btnAchivement500MileStone.Click

        '########################   500 KICKS ACHIVEMENT BUTTON   #############################

        Dim lckicks As Decimal
        Dim lcReward500 = 200

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(1))

        'Rewards The Player
        lckicks = lckicks + lcReward500

        'Adds Achivement To List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(1))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)

        'UpDates Screen
        Reuseable_Code.UpdateScreen(lblScore, lckicks)

        'Disables Button So User Can't Claim It Twise
        btnAchivement500MileStone.Enabled = False
    End Sub
    Private Sub btnAchivement1000MileStone_Click(sender As Object, e As EventArgs) Handles btnAchivement1000MileStone.Click

        '#######################   1000 KICKS ACHVEMENT BUTTON   #########################

        Dim lckicks As Decimal
        Dim lcReward1000 = 500

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(2))

        'Rewards The Player
        lckicks = lckicks + lcReward1000

        'Adds Achivement To List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(2))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lckicks)

        'Disables Button So User Can't Claim It Twise
        btnAchivement1000MileStone.Enabled = False
    End Sub
    Private Sub btnAchivementMileStone5PowerUps_Click(sender As Object, e As EventArgs) Handles btnAchivementMileStone5PowerUps.Click

        '########################   5 POWER UPS ACHIVEMENT BUTTON   #########################

        Dim lcClickValue As Decimal
        Dim lcEnergyDrinksOwned As UShort
        Dim lcValue As Decimal = 0.1
        Dim lcAllPowerUpsOwned As UShort

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateFreePowerUpEnergyDrink(lcClickValue, lcEnergyDrinksOwned, lcAllPowerUpsOwned)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(3))

        'Gives Free Power Up
        Reuseable_Code.IncressClickValue(lcClickValue, lcValue)

        'Adds One To Amount Of Power Ups Owned
        lcEnergyDrinksOwned = lblEnergyDrinksOwned.Text + 1

        'Adds Achivement To List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(3))

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblEnergyDrinksOwned, lcEnergyDrinksOwned)
        Reuseable_Code.UpdateScreen(lblAllPowerUpsOwned, lcAllPowerUpsOwned)

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesFreePowerUpEnergyDrink(lcClickValue, lcEnergyDrinksOwned, lcAllPowerUpsOwned)

        'Disables Button So User Can't Claim It Twise
        btnAchivementMileStone5PowerUps.Enabled = False
    End Sub

    Private Sub btnAchivementMileStone20PowerUps_Click(sender As Object, e As EventArgs) Handles btnAchivementMileStone20PowerUps.Click

        '####################  20 POWER UPS ACHIVEMENT BUTTON   #############################

        Dim lcKicksPerSecond As UShort
        Dim lcKidsOwned As UShort
        Dim lcCountPerSecond As Decimal
        Dim lcAllPowerUpsOwned As UShort

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateFreePowerUpKids(lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcAllPowerUpsOwned)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(4))

        'Gives Free Power Up
        lcKicksPerSecond = lcKicksPerSecond + 1
        lcCountPerSecond = lcKicksPerSecond

        'Adds One To Amount Of Power Ups Owned
        lcKidsOwned = lblKidsOwned.Text + 1

        'Adds Achivement To List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(4))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesFreePowerUpKids(lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcAllPowerUpsOwned)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblAllPowerUpsOwned, lcAllPowerUpsOwned)
        Reuseable_Code.UpdateScreen(lblScorePerSecond, lcCountPerSecond)
        Reuseable_Code.UpdateScreen(lblScore, lcKicksPerSecond)

        'Disables Button So User Can't Claim It Twise
        btnAchivementMileStone20PowerUps.Enabled = False
    End Sub
    Private Sub btnAchivementsMileStone50PowerUp_Click(sender As Object, e As EventArgs) Handles btnAchivementMileStone50PowerUp.Click

        '#########################   50 POWER UPS ACHIVEMENT BUTTON   #############################3

        Dim lcClickValue As Decimal
        Dim lcNewShoesOwned As UShort
        Dim lcAllPowerUpsOwned As UShort
        Dim lcValueOfPowerUp As Decimal = 1

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateFreePowerUpNewShoes(lcClickValue, lcNewShoesOwned, lcAllPowerUpsOwned)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(5))


        'Gives Free Power Up
        Reuseable_Code.IncressClickValue(lcClickValue, lcValueOfPowerUp)

        'Adds One To Amount Of Power Ups Owned
        lcNewShoesOwned = lblNewShoesOwned.Text + 1

        'Adds Achivment To A List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(5))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesFreePowerUpNewShoes(lcClickValue, lcNewShoesOwned, lcAllPowerUpsOwned)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblNewShoesOwned, lcNewShoesOwned)
        Reuseable_Code.UpdateScreen(lblAllPowerUpsOwned, lcAllPowerUpsOwned)

        'Disables Button So User Can't Claim It Twise
        btnAchivementMileStone50PowerUp.Enabled = False
    End Sub
    Private Sub btnAchivementMileStone1000KicksHeld_Click(sender As Object, e As EventArgs) Handles btnAchivementMileStone1000KicksHeld.Click

        '#########################   1000 KICKS ACHIVEMENT BUTTON   ###########################

        Dim lckicks As Decimal
        Dim lcReward100 = 500

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(6))

        'Rewards The Player
        lckicks = lckicks + lcReward100

        ''Adds Achivment To A List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(6))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lckicks)

        'Disables Button So User Can't Claim It Twise
        btnAchivementMileStone1000KicksHeld.Enabled = False
    End Sub
    Private Sub btnAchivementMileStone5000KicksHeld_Click(sender As Object, e As EventArgs) Handles btnAchivementMileStone5000KicksHeld.Click

        '###########################   5000 KICKS ACHIVEMENT BUTTON   ##############################3

        Dim lckicks As Decimal
        Dim lcReward100 = 1000

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(7))

        'Rewards The Player
        lckicks = lckicks + lcReward100

        'Adds Achivment To A List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(7))

        'Returns Varibles 
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lckicks)

        'Disables Button So User Can't Claim It Twise
        btnAchivementMileStone5000KicksHeld.Enabled = False
    End Sub
    Private Sub btnAchivementMileStone10000KicksHeld_Click(sender As Object, e As EventArgs) Handles btnAchivementMileStone10000KicksHeld.Click

        '###########################   10000 KICKS ACHIVEMENT BUTTON   ##############################

        Dim lckicks As Decimal
        Dim lcReward100 = 5000

        'Checks Achivement Messages
        Storing_Achivements.Achivements()

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        'Message Box Shows Message Stored In Array
        MessageBox.Show(Storing_Achivements.AchivementMessages(8))

        'Rewards The Player
        lckicks = lckicks + lcReward100

        'Adds Achivment To A List Box On Another Form
        frmAchievements.lbAchivements.Items.Add(Storing_Achivements.AchivementMessages(8))

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblScore, lckicks)

        'Disables Button So User Can't Claim It Twise
        btnAchivementMileStone10000KicksHeld.Enabled = False
    End Sub

    Private Sub btnLoadFromEnemyScreen_Click(sender As Object, e As EventArgs) Handles btnLoadFromEnemyScreen.Click

        '#########################  LOAD BUTTON FOR IF SAVED ON THE ENEMY SCREEN   ####################

        Dim lcKicks As Decimal
        Dim lcClickValue As Decimal
        Dim lcDrinkCost As Single
        Dim lcEnergyDrinksOwned As UShort
        Dim lcKidsCost As Single
        Dim lcNewShoesCost As Single
        Dim lcKicksPerSecond As UShort
        Dim lcKidsOwned As UShort
        Dim lcCountPerSecond As Decimal
        Dim lcNewShoesOwned As UShort
        Dim lcTime As UShort
        Dim lcEnemyHeathPoints As Short
        Dim lcEnemyClickValue As Decimal
        Dim lcArrowsCost As Decimal
        Dim lcProtectCost As Decimal
        Dim lcDammageToEnemy As Decimal
        Dim lcAllPowerUpsOwned As UShort
        Dim lcArrowPowerUpsOwned As UShort
        Dim lcProtectPowerUpsOwned As UShort

        'Sends varibles to get updated
        Module_lvl_Varibles.UpdateSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Loads games with saves varibles
        Saveing.LoadFromEnemyScreen(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.ReturnValuesSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.UpdateSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Updates screen with saved Varibles
        Reuseable_Code.UpdateScreenSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.ReturnValuesSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

    End Sub
End Class
