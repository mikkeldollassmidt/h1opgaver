using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    public class SortingHat
    {
        enum Colleges { Gryffindor, Hufflepuff, Ravenclaw, Slyhterin };
        public int randomNumber;

        public void ChooseCollege()
        {
            Random r = new Random();
            randomNumber = r.Next(0, 4);

            Console.WriteLine((Colleges)randomNumber);
            Console.ReadLine();
        }
    }
}
