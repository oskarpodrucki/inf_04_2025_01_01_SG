using System;

namespace konsolowa
{
    class Program
    {
        class Tablica
        {
            private int[] LiczbyCalkowite;
            private int LiczbaElementow;

            public Tablica(int RozmiarTablicy)
            {
                this.LiczbaElementow = RozmiarTablicy;
                this.LiczbyCalkowite = new int[RozmiarTablicy];

                Random random = new Random();

                for (int i = 0; i < RozmiarTablicy; i++)
                {
                    LiczbyCalkowite[i] = random.Next(1, 1000);
                }
            }

            /**********************************************
             nazwa metody: WyswietlElementy
             opis metody: Wyświetla wszystkie elementy tablicy w postaci „<index_tablicy>: <wartość>”. Nie zwraca wartości
             parametry: brak
             zwracany typ i opis: brak
             autor: 12345678901
             ***********************************************/
            public void WyswietlElementy()
            {
                for (int i = 0; i < LiczbaElementow; i++)
                {
                    Console.WriteLine($"{i}: {LiczbyCalkowite[i]}");
                }
            }

            /**********************************************
             nazwa metody: ZnajdzWartosc
             opis metody: Wyszukuje pierwsze wystąpienie wartości, przekazanej jako argument. Metoda zwraca indeks szukanego elementu lub liczbę -1, gdy elementu nie znaleziono
             parametry: wartosc - szukana wartość przez metodę
             zwracany typ i opis: int, indeks szukanego elementu lub -1, gdy elementu nie znaleziono 
             autor: 12345678901
             ***********************************************/
            public int ZnajdzWartosc(int wartosc)
            {
                for (int i = 0; i < LiczbaElementow; i++)
                {
                    if (LiczbyCalkowite[i] == wartosc)
                    {
                        return i;
                    }
                }
                return -1;
            }

            /**********************************************
             nazwa metody: WyswietlNieparzyste
             opis metody: Wyświetla wszystkie wartości nieparzyste z tablicy i zwraca ich liczbę
             parametry: brak
             zwracany typ i opis: int, liczba znalezionych elementów nieparzystych
             autor: 12345678901
             ***********************************************/
            public int WyswietlNieparzyste()
            {
                int WystapieniaNieparzystych = 0;

                Console.WriteLine("Liczby nieparzyste:");

                for (int i = 0; i < LiczbaElementow; i++)
                {
                    if (LiczbyCalkowite[i] % 2 != 0)
                    {
                        Console.WriteLine(LiczbyCalkowite[i]);
                        WystapieniaNieparzystych++;
                    }
                }

                Console.WriteLine($"Razem nieparzystych: {WystapieniaNieparzystych}");
                return WystapieniaNieparzystych;
            }

            /**********************************************
             nazwa metody: ZwrocSrednia
             opis metody: Licząca średnią arytmetyczną wartości w tablicy i zwracającą tą wartość
             parametry: brak
             zwracany typ i opis: double, średnia obliczona z wartości z tablicy
             autor: 12345678901
             ***********************************************/
            public double ZwrocSrednia()
            {
                double srednia = 0;
                int suma = 0;

                for (int i = 0; i < LiczbaElementow; i++)
                {
                    suma += LiczbyCalkowite[i];
                }

                srednia = (double)suma / LiczbaElementow;

                return srednia;
            }
        }

        static void Main(string[] args)
        {
            Tablica tablica = new Tablica(50);

            tablica.WyswietlElementy();

            int index = tablica.ZnajdzWartosc(444);
            if (index != -1)
            {
                Console.WriteLine($"Szukana wartość 444 została znaleziona na indeksie: {index}");
            }

            tablica.WyswietlNieparzyste();

            double srednia = tablica.ZwrocSrednia();
            Console.WriteLine($"Średnia wszystkich elementów: {srednia}");
        }
    }
}