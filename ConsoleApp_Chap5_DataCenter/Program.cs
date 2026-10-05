namespace ConsoleApp_Chap5_DataCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indiquez la consommation énergétique du data center en % :");
            double consommation = double.Parse(Console.ReadLine());
            double init = 1;
            int annee = 0;
            Console.WriteLine(" ");
            while (init < 2)
            {
                init = init * (consommation/100 + 1);
                init = Math.Round(init, 2);
                annee++;
            }
            Console.WriteLine("Le data center doublera sa consommation après {0} ans.", annee);
        }
    }
}
