#include <iostream>
#include <vector>
#include <cstdlib>
#include <ctime>

// Standard c++11
// Dodaj do opcji kompilatora -std=c++11

using vi = std::vector<int>;

std::vector<int> orgTablica = {15, 12, 11, 10, 11, 8, 5, 3, 7, 2, 9};

void Wynurzenie(vi& tablica, int i)
{
	int j = i;
	while(j != 0)
	{
		int rodzic = (j-1)/2;
		if(tablica.at(rodzic) < tablica.at(j))
		{
			int temp = tablica.at(j);
			tablica.at(j) = tablica.at(rodzic);
			tablica.at(rodzic) = temp;
		}
		j = rodzic;
	}
}

void Zatapianie(vi& tablica, int j)
{
	if(j < tablica.size())
	{
		int synLewy = (2*j)+1;
		int synPrawy = (2*j)+2;
		
		if(synLewy < tablica.size())
		{
			if(tablica.at(synLewy) > tablica.at(j))
			{
				int temp = tablica.at(j);
				tablica.at(j) = tablica.at(synLewy);
				tablica.at(synLewy) = temp;
				Zatapianie(tablica, synLewy);
			}
		}
		
		if(synPrawy < tablica.size())
		{
			if(tablica.at(synPrawy) > tablica.at(j))
			{
				int temp = tablica.at(j);
				tablica.at(j) = tablica.at(synPrawy);
				tablica.at(synPrawy) = temp;
				Zatapianie(tablica, synPrawy);
			}
		}
	}
}

void print(vi& tablica)
{
	for(int i = 0; i < tablica.size(); ++i)
	{
		std::cout<<"["<<i<<"]: "<<tablica.at(i)<<" ";
	}
	std::cout<<"\n";
}

vi CopyTablica(vi& tablica)
{
	vi nowaTablica = {};
	for(auto i : tablica)
	{
		nowaTablica.push_back(i);
	}
	return nowaTablica;
}

int Extract(vi& tablica)
{
	if(tablica.size() == 0)
		return -1;
		
	int ret = tablica.at(0);
		
	int temp = tablica.at(tablica.size()-1);
	tablica.at(tablica.size()-1) = tablica.at(0);
	tablica.at(0) = temp;
	
	tablica.pop_back();
	
	Zatapianie(tablica, 0);
	
	return ret;
}

int main()
{
	srand(time(NULL));
	
	std::cout<<"Oryginalna\n";
	print(orgTablica);
		
	std::cout<<"\n";
	
	{
		std::cout<<"Wynurzenie\n";
		vi tablica = CopyTablica(orgTablica);
		tablica.at(tablica.size()-1) = 1613;
		std::cout<<"Przed wynurzaniem\n";
		print(tablica);
		Wynurzenie(tablica, tablica.size()-1);
		std::cout<<"Po wynurzaniu\n";
		print(tablica);
	}
	
	std::cout<<"\n";
	
	{
		std::cout<<"Zatapianie\n";
		vi tablica = CopyTablica(orgTablica);
		tablica.at(0) = 1;
		std::cout<<"Przed zatapianiem\n";
		print(tablica);
		Zatapianie(tablica, 0);
		std::cout<<"Po zatapianiu\n";
		print(tablica);
	}
	
    
	std::vector<int> KolejkaPriorytetowa = {};		
    std::cout<<"Kolejka \n";
    for( int i = 0; i < 10; i++ )
    {
        int nowa = rand()%20;
        std::cout<<"Wstawiam "<<nowa<<"\n";
        KolejkaPriorytetowa.push_back(nowa);
        std::cout<<"Przed wynurzaniem\n";
		print(KolejkaPriorytetowa);
        Wynurzenie(KolejkaPriorytetowa, KolejkaPriorytetowa.size()-1);
		std::cout<<"Po wynurzaniu\n";
		print(KolejkaPriorytetowa);
	}
	
	std::cout<<"\n";
	
	std::cout<<"Extract\n";
    std::cout<<"Przed\n";
	print(KolejkaPriorytetowa);
	std::cout<<Extract(KolejkaPriorytetowa)<<"\n";
    std::cout<<"Po\n";
	print(KolejkaPriorytetowa);
	
}
