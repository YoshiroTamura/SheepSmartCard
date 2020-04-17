![SheepSmartCard](https://github.com/YoshiroTamura/SheepSmartCard/blob/master/sheepsmartcard-s.png)
# SheepSmartCard DLL
SheepSmartCard DLL is a dynamic link library to read smart card ID.

## Description
SheepSmartCard DLL calls WinScard API(winscard.dll) and read an unique ID that any smart cards have, 'UID' of RFID Type A (Mifare) and 'IDm' of RFID Type F (FeliCa).  
This library only reads ID, so you do not worry about the card information leaking and changing by using it.

## Requirement
OS : Windows 10 / Windows 7  
Card Reader : Supports ISO 14443 Type-A (Mifare) / NFC Type-F (FeliCa)  
Smart Card : Mifare (Standard,UltraLight) / FeliCa  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;* Does not support Type-B card because it returns random ID (PUPI).  

## Usage
1. Download and place dll to your system directory.  
&nbsp;&nbsp;- 64 bit application on 64 bit operating system : SheepSmartCard64.dll to C:\Windows\System32   
&nbsp;&nbsp;- 32 bit application on 64 bit operating system : SheepSmartCard32.dll to C:\Windows\SysWOW64  
&nbsp;&nbsp;- 32 bit operating system : SheepSmartCard32.dll to C:\Windows\System32  
2. Call dll and define a function named GetSmartCardUID.  
&nbsp;I provide sample code for [Visual C#](https://github.com/YoshiroTamura/SheepSmartCard/tree/master/SheepSmartCardSampleCs), [Visual Basic](https://github.com/YoshiroTamura/SheepSmartCard/tree/master/SheepSmartCardSampleVb), and VBA ([Excel](https://github.com/YoshiroTamura/SheepSmartCard/tree/master/SheepSmartCardSampleExcel), [Access](https://github.com/YoshiroTamura/SheepSmartCard/tree/master/SheepSmartCardSampleAccess)). Please check those.    

## License
[MIT License](https://github.com/YoshiroTamura/SheepSmartCard/blob/master/LICENSE) © Yoshiro Tamura  

## Author
[Yoshiro Tamura](https://www.eclip.jp)
&nbsp;&nbsp;IT engineer, used to be a shepherd.

