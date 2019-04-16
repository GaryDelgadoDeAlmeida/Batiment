using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Batiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------------------------------------------------------------------------------\n" +
                " Petit exercice sur l'héritage. Les données énnoncées sont aléatoires, voir non réelles." +
                "\n-------------------------------------------------------------------------------------------\n");

            Batiment batiment1, batiment2;
            batiment1 = new Batiment();
            batiment2 = new Batiment("68 rue Anatole");
            Console.WriteLine("Batiment 1 sans paramètre : " + batiment1.ToString()
                + "\nBatiment 2 avec paramètre : " + batiment2.ToString());
            Console.WriteLine();
            Maison maison1, maison2;
            maison1 = new Maison();
            maison2 = new Maison("207 boulevard Saint-Michel", 3);
            Console.WriteLine("Maison 1 hérite de bâtiment sans paramètre : " + maison1.ToString()
                + "\nMaison 2 hérite de bâtiment avec paramètre : " + maison2.ToString());
            Console.ReadLine();
        }
    }
}
