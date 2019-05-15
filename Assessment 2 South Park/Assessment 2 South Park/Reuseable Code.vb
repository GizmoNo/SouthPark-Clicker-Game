Module Reuseable_Code
    Public Function UpdateScreen(ByRef prDisplayValue As Label, ByRef prScore As Double)

        '########################   Updates Screen   #############################   

        prDisplayValue.Text = prScore
        Return prDisplayValue
    End Function
    Public Sub CheckPrices(ByRef prPowerup As Button, ByRef prCost As Double, ByRef prScore As Double)

        '##############################   Checks to see if you have enough points to buy power up if 
        'you do buttons are clickable if not they are unclickable  #############################

        If prScore >= prCost Then
            prPowerup.Enabled = True
        Else
            prPowerup.Enabled = False
        End If
    End Sub
    Public Function IncressClickValue(ByRef prClickValue As Decimal, ByVal prAmountToAdd As Decimal)

        '########################   Updates the value of each click   ###########################

        prClickValue = prClickValue + prAmountToAdd
        Return prClickValue
    End Function
    Public Function TakeAwayCost(ByRef prScore As Decimal, ByRef prCost As Decimal)

        '#######################   Takes cost of power up off of score   ##########################

        prScore = prScore - prCost
        Return prScore
    End Function
    Public Function IncressCost(ByRef prPowerUpCost As Decimal)

        '#########################   Incresses cost of power up   ##########################3

        prPowerUpCost = prPowerUpCost * 1.2
        Return prPowerUpCost
    End Function
    Public Sub UpdateScreenSaveLoad(ByVal prKicks, ByVal prClicks, ByVal prDrink, ByVal prEnergyDrinksOwned, ByVal prKids, ByVal prShoes, ByVal prKicksPerSecond, ByVal prKidsOwned, ByVal prCountPerSecond, ByVal prNewShoesOwned, ByVal prTime, ByVal prEnemyHeathPoints, ByVal prEnemyClickValue, ByVal prArrowsCost, ByVal prProtectCost, ByVal prDammageToEnemy, ByVal prAllPowerUpsOwned, ByVal prArrowPowerUpsOwned, ByVal prProtectPowerUpsOwned)

        '#################   Updates Screen with new varibles after loading a game   #################

        Dim lcClickValue As Decimal
        Dim lcKicksPerSecond As UShort
        Dim lcEnemyClickValue As Decimal
        Dim lcDammageToEnemy As Decimal
        prKicks = frmSouthPark.lblScore
        lcClickValue = prClicks
        frmSouthPark.btnEnergyDrink.Text = "Energy Drink Cost " & (prDrink) & " Kicks Perk your self up with an energy drink Incresses your kick rate by 0.1"
        frmSouthPark.lblEnergyDrinksOwned.Text = prEnergyDrinksOwned
        frmSouthPark.btnKids.Text = "Extra Kids Cost " & (prKids) & " Kicks Call For Other Kids To Help Automaticly Adds 1 Kick Per Second"
        frmSouthPark.btnNewShoes.Text = "New Shoes Cost" & (prShoes) & " Kicks Buy some new shoes to replace your old worn out ones"
        prKicksPerSecond = lcKicksPerSecond
        frmSouthPark.lblKidsOwned.Text = prKidsOwned
        frmSouthPark.lblScorePerSecond.Text = prCountPerSecond
        frmSouthPark.lblNewShoesOwned.Text = prNewShoesOwned
        frmSouthPark.lblCountDownTillEnemyAppears.Text = prTime
        frmEndGame.lblHealthPoints.Text = prEnemyHeathPoints
        lcEnemyClickValue = prEnemyClickValue
        frmEndGame.btnPowerUpArrows.Text = "Arrow Barrage " & (prArrowsCost) & " Get The Other Kids To Send In A Arrow Barrage To Fend Off The Enemy.Upgrades Dammage Per Click By 1"
        frmEndGame.btnProtectPowerUp.Text = "Protect " & (prProtectCost) & "Get Kids To Protect Your Points. Decreases  Cost Per Click By 0.5. You Can Only Buy This Once"
        lcDammageToEnemy = prDammageToEnemy
        frmSouthPark.lblAllPowerUpsOwned.Text = prAllPowerUpsOwned
        frmEndGame.lblArrowsOwned.Text = prArrowPowerUpsOwned
        frmEndGame.lblProtectOwned.Text = prProtectPowerUpsOwned



    End Sub

    Public Sub HideButtons()

        '####################   HIDES ALL ACHIVEMENT BUTTONS   ########################

        frmSouthPark.btnAchivement100MileStone.Hide()
        frmSouthPark.btnAchivement500MileStone.Hide()
        frmSouthPark.btnAchivement1000MileStone.Hide()
        frmSouthPark.btnAchivementMileStone5PowerUps.Hide()
        frmSouthPark.btnAchivementMileStone20PowerUps.Hide()
        frmSouthPark.btnAchivementMileStone50PowerUp.Hide()
        frmSouthPark.btnAchivementMileStone1000KicksHeld.Hide()
        frmSouthPark.btnAchivementMileStone5000KicksHeld.Hide()
        frmSouthPark.btnAchivementMileStone10000KicksHeld.Hide()
    End Sub
    Public Sub CheckAchivementButtons()

        '##########################   CHECKS TO SEE IF YOU HAVE UNLOCKED ACHIVEMENT   ###################

        Dim lckicks As Decimal

        'Updates Varibles
        Module_lvl_Varibles.UpdateAchivementClick(lckicks)

        If lckicks >= 100 Then
            frmSouthPark.btnAchivement100MileStone.Show()
        End If
        If lckicks >= 500 Then
            frmSouthPark.btnAchivement500MileStone.Show()
        End If
        If lckicks >= 1000 Then
            frmSouthPark.btnAchivement1000MileStone.Show()
        End If
        If frmSouthPark.lblAllPowerUpsOwned.Text = 5 Then
            frmSouthPark.btnAchivementMileStone5PowerUps.Show()
        End If
        If frmSouthPark.lblAllPowerUpsOwned.Text = 20 Then
            frmSouthPark.btnAchivementMileStone20PowerUps.Show()
        End If
        If frmSouthPark.lblAllPowerUpsOwned.Text = 50 Then
            frmSouthPark.btnAchivementMileStone50PowerUp.Show()
        End If
        If lckicks >= 1000 Then
            frmSouthPark.btnAchivementMileStone1000KicksHeld.Show()
        End If
        If lckicks >= 5000 Then
            frmSouthPark.btnAchivementMileStone5000KicksHeld.Show()
        End If
        If lckicks >= 10000 Then
            frmSouthPark.btnAchivementMileStone10000KicksHeld.Show()
        End If

        'Returns Varibles
        Module_lvl_Varibles.ReturnValuesAchivementClick(lckicks)
    End Sub
    Public Function UpdateScreenEnemy(ByRef prDisplayValue As Label, ByRef prScore As Double)

        '###################   Updates Screen FOR ENEMY SCREEN ONLY  ##########################
        '###################   MAKES SURE THAT ALL VARIBLES ON PAGE ARE 3 DECIMAL PLACES   ###########

        prDisplayValue.Text = (FormatNumber(CDbl(prScore), 3))
        Return prDisplayValue
    End Function
End Module
