# Algorytmy i Struktury Danych - wersja C++

Do poprawnego skompilowania wymagany jest kompilator obsługujący standard C++11 lub nowszy, poleca się kompilacje z flagą -std=C++14

W kodzie wykorzystany jest wektor a nie tablica danych, jest to dla ułatwienia pokazania działania algorytmu bez komplikacji wynikająch z problemów w przenoszeniu danych w C++.
Więcej informacji o std::vector: https://en.cppreference.com/w/cpp/container/vector

# Korzystanie

Aby skorzystać z konkretnych implementacji wystarczy zbudować obiekt odpowiedniej klasy po czym wywołać odpowiednią metodę, np. Sortowanie bąbelkowe:

```
Sortowanie sort{};
list<int> kolekcja {16, 25, 99, 100}; 
sort.Babelkowe(kolekcja);
```

## Wyszukiwanie
Klasa Wyszukiwanie zawiera trzy metody wyszukiwania:
1. Liniowe - dla nieuporządkowanych kolekcji
2. Binarne - dla uporządkowanych kolekcji
3. Interpolacyjne - jw

## Sortowanie
Klasa Sortowanie zawiera metody sortowania:
1. Proste przez wybieranie
2. Proste przez wstawianie
3. Bąbelkowe
