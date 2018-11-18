#include <memory>
#include <climits>
#include <iostream>

using namespace std;

class KolejkaElement;

using keptr = shared_ptr<KolejkaElement>;

class KolejkaElement{
	
	private:
		int _wartosc;
		keptr _nastepny;
		
	public:
		KolejkaElement(int val)
		{
			_wartosc = val;
		}
		
		keptr Enque(int element)
		{
			if(_nastepny == nullptr)
			{
				_nastepny = make_shared<KolejkaElement>(element);
				return _nastepny;
			}else{
				return _nastepny->Enque(element);
			}
		}
		
		int Deque()
		{
			return _wartosc;
		}
		
		keptr Nastepny()
		{
			return _nastepny;
		}
};


class Kolejka{
	private:
		keptr _pierwszy;
		keptr _ostatni;
		
	public:
		Kolejka(){
		}
		
		void Enque(int element)
		{
			if(_pierwszy == nullptr)
			{
				_pierwszy = make_shared<KolejkaElement>(element);
				_ostatni = _pierwszy;
			}else{
				_ostatni = _pierwszy->Enque(element);
			}
		}
		
		int Deque()
		{
			if(_pierwszy == nullptr)
			{
				return INT_MIN;
			}
			
			int ret = _pierwszy->Deque();
			_pierwszy = _pierwszy->Nastepny();
			
			return ret;
		}
		
		void Print()
		{
			keptr temp = _pierwszy;
			
			while(temp != nullptr)
			{
				cout<<temp->Deque()<<" ";
				
				temp = temp->Nastepny();
			}
			
			cout<<endl;
			
			
		}
};


int main()
{
	shared_ptr<Kolejka> kolejka = make_shared<Kolejka>();
	
	kolejka->Enque(5);
	kolejka->Enque(2);
	kolejka->Enque(6);
	kolejka->Enque(8);
	kolejka->Enque(1);
	kolejka->Enque(2);
	
	kolejka->Print();
	
	kolejka->Deque();
	kolejka->Deque();
	kolejka->Deque();
	kolejka->Deque();
	kolejka->Deque();
	kolejka->Deque();
	kolejka->Deque();
	
	kolejka->Print();
}
