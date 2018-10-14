#pragma once
#include "Dane.h"

class Wyszukiwanie
{
private:
	Dane dane{};
public:
	Wyszukiwanie();
	~Wyszukiwanie();

	int Liniowe(list_ptr<int>& przeszukiwanaKolekcja, int WyszukiwanyElement);
	int Binarne(list_ptr<int>& posortowanaKolekcja, int szukanyElement);
	int Interpolacyjne(list_ptr<int>& posortowanaKolekcja, int szukanyElement);
};

