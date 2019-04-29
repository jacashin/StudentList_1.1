using System;
using System.Collections.Generic;

namespace StudentList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, would you like to search by Student name, fav color OR press 'a' to add a new name?");
           
            var userInput = Console.ReadLine();
         
            StudList studentList = new StudList();

            studentList.StudClass = new List<StudentClass>();
            

                studentList.StudClass.Add(new StudentClass { StudName = "Jacob Ashin", FavoriteColor = "teal" });

                studentList.StudClass.Add(new StudentClass { StudName = "Miguel Cabrera ", FavoriteColor = "green" });

                studentList.StudClass.Add(new StudentClass { StudName = "Niko Goodrum", FavoriteColor = "coral" });

                studentList.StudClass.Add(new StudentClass { StudName = "Brandon Dixon", FavoriteColor = "yellow" });

                studentList.StudClass.Add(new StudentClass { StudName = "Gordon Beckham", FavoriteColor = "peach" });

                studentList.StudClass.Add(new StudentClass { StudName = "Josh Harrison", FavoriteColor = "burgandy" });

          

                if (studentList.StudClass.Exists(x => x.StudName == userInput))
                {
                    Console.WriteLine($"{userInput} exists, his fav color is {favoriteColor}!");
                }

                if ((studentList.StudClass.Exists(x => x.FavoriteColor == userInput)))
                {
                    Console.WriteLine($"{StudName}'s favorite color is {userInput}");
                }

                if (userInput.Equals("a", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("What is the student's name?");

                    string newStudentName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(newStudentName))
                    {
                        Console.WriteLine("Wrong input");
                        
                    }

                    else
                    {
                        studentList.StudClass.Add(new StudentClass { StudName = newStudentName });

                        Console.WriteLine("What is the student's favorite color? ");

                        string newStudentsColor = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(newStudentsColor))
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        else

                            studentList.StudClass.Add(new StudentClass { FavoriteColor = newStudentsColor });
                    }
                }
                else if (!(userInput.Equals("a", StringComparison.OrdinalIgnoreCase) || (studentList.StudClass.Exists(x => x.StudName == userInput)) || (studentList.StudClass.Exists(x => x.FavoriteColor == userInput))))
                {
                    Console.WriteLine("Invalid input");
                }
            
            foreach (var item in studentList.StudClass)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
