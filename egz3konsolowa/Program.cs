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

        static void Main(string[] args)
        {
            int[] pesel = { 5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3 };
        }
    }
}
