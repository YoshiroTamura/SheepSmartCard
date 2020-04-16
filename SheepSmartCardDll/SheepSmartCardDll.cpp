#include "pch.h"
#include "winscard.h"
#include "stdio.h"

#pragma comment (lib, "winscard.lib")

int __stdcall GetSmartCardUID(char* SCardUID)
{
	SCARDCONTEXT hContext;
	LPTSTR       pmszReaderName = NULL;
	DWORD        dwcchReaders = SCARD_AUTOALLOCATE;
	DWORD        dwActiveProtocol;
	SCARDHANDLE  hCardHandle = NULL;
	LONG         lResult, errCode = 999;
	LPCSCARD_IO_REQUEST pioSendPci;
	BYTE         bSendBuffer[] = { 0xFF, 0xCA, 0x00, 0x00, 0x00 };
	BYTE         bRecvBuffer[256];
	DWORD        dwRecvLength = sizeof(bRecvBuffer);

	lResult = SCardEstablishContext(SCARD_SCOPE_USER, NULL, NULL, &hContext);

	if (lResult != SCARD_S_SUCCESS) {
		errCode = 300;
	}
	else {
		lResult = SCardListReaders(hContext, SCARD_ALL_READERS, (LPTSTR)&pmszReaderName, &dwcchReaders);
		if (lResult != SCARD_S_SUCCESS) {
			errCode = 200;
		}
		else {
			lResult = SCardConnect(hContext, pmszReaderName, SCARD_SHARE_SHARED, SCARD_PROTOCOL_T0 | SCARD_PROTOCOL_T1, &hCardHandle, &dwActiveProtocol);
			if (lResult != SCARD_S_SUCCESS) {
				errCode = 100;
			}
			else {
				if (dwActiveProtocol == SCARD_PROTOCOL_T1) {
					pioSendPci = SCARD_PCI_T1;
				}
				else {
					pioSendPci = SCARD_PCI_T0;
				}
				lResult = SCardTransmit(hCardHandle, pioSendPci, bSendBuffer, sizeof(bSendBuffer), NULL, bRecvBuffer, (LPDWORD)&dwRecvLength);
				if (lResult != SCARD_S_SUCCESS) {
					errCode = 400;
				}
				else {
					if (bRecvBuffer[dwRecvLength - 2] == 0x90 && bRecvBuffer[dwRecvLength - 1] == 0x00) {
						dwRecvLength -= 2;
						for (int i = 0; i <= (int)dwRecvLength - 1; i++) {
							sprintf_s(SCardUID, 16, "%02X", (int)bRecvBuffer[i]);
							SCardUID += 2;
						}
						errCode = 0;
					}
					else {
						dwRecvLength = 0;
						errCode = 400;
					}
				}
			}
		}
	}
	if (hCardHandle) {
		lResult = SCardDisconnect(hCardHandle, SCARD_LEAVE_CARD);
	}
	if (pmszReaderName) {
		SCardFreeMemory(hContext, pmszReaderName);
	}
	if (hContext) {
		SCardReleaseContext(hContext);
	}
	return errCode;
}


