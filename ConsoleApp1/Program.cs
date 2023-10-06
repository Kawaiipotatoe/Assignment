namespace ConsoleApp1
{

    internal class ConsoleApp1

    {

    public static int Add(int a, int b)
        {int result = a + b; return result;}
    public static int Subtract(int a, int b)
        {int result = a - b; return result;}
    public static int Multiply(int a, int b)
        {int result = a * b; return result;}
    public static float Divide(float a, float b)
        {float result = a / b;return result;}


    public static string Text(string a)
        {string name = a;return name;}
    public static string Text2(string a)
        {string name2 = a;return name2;}
    public static string Text3(string a)
        {string name3 = a;return name3;}
    public static string Text4(string a)
        {string name4 = a;return name4;}
       
    public static bool even(int a)
        {return a % 2 == 0;}
    public static bool odd(int a)
        {return a % 2 != 0;}

    public static void Main()
         {
            int AddResult = Add(5, 3);
                Console.WriteLine(AddResult);
            int SubtractResult = Subtract(5, 3);
                Console.WriteLine(SubtractResult);
            float DivideResult = Divide(5, 3);
                Console.WriteLine(DivideResult);
            int MultiplyResult = Multiply(5, 3);
                Console.WriteLine(MultiplyResult);

            string Nameresult = Text("hehe");
                Console.WriteLine(Nameresult);
            string Nameresult2 = Text("haha");
                Console.WriteLine(Nameresult2);
            string Nameresult3 = Text("huhu");
                Console.WriteLine(Nameresult3);
            string Nameresult4 = Text("hoho");
                Console.WriteLine(Nameresult4);

            bool oddd = odd(5);
                Console.WriteLine(oddd);
            bool evenn = even(5);
                Console.WriteLine(evenn);

        }
    }
}