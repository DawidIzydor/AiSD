// C++.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include "Wyszukiwanie.h"
#include "Dane.h"
#include "Tester.h"


int main()
{
	Tester test{};

	test.TestWyszukiwania();
	test.TestSortowania();

}

