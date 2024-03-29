﻿Public Class Strings
    Public Shared OSInfo() As String
    Public Shared ComputerInfo(7) As String
    Public Shared IsFree As Boolean
    Public Shared OnceInfo(8) As String
    Public Shared AvailableFeature(53) As String
    Public Shared CLIInterpreter As String
    Public Shared SaveFile As String
    Public Shared Achievement As String
    Public Shared ProcessID(15) As String

    'STRING CATEGORIZATION WRITING RULES!
    'THIS IS IN ORDER TO REMAIN COMPATIBLE WITH OLDER VERSIONS!
    '
    'General string :
    '(Row Number) = Function/Subject (default value : default)
    '
    'Each have to placed in numerical order
    'If there's moved strings for newer version, example:
    '0 = Computer Name (0.1) => OS Version (0.2) => Root Location (0.3), etc.
    'If there's removed strings for newer version, example:
    '69 = Secret Easter Egg (removed in 0.420)
    'If there's repurposed strings for newer version after removed, example:
    '5 = FreeRoam enabled? (removed in 0.4) => Story Mode State
    '
    'ALWAYS WRITE THE NOTES IN COMMENTS, THIS CLASS ONLY IS FOR STORING STRINGS AND DEPLOYING STRINGS TO DISK

    'OSInfo Strings:
    '0 = OSVersion (default : dependant)
    '
    'OnceInfo Strings:
    '0 = IsRoot? (0.1) (default : No)
    '1 = RootDirectory (0.2.3) (default : Environment.SpecialDirectories.ApplicationData & "\ShiftOS\ShiftFS\")
    '2 = Infobar Boolean (0.2.3) (default : True)
    '3 = Color for Terminal (0.2.3) (default : 0F) => moved to ComputerInfo(5)
    '4 = RootDirectoryString (0.2.3) (default : !)
    '5 = Terminal TrackPos (0.2.3) (default : 0)
    '6 = GameMode (0.2.3) (dependant)
    '7 = MaxWidth (0.2.4) (depentant)
    '8 = MaxHeight (0.2.4) (depentant)
    '
    'ComputerInfo Strings:
    '0 = Computer Name (0.1) (default : shiftos)
    '1 = Username (0.1) (default : user)
    '2 = Codepoint (0.2) (default : 0)
    '3 = Story Chapter (0.2) (default : 0 for New Game)
    '4 = Installed Packages (0.2.3) (default : 0 for New Game)
    '5 = Color for Terminal (0.2.4) (default : 0F)
    '6 = Color for Infobar (0.2.4) (default : F0)
    '7 = Window Manager (0.2.7) (default : 0)
    '
    'AvailableFeature (Default is defined on the Story Mode, Free Mode automatically assigns every available feature to 1, Unavailable in the Shiftorium assigned as 2, Upgraded assigned as 3) Strings:
    'Chapter 1
    '
    '0 = MAN command [Manual on each command] (0.2) (default : 0)
    '1 = CLEAR command [Clearing the screen] (0.2) (default : 0)
    '2 = PRINT command [Printing a string] (0.2.2) (default : 0)
    '3 = Terminal Display Driver [Dependencies for advanced terminal applications] (0.2.2) (default : 0)
    '4 = Terminal InfoBar [A panel bar at the bottom of the terminal to show 'Time', 'User Session', 'Codepoint', 'Program running'] (0.2.2) (default : 0)
    '5 = Time by Second [Showing time in seconds form since midnight] (0.2.2) (default : 0)
    '6 = Time by Minutes [Showing time in minutes form since midnight] (0.2.2) (default : 0)
    '7 = Time by Hours [Showing time in hours form since midnight] (0.2.2) (default : 0)
    '8 = Shiftfetch [ShiftOS port of Neofetch, A command-line system information tool] (0.2.3) (default : 0)
    '9 = bc [Basic Calculator for ShiftOS] (0.2.3) (default : 0)
    '10 = 2-bit Color Display [Adds Dark Gray and Light Gray support to the Display Driver] (0.2.3) (default : 0)
    '11 = ShiftOS Key [A key to unlock advanced features on ShiftOS] (0.2.3) (default : 0)
    '12 = Time by PM and AM [Showing time in hours form since midnight] (0.2.3) (default : 0)
    '13 = Red, Green, Blue [Adds Red, Green, and Blue support to the Display Driver] (0.2.3) (default : 0)
    '14 = RGB Variant [Adds lighter or darker variant of Red, Green, and Blue] (0.2.3) (default : 0)
    '15 = 4-bit Color Display [Adds to 16 colours support to the Display Driver] (0.2.3) (default : 0)
    '16 = Terminal Read-Only Memory Driver [ShiftOS Read-Only Memory support for HDD, SSD, etc.] (0.2.4) (default : 0)
    '17 = TextPad [Notepad] (0.2.4) (default : 0)
    '18 = ShiftKey [DOSKey for ShiftOS] (0.2.4) (default : 0)
    '19 = Custom Username [Custom username for ShiftOS] (0.2.4) (default : 0)
    '20 = Custom Hostname [Custom hostname for ShiftOS] (0.2.4) (default : 0)
    '21 = Reverse String [Reverse a text] (0.2.4) (default : 0)
    '22 = Cowsay [Cowsay] (0.2.4) (default : 0)
    '23 = Time by Hours and Minutes [Shows time in Hours and Minutes format] (0.2.5) (default : 0)
    '24 = Date command [Shows date in days since first day of the year format] (0.2.5) (default : 0)
    '25 = Date by week [Shows date in weeks since first week of the year format] (0.2.5) (default : 0)
    '26 = Date by month [Shows date in months since first month of the year format] (0.2.5) (default : 0)
    '27 = Date by year [Shows date in year format] (0.2.5) (default : 0)
    '28 = Date by month and year [Shows date in MM/YYYY format] (0.2.5) (default : 0)
    '29 = Date by general [Shows date in general DD/MM/YYYY format] (0.2.5) (default : 0)
    '30 = Batch-file support for ShiftOS [Gives execution support for ShiftOS Script File (.scr)] (0.2.5) (default : 0)
    '31 = Rename support [Ability to rename files in ShiftOS] (default : 0)
    '32 = Zip command [Ability to compress file in a zip file] (default : 0)
    '33 = Unzip command [Ability to extract file in a zip file] (default : 0)
    '34 = MathQuiz [Simple arithmatical question game to get codepoint] (default : 0)
    '
    'Chapter 2 for ShiftOS
    '35 = Dual Window Manager [Simple Window Manager for ShiftOS] (default : 0)
    '36 = Shifter [Customization program for ShiftOS, DuWM version] (default : 0)
    '37 = Knowledge Input [Guess how much things as many as you can] (default : 0)
    '38 = KI Animals [Adds animal category into the Knowledge Input] (default : 0)
    '39 = KI Fruits [Adds fruit category into the Knowledge Input] (default : 0)
    '40 = DuWM RGB Support [Adds RGB and its other variant support to DuWM] (default : 0)
    '41 = DuWM 16 Colors Support [Adds mix of RGB color support into ShiftOS] (default : 0)
    '42 = KI US States [Adds United States States category into the Knowledge Input] (default : 0)
    '43 = DuWM Advanced Read and Write [Expands read and write support for DuWM] (default : 0)
    '44 = File Skimmer [A file manager for ShiftOS] (default : 0)
    '45 = File Skimmer Folder Support [Supports for reading and writing folder in File Skimmer] (default : 0)
    '46 = File Skimmer File Support [Supports for reading and writing file in File Skimmer] (default : 0)
    '47 = File Skimmer Delete Support [Adds file deletion function into ShiftOS] (default : 0)
    '48 = File Skimmer ZIP Support [Adds ZIP compression function into ShiftOS] (default : 0)
    '49 = File Skimmer Properties Pane [Adds a sidebar contains file/directory informations] (default : 0)
    '50 = File Skimmer JobBar [Adds a top bar for actions on File Skimmer] (default : 0)
    '51 = File Skimmer Small Icons [Adds small icons layout on File Skimmer] (default : 0)
    '52 = File Skimmer List [Adds small icons layout on File Skimmer] (default : 0)
    '53 = Shifter Console [Adds Console Customization on Shifter] (default : 0)
    '
    'Features bought hierarchy :
    '
    'Chapter 1:
    'ShiftOS Key (KEY) (5 CP)
    '>ShiftOS Help Manual (MAN) (10 CP)
    '>>Custom Username (USERNAME) (15 CP)
    '>>Custom Hostname (HOSTNAME) (15 CP)
    '>Terminal Clear (CLEAR) (20 CP)
    '>>Terminal Print (PRINT) (25 CP)
    '>>>Reverse String command (REV) (30 CP)
    '>>>>Cowsay (50 CP)
    '>>>>Fortune command (55 CP)
    '>>>ShiftKey (ShOSKey) (45 CP)
    '>>>Terminal Display Driver (TERMDSPDRV) (40 CP)
    '>>>>Terminal InfoBar (INFOBAR) (50 CP)
    '>>>>Shiftfetch (SHIFTFETCH) (55 CP)
    '>>>>2-bit Color Display (2BITCOLOR) (60 CP)
    '>>>>>Red, Green, Blue (rgb) (70 CP)
    '>>>>>>RGB Variant (rgb2) (75 CP)
    '>>>>>>>4-bit Color Display (4BITCOLOR) (80 CP)
    '>>>>>>>>Terminal Read-Only Memory Driver (ROMDRIVER, DIR, MKDIR, RMDIR, CD, PWD) (90 CP)
    '>>>>>>>>>ZIP command (ZIP) (95 CP)
    '>>>>>>>>>UNZIP command (UNZIP) (95 CP)
    '>>>>>>>>>Rename support (RENAME) (95 CP)
    '>>>>>>>>>TextPad (100 CP)
    '>>>>>>>>>>ShiftOS Batch Script Support (BATCHSCRIPT) (100 CP)
    '>>Basic Calculator (BC) (55 CP)
    '>>>MathQuiz (MATHQUIZ) (60 CP)
    '>>Time by Seconds (TIME, STIME) (10 CP)
    '>>>Time by Minutes (TIME, MTIME) (20 CP)
    '>>>>Time by Hours (Time, HTIME) (30 CP)
    '>>>>>PM and AM (Time, PMAM (40 CP))
    '>>>>>>Time by Hours and Minutes (Time, HHMM (50 CP))
    '>>>>>>>Date command (DATE (70 CP))
    '>>>>>>>>Date by week (DATE, WOY (75 CP))
    '>>>>>>>>>Date by month (DATE, MOY (80 CP))
    '>>>>>>>>>>Date by year (DATE, YEAR (85 CP))
    '>>>>>>>>>>>Date by month and year (DATE, MMYYYY (90 CP))
    '>>>>>>>>>>>>Date by general (DATE, GENERALDATE (95 CP))
    '
    'Chpater 2:
    '>Dual Window Manager (DUWM) (200 CP)
    '>>DuWM RGB Support (DUWMRGB) (225 CP)
    '>>>DuWM 16 Colors Support (DUWMRGB2) (275 CP)
    '>>Shifter (SHIFTER) (250 CP)
    '>>>Shifter Console (SHR_CONSOLE) (275 CP)
    '>>Knowledge Input (KNOWLEDGE) (275 CP)
    '>>>KI Animals (KI_ANIMALS) (300 CP)
    '>>>KI Fruits (KI_FRUITS) (300 CP)
    '>>>KI US States (KI_US) (300 CP)
    '>>DuWM Advanced Read and Write support (DUWM_RW) (250 CP)
    '>>>File Skimmer (FILESKIMMER) (300 CP)
    '>>>>FS Folder Support (FS_FOLDER) (325 CP)
    '>>>>>FS File Support (FS_FILE) (350 CP)
    '>>>>>>FS Delete Support (FS_DELETE) (400 CP)
    '>>>>>>FS ZIP Support (FS_ZIP) (500 CP)
    '>>>>FS Properties Pane (FS_PPANE) (350 CP)
    '>>>>FS JobBar (FS_JOBBAR) (400 CP)
    '>>>>>FS Small Icons Layout (FS_SMALLICONS) (425 CP)
    '>>>>>FS List Layout (FS_LIST) (425 CP)
End Class
