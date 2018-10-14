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

int Wyszukiwanie::Liniowe(list_ptr<int>& przeszukiwanaKolekcja, int WyszukiwanyElement)
{
	int iloscIteracji = 0;

	for (int i = 0; i < przeszukiwanaKolekcja->size(); ++i)
	{
		iloscIteracji++;

		if (przeszukiwanaKolekcja->at(i) == WyszukiwanyElement)
		{
			std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;
			return i;
		}
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

	return -1;
}

int Wyszukiwanie::Binarne(list_ptr<int>& posortowanaKolekcja, int szukanyElement)
{
	int iloscIteracji = 0;

	int LewyEl = 0;
	int PrawyEl = posortowanaKolekcja->size() - 1;

	while (LewyEl < PrawyEl)
	{
		iloscIteracji++;

		int SrodkowyEl = (LewyEl + PrawyEl) / 2;

		if (posortowanaKolekcja->at(SrodkowyEl) < szukanyElement)
		{
			LewyEl = SrodkowyEl + 1;
		}
		else
		{
			PrawyEl = SrodkowyEl;
		}
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

	if (posortowanaKolekcja->at(LewyEl) == szukanyElement)
	{
		return LewyEl;
	}
	else
	{
		return -1;
	}
}

int Wyszukiwanie::Interpolacyjne(list_ptr<int>& posortowanaKolekcja, int szukanyElement)
{
	int iloscIteracji = 0;

	int LewyEl = 0;
	int PrawyEl = posortowanaKolekcja->size() - 1;

	while (LewyEl < PrawyEl)
	{
		iloscIteracji++;

		int SrodkowyEl = (LewyEl + PrawyEl) * (szukanyElement - posortowanaKolekcja->at(LewyEl)) / (posortowanaKolekcja->at(PrawyEl) - posortowanaKolekcja->at(LewyEl));

		if (posortowanaKolekcja->at(SrodkowyEl) < szukanyElement)
		{
			LewyEl = SrodkowyEl + 1;
		}
		else
		{
			PrawyEl = SrodkowyEl;
		}
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

	if (posortowanaKolekcja->at(LewyEl) == szukanyElement)
	{
		return LewyEl;
	}
	else
	{
		return -1;
	}
}
