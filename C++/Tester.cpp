#include "pch.h"
#include "Tester.h"
#include <iostream>
#include "Helper.h"
#include "Dane.h"
#include  "Wyszukiwanie.h"
#include "Sortowanie.h"
#include "consts.h"

Tester::Tester()
{
}


Tester::~Tester()
{
}

void Tester::TestWyszukiwania()
{
	Dane dane{};
	Wyszukiwanie wysz{};

	int wyszukiwany;
	int znaleziony;

	std::cout << "Test wyszukiwania\n\n";

	std::cout << "Przeszukiwanie liniowe" << std::endl;
	{
		wyszukiwany = 99;
		list<int> lista = dane.PosortowanaLista;
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		znaleziony = wysz.Liniowe(lista, wyszukiwany);
		std::cout << "Szukano " << wyszukiwany << ".";
		if (znaleziony >= 0)
		{
			std::cout << " Znaleziono na " << znaleziony << " pozycji.";
		}
		else {
			std::cout << " Nie znaleziono";
		}
		std::cout << "\n" << std::endl;
	}
	/*{
		wyszukiwany = 348;
		list<int> lista = dane.GetRandomLista(DLUGOSC_RAND_LISTY);
		if(WYSWIETL_DANE)
			help.Wyswietl(lista);
		znaleziony = wysz.Liniowe(lista, wyszukiwany);
		std::cout << "Szukano " << wyszukiwany << ".";
		if (znaleziony >= 0)
		{
			std::cout << " Znaleziono na " << znaleziony << " pozycji.";
		}
		else {
			std::cout << " Nie znaleziono";
		}
		std::cout << "\n" << std::endl;
	}*/

	std::cout << "Przeszukiwanie binarne" << std::endl;
	{
		wyszukiwany = 99;
		list<int>& lista = dane.PosortowanaLista;
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		znaleziony = wysz.Binarne(lista, wyszukiwany);
		std::cout << "Szukano " << wyszukiwany << ".";
		if (znaleziony >= 0)
		{
			std::cout << " Znaleziono na " << znaleziony << " pozycji.";
		}
		else {
			std::cout << " Nie znaleziono";
		}
		std::cout << "\n";
	}
	{
		wyszukiwany = 348;
		list<int>& lista = dane.PosortowanaLista;
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		znaleziony = wysz.Binarne(lista, wyszukiwany);
		std::cout << "Szukano " << wyszukiwany << ".";
		if (znaleziony >= 0)
		{
			std::cout << " Znaleziono na " << znaleziony << " pozycji.";
		}
		else {
			std::cout << " Nie znaleziono";
		}
		std::cout << "\n" << std::endl;
	}

	std::cout << "Przeszukiwanie interpolacyjne" << std::endl;
	{
		wyszukiwany = 99;
		list<int>& lista = dane.PosortowanaLista;
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		znaleziony = wysz.Interpolacyjne(lista, wyszukiwany);
		std::cout << "Szukano " << wyszukiwany << ".";
		if (znaleziony >= 0)
		{
			std::cout << " Znaleziono na " << znaleziony << " pozycji.";
		}
		else {
			std::cout << " Nie znaleziono";
		}
		std::cout << "\n";
	}
	{
		wyszukiwany = 348;
		list<int>& lista = dane.PosortowanaLista;
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		znaleziony = wysz.Interpolacyjne(lista, wyszukiwany);
		std::cout << "Szukano " << wyszukiwany << ".";
		if (znaleziony >= 0)
		{
			std::cout << " Znaleziono na " << znaleziony << " pozycji.";
		}
		else {
			std::cout << " Nie znaleziono";
		}
		std::cout << "\n" << std::endl;
	}
}

void Tester::TestSortowania()
{
	Dane dane{};

	Sortowanie sort{};

	std::cout << "Test sortowania\n";

	{
		std::cout << "Przez proste wstawianie\n";
		auto lista = dane.GetRandomLista(DLUGOSC_RAND_LISTY);
		std::cout << "Przed posortowaniem\n";
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		sort.PrzezProsteWstawianie(lista);
		std::cout << "Po posortowaniu\n";
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		std::cout << std::endl;
	}

	{
		std::cout << "Przez proste wybieranie\n";
		auto lista = dane.GetRandomLista(DLUGOSC_RAND_LISTY);
		std::cout << "Przed posortowaniem\n";
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		sort.PrzezProsteWybieranie(lista);
		std::cout << "Po posortowaniu\n";
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		std::cout << std::endl;
	}

	{
		std::cout << "Babelkowe\n";
		auto lista = dane.GetRandomLista(DLUGOSC_RAND_LISTY);
		std::cout << "Przed posortowaniem\n";
		if(WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		sort.Babelkowe(lista);
		std::cout << "Po posortowaniu\n";
		if (WYSWIETL_DANE)
			help.Wyswietl(lista);
		else
			std::cout << "Ilosc elementow: " << DLUGOSC_RAND_LISTY << "\n";
		std::cout << std::endl;
	}
}
