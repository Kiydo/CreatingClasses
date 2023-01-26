using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person two; // ID: 2 | Name: Gina James
            two = new Person(2, "Gina", "James", 18, "Green", false);
            two.personid(); // Displays Gina James' ID, Names, and favorite colours

            Person three; // ID: 3 | Name: Mike Briscoe
            three = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Console.WriteLine(three.ToString()); // Displays all information of Mike Briscoe

            Person one; // ID: 1 | Name: Ian Brooks
            one = new Person(1, "Ian", "Brooks", 30, "Red", true);
            one.ChangeFavoriteColour = "White"; // Changes favorite colour of Ian Brooks to White
            one.personid(); // Displays Ian Brooks' ID, Names, and New favorite Colour

            Person four; // ID: 4 | Name: Mary Beals
            four = new Person(4, "Mary", "Beals", 28, "Yellow", true);
            four.GetAgeInTenYears(); // Displays Mary's Names and age in ten years

            four.Wait(); // Gives User time to look at program



        }
    }
}
