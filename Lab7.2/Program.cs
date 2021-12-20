namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
             //8 вариант - базовый уровень
                Console.WriteLine("Введите предложение: ");
                string TEXT1 = Console.ReadLine();
            TEXT1 = TEXT1.Replace(' ', '~');
                Console.WriteLine(TEXT1);
            
        }
    }
}