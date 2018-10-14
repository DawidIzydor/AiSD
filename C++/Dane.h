#pragma once
#include <random>
#include <vector>
#include <memory>
#include "Helper.h"

#define MIN_RAND 0
#define MAX_RAND 1000

class Dane
{
private:
	std::random_device rd;
	std::mt19937 mt;
	std::uniform_int_distribution<int> dist;
public:
	Dane();
	~Dane();

	int GetRandomInt();
	list<int> GetRandomLista(int dlugosc);

	list<int> NieposortowanaLista = { 55, 61, 3, 2, 1, 11, 1612, 25, 22, 316 };
	list<int> PosortowanaLista = { 1, 2, 4, 6, 7, 8, 12, 25, 66, 78, 99, 123, 244, 567, 775 };
};

