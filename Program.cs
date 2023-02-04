/*
Assignment-2 SQAT
PROG-8170 SEC-1

Done by: Group-6
Syed Sirajul Hasan - 8836760
Piyush Mansukhbhai Monpara - 8784742

File: Program.cs
*/

using PROG8170_Section1_Assignment2_Group6;

class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle();
        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("\n   * Circle Menu *\n");
            Console.WriteLine("1. Get Circle Radius");
            Console.WriteLine("2. Change Circle Radius");
            Console.WriteLine("3. Get Circle Circumference");
            Console.WriteLine("4. Get Circle Area");
            Console.WriteLine("5. Exit\n");

            Console.Write("Enter your choice: ");
            try
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nThe circle radius is: " + c.GetRadius() + "\n");
                        break;
                    case 2:
                        Console.WriteLine("\nEnter the new radius: ");
                        int newRadius = int.Parse(Console.ReadLine());
                        if (newRadius < 1)
                        {
                            Console.WriteLine("\nRadius must be greater than 0");
                        }
                        else
                        {
                            c.SetRadius(newRadius);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nThe circle circumference is: " + c.GetCircumference() + "\n");
                        break;
                    case 4:
                        Console.WriteLine("\nThe circle area is: " + c.GetArea() + "\n");
                        break;
                    case 5:
                        Console.WriteLine("\nExiting program\n");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice, try again...!\n");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input. Please enter a number...!");
            }
        }
    }
}