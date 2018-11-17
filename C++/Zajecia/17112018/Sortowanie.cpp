#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;



int PrzezProsteWybieranie(int* tablica, int n, bool odwrotnie = false)
{
	int iloscIteracji = 0;

	for (int i = 0; i < n - 1; ++i)
	{
		int PozycjaNajmniejszego = i;

		for (int j = i + 1; j < n; ++j)
		{
			iloscIteracji++;

			if (!odwrotnie && tablica[j] < tablica[PozycjaNajmniejszego] || odwrotnie && tablica[j] > tablica[PozycjaNajmniejszego])
			{
				PozycjaNajmniejszego = j;
			}
		}

		int temp = tablica[PozycjaNajmniejszego];
		tablica[PozycjaNajmniejszego] = tablica[i];
		tablica[i] = temp;
	}

	return iloscIteracji;
}

int PrzezProsteWstawianie(int* tablica, int n, bool odwrotnie = false)
{
	int iloscIteracji = 0;

	for (int i = 1; i < n; ++i)
	{
		int Klucz = tablica[i];

		int j = i - 1;

		while (j >= 0 && (tablica[j] > Klucz && !odwrotnie || odwrotnie && tablica[j] < Klucz))
		{
			iloscIteracji++;

			tablica[j + 1] = tablica[j];
			j--;
		}

		tablica[j + 1] = Klucz;
	}

	return iloscIteracji;
}

int Babelkowe(int* tablica, int n, bool odwrotnie = false)
{
	int iloscIteracji = 0;

	do
	{
		for (int i = 0; i < n - 1; ++i)
		{
			iloscIteracji++;

			if (tablica[i] > tablica[i + 1] && !odwrotnie || odwrotnie && tablica[i] < tablica[i + 1])
			{
				int temp = tablica[i];
				tablica[i] = tablica[i + 1];
				tablica[i + 1] = temp;
			}
		}

		n--;
	} while (n > 1);

	return iloscIteracji++;

}


void Sortuj(int n)
{
	int* tablica = new int[n];
	int* orgtab = new int[n];

	auto generuj = [orgtab, n]()->void {
		for (int i = 0; i < n; ++i)
		{
			orgtab[i] = rand() % n;
		}
	};

	auto wyswietl = [tablica, n]()->void {
		for (int i = 0; i < n - 1; ++i)
		{
			cout << tablica[i] << ",";
		}
		cout << tablica[n - 1] << endl;
	};

	auto kopiuj = [n](int* tablicaz, int* tablicado)->void {
		for (int i = 0; i < n; ++i)
		{
			tablicado[i] = tablicaz[i];
		}
	};

	generuj();

	cout << "N = " << n << endl;

	kopiuj(orgtab, tablica);


	{
		cout << "Wybieranie" << endl;

		clock_t poczatek = clock();
		PrzezProsteWybieranie(tablica, n);
		clock_t koniec = clock();

		double wynik = (double)(koniec - poczatek) / CLOCKS_PER_SEC;

		cout << "Czas: " << wynik << endl;
	}


	kopiuj(orgtab, tablica);

	{

		cout<<"Wstawianie"<<endl;

		clock_t poczatek = clock();
		PrzezProsteWstawianie(tablica, n);
		clock_t koniec = clock();

		double wynik = (double)(koniec-poczatek)/CLOCKS_PER_SEC;

		cout<<"Czas: "<<wynik<<endl;
	}

	kopiuj(orgtab, tablica);


	{

		cout << "Babelkowe" << endl;

		clock_t poczatek = clock();
		Babelkowe(tablica, n, true);
		clock_t koniec = clock();

		double wynik = (double)(koniec - poczatek) / CLOCKS_PER_SEC;

		cout << "Czas: " << wynik << endl;
	}


}

int main()
{

	time_t t;
	int zar = time(&t);

	srand(zar);

	Sortuj(20);

	cout << endl;

	Sortuj(2000);

	cout << endl;

	Sortuj(10000);


	cout << endl;

	Sortuj(50000);


	cout << endl;

	Sortuj(100000);

}
