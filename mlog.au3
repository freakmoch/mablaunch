#cs ---------------------------------------------------------------------------- 

 AutoIt Version: 3.3.6.0 
 Author: Nightingale737     

 Script Function:Mabinogi auto log in 
    Template AutoIt script. 

#ce ---------------------------------------------------------------------------- 

; Script Start - Add your code below here 

$user = IniRead("mlog.ini", "Begin", "user", "default")
$pass = IniRead("mlog.ini", "Begin", "pass", "default")
Sleep(5000) 
send($user) 
Send("{TAB}", 0) 
Send($pass) 
