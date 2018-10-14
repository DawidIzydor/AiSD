#pragma once
#include "Helper.h"

class Sortowanie
{
public:
	Sortowanie();
	~Sortowanie();

	void PrzezProsteWybieranie(list<int>& KolecjaDoPosortowania);
	void PrzezProsteWstawianie(list<int>& KolekcjaDoPosortowania);
	void Babelkowe(list<int>& KolekcjaDoPosortowania);
};

