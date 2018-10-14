#pragma once
#include "Dane.h"
#include "Helper.h"

class Wyszukiwanie
{
private:
	Dane dane{};
public:
	Wyszukiwanie();
	~Wyszukiwanie();

	int Liniowe(list<int>& przeszukiwanaKolekcja, int WyszukiwanyElement);
	int Binarne(list<int>& posortowanaKolekcja, int szukanyElement);
	int Interpolacyjne(list<int>& posortowanaKolekcja, int szukanyElement);
};

