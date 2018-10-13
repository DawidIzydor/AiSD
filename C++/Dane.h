#pragma once
#include <random>
#include <vector>
#include <memory>

#define MIN_RAND 0
#define MAX_RAND 1000

template<typename T>
using list = std::vector<T>;
template<typename T>
using list_ptr = std::unique_ptr<list<T>>;

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
	list_ptr<int> GetRandomLista(int dlugosc);

	list<int> PosortowanaLista = list<int>{ 1, 2, 4, 6, 7, 8, 12, 25, 66, 78, 99, 123, 244, 567, 775, 3512 };
};

