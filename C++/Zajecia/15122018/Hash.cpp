#include <iostream>

#include <vector>
#include <list>

// Standard c++11
// Dodaj do opcji kompilatora -std=c++11

using vs = std::list<std::string>;

enum Typ{
	typ1,
	typ2,
};

class HashTable{
	private:
		int _dlugosc;
		Typ _typ;
		std::vector<vs> tbl;
		
	int Hash1(std::string str)
	{	
		int i = 0;
		for(char c : str)
		{
			i+= (int)c;
		}
		
		return i%_dlugosc;
	}
	
	
	int Hash2(std::string str)
	{	
		// Stałe można dowolnie zmienić
		const double A = 0.669;
		const int m = 57;
		
		int i = 0;
		for(char c : str)
		{
			i += m * A * c;
		}
		
		return i%_dlugosc;
	}
	
	public:
		HashTable(int dlugosc, Typ typ = Typ::typ1)
		{
			_typ = typ;
			_dlugosc = dlugosc;
			
			while(tbl.size() <= dlugosc)
			{
				tbl.push_back(vs{});
			}
		}
		
		int CalculateHash(std::string str)
		{
			int hash = 0;
			switch(_typ)
			{
				case Typ::typ1:
					hash = Hash1(str);
					break;
					
				case Typ::typ2:
					hash = Hash2(str);
					break;
			}
			
			return hash;
		}
		
		void AddElement(std::string str)
		{
			int hash = CalculateHash(str);
			
			tbl.at(hash).push_back(str);
		}
		
		void Print()
		{
			for(int i = 0; i < tbl.size(); ++i)
			{
				std::cout<<"Hash: "<<i<<"\n";
				for(auto el : tbl.at(i))
				{
					std::cout<<el<<"\n";
				}
				std::cout<<"\n";
			}
		}
};

int main()
{
	{
		HashTable hc(13, Typ::typ1);
		
		hc.AddElement("asd");
		hc.AddElement("dsa");
		hc.AddElement("aaa");
		hc.AddElement("Dawid");
		hc.AddElement("dawid");
		hc.AddElement("Adrian");
		hc.AddElement("Izydor");
		hc.AddElement("izydor");
		hc.AddElement("Sikora");
		
		hc.Print();
	}
	
	{
		HashTable hc(13, Typ::typ2);
		
		hc.AddElement("asd");
		hc.AddElement("dsa");
		hc.AddElement("aaa");
		hc.AddElement("Dawid");
		hc.AddElement("dawid");
		hc.AddElement("Adrian");
		hc.AddElement("Izydor");
		hc.AddElement("izydor");
		hc.AddElement("Sikora");
		
		hc.Print();
	}
}
