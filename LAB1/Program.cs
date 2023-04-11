using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console app
            //Application.Run(new BackBagForm());
            Console.WriteLine("Podaj liczbę przedmiotów");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj seed");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj maksymalną wagę");
            int fw = int.Parse(Console.ReadLine());
            BackBag backBag = new BackBag(n, s, fw);
            Console.WriteLine("Rezult");
            Console.WriteLine(backBag.FindBestResult());
            Console.ReadLine();

            //Windows forms app
            //Application.Run(new BackBagForm());
        }
    }
}
