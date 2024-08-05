namespace MembershipDiscount
    {
        class Program
        {//enum for the discount rates 
            enum DiscountRates
            {
                YearTo4Years = 5,
                Year5To9Years = 10,
                Year10To14Years = 20,
                Year15Plus = 35
            }

            static void Main(string[] args)
            {
                bool running = true;

                while (running)
                {
                    // Asking user for the current year
                    Console.Write("Enter the current year (or type 'exit' to quit): ");
                    string input = Console.ReadLine();

                    //If user types Exit the program exits. Converts input into lower case
                    if (input.ToLower() == "exit")
                    {
                        running = false;
                        continue;
                    }
                    //Converting string into an int statement
                    if (!int.TryParse(input, out int currentYear))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid year.");
                        continue;
                    }

                    // Asking user for the year they registered. Also changes the value to int from string
                    Console.Write("Please enter the year you registered: ");
                    if (!int.TryParse(Console.ReadLine(), out int dateRegistered))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid year.");
                        continue;
                    }

                    // Calculating the number of years the user has been a member
                    int yearPeriod = currentYear - dateRegistered;

                // Showing and displaying the discount based on how long user has been a member using if statements.can use case statement 
                //Referancing enums to give the discount 
                switch (yearPeriod)
                {
                    case < 0:
                        Console.WriteLine("Invalid membership duration. Registration year cannot be in the future.");
                        break;
                    case <= 4:
                        Console.WriteLine($"Your discount is {(int)DiscountRates.YearTo4Years}%");
                        break;
                    case <= 9:
                        Console.WriteLine($"Your discount is {(int)DiscountRates.Year5To9Years}%");
                        break;
                    case <= 14:
                        Console.WriteLine($"Your discount is {(int)DiscountRates.Year10To14Years}%");
                        break;
                    case >= 15:
                        Console.WriteLine($"Your discount is {(int)DiscountRates.Year15Plus}%");
                        break;

                    default:
                        Console.WriteLine("Invalid membership duration. Please enter correct date!");
                        break;

                }
                        /* when using an if statement to check user discount. 

                        if (yearPeriod < 0)
                            {
                                Console.WriteLine("Invalid membership duration. Registration year cannot be in the future.");
                            }
                            else if (yearPeriod <= 4)
                            {
                                Console.WriteLine($"Your discount is {(int)DiscountRates.YearTo4Years}%");
                            }
                            else if (yearPeriod <= 9)
                            {
                                Console.WriteLine($"Your discount is {(int)DiscountRates.Year5To9Years}%");
                            }
                            else if (yearPeriod <= 14)
                            {
                                Console.WriteLine($"Your discount is {(int)DiscountRates.Year10To14Years}%");
                            }
                            else if (yearPeriod > 15)
                            {
                                Console.WriteLine($"Your discount is {(int)DiscountRates.Year15Plus}%");
                            }
                            else
                        {
                            Console.WriteLine("Invalid membership duration. Please enter correct date!");
                        }
                        */
                }
                Console.ReadKey();
            }
        }
    }

