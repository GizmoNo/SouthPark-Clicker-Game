Module Module_lvl_Varibles

    '###  Contians all mdvalues used to update varibles and send them between forms when called ###

    Dim mdNewShoesCost = 500
    Dim mdKickValue = 0
    Dim mdClickValue = 1
    Dim mdKidsCost = 200
    Dim mdDrinkCost = 15
    Dim mdKicksPerSecond = 0
    Dim mdEnergyDrinksOwned = 0
    Dim mdKidsOwned = 0
    Dim mdNewShoesOwned = 0
    Dim mdCountPerSecond = 0
    Dim mdTime = 300
    Dim mdEnemyHeathPoints = 100
    Dim mdEnemyClickValue = 1
    Dim mdArrowsCost = 1000
    Dim mdProtectCost = 50000.567
    Dim mdDammageToEnemy = 1
    Dim mdAllPowerUpsOwned = 0
    Dim mdArrowsOwned = 0
    Dim mdProtectOwned = 0
    Public Sub UpdateClicker(ByRef prKicks, ByRef prClicks)

        '#######################   UPDATES VARIBLES FOR MAIN CLICKER   ###########################

        prKicks = mdKickValue
        prClicks = mdClickValue
    End Sub
    Public Sub ReturnValuesClicker(prKicks, prClicks)

        '##########################   RETURNS VARIBLES FOR MAIN CLICKER   #######################3

        mdKickValue = prKicks
        mdClickValue = prClicks
    End Sub
    Public Sub UpdateEnergyDrink(ByRef prDrink, ByRef prKicks, ByRef prClicks, ByRef prEnergyDrinksOwned, ByRef prAllPowerUpsOwned)

        '#############################  UPDATES ENERGY DRINK POWER UP VARIBLES  #######################

        prDrink = mdDrinkCost
        prKicks = mdKickValue
        prClicks = mdClickValue
        prEnergyDrinksOwned = mdEnergyDrinksOwned
        prAllPowerUpsOwned = mdAllPowerUpsOwned

    End Sub
    Public Sub ReturnValuesEnergyDrink(prDrink, prKicks, prClicks, prEnergyDrinksOwned, prAllPowerUpsOwned)

        '#########################   RETURNS VARIBLES FOR ENERGY DRINK POWER UP   ###########################

        mdDrinkCost = prDrink
        mdKickValue = prKicks
        mdClickValue = prClicks
        mdEnergyDrinksOwned = prEnergyDrinksOwned
        mdAllPowerUpsOwned = prAllPowerUpsOwned

    End Sub
    Public Sub UpdateCheckPrices(ByRef prKicks, ByRef prDrink, ByRef prKids, ByRef prShoes, ByRef prArrowsCost, ByRef prProtectCost)

        '######################### UPDATES VARIBLES FOR CHECK PRICES TIMER   ############################

        prKicks = mdKickValue
        prDrink = mdDrinkCost
        prKids = mdKidsCost
        prShoes = mdNewShoesCost
        prArrowsCost = mdArrowsCost
        prProtectCost = mdProtectCost
    End Sub
    Public Sub ReturnValuesCheckPrices(prKicks, prDrink, prKids, prShoes, prArrowsCost, prProtectCost)

        '####################   RETURNS VARIBLES FOR CHECK PRICES TIMER   ##########################

        mdKickValue = prKicks
        mdDrinkCost = prDrink
        mdKidsCost = prKids
        mdNewShoesCost = prShoes
        mdArrowsCost = prArrowsCost
        mdProtectCost = prProtectCost

    End Sub
    Public Sub UpdateKids(ByRef prKicks, ByRef prKids, ByRef prkps, ByRef prKidsOwned, ByRef prCountingPerSecond, ByRef prAllPowerUpsOwned)

        '#######################   UPDATES VARIBLES FOR KIDS POWER UP   ###############################

        prKicks = mdKickValue
        prKids = mdKidsCost
        prkps = mdKicksPerSecond
        prKidsOwned = mdKidsOwned
        prCountingPerSecond = mdCountPerSecond
        prAllPowerUpsOwned = mdAllPowerUpsOwned
    End Sub
    Public Sub ReturnValuesKids(prKicks, prKids, prkps, prKidsOwned, prCountingPerSecond, prAllPowerUpsOwned)

        '#########################   RETURNS VARIBLES FOR KIDS POWER UP   #######################

        mdKickValue = prKicks
        mdKidsCost = prKids
        mdKicksPerSecond = prkps
        mdKidsOwned = prKidsOwned
        mdCountPerSecond = prCountingPerSecond
        mdAllPowerUpsOwned = prAllPowerUpsOwned
    End Sub
    Public Sub UpdateCheats(ByRef prKicks)

        '########################   UPDATES VARIBLES FOR CHEATS   ############################
        prKicks = mdKickValue
    End Sub
    Public Sub ReturnValuesCheats(prKicks)

        '###########################   RETURNS VARIBLES FOR CHEATS   #########################3

        mdKickValue = prKicks
    End Sub
    Public Sub UpdateTimer2(ByRef prKicksPerSecond, ByRef prKicks)

        '##########################   UPDATES VARIBLES FOR AUTOCLICKER TIMER   ######################

        prKicksPerSecond = mdKicksPerSecond
        prKicks = mdKickValue
    End Sub
    Public Sub ReturnValuesTimer2(prKicksPerSecond, prKicks)

        '#############################   RETURNS VARIBLES FOR AUTOCLICKER TIMER   ######################

        mdKicksPerSecond = prKicksPerSecond
        mdKickValue = prKicks
    End Sub
    Public Sub UpdateNewShoes(ByRef prShoes, ByRef prKicks, ByRef prClicks, ByRef prNewShoesOwned, ByRef prAllPowerUpsOwned)

        '#######################   UPDATES VARIBLES FOR NEW SHOWS POWER UP   ########################

        prShoes = mdNewShoesCost
        prKicks = mdKickValue
        prClicks = mdClickValue
        prNewShoesOwned = mdNewShoesOwned
        prAllPowerUpsOwned = mdAllPowerUpsOwned
    End Sub
    Public Sub ReturnValuesNewShoes(prShoes, prKicks, prClicks, prNewShoesOwned, prAllPowerUpsOwned)

        '######################## RETURNS VARIBLES FOR NEW SHOES POWER UP   #########################

        mdNewShoesCost = prShoes
        mdKickValue = prKicks
        mdClickValue = prClicks
        mdNewShoesOwned = prNewShoesOwned
        mdAllPowerUpsOwned = prAllPowerUpsOwned
    End Sub
    Public Sub UpdateSaveLoad(ByRef prKicks, ByRef prClicks, ByRef prDrink, ByRef prEnergyDrinksOwned, ByRef prKids, ByRef prShoes, ByRef prKicksPerSecond, ByRef prKidsOwned, ByRef prCountPerSecond, ByRef prNewShoesOwned, ByRef prTime, ByRef prEnemyHeathPoints, ByRef prEnemyClickValue, ByRef prArrowsCost, ByRef prProtectCost, ByRef prDammageToEnemy, ByRef prAllPowerUpsOwned, ByRef prArrowPowerUpsOwned, ByRef prProtectPowerUpsOwned)

        '########################   UPDATES VARIBLES FOR SAVEING AND LOADING   #######################

        prKicks = mdKickValue
        prClicks = mdClickValue
        prDrink = mdDrinkCost
        prEnergyDrinksOwned = mdEnergyDrinksOwned
        prKids = mdKidsCost
        prShoes = mdNewShoesCost
        prKicksPerSecond = mdKicksPerSecond
        prKidsOwned = mdKidsOwned
        prCountPerSecond = mdCountPerSecond
        prNewShoesOwned = mdNewShoesOwned
        prTime = mdTime
        prEnemyHeathPoints = mdEnemyHeathPoints
        prEnemyClickValue = mdEnemyClickValue
        prArrowsCost = mdArrowsCost
        prProtectCost = mdProtectCost
        prDammageToEnemy = mdDammageToEnemy
        prAllPowerUpsOwned = mdAllPowerUpsOwned
        prArrowPowerUpsOwned = mdArrowsOwned
        prProtectPowerUpsOwned = mdProtectOwned
    End Sub
    Public Sub ReturnValuesSaveLoad(prKicks, prClicks, prDrink, prEnergyDrinksOwned, prKids, prShoes, prKicksPerSecond, prKidsOwned, prCountPerSecond, prNewShoesOwned, prTime, prEnemyHealthPoints, prEnemyClickValue, prArrowsCost, prProtectCost, prDammageToEnemy, prAllPowerUpsOwned, prArrowPowerUpsOwned, prProtectPowerUpsOwned)

        '##########################   RETURNS VARIBLES FOR SAVEING AND LOADING   #########################

        mdKickValue = prKicks
        mdClickValue = prClicks
        mdDrinkCost = prDrink
        mdEnergyDrinksOwned = prEnergyDrinksOwned
        mdKidsCost = prKids
        mdNewShoesCost = prShoes
        mdKicksPerSecond = prKicksPerSecond
        mdKidsOwned = prKidsOwned
        mdCountPerSecond = prCountPerSecond
        mdNewShoesOwned = prNewShoesOwned
        mdTime = prTime
        mdEnemyHeathPoints = prEnemyHealthPoints
        mdEnemyClickValue = prEnemyClickValue
        mdArrowsCost = prArrowsCost
        mdProtectCost = prProtectCost
        mdDammageToEnemy = prDammageToEnemy
        mdAllPowerUpsOwned = prAllPowerUpsOwned
        mdArrowsOwned = prArrowPowerUpsOwned
        mdProtectOwned = prProtectPowerUpsOwned
    End Sub
    Public Sub UpdateAchivementClick(ByRef prKicks)

        '####################  UPDATES VARIBLES FOR ALL ACHIVEMENTS   ########################

        prKicks = mdKickValue

    End Sub
    Public Sub ReturnValuesAchivementClick(prKicks)

        '#######################   RETURNS VARIBLES FOR ALL ACHIVEMENTS   ####################

        mdKickValue = prKicks
    End Sub
    Public Sub UpdateEnemyTimer(ByRef prTime)

        '######################   UPDATES VARIBLES FOR ENEMY APPARES TIMER  #####################

        prTime = mdTime
    End Sub
    Public Sub ReturnEnemyTimer(prTime)

        '#############################   RETURNS VARIBLES FOR ENEMY APPARES TIMER   #####################

        mdTime = prTime
    End Sub
    Public Sub UpdateEnemyValues(ByRef prKicks, ByRef prEnemyHealthPoints, ByRef prTime, ByRef prDammageToEnemy, ByRef prEnemyClickValue)

        '##########################   UPDATES VARIBLES FOR ENEMY CLICKER   #####################

        prKicks = (FormatNumber(CDbl(mdKickValue), 3))
        prEnemyHealthPoints = mdEnemyHeathPoints
        prTime = mdTime
        prDammageToEnemy = mdDammageToEnemy
        prEnemyClickValue = mdEnemyClickValue
    End Sub
    Public Sub ReturnEnemyValues(prKicks, prEnemyHealthPoints, prTime, prDamageToEnemy, prEnemyClickValue)

        '########################   RETURN VARIBLES FOR ENEMY CICKER   ###########################

        mdKickValue = (FormatNumber(CDbl(prKicks), 3))
        mdEnemyHeathPoints = prEnemyHealthPoints
        mdTime = prTime
        mdDammageToEnemy = prDamageToEnemy
        mdEnemyClickValue = prEnemyClickValue
    End Sub
    Public Sub UpdateEnemyTimerValues(ByRef prKicks)

        '########################  UPDATES FOR ENEMY TIMER   ######################

        prKicks = (FormatNumber(CDbl(mdKickValue), 3))
    End Sub
    Public Sub ReturnEnemyTimerValues(prKicks)

        '#####################   RETURN VALUES FOR ENEMY TIMER

        mdKickValue = (FormatNumber(CDbl(prKicks), 3))
    End Sub
    Public Sub UpdateArrowPowerUp(ByRef prDammageToEnemy, ByRef prKicks, ByRef prArrowsCost, ByRef prArrowsOwned)

        '######################   UPDATES VARIBLES FOR ARROWS POWER UP   ###################

        prDammageToEnemy = mdDammageToEnemy
        prKicks = (FormatNumber(CDbl(mdKickValue), 3))
        prArrowsCost = mdArrowsCost
        prArrowsOwned = mdArrowsOwned
    End Sub
    Public Sub ReturnArrowPowerUp(prDammgeToEnemy, prKicks, prArrowsCost, prArrowsOwned)

        '#######################   RETURNS VARIBLES FOR ARROWS POWER UP   ####################

        mdDammageToEnemy = prDammgeToEnemy
        mdKickValue = (FormatNumber(CDbl(prKicks), 3))
        mdArrowsCost = prArrowsCost
        mdArrowsOwned = prArrowsOwned
    End Sub
    Public Sub UpdateEndGameForm(ByRef prKicks, ByRef prEnemyHealthPoints, ByRef prArrowsCost, ByRef prEnemyClickValue, ByRef prArrowsOwned, ByRef prProtectOwned)

        '########################   UPDATE VARIBLES ON ENEMY FORM LOAD   #########################

        prKicks = (FormatNumber(CDbl(mdKickValue), 3))
        prEnemyHealthPoints = mdEnemyHeathPoints
        prArrowsCost = mdArrowsCost
        prEnemyClickValue = mdEnemyClickValue
        prArrowsOwned = mdArrowsOwned
        prProtectOwned = mdProtectOwned
    End Sub
    Public Sub ReturnValuesEndGameForm(prKicks, prEnemyHealthPoints, prArrowsCost, prEnemyClickValue, prArrowsOwned, prProtectOwned)

        '############################   RETURN VARIBLES FOR ON ENEMY FORM LOAD   #########################

        mdKickValue = (FormatNumber(CDbl(prKicks), 3))
        mdEnemyHeathPoints = prEnemyHealthPoints
        mdArrowsCost = prArrowsCost
        mdEnemyClickValue = prEnemyClickValue
        mdArrowsOwned = prArrowsOwned
        mdProtectOwned = prProtectOwned
    End Sub
    Public Sub UpdateProtectPowerUp(ByRef prEnemyClickValue, ByRef prKicks, ByRef prProtectCost, ByRef prProtectOwned)

        '########################   UPDATE VARIBLES FOR PROTECT POWER UP   #######################

        prEnemyClickValue = mdEnemyClickValue
        prKicks = (FormatNumber(CDbl(mdKickValue), 3))
        prProtectCost = mdProtectCost
        prProtectOwned = mdProtectOwned
    End Sub
    Public Sub ReturnValuesProtectPowerUp(prEnemyClickValue, prKicks, prProtectCost, prProtectOwned)

        '########################  RETURN VARIBLES FOR PROTECT POWER UP   ##########################

        mdEnemyClickValue = prEnemyClickValue
        mdKickValue = (FormatNumber(CDbl(prKicks), 3))
        mdProtectCost = prProtectCost
        mdProtectOwned = prProtectOwned
    End Sub
    Public Sub UpdateFreePowerUpNewShoes(ByRef prClickValue, ByRef prShoes, ByRef prAllPowerUpsOwned)

        '###################   UPDATE VARIBLES FOR FREE NEW SHOWS POWER UP   ##########################

        prClickValue = mdClickValue
        prShoes = mdNewShoesOwned
        prAllPowerUpsOwned = mdAllPowerUpsOwned
    End Sub
    Public Sub ReturnValuesFreePowerUpNewShoes(prClickValue, prShoes, prAllPowerUpsOwned)

        '#####################   RETURN VARIBLES FOR FREE NEW SHOWS POWER UP   ###########################

        mdClickValue = prClickValue
        mdNewShoesOwned = prShoes
        mdAllPowerUpsOwned = prAllPowerUpsOwned
    End Sub
    Public Sub UpdateFreePowerUpEnergyDrink(ByRef prClickValue, ByRef prEnergyDrink, ByRef prAllPowerUpsOwned)

        '############################   UPDATE VARIBLES FOR FREE ENERGY DRINK POWER UP   ###################

        prClickValue = mdClickValue
        prEnergyDrink = mdEnergyDrinksOwned
        prAllPowerUpsOwned = mdAllPowerUpsOwned
    End Sub
    Public Sub ReturnValuesFreePowerUpEnergyDrink(prClickValue, prEnergyDrink, prAllPowerUpsOwned)

        '#######################   RETURN VARIBLES FOR FREE ENEMY DRINK POWER UP   ###################

        mdClickValue = prClickValue
        mdEnergyDrinksOwned = prEnergyDrink
        mdAllPowerUpsOwned = prAllPowerUpsOwned
    End Sub
    Public Sub UpdateFreePowerUpKids(ByRef prKicksPerSecond, ByRef prKidsOwned, ByRef prCountPerSecond, ByRef prAllPowerUpsOwned)

        '#############################   UPDATE VARIBLES FOR FREE KIDS POWER UP   #######################

        prKicksPerSecond = mdKicksPerSecond
        prKidsOwned = mdKidsOwned
        prCountPerSecond = mdCountPerSecond
        prAllPowerUpsOwned = mdAllPowerUpsOwned
    End Sub
    Public Sub ReturnValuesFreePowerUpKids(prKicksPerSecond, prKidsOwned, prCountPerSecond, prAllPowerUpsOwned)

        '###########################  RETURN VARIBLES FOR FREE KIDS POWER UP   #########################

        mdKicksPerSecond = prKicksPerSecond
        mdKidsOwned = prKidsOwned
        mdCountPerSecond = prCountPerSecond
        mdAllPowerUpsOwned = prAllPowerUpsOwned

    End Sub


End Module
