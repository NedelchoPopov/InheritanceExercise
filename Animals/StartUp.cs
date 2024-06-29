using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            Dog dog = new(info[0], int.Parse(info[1]), info[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Cat":
                            Cat cat = new(info[0], int.Parse(info[1]), info[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Frog":
                            Frog frog = new(info[0], int.Parse(info[1]), info[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            Kitten kittens = new(info[0], int.Parse(info[1]));
                            Console.WriteLine(kittens);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new(info[0], int.Parse(info[1]));
                            Console.WriteLine(tomcat);
                            break;

                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
