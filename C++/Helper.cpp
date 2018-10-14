#include "pch.h"
#include "Helper.h"
#include <iostream>

Helper::Helper()
{
}


Helper::~Helper()
{
}

void Helper::Wyswietl(list<int>& lista)
{
	for (auto a : lista)
	{
		std::cout << a << ", ";
	}
	std::cout << std::endl;
}
