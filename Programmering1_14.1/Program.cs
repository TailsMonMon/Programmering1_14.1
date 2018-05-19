using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmering1_14._1 {
    class Program {
        static void Main(string[] args) {
            List<Person> peopleNameAndSocialSecurityNumber = new List<Person>();

            peopleNameAndSocialSecurityNumber.Add(new Person("Anna",     199001101234));
            peopleNameAndSocialSecurityNumber.Add(new Person("Björn",    199101101234));
            peopleNameAndSocialSecurityNumber.Add(new Person("Carina",   199201101234));
            peopleNameAndSocialSecurityNumber.Add(new Person("Denise",   199301101234));
            peopleNameAndSocialSecurityNumber.Add(new Person("Eleonore", 199401101234));
            peopleNameAndSocialSecurityNumber.Add(new Person("Fabian",   199501101234));

            Console.WriteLine("[L]ägg till en person \n" +
                              "[H]itta en person");

            ConsoleKeyInfo menuChoice = Console.ReadKey(true);

            if(menuChoice.Key == ConsoleKey.L) {
                Console.Write("Namn: ");
                string personName = Console.ReadLine();
                Console.Write("Personnummer: ");
                long personSocialSecurityNumber = Convert.ToInt64(Console.ReadLine());

                peopleNameAndSocialSecurityNumber.Add(new Person(personName, personSocialSecurityNumber));
            }
            else if(menuChoice.Key == ConsoleKey.H) {
                Console.Write("Ange personnummer du söker: ");
                long searchValue = Convert.ToInt64(Console.ReadLine());
                int firstIndex = 0;
                int lastIndex = peopleNameAndSocialSecurityNumber.Count();
                bool keepLooping = true;

                do {
                int middleIndex = (firstIndex + lastIndex) / 2;

                    if(searchValue > peopleNameAndSocialSecurityNumber[middleIndex].Number) {
                        firstIndex = middleIndex;
                        Console.WriteLine("A");
                    }
                    else if(searchValue < peopleNameAndSocialSecurityNumber[middleIndex].Number) {
                        lastIndex = middleIndex;
                        Console.WriteLine("B");
                    }
                    else if(searchValue == peopleNameAndSocialSecurityNumber[middleIndex].Number) {
                        keepLooping = false;
                        Console.WriteLine("C");
                        Console.WriteLine("Personen heter {0} och ligger på index {1}", peopleNameAndSocialSecurityNumber[middleIndex].Name, middleIndex);
                    }
                } while(keepLooping == true);
            }
            else {
                Console.WriteLine("[L]ägg till en person \n" +
                                  "[H]itta en person");
            }
            Console.ReadKey();
        }
    }
}
