using System;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // Instantiated from the Employee class
            employee.firstName = "Jessica"; // employee object that calls on the properties of the Person class
            employee.lastName = "Simpson";
            employee.rank = "Elite";
            employee.gender = "Female";
            employee.age = 35;
            employee.SayName();
            Console.WriteLine("Good afternoon, " + employee.firstName + " " + employee.lastName + ". I see that you're a " + employee.gender + ", and you're " + employee.rank + " rank is prestigious.");

            IQuittable quittable = new Employee();
            quittable.Quit();

            Console.WriteLine(GetMax(1, 47, 78));
            Console.WriteLine(SolarSystem(2));
            Console.ReadKey();
        }

        static int GetMax(int num, int num2, int num3)
        {
            int answer;

            if (num >= num2 && num >= num3)
            {
                answer = num;
            }
            else if (num2 >= num && num2 >= num3) {
                answer = num2;
            }
            else
            {
                answer = num3;
            }

            return answer;
        }

        static string SolarSystem(int orbiting)
        {
            string orbitingPlanet;

            switch (orbiting)
            {
                case 0:
                    orbitingPlanet = "Mercury";
                    break;
                case 1:
                    orbitingPlanet = "Venus";
                    break;
                case 2:
                    orbitingPlanet = "Earth";
                    break;
                case 3:
                    orbitingPlanet = "Mars";
                    break;
                case 4:
                    orbitingPlanet = "Jupiter";
                    break;
                case 5:
                    orbitingPlanet = "Saturn";
                    break;
                case 6:
                    orbitingPlanet = "Uranus";
                    break;
                case 7:
                    orbitingPlanet = "Neptune";
                    break;

                default:
                    orbitingPlanet = "Invalid option. No planet assigned to this number: ";
                    break;
            }

            return orbitingPlanet;
        }
    }
}
