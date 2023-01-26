using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public void DisplayPersonInfo() // Displays First and Last Name
        {
            string firstName = this.firstName;
            string lastName = this.lastName;

            Console.WriteLine(firstName+ " " + lastName);
        }

        public void personid() // Displays Person ID, Names, and favorite colours
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            string favoriteColor = this.favoriteColor;

            Console.WriteLine(personId+": "+firstName+" "+lastName+"'s favorite colour is "+favoriteColor);


        }

        public string ChangeFavoriteColour // Changes Persons favorite colour to set value
        {
            get
            {
                return this.favoriteColor; // gets the persons favorite colour
            }
            set
            {
                this.favoriteColor = value; // sets favorite colour to white
            }
        }

        public void GetAgeInTenYears() // adds ten years to persons age
        {
            string firstName = this.firstName;
            string lastName = this.lastName;
            int age = this.age;

            int ageInTenYears = age + 10; // adds ten years
        

            Console.WriteLine(firstName+" "+lastName+"'s Age in 10 years is: "+ageInTenYears); // displays person and age +10 years in sentence
        }

        public override string ToString() // Displays all information in a sentence
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            int age = this.age;
            string favoriteColor = this.favoriteColor;
            bool isWorking = this.isWorking;

            string Text = "Person ID: "+personId+"\nFirst Name: "+firstName+"\nLast Name: "+lastName+"\nFavorite Colour: "+favoriteColor+"\nAge: "+age+"\nIs Working: "+isWorking;
            return Text; // returns the sentence


        }
        public void Wait() // gives user time to look at program
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true); // any key pressed will end the program
        }

        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking) // Constructor
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }
    }
}
