namespace ProjetTests
{
    public class Calculatrice
    {
        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Addition(params int[] numbers)
        {
            return numbers.Sum();
        }

        public int Soustraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
