using System.ComponentModel.Design;

namespace egz3konsolowa
{
    internal class Program
    {

        static char SprawdzPlec(int[] pesel)
        {
            char plec = ' ';
            if (pesel[9] % 2 == 0)
                plec = 'K';
            else
                plec = 'M'; 

            return plec; 
        }
        
        static bool SprawdzPoprawnosc(int[] pesel)
        {
            bool poprawny = true;

            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            int S = 0;
            int R = 0;

            for(int i=0; i<wagi.Length; i++)
            {
                S += wagi[i] * pesel[i];
            }

            int M = S % 10;

            if (M == 0)
                R = 0;
            else if (M > 0)
                R = 10 - M;

            if (R == pesel[10])
                poprawny = true;
            else
                poprawny = false;
            

            return poprawny;
        }

        static void Main(string[] args)
        {
            int[] pesel = { 5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3 };
            int[] peselUzytkownika = new int[11];

            int liczba = 0;

            for(int i =0; i<11; i++)
            {
                Console.WriteLine("Podaj liczbę " + (i+1) + "numeru pesel: ");
                liczba = int.Parse(Console.ReadLine());
                peselUzytkownika[i] = liczba;
            }
        }
    }
}
