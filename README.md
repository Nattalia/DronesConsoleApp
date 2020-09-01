#####################################################################
###################### DRONES CONSOLE APP ###########################
#####################################################################

---------------------------------------------------------------------
------------------------------ Solution -----------------------------
---------------------------------------------------------------------

    - Language: C#	
    - Platform: .Net Core 2.2.
    - Solution containing two proyects: 
	- DronesConsoleApp - Aplication. 
		- Business: Folder with business logic classes.
		- Common: Folder with common classes.
		- CustomExpception: Folder with custom exceptions.
		- Data: Folder with plane objects.
		- Documentation: Documentation.
	- DronesUnitTests - Unit Tests.
		- ChangePositionTest - Class to test dron orientation changes.
		- MoveFordwardTest - Class to test dron move fordward operation. 


---------------------------------------------------------------------
-------------------- Execution instructions -------------------------
---------------------------------------------------------------------

- Unzip file <PATH_TO_DOWNLOAD_FOLDER>\DronesConsoleApp\bin\Release\netcoreapp2.2\DronesConsoleAppDll.zip in current folder.
- Execute: dotnet <PATH_TO_DOWNLOAD_FOLDER>\DronesConsoleApp\bin\Release\netcoreapp2.2\DronesConsoleApp.dll
    - Input parameters will be asked to the user: 
	- Flying area format: Width(int) Height(int). Example: 5 5
	- Dron start position format: XCoordenate(int) YCoordenate(int) Direction(N/S/E/W). Example: 2 1 S
	- Dron movements format: (R/L/M). Example: LMMRMMLM

---------------------------------------------------------------------
--------------------- Testing instructions --------------------------
---------------------------------------------------------------------

- Execute: dotnet test <PATH_TO_DOWNLOAD_FOLDER>\DronesUnitTests --logger:trx
- Go to <PATH_TO_DOWNLOAD_FOLDER>\DronesUnitTests\TestResults to see test result.

mi nuevo trabajo en develop nataliaror
este es un cambio que acabo de hacer
prueba 33333333333333333
hoooooooola
esto mola mucho
11111111111111111111111111111111