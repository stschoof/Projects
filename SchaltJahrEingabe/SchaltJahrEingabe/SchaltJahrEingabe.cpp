#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>
//#include <winnt.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

// Stellen Sie ein Array bereit, dass 8x8 Felder plus eine Umrandung hat
// Bei leeren Felder, ohne Figur  sollen 'W' und 'S' die Farbe zeigen
// Die Figuren werden als "TPLDKB" angezeigt.
// Die schwarzen Figuren sind Kleinbuchstaben, die weissen als Großbuchstabe.

int z, s;
int zeilen = 10, spalten = 10;   // kann flexibel die Größe ändern
int vs, vz, ns, nz;
char brett[10][10]; // schachbrett als 2 dim Array   mit 10*10*8 bit   = 100byte 

int ende = 0;
// returntyp   name ([paramter] )
void bildstandAnzeige()  // void bedeutet das nichts errechnet und zurückgegeben wird
						 // int, float, bool  usw. müssten mit return ergebnis etwas melden
{
	system("CLS");
	// Anzeige des Spielstandes 
	for (z = 0; z<zeilen; z++)
	{
		for (s = 0; s<spalten; s++)
		{
			if (brett[z][s] == 'S')
			{
				// schwarz malen
				//	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_BLUE | BACKGROUND_GREEN);
				printf("%c", ' ');
				//	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_GREEN | BACKGROUND_BLUE);
			}
			else
			{
				if (brett[z][s] == 'W')
				{
					// weiss malen
					//	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_GREEN | BACKGROUND_BLUE);
					printf("%c", 176);
					//	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_BLUE | BACKGROUND_GREEN);
				}
				else
				{
					printf("%c", brett[z][s]);
				}
			}

		}
		printf("\n");
	}

}

void grundstellung()
// Füllen Sie das Array ( mit Figuren in Grundstellung )
{
	for (z = 0; z<zeilen; z++)
	{
		for (s = 0; s<spalten; s++)
		{
			brett[z][s] = 'X';  // später löschen

								// Umrandung 
								// 	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_GREEN | BACKGROUND_BLUE);
			if (z == 0 || z == 9)
			{
				brett[z][s] = 64 + s;  // ASCII 64 ist dsas zeichen vor dem A ( @ ) 
			}
			if (s == 0 || s == 9)
			{
				brett[z][s] = 48 + 9 - z; // ASCII 48 ist die Ziffer 0 
			}
			if (z > 2 && z < 7 && s != 0 && s != 9)
			{
				if ((z + s) % 2)
				{
					brett[z][s] = 'S';
				}
				else
				{
					brett[z][s] = 'W';
				}
			}

			// hier die Figuren aufstellen
			//	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_BLUE | BACKGROUND_GREEN);

			if (z == 2 && s != 0 && s != 9)
				brett[z][s] = 'B';
			if (z == 7 && s != 0 && s != 9)
				brett[z][s] = 'b';

			if (z == 1)
			{
				switch (s)
				{
				case 1:  // ist der Ersatz für  if ( s == 1 || s == 8 )
				case 8:
				{
					brett[z][s] = 'T';	break;
				}
				case 2:
				case 7:
				{
					brett[z][s] = 'P';	break;
				}
				case 3:
				case 6:
				{
					brett[z][s] = 'L';	break;
				}
				case 4:
				{
					brett[z][s] = 'D';	break;
				}
				case 5:
				{
					brett[z][s] = 'K';	break;
				}
				}

			}

			if (z == 8)
			{
				switch (s)
				{
				case 1:
				case 8:
				{
					brett[z][s] = 't';	break;
				}
				case 2:
				case 7:
				{
					brett[z][s] = 'p';	break;
				}
				case 3:
				case 6:
				{
					brett[z][s] = 'l';	break;
				}
				case 4:
				{
					brett[z][s] = 'd';	break;
				}
				case 5:
				{
					brett[z][s] = 'k';	break;
				}
				}
			}

		}
	}


	brett[0][0] = ' ';
	brett[zeilen - 1][0] = ' ';
	brett[0][spalten - 1] = ' ';
	brett[zeilen - 1][spalten - 1] = ' ';

}

//   A3B5             A      3        B       5   
void figurBewegen(int vs, int vz, int ns, int nz)
{
	char ersatz = ' ';
	// zug 

	// rausnehmen und umkopieren 
	//  nach   ziel     von   ursprung
	brett[nz][ns] = brett[vz][vs];
	//     T              B 

	if ((vz + vs) % 2)
	{
		brett[vz][vs] = 'S';
	}
	else
	{
		brett[vz][vs] = 'W';
	}

	//  in C++ einfacher als : brett[vz][vs] = (vz+vs)%2?'W':'S';   statt 157 bis 164 
}


void usereingabe()
{
	char eingabe[4];
	printf("Bitte geben Sie Ihren Zug ein. Format z.B. A2B3 \n");
	scanf("%s", eingabe);

	//	printf("%c%c%c%c\n",eingabe[0],eingabe[1], eingabe[2], eingabe[3]);
	system("Pause");
	vs = toupper(eingabe[0]) - 64;
	vz = 9 - (eingabe[1] - 48);
	ns = toupper(eingabe[2]) - 64;
	nz = 9 - (eingabe[3] - 48);

	//	 printf("%i %i nach %i %i\n",vs,vz, ns, nz);
	// 	system("Pause");	
	// 2,1,3,3
}

int main(int argc, char *argv[]) {
	char weiter;

//	MessageBox(0, "Willkommen beim Schach 2017", "SchachOmat2017", MB_OK);

	//MessageBox(,"Hello","Caption",MB_OK);
	//printf("Willkommen zum Schachspiel \n)"); // auch das ist ein Funktionsaufruf mit Parameterübergabe
	grundstellung();

	bildstandAnzeige();
	system("Pause");
	do // while( !ende)
	{
		usereingabe();

		figurBewegen(vs, vz, ns, nz);
		bildstandAnzeige();
		system("Pause");
		printf("\nNoch ein Zug ? J/N  :");
		fflush(stdin);
		scanf("%c", &weiter);
		if (toupper(weiter) == 'N')
			ende = 1;
	} while (ende == 0);

	// printf("%i", sizeof(brett));  // erwarte 100 wegen 10 mal 10

	return 0;
}
