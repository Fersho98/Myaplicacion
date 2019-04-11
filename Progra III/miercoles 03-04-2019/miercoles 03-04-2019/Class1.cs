using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miercoles_03_04_2019
{
    class Class1
    {
        public static IEnumerable<int> obtenerpares()
        {
            int[] numeros = { 1, 5, 2, 8, 4, 6, 17, 9, 0, 8 };

            IEnumerable<int> pares = from n in numeros
                                     where n % 2 == 0
                                     select n;
            return pares;
        }




        private static string[] postres = { "Pie de Limon", "Torta tres leches","Queque","Chupelupe","Selva Negra"};


        private static IEnumerable<string> encontrado = from p in postres
                                                        where p.contains("Limon")
                                                        select p;


        public static IEnumerable<string> obtenerpostre()
        {
            return encontrado;
        }
    }
}
