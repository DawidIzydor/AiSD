#include <iostream>
#include <climits>
#include <cmath>
#include <functional>
#include <memory>

using namespace std;

class DrzewoElement;

using deptr = shared_ptr<DrzewoElement>;

enum PrintOrder{
	Preorder,
	Postorder,
	Inorder
};

class DrzewoElement{
	private:
		int _element;
		
	public:
		DrzewoElement* Rodzic;
		deptr Lewy;
		deptr Prawy;
		
		DrzewoElement(int element, DrzewoElement* rodzic)
		{
			_element = element;
			Rodzic = rodzic;
		}	
		
		int GetValue()
		{
			return _element;
		}
		
		void SetValue(int val)
		{
			_element = val;
		}
		
		void Add(int element)
		{
			if(element < _element)
			{
				if(Lewy == nullptr)
				{
					Lewy = make_shared<DrzewoElement>(element, this);
				}else{
					Lewy->Add(element);
				}
			}else if(element > _element){
				if(Prawy == nullptr)
				{
					Prawy = make_shared<DrzewoElement>(element, this);
				}else{
					Prawy->Add(element);
				}
			}
		}
		
		void Print(PrintOrder order)
		{
			if(order == PrintOrder::Preorder)
			{
				cout<<_element<<" ";	
			}
			
			if(Lewy != nullptr)
			{
				Lewy->Print(order);
			}
			
			if(order == PrintOrder::Inorder)
			{
				cout<<_element<<" ";	
			}
			
			if(Prawy != nullptr)
			{
				Prawy->Print(order);
			}
			
			if(order == PrintOrder::Postorder)
			{
				cout<<_element<<" ";	
			}
		}
		
		DrzewoElement* Find(int element)
		{
			if(_element == element)
			{
				return this;
			}
			
			if(element < _element)
			{
				if(Lewy != nullptr)
				{
					return Lewy->Find(element);
				}else{
					return nullptr;
				}
			}
			
			if(element > _element)
			{
				if(Prawy != nullptr)
				{
					return Prawy->Find(element);
				}else{
					return nullptr;
				}
			}
		}
		
		int SmallestEl()
		{
			if(Lewy == nullptr)
			{
				return _element;
			}else{
				return Lewy->SmallestEl();
			}
		}
	
		int BiggestEl()
		{
			if(Prawy == nullptr)
			{
				return _element;
			}else{
				return Prawy->BiggestEl();
			}
		}
		
		DrzewoElement* Smallest()
		{
			if(Lewy == nullptr)
			{
				return this;
			}else{
				return Lewy->Smallest();
			}
		}
	
		DrzewoElement* Biggest()
		{
			if(Prawy == nullptr)
			{
				return this;
			}else{
				return Prawy->Biggest();
			}
		}
		
};

class Drzewo{
	private:
		deptr _root;
		
	public:
		
		void Add(int element)
		{
			if(_root == nullptr)
			{
				_root = make_shared<DrzewoElement>(element, nullptr);
			}else{
				_root->Add(element);
			}
		}
		
		void Print(PrintOrder order)
		{
			if(_root != nullptr)
			{
				_root->Print(order);
			}
			
			cout<<endl;
		}
		
		void Delete(int element)
		{
			if(_root == nullptr) return;
			
			DrzewoElement* found = _root->Find(element);
			
			if(found == nullptr) return;
			
			if(found->Rodzic == nullptr)
			{
				_root = nullptr;
			}else{
			
				if(found->Lewy == nullptr && found->Prawy == nullptr)
				{
					auto test = found->Rodzic->GetValue();
					auto test2 = found->GetValue();
					
					if(found->Rodzic->GetValue() < found->GetValue())
					{
						found->Rodzic->Prawy = nullptr;
					}else{
						found->Rodzic->Lewy = nullptr;
					}
					
				}else if(found->Prawy != nullptr && found->Lewy != nullptr){
					
					DrzewoElement* smallest = found->Prawy->Smallest();
					
					found->SetValue(smallest->GetValue());
					
					if(smallest->Prawy != nullptr)
					{
						smallest->Rodzic->Lewy = smallest->Prawy;
					}else{
						if(smallest->Rodzic == found)
						{
							smallest->Rodzic->Prawy = nullptr;
						}else{
							smallest->Rodzic->Lewy = nullptr;
						}
					}
						
				}else if(found->Lewy == nullptr)
				{
					if(found->Rodzic->GetValue() < found->GetValue())
					{
						found->Rodzic->Prawy = found->Prawy;
					}else{
						found->Rodzic->Lewy = found->Prawy;
					}
				}else if(found->Prawy == nullptr)
				{
					if(found->Rodzic->GetValue() < found->GetValue())
					{
						found->Rodzic->Prawy = found->Lewy;
					}else{
						found->Rodzic->Lewy = found->Lewy;
					}
				}
			
			}
		}
};


int main()
{
	{
		// ilosc 'poziomow' drzewa
		int poziomy = 4;
		int elementy = pow(2, poziomy)-3;
		
		int drzewo[elementy] = {5, 3, 2, 1, 7, INT_MIN, 4, INT_MIN, 6, INT_MIN, 9, 8, INT_MIN};
		
		auto LewyIndex = [](int i)->int{return 2*i+1;};
		auto PrawyIndex = [](int i)->int{return 2*i+2;};
		
		function<void(int)> Print = [&drzewo, &elementy, &Print, &LewyIndex, &PrawyIndex](int lisc)->void{
			if(lisc < elementy)
			{
				Print(LewyIndex(lisc));
				Print(PrawyIndex(lisc));
				
				int w = drzewo[lisc];
				if(w != INT_MIN)
				{
					cout<<w<<" ";
				}else{
					cout<<" ";
				}
			}
		};
		
		Print(0);
		cout<<endl;
	}	
	
	{
		cout<<endl;
		
		shared_ptr<Drzewo> drzewo = make_shared<Drzewo>();
		
		int drzewoels[] = {5, 3, 2, 1, 7, 4, 6, 9, 8, INT_MIN};
		for(int i = 0; drzewoels[i] != INT_MIN; ++i)
		{
			drzewo->Add(drzewoels[i]);
		}
		
		cout<<"Preorder \n";
		drzewo->Print(PrintOrder::Preorder);
		
		
		cout<<"Inorder \n";
		drzewo->Print(PrintOrder::Inorder);
		
		
		cout<<"Postorder \n";
		drzewo->Print(PrintOrder::Postorder);
		
		cout<<"Usun 1\n";
		drzewo->Delete(1);
		
		cout<<"Inorder \n";
		drzewo->Print(PrintOrder::Inorder);
		
				
		cout<<"Dodaj 1\n";
		drzewo->Add(1);
		
		cout<<"Inorder \n";
		drzewo->Print(PrintOrder::Inorder);
		
		cout<<"Usun 3\n";
		
		drzewo->Delete(3);
		
		cout<<"Inorder \n";
		drzewo->Print(PrintOrder::Inorder);
		
		
		cout<<"Usun 99\n";
		
		drzewo->Delete(99);
		
		cout<<"Inorder \n";
		drzewo->Print(PrintOrder::Inorder);
		
		
		cout<<"Usun 9, 6, 2\n";
	
		drzewo->Delete(9);
		drzewo->Delete(6);
		drzewo->Delete(2);
		
		cout<<"Inorder \n";
		drzewo->Print(PrintOrder::Inorder);
		
	}
	
}
