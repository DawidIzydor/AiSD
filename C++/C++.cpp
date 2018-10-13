// C++.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include "Wyszukiwanie.h"
#include "Dane.h"


#define DLUGOSC_RAND_LISTY 25

void Wyswietl(list_ptr<int>& lista)
{
	for (auto a : *(lista.get()))
	{
		std::cout << a << ", ";
	}
	std::cout << std::endl;
}

int main()
{
	Dane dane{};
	Wyszukiwanie wysz{};

	int wyszukiwany;
	int znaleziony;
	list_ptr<int> lista;

	std::cout << "Przeszukiwanie liniowe" << std::endl;
	wyszukiwany = 348;
	lista = dane.GetRandomLista(DLUGOSC_RAND_LISTY);
	Wyswietl(lista);
	znaleziony = wysz.Liniowe(lista, wyszukiwany);
	std::cout << "Szukano " << wyszukiwany<<".";
	if (znaleziony >= 0)
	{
		std::cout << " Znaleziono na " << znaleziony << " pozycji.";
	}
	else {
		std::cout << " Nie znaleziono";
	}
	std::cout<<"\n"<<std::endl;

	std::cout << "Przeszukiwanie binarne" << std::endl;
	wyszukiwany = 99;
	lista = std::make_unique<list<int>>(dane.PosortowanaLista);
	Wyswietl(lista);
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
	wyszukiwany = 348;
	lista = std::make_unique<list<int>>(dane.PosortowanaLista);
	Wyswietl(lista);
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

