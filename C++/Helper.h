#pragma once

#include <vector>
#include <memory>

template<typename T>
using list = std::vector<T>;
template<typename T>
using list_ptr = std::unique_ptr<list<T>>;

class Helper
{
public:
	Helper();
	~Helper();

	static void Wyswietl(list<int>& lista);
};

