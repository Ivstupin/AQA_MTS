namespace asdasd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "dfgfd";

            bool isNumeric = s.Any(char.IsDigit);

            Console.WriteLine(isNumeric);
        }
    }
}
