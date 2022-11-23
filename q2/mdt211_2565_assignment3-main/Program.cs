class Program
{
    static void Main(string[] args)
    {
        Queue<char> Factory = new Queue<char>();
        char input;
        string ans = "";
        string qns = "";
        do
        {
            input = Console.ReadLine()[0];
            if (input == 'L')
            {
                Factory.Enqueu('1'); qns += "1";
            }
            else if (input == 'M')
            {
                Factory.Enqueu('2'); qns += "2";
            }
            else if (input == 'S')
            {
                Factory.Enqueu('3'); qns += "3";
            }
        } while (input == 'L' || input == 'M' || input == 'S');

        ans = QExpression(Factory, ans);
        ans = QExpression(Factory, ans);
        qns += ans;
        Console.WriteLine(qns);
    }
    public static string QExpression(Queue<char> Factory, string ans)
    {
        for (int i = 0; i < Factory.GetLength(); i++)
        {
            char temp = Factory.Dequeue();
            if (temp == '1')
            {
                ans += "22";
                Factory.Enqueu('2'); Factory.Enqueu('2');
            }
            else if (temp == '2')
            {
                ans += "333";
                Factory.Enqueu('3'); Factory.Enqueu('3'); Factory.Enqueu('3');
            }
        }
        return ans;
    }
}//dotnet run

