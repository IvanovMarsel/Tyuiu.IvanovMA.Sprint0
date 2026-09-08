using Tyuiu.IvanovMA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.IvanovMA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов клааса DataService и метода GetMessage
            //из библиотеки Tyuiu.IvanovMA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Марсель"));
            Console.ReadKey();
        }
    }
}
