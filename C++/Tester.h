#pragma once

#include "Helper.h"

class Tester
{
private:
	Helper help{};
public:
	Tester();
	~Tester();

	void TestWyszukiwania();
	void TestSortowania();
};

