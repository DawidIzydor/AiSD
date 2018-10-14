#include "pch.h"
#include "Dane.h"
#include <memory>

Dane::Dane()
{
	mt = std::mt19937(rd());
	dist = std::uniform_int_distribution<int>(MIN_RAND, MAX_RAND);
};


Dane::~Dane()
{
}

int Dane::GetRandomInt()
{
	return dist(mt);
}

list<int> Dane::GetRandomLista(int dlugosc)
{
	list<int> ret{};
	if (dlugosc <= 0)
	{
		return ret;
	}

	for (int i = 0; i < dlugosc; ++i)
	{
		ret.push_back(GetRandomInt());
	}

	return ret;
}
