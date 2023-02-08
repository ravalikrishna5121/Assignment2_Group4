using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment2_Group4
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 0;
            bool flag = false;

            do
            {
                Console.Write("Enter the radius of your choice\n");
                try
                {
                    radius = Convert.ToInt32(Console.ReadLine());
                    if (radius < 1)
                    {
                        Console.WriteLine("Radius with 0 and less than 0 are not valid");

                    }
                    else
                    {
                        flag = true;
                    }

                }
                catch
                {
                    Console.WriteLine("Radius value cannot be a non numeric value");
                }

            } while (flag != true);



            Circle circle = new Circle(radius);
            while (true)
            {
                try
                {
                    Console.WriteLine("1. Get Circle Radius");
                    Console.WriteLine("2. Change Circle Radius");
                    Console.WriteLine("3. Get Circle Circumference");
                    Console.WriteLine("4. Get Circle Area");
                    Console.WriteLine("5. Exit");

                    Console.Write("\nPlease select from the options available\n");
                    int selection = Convert.ToInt32(Console.ReadLine());
                    if (selection == 1)
                    {
                        Console.WriteLine("The Radius of the circle is " + circle.GetRadius() + "\n");
                    }
                    else if (selection == 2)
                    {
                        Console.Write("Enter the new radius of the circle\n");
                        int newRadius = Convert.ToInt32(Console.ReadLine());
                        circle.SetRadius(newRadius);
                    }
                    else if (selection == 3)
                    {
                        Console.WriteLine("Circumference of the circle is " + circle.GetCircumference() + "\n");
                    }
                    else if (selection == 4)
                    {
                        Console.WriteLine("Area of the circle is " + circle.GetArea() + "\n");
                    }
                    else if (selection == 5)
                    {
                        Console.WriteLine("Exit program");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Select from the available menu options\n");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter an interger value for the option !! ");
                }
            }


        }
    }
}


