internal class Assignment
{
    public static int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }
    public static int Subtract(int a, int b)
    {
        int result = a - b;
        return result;
    }
    public static int Multiply(int a, int b)
    {
        int result = a * b;
        return result;
    }
    public static float Divide(float a, float b)
    {
        float result = a / b;
        return result;
    }

    public static void Main(string[] args)
    {
        int AddResult = Add(5, 3);
        Console.WriteLine(AddResult);

        int SubtractResult = Subtract(5, 3);
        Console.WriteLine(SubtractResult);

        float DivideResult = Divide(5, 3);
        Console.WriteLine(DivideResult);

        int MultiplyResult = Multiply(5, 3);
        Console.WriteLine(MultiplyResult);
    }
}