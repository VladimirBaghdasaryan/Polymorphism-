namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Toyota("Camry", 2022);
            car1.PrintInfo();

            Car car2 = new Bmw("X6", 2017);
            car2.PrintInfo();
        }
    }
}