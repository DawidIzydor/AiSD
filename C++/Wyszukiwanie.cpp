#include "pch.h"
#include "Wyszukiwanie.h"
#include "Dane.h"
#include <iostream>

Wyszukiwanie::Wyszukiwanie()
{
}


Wyszukiwanie::~Wyszukiwanie()
{
}

int Wyszukiwanie::Liniowe(list<int>& przeszukiwanaKolekcja, int WyszukiwanyElement)
{
	int iloscIteracji = 0;

	for (int i = 0; i < przeszukiwanaKolekcja.size(); ++i)
	{
		iloscIteracji++;

		if (przeszukiwanaKolekcja.at(i) == WyszukiwanyElement)
		{
			std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;
			return i;
		}
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

	return -1;
}

int Wyszukiwanie::Binarne(list<int>& posortowanaKolekcja, int szukanyElement)
{
	int iloscIteracji = 0;

	int LewyEl = 0;
	int PrawyEl = posortowanaKolekcja.size() - 1;

	while (LewyEl < PrawyEl)
	{
		iloscIteracji++;

		int SrodkowyEl = (LewyEl + PrawyEl) / 2;

		if (posortowanaKolekcja.at(SrodkowyEl) < szukanyElement)
		{
			LewyEl = SrodkowyEl + 1;
		}
		else
		{
			PrawyEl = SrodkowyEl - 1;
		}
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

	if (posortowanaKolekcja.at(LewyEl) == szukanyElement)
	{
		return LewyEl;
	}
	else
	{
		return -1;
	}
}

int Wyszukiwanie::Interpolacyjne(list<int>& posortowanaKolekcja, int szukanyElement)
{
	int iloscIteracji = 0;

	int LewyEl = 0;
	int PrawyEl = posortowanaKolekcja.size() - 1;

	while (LewyEl < PrawyEl)
	{
		iloscIteracji++;

		int Wspolczynnik = (szukanyElement - posortowanaKolekcja[LewyEl]) * (PrawyEl - LewyEl) / (posortowanaKolekcja[PrawyEl] - posortowanaKolekcja[LewyEl]);

		if (Wspolczynnik < 0) break; // bez tego czasem siê zapêtla, do sprawdzenia

		int SrodkowyEl = LewyEl + Wspolczynnik;

		if (posortowanaKolekcja.at(SrodkowyEl) < szukanyElement)
		{
			LewyEl = SrodkowyEl + 1;
		}
		else
		{
			PrawyEl = SrodkowyEl - 1;
		}
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

	if (posortowanaKolekcja.at(LewyEl) == szukanyElement)
	{
		return LewyEl;
	}
	else
	{
		return -1;
	}
}
