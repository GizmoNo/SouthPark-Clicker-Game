Imports System.IO
Imports System.Xml.Serialization
Module Saveing
    Dim lcFileName As String
    Dim lcSaveFile As String
    Dim lcSaveAchivements As String
    Public Sub SaveFileAs(ByVal prKicks, ByVal prClickValue, ByVal prDrinkCost, ByVal prEnergyDrinksOwned, ByVal prKidsCost, ByVal prNewShoesCost, ByVal prKicksPerSecond, ByVal prKidsOwned, ByVal prCountPerSecond, ByVal prNewShoesOwned, ByVal prTime, ByVal prEnemyHeathPoints, ByVal prEnemyClickValue, ByVal prArrowsCost, ByVal prProtectCost, ByVal prDammageToEnemy, ByVal prAllPowerUpsOwned, ByVal prArrowPowerUpsOwned, ByVal prProtectPowerUpsOwned)

        '##############   CODE FOR SAVING ALL VARIBLES CONTAINED IN PROGRAM   #########################

        '###########################   SENDS ALL MY VARIBLES TO THE ARRAY   ###########################

        SaveAs = {prKicks, prClickValue, prDrinkCost, prEnergyDrinksOwned, prKidsCost, prNewShoesCost, prCountPerSecond, prKidsOwned, prCountPerSecond, prNewShoesOwned, prTime, prEnemyHeathPoints, prEnemyClickValue, prArrowsCost, prProtectCost, prDammageToEnemy, prAllPowerUpsOwned, prArrowPowerUpsOwned, prProtectPowerUpsOwned}
        lcFileName = InputBox("Enter a file name to save as :", "Save Game", "Type name here.")

        lcFileName = "\" & lcFileName & ".txt"

        If lcFileName = "" Then
            ' user cancelled the InputBox,do what you need to

        Else
            'seting the save file path to Mydocuments\filenam.txt
            lcSaveFile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & lcFileName

            Dim xml_serializerVars As New XmlSerializer(SaveAs.GetType)
            Dim SaveAllVaribles As New StreamWriter(lcSaveFile)
            xml_serializerVars.Serialize(SaveAllVaribles, SaveAs)
        End If

        '######################   CODE FOR SAVING EVERYTHING IN LIST BOX   ##########################

        lcSaveAchivements = My.Computer.FileSystem.SpecialDirectories.MyDocuments & ("Achivements")

        Dim SaveAchivements As New IO.StreamWriter(lcSaveAchivements)
        Dim Save As Integer

        For Save = 0 To frmAchievements.lbAchivements.Items.Count - 1
            SaveAchivements.WriteLine(frmAchievements.lbAchivements.Items.Item(Save))
        Next
        SaveAchivements.Close()
    End Sub

    Public Sub Load(ByRef prKicks, ByRef prClickValue, ByRef prDrinkCost, ByRef prEnergyDrinksOwned, ByRef prKidsCost, ByRef prNewShoesCost, ByRef prKicksPerSecond, ByRef prKidsOwned, ByRef prCountPerSecond, ByRef prNewShoesOwned, ByRef prTime, ByRef prEnemyHeathPoints, ByRef prEnemyClickValue, ByRef prArrowsCost, ByRef prProtectCost, ByRef prDammageToEnemy, ByRef prAllPowerUpsOwned, ByRef prArrowPowerUpsOwned, ByRef prProtectPowerUpsOwned)

        '#####################   CODE FOR LOADING ALL SAVED VARIBLES   ##############################

        'make a pop up box to get the name of the user file
        lcFileName = InputBox("Enter your saved file name :", "Load Game", "Type name here.")

        'Reformat it to use in a file name later  \filenam.txt 
        lcFileName = "\" & lcFileName & ".txt"



        'Use it to go get the file (what if they type in the name wrong!!!)
        lcSaveFile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & lcFileName

        Dim loadall As Array = {prKicks, prClickValue, prDrinkCost, prEnergyDrinksOwned, prKidsCost, prNewShoesCost, prKicksPerSecond, prKidsOwned, prCountPerSecond, prNewShoesOwned, prTime, prEnemyHeathPoints, prEnemyClickValue, prArrowsCost, prProtectCost, prDammageToEnemy, prAllPowerUpsOwned, prArrowPowerUpsOwned, prProtectPowerUpsOwned}

        Dim xml_serializerVars As New XmlSerializer(loadall.GetType)
        Dim SaveAllVaribles As New StreamReader(lcSaveFile)
        loadall = xml_serializerVars.Deserialize(SaveAllVaribles)

        prKicks = loadall(0)
        prClickValue = loadall(1)
        prDrinkCost = loadall(2)
        prEnergyDrinksOwned = loadall(3)
        prKidsCost = loadall(4)
        prNewShoesCost = loadall(5)
        prKicksPerSecond = loadall(6)
        prKidsOwned = loadall(7)
        prCountPerSecond = loadall(8)
        prNewShoesOwned = loadall(9)
        prTime = loadall(10)
        prEnemyHeathPoints = loadall(11)
        prEnemyClickValue = loadall(12)
        prArrowsCost = loadall(13)
        prProtectCost = loadall(14)
        prDammageToEnemy = loadall(15)
        prAllPowerUpsOwned = loadall(16)
        prArrowPowerUpsOwned = loadall(17)
        prProtectPowerUpsOwned = loadall(18)


        '#######################   CODE FOR LOADING STUFF IN A LIST BOX   ########################

        lcSaveAchivements = My.Computer.FileSystem.SpecialDirectories.MyDocuments & ("Achivements")

        Dim Load As New IO.StreamReader(lcSaveAchivements)
        While (Load.Peek() > -1)
            frmAchievements.lbAchivements.Items.Add(Load.ReadLine)
        End While
        Load.Close()

    End Sub
    Public Sub LoadFromEnemyScreen(ByRef prKicks, ByRef prClickValue, ByRef prDrinkCost, ByRef prEnergyDrinksOwned, ByRef prKidsCost, ByRef prNewShoesCost, ByRef prKicksPerSecond, ByRef prKidsOwned, ByRef prCountPerSecond, ByRef prNewShoesOwned, ByRef prTime, ByRef prEnemyHeathPoints, ByRef prEnemyClickValue, ByRef prArrowsCost, ByRef prProtectCost, ByRef prDammageToEnemy, ByRef prAllPowerUpsOwned, ByRef prArrowPowerUpsOwned, ByRef prProtectPowerUpsOwned)

        '###################### CODE TO LOAD ALL VARIBLES IF SAVED ON ENEMT SCREEN  ###########################


        'make a pop up box to get the name of the user file
        lcFileName = InputBox("Enter your saved file name :", "Load Game", "Type name here.")

        'Reformat it to use in a file name later  \filenam.txt 
        lcFileName = "\" & lcFileName & ".txt"

        frmSouthPark.TimerEnemyApparesTimer.Stop()

        frmEndGame.Show()

        'Use it to go get the file (what if they type in the name wrong!!!)
        lcSaveFile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & lcFileName
        Dim loadall As Array = {prKicks, prClickValue, prDrinkCost, prEnergyDrinksOwned, prKidsCost, prNewShoesCost, prKicksPerSecond, prKidsOwned, prCountPerSecond, prNewShoesOwned, prTime, prEnemyHeathPoints, prEnemyClickValue, prArrowsCost, prProtectCost, prDammageToEnemy, prAllPowerUpsOwned, prArrowPowerUpsOwned, prProtectPowerUpsOwned}
        Dim xml_serializerVars As New XmlSerializer(loadall.GetType)
        Dim SaveAllVaribles As New StreamReader(lcSaveFile)
        loadall = xml_serializerVars.Deserialize(SaveAllVaribles)

        prKicks = loadall(0)
        prClickValue = loadall(1)
        prDrinkCost = loadall(2)
        prEnergyDrinksOwned = loadall(3)
        prKidsCost = loadall(4)
        prNewShoesCost = loadall(5)
        prKicksPerSecond = loadall(6)
        prKidsOwned = loadall(7)
        prCountPerSecond = loadall(8)
        prNewShoesOwned = loadall(9)
        prTime = loadall(10)
        prEnemyHeathPoints = loadall(11)
        prEnemyClickValue = loadall(12)
        prArrowsCost = loadall(13)
        prProtectCost = loadall(14)
        prDammageToEnemy = loadall(15)
        prAllPowerUpsOwned = loadall(16)
        prArrowPowerUpsOwned = loadall(17)
        prProtectPowerUpsOwned = loadall(18)

        '#######################   CODE FOR LOADING STUFF IN A LIST BOX   ########################

        lcSaveAchivements = My.Computer.FileSystem.SpecialDirectories.MyDocuments & ("Achivements")

        Dim Load As New IO.StreamReader(lcSaveAchivements)
        While (Load.Peek() > -1)
            frmAchievements.lbAchivements.Items.Add(Load.ReadLine)
        End While
        Load.Close()

    End Sub
    Public Sub OpenFile()

        '#######################   CODE TO SEE SAVED FILE   #############################

        Try
            Dim p As New System.Diagnostics.Process

            'there is a bunch of BLABLABLA here.  Ignore it as nessacary Liberay call stuff
            'This line is saying  go get the file we saved earlier on line 21

            Dim s As New System.Diagnostics.ProcessStartInfo(lcSaveFile)
            s.UseShellExecute = True
            s.WindowStyle = ProcessWindowStyle.Normal
            p.StartInfo = s
            p.Start()
        Catch ex As Exception
            MessageBox.Show("File couldnt be found!", "opps", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '###################   ARRAY FOR ALL THE SAVED AND LOAD VARIBLES   #########################

    Public SaveAs As Array
End Module
