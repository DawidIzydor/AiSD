#include <iostream>
#include <memory>

using namespace std;

class ListaElement
{
	private:
		int Element;
		
		// 0 - nic, 1 - rosnaco, 2 - malejaco
		int _rosnaco;
		
	
	public:
		shared_ptr<ListaElement> Nastepny;
		
		ListaElement(int val, int rosnaco){
			Element = val;
			_rosnaco = rosnaco;
		}
		
		void setValue(int val){
			Element = val;
		}	
		
		
		int getValue()
		{
			return Element;
		}
			
		void Dodaj(int element)
		{
			if(Nastepny == nullptr)
			{
				Nastepny = make_shared<ListaElement>(element, _rosnaco);
			}else{
				Nastepny->Dodaj(element);
			}
		
		}
};

using leptr = shared_ptr<ListaElement>;

class Lista
{
	private:
		shared_ptr<ListaElement> Pierwszy;
		
		// 0 - nic, 1 - rosnaco, 2 - malejaco
		int _rosnaco = 0;
		
		void add(int element)
		{
			if(_rosnaco != 1 && _rosnaco != 2)
			{
				return;
			}
			
			if(Pierwszy->getValue() > element && _rosnaco == 1 || _rosnaco == 2 && Pierwszy->getValue() < element)
			{
				
				auto NewPtr = make_shared<ListaElement>(element, _rosnaco);
				NewPtr->Nastepny = Pierwszy;
				Pierwszy = NewPtr;
				
			}else{
				leptr temp = Pierwszy;
				while(temp->Nastepny != nullptr)
				{
					if(_rosnaco == 1 && temp->Nastepny->getValue() > element)
					{
						auto NewPtr = make_shared<ListaElement>(element, _rosnaco);
						NewPtr->Nastepny = temp->Nastepny;
						temp->Nastepny = NewPtr;
						return;
					}else if(_rosnaco == 2 && temp->Nastepny->getValue() < element)
					{
						auto NewPtr = make_shared<ListaElement>(element, _rosnaco);
						NewPtr->Nastepny = temp->Nastepny;
						temp->Nastepny = NewPtr;
						return;
					}
					temp = temp->Nastepny;
				}
				
				temp->Dodaj(element);
			}
		}
		
	public:
		Lista(int rosnaco = 0)
		{
			_rosnaco = rosnaco;
		}
		
		leptr Find(int element)
		{
			leptr ret = nullptr;
			leptr temp = Pierwszy;
			
			while(temp != nullptr)
			{
				if(temp->getValue() == element)
				{
					ret = temp;
					break;
				}
				temp = temp->Nastepny;
			}
			
			return ret;
		}
		
		void Usun(int element)
		{
			leptr ret = nullptr;
			leptr poprzedni = nullptr;
			leptr temp = Pierwszy;
			
			while(temp != nullptr)
			{
				if(temp->getValue() == element)
				{
					ret = temp;
					break;
				}
				poprzedni = temp;
				temp = temp->Nastepny;
			}
			
			if(ret != nullptr)
			{
				if(poprzedni == nullptr)
				{
					Pierwszy = Pierwszy->Nastepny;
				}else{
					poprzedni->Nastepny = ret->Nastepny;
				}
			}
		}
		
		void addBack(int element)
		{
			
			if(Pierwszy == nullptr)
			{
				Pierwszy = make_shared<ListaElement>(element, _rosnaco);
			}else{
				if(_rosnaco != 1 && _rosnaco != 2)
				{
					Pierwszy->Dodaj(element);
				}else{
					add(element);
				}
			}
		}
		
		bool isEmpty()
		{
			return Pierwszy == nullptr;
		}
		
		void addFront(int element)
		{
			if(Pierwszy == nullptr)
			{
				Pierwszy = make_shared<ListaElement>(element, _rosnaco);
			}else{
				
				if(_rosnaco != 1 && _rosnaco != 2)
				{
					auto NewPtr = make_shared<ListaElement>(element, _rosnaco);
					NewPtr->Nastepny = Pierwszy;
					Pierwszy = NewPtr;
				}else{
					add(element);
				}
			}
		}
		
		void Print()
		{
			shared_ptr<ListaElement> temp = Pierwszy;
			while(temp != nullptr)
			{
				cout<<temp->getValue()<<" ";
				temp = temp->Nastepny;
			}
			cout<<endl;
		}
		
		void ClearLista()
		{
			Pierwszy = nullptr;
		}
};

int main()
{
	{	
		cout<<"Bez okreslenia"<<endl;
		shared_ptr<Lista> lista = make_shared<Lista>();
		
		cout<<"Add back"<<endl;
		lista->addBack(5);
		lista->addBack(3);
		lista->addBack(7);
		lista->addBack(2);
		lista->addBack(1);
		lista->addBack(1);
		
		lista->Print();
		
		cout<<endl;
		
		lista->ClearLista();
		
		cout<<"Add front"<<endl;
		
		lista->addFront(5);
		lista->addFront(3);
		lista->addFront(7);
		lista->addFront(2);
		lista->addFront(1);
		lista->addFront(1);
		
		lista->Print();
		cout<<endl;
		
		lista->ClearLista();
		
		cout<<"Delete"<<endl;
		
		lista->addFront(5);
		lista->addFront(3);
		lista->addFront(7);
		lista->addFront(2);
		lista->addFront(1);
		lista->addFront(1);
		
		lista->Usun(7);
		
		lista->Print();
		cout<<endl;
	}
	
	{
	
		cout<<"Rosnaco"<<endl;
		
		shared_ptr<Lista> lista = make_shared<Lista>(1);
		
		cout<<"Add back"<<endl;
		lista->addBack(5);
		lista->addBack(3);
		lista->addBack(7);
		lista->addBack(2);
		lista->addBack(1);
		lista->addBack(1);
		
		lista->Print();
		
		cout<<endl;
		
		lista->ClearLista();
		
		cout<<"Add front"<<endl;
		
		lista->addFront(5);
		lista->addFront(3);
		lista->addFront(7);
		lista->addFront(2);
		lista->addFront(1);
		lista->addFront(1);
		
		lista->Print();
		cout<<endl;
		
		lista->ClearLista();
		
		cout<<"Delete"<<endl;
		
		lista->addFront(5);
		lista->addFront(3);
		lista->addFront(7);
		lista->addFront(2);
		lista->addFront(1);
		lista->addFront(1);
		
		lista->Usun(7);
		
		lista->Print();
		cout<<endl;
	}
	
	{
		cout<<"Malejaco"<<endl;
		
		shared_ptr<Lista> lista = make_shared<Lista>(2);
		
		cout<<"Add back"<<endl;
		lista->addBack(5);
		lista->addBack(3);
		lista->addBack(7);
		lista->addBack(2);
		lista->addBack(1);
		lista->addBack(1);
		
		lista->Print();
		
		cout<<endl;
		
		lista->ClearLista();
		
		cout<<"Add front"<<endl;
		
		lista->addFront(5);
		lista->addFront(3);
		lista->addFront(7);
		lista->addFront(2);
		lista->addFront(1);
		lista->addFront(1);
		
		lista->Print();
		cout<<endl;
		
		lista->ClearLista();
		
		cout<<"Delete"<<endl;
		
		lista->addFront(5);
		lista->addFront(3);
		lista->addFront(7);
		lista->addFront(2);
		lista->addFront(1);
		lista->addFront(1);
		
		lista->Usun(7);
		
		lista->Print();
		cout<<endl;
	}
}
