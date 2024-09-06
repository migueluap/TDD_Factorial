namespace Tdd.Factorial;

public class FactorialService
{
    public int Calculate(int number)
    {
        if (number  == 0) return 1;

        //return number * Calculate(number - 1);

        int result = 1;
        for (int index = 1; index <= number; index++)
            result *= index;

        return result;
    }
}
