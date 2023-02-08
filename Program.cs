/*
Assignment-2 SQAT
PROG-8170 SEC-1

Done by: Group-6
Syed Sirajul Hasan - 8836760
Piyush Mansukhbhai Monpara - 8784742

File: Program.cs
*/

using PROG8170_Section1_Assignment2_Group6;

        Circle c = new Circle();
        int option = 0;
        bool GetCircleValue = false;
        bool isvalidinput = false;
        bool changeCircleValue = false;
        bool OptionValue = false;
try
{
    while (isvalidinput == false)
        {
            Console.WriteLine("Please enter circle radius");
            var GetCircleVal = Console.ReadLine();
            GetCircleValue = int.TryParse(GetCircleVal, out int result);
            if (GetCircleValue != false && Convert.ToInt32(GetCircleVal) > 0)
            {
                c.SetRadius(Convert.ToInt32(GetCircleVal));
                isvalidinput = true;
            }
            else
            {
                c.SetRadius(1);
                return;
            }
        }
        while (option != 5)
        {


            Console.Write("-----------------------------------------\n");
            Console.WriteLine("1. Get Circle Radius");
            Console.WriteLine("2. Change Circle Radius");
            Console.WriteLine("3. Get Circle Circumference");
            Console.WriteLine("4. Get Circle Area");
            Console.WriteLine("5. Exit\n");
            Console.Write("-----------------------------------------\n");
            Console.WriteLine("Enter your choice");

            var MenuOption = Console.ReadLine();
            
            OptionValue = int.TryParse(MenuOption, out int result1);
            if(OptionValue == true) {
            option = int.Parse(MenuOption);
            switch (option)
                {
                    case 1:
                        Console.WriteLine(c.GetRadius());
                        break;
                    case 2:
                        Console.WriteLine("\nEnter the new radius: ");
                        var setCircleValue = Console.ReadLine();
                        changeCircleValue = int.TryParse(setCircleValue, out int result);
                        if (changeCircleValue == false && Convert.ToInt32(setCircleValue) < 1)
                        {
                            Console.WriteLine("\nRadius must be greater than 0");
                        }
                        else
                        {
                            c.SetRadius(Convert.ToInt32(setCircleValue));
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
    }
            
        }
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
