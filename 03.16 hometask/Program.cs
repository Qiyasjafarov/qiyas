// See https://aka.ms/new-console-template for more information
class Sas
{
static void Main()
{

    Console.WriteLine(CalculateArea(8,40));
        
}

    static int CalculateArea(int r)
    {if (r > 0)
        {
            int s = 3 * r * r;

            return s;
        }
        else return -1;

    }
    static int CalculateArea(int a, int b)
    {
        if (a > 0 && b > 0)
        {
            int s = a * b;

            return s;
        }
        else return -1;
    }

    static int CalculateArea(int a, int b, int c)
    {
        if (a > 0 && b > 0 && c > 0)
        {
            int s = 2 * (a * b + a * c + b * c);

            return s;
        }
        else return -1;
    }
}