Public Class frmEndGame
    Private Sub frmEndGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '#######################   Updates All Varibles On Screen When Form Loads   ########################

        'Starts Timer That AutoMaticly Takes Points Of User Score
        TmrTakesAwayPoints.Start()

        'Stops AutoClicker Timer On Main Form
        frmSouthPark.TimerAutoClicker.Stop()


        Dim lcKicks As Decimal
        Dim lcEnemyHealthPoints As Short
        Dim lcEnemyClickValue As Decimal
        Dim lcArrowsCost As Decimal
        Dim lcArrowsOwned As UShort
        Dim lcProtectOwned As UShort

        'Updates Varibles
        Module_lvl_Varibles.UpdateEndGameForm(lcKicks, lcEnemyHealthPoints, lcArrowsCost, lcEnemyClickValue, lcArrowsOwned, lcProtectOwned)

        'Updates Screen
        Reuseable_Code.UpdateScreenEnemy(lblEnemyKicks, lcKicks)
        Reuseable_Code.UpdateScreen(lblArrowsOwned, lcArrowsOwned)
        Reuseable_Code.UpdateScreen(lblProtectOwned, lcProtectOwned)

        'Updates Button Text
        lblHealthPoints.Text = lcEnemyHealthPoints
        btnPowerUpArrows.Text = "Arrow Barrage " & (lcArrowsCost) & " Get The Other Kids To Send In A Arrow Barrage To Fend Off The Enemy.Upgrades Dammage Per Click By 1"

        'Returns Varibes
        Module_lvl_Varibles.ReturnValuesEndGameForm(lcKicks, lcEnemyHealthPoints, lcArrowsCost, lcEnemyClickValue, lcArrowsOwned, lcProtectOwned)
    End Sub

    Private Sub TimerTakesAwayPoints_Tick(sender As Object, e As EventArgs) Handles TmrTakesAwayPoints.Tick

        '###################   Timer To AutoMaticly Take Score Off The User Score   ###################

        Dim lcKicks As Decimal

        'Updates Varibles
        Module_lvl_Varibles.UpdateEnemyTimerValues(lcKicks)

        'Continusly Takes 1 Off User Score
        lcKicks = lcKicks - 1

        'Updates Screen
        Reuseable_Code.UpdateScreenEnemy(lblEnemyKicks, lcKicks)

        'Returns Varibles
        Module_lvl_Varibles.ReturnEnemyTimerValues(lcKicks)

        'If Score = 0 Then Will Shows Message Box And Close The Game
        If lcKicks <= 0 Then
            TmrTakesAwayPoints.Stop()
            MessageBox.Show("GAME OVER")
            frmSouthPark.Close()
        End If

    End Sub

    Private Sub pbEnemy_Mousedown(sender As Object, e As EventArgs) Handles pbEnemy.MouseDown

        '######################  Clicking On The Enemy   #####################

        Dim lcEnemyClickValue As Decimal
        Dim lcDammageToEnemy As Decimal
        Dim lcEnemyHealthPoints As Short
        Dim lcKicks As Decimal
        Dim lcTime As UShort

        'Update Varibles
        Module_lvl_Varibles.UpdateEnemyValues(lcKicks, lcEnemyHealthPoints, lcTime, lcDammageToEnemy, lcEnemyClickValue)

        'Each Time You Click On The Enemy Takes Away 1 Point On Score
        lcKicks = lcKicks - lcEnemyClickValue

        'Every Time You Click On Enemy Takes Away There Health Points
        lcEnemyHealthPoints = lcEnemyHealthPoints - lcDammageToEnemy

        'Returns Varibles
        Module_lvl_Varibles.ReturnEnemyValues(lcKicks, lcEnemyHealthPoints, lcTime, lcDammageToEnemy, lcEnemyClickValue)

        'If Enemy Health = 0 Then Stops Timer Closes Enemy Form Shows Main Form Shows Message Box
        'Makes Enemy Health Points 100 Again Makes Timer 5 min Again Starts Enemy Timer Again
        'Restarts AutoClicker Timer Again
        If lcEnemyHealthPoints <= 0 Then
            TmrTakesAwayPoints.Stop()
            Me.Close()
            frmSouthPark.Show()
            MessageBox.Show("You Stoped Her For Now")
            lcTime = 300
            lcEnemyHealthPoints = 100
            frmSouthPark.TimerEnemyApparesTimer.Start()
            frmSouthPark.TimerAutoClicker.Start()

        End If

        'Updtes Screen
        Reuseable_Code.UpdateScreenEnemy(lblEnemyKicks, lcKicks)
        Reuseable_Code.UpdateScreen(lblHealthPoints, lcEnemyHealthPoints)

        'Returns Varibles
        Module_lvl_Varibles.ReturnEnemyValues(lcKicks, lcEnemyHealthPoints, lcTime, lcDammageToEnemy, lcEnemyClickValue)

    End Sub

    Private Sub btnPowerUpArrows_Click(sender As Object, e As EventArgs) Handles btnPowerUpArrows.Click

        '#######################   Power Up Arrows   ####################################

        Dim lcDammageToEnemy As Decimal
        Dim lcKicks As Decimal
        Dim lcArrowsCost As Decimal
        Dim lcArrowsOwned As UShort
        Dim lcValue As Byte = 1

        'Updates Varibles
        Module_lvl_Varibles.UpdateArrowPowerUp(lcDammageToEnemy, lcKicks, lcArrowsCost, lcArrowsOwned)

        'Incresses Dammage To Enemy
        Reuseable_Code.IncressClickValue(lcDammageToEnemy, lcValue)

        'Adds 1 To Amount Owned
        lcArrowsOwned = lcArrowsOwned + 1

        'Takes Away Cost Of Power Up
        Reuseable_Code.TakeAwayCost(lcKicks, lcArrowsCost)

        'Incresses Cost Of Power Up
        Reuseable_Code.IncressCost(lcArrowsCost)

        'Updates Label With New Cost
        btnPowerUpArrows.Text = "Arrow Barrage " & (lcArrowsCost) & " Get The Other Kids To Send In A Arrow Barrage To Fend Off The Enemy.Upgrades Dammage Per Click By 1"

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblArrowsOwned, lcArrowsOwned)

        'Returns Varibles
        Module_lvl_Varibles.ReturnArrowPowerUp(lcDammageToEnemy, lcKicks, lcArrowsCost, lcArrowsOwned)
    End Sub
    Private Sub ProtectPowerUp_Click(sender As Object, e As EventArgs) Handles btnProtectPowerUp.Click

        '###########################   Protect Power Up   ################################

        Dim lcEnemyClickValue As Decimal
        Dim lcKicks As Decimal
        Dim lcProtectCost As Decimal
        Dim lcProtectOwned As UShort

        'Updates Varibles
        Module_lvl_Varibles.UpdateProtectPowerUp(lcEnemyClickValue, lcKicks, lcProtectCost, lcProtectOwned)

        'Makes Click Value = 0.5
        lcEnemyClickValue = lcEnemyClickValue - 0.1

        'Takes Away Cost Of Power Up
        Reuseable_Code.TakeAwayCost(lcKicks, lcProtectCost)

        'Incresses Cost
        Reuseable_Code.IncressCost(lcProtectCost)

        'Updates Label With New Cost
        btnProtectPowerUp.Text = "Protect:" & (lcProtectCost) & "Get Kids To Protect Your Points. Decreases  Cost Per Click By 0.1."

        'Adds One To Amount Owned
        lcProtectOwned = lcProtectOwned + 1

        'Updates Screen
        Reuseable_Code.UpdateScreen(lblProtectOwned, lcProtectOwned)

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesProtectPowerUp(lcEnemyClickValue, lcKicks, lcProtectCost, lcProtectOwned)

    End Sub
    Private Sub LoadFromEnemyScreen_Click(sender As Object, e As EventArgs) Handles btnLoadFromEnemyScreen.Click

        '#######################   Loads Game With All Varibles   #######################

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

        'Saves all values on screen
        Saveing.Load(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

        'Sends varibles to get updated
        Module_lvl_Varibles.ReturnValuesSaveLoad(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)
    End Sub
    Private Sub SaveFromEnemyScreen_Click(sender As Object, e As EventArgs) Handles btnSaveFromEnemyScreen.Click

        '#############################   Saves Game With All Varibles   ###########################

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
        Saveing.SaveFileAs(lcKicks, lcClickValue, lcDrinkCost, lcEnergyDrinksOwned, lcKidsCost, lcNewShoesCost, lcKicksPerSecond, lcKidsOwned, lcCountPerSecond, lcNewShoesOwned, lcTime, lcEnemyHeathPoints, lcEnemyClickValue, lcArrowsCost, lcProtectCost, lcDammageToEnemy, lcAllPowerUpsOwned, lcArrowPowerUpsOwned, lcProtectPowerUpsOwned)

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