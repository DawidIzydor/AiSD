#include "pch.h"
#include "Sortowanie.h"
#include <iostream>

Sortowanie::Sortowanie()
{
}


Sortowanie::~Sortowanie()
{
}

void Sortowanie::PrzezProsteWybieranie(list<int>& KolecjaDoPosortowania)
{
	int iloscIteracji = 0;

	for (int i = 0; i < KolecjaDoPosortowania.size()- 1; ++i)
	{
		iloscIteracji++;

		int PozycjaNajmniejszego = i;

		for (int j = i + 1; j < KolecjaDoPosortowania.size(); ++j)
		{
			iloscIteracji++;

			if (KolecjaDoPosortowania[j] < KolecjaDoPosortowania[PozycjaNajmniejszego])
			{
				PozycjaNajmniejszego = j;
			}
		}

		int temp = KolecjaDoPosortowania[PozycjaNajmniejszego];
		KolecjaDoPosortowania[PozycjaNajmniejszego] = KolecjaDoPosortowania[i];
		KolecjaDoPosortowania[i] = temp;
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;
}

void Sortowanie::PrzezProsteWstawianie(list<int>& KolekcjaDoPosortowania)
{
	int iloscIteracji = 0;

	for (int i = 1; i < KolekcjaDoPosortowania.size(); ++i)
	{
		iloscIteracji++;

		int Klucz = KolekcjaDoPosortowania[i];

		int j = i - 1;

		while (j >= 0 && KolekcjaDoPosortowania[j] > Klucz)
		{
			iloscIteracji++;

			KolekcjaDoPosortowania[j + 1] = KolekcjaDoPosortowania[j];
			j--;
		}

		KolekcjaDoPosortowania[j + 1] = Klucz;
	}

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;
}

void Sortowanie::Babelkowe(list<int>& KolekcjaDoPosortowania)
{
	int iloscIteracji = 0;

	int n = KolekcjaDoPosortowania.size();

	do
	{
		iloscIteracji++;

		for (int i = 0; i < n - 1; ++i)
		{
			iloscIteracji++;

			if (KolekcjaDoPosortowania[i] > KolekcjaDoPosortowania[i + 1])
			{
				int temp = KolekcjaDoPosortowania[i];
				KolekcjaDoPosortowania[i] = KolekcjaDoPosortowania[i + 1];
				KolekcjaDoPosortowania[i + 1] = temp;
			}
		}

		n--;
	} while (n > 1);

	std::cout << "Ilosc iteracji: " << iloscIteracji << std::endl;

}

