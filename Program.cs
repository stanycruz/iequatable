using System;
using System.Collections.Generic;
using System.Linq;

namespace iequatable
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Pessoa> pessoas1 = new Pessoa[]
            {
                new Pessoa("Renan Osvaldo Benício Dias", "218.523.393-90", "19.030.419-4", Convert.ToDateTime("01/08/1952")),
                new Pessoa("Patrícia Fátima Costa", "328.436.702-09", "31.519.736-5", Convert.ToDateTime("06/06/1980")),
                new Pessoa("Eduardo Miguel Ferreira", "879.996.099-00", "20.114.904-7", Convert.ToDateTime("21/06/1946")),
                new Pessoa("Arthur José Bernardo Aragão", "170.726.840-18", "35.549.099-7", Convert.ToDateTime("11/02/1993")),
                new Pessoa("Giovanni Murilo Gael da Cruz", "956.193.702-67", "13.095.098-1", Convert.ToDateTime("04/02/1994")),
                //mais seis pessoas em 1 que não contém em 2
                new Pessoa("Diego Antonio Vicente Lima", "290.708.148-97", "31.490.639-3", Convert.ToDateTime("19/03/1992")),
                new Pessoa("Levi Yuri Fernandes", "217.024.637-10", "12.636.006-6", Convert.ToDateTime("15/03/1965")),
                new Pessoa("Sérgio Enzo Mário Aragão", "220.435.884-35", "19.895.201-6", Convert.ToDateTime("14/07/1958")),
                new Pessoa("Carlos Raimundo Nicolas Mendes", "080.994.941-56", "080.994.941-56", Convert.ToDateTime("08/03/1972")),
                new Pessoa("Breno Gabriel Jorge Barros", "074.080.994-68", "48.030.880-9", Convert.ToDateTime("21/08/1977")),
                new Pessoa("Emily Alícia Lima", "798.079.359-54", "38.411.770-3", Convert.ToDateTime("02/01/1972"))
            };

            IEnumerable<Pessoa> pessoas2 = new Pessoa[]
            {
                new Pessoa("Renan Osvaldo Benício Dias", "218.523.393-90", "19.030.419-4", Convert.ToDateTime("01/08/1952")),
                new Pessoa("Patrícia Fátima Costa", "328.436.702-09", "31.519.736-5", Convert.ToDateTime("06/06/1980")),
                new Pessoa("Eduardo Miguel Ferreira", "879.996.099-00", "20.114.904-7", Convert.ToDateTime("21/06/1946")),
                new Pessoa("Arthur José Bernardo Aragão", "170.726.840-18", "35.549.099-7", Convert.ToDateTime("11/02/1993")),
                new Pessoa("Giovanni Murilo Gael da Cruz", "956.193.702-67", "13.095.098-1", Convert.ToDateTime("04/02/1994"))
            };

            ISet<Pessoa> set1 = new HashSet<Pessoa>(pessoas1);
            ISet<Pessoa> set2 = new HashSet<Pessoa>(pessoas2);

            var compare = set1.Except(set2);

            Console.WriteLine($"-- {compare.Count()} Resultados --");

            foreach (var item in compare)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
