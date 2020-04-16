![SheepSmartCard](https://github.com/YoshiroTamura/SheepSmartCard/blob/master/sheepsmartcard-s.png)
# SheepSmartCard DLL
SheepSmartCard DLL is a dynamic link library to read smart card ID.

## Description
SheepSmartCard DLL calls WinScard API(winscard.dll) and read an unique ID that any smart cards have, 'UID' of RFID Type A (Mifare) and 'IDm' of RFID Type F (FeliCa).  
This library only reads ID, so you do not worry about the card information leaking and changing by using it.

## Requirement
OS : Windows 10 / Windows 7  
Card Reader : Supports ISO 14443 Type-A (Mifare) or NFC Type-F (FeliCa)  
Smart Card : Mifare or FeliCa  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;* Does not support Type-B card because it returns random ID (PUPI).  

## Usage
