using System;

namespace UnitedConsole;

class Program
{
    static void Main(string[] args)
    {
        TeamManager teamManager = new TeamManager();

        Console.WriteLine("<<Please Choice>> \n(1) Add Player \n(2) Add Coach \n(3) Show Players \n(4) Show Coaches");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter 'exit' to go back to main menu.");

                    Console.WriteLine("Enter Player Code: ");
                    string codeInput = Console.ReadLine();
                    if (codeInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    if (!int.TryParse(codeInput, out int code))
                    {
                        Console.WriteLine("Invalid Player Code. Please enter a number.");
                        continue;
                    }

                    Console.WriteLine("Enter Player Name: ");
                    string name = Console.ReadLine();
                    if (name.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    Console.WriteLine("Enter Player Address: ");
                    string address = Console.ReadLine();
                    if (address.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    Console.WriteLine("Enter Player Shirt Number: ");
                    string shirtNumInput = Console.ReadLine();
                    if (shirtNumInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    if (!int.TryParse(shirtNumInput, out int shirtNum))
                    {
                        Console.WriteLine("Invalid Shirt Number. Please enter a number.");
                        continue;
                    }

                    Console.WriteLine("Enter Position: ");
                    string position = Console.ReadLine();
                    if (position.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    Console.WriteLine("Enter Salary: ");
                    string salaryInput = Console.ReadLine();
                    if (salaryInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    if (!decimal.TryParse(salaryInput, out decimal salary))
                    {
                        Console.WriteLine("Invalid Salary. Please enter a valid decimal number.");
                        continue;
                    }

                    Player player = new Player
                    {
                        Code = code,
                        Name = name,
                        Address = address,
                        ShirtNumber = shirtNum,
                        Position = position,
                        Salary = salary
                    };
                    teamManager.AddPlayer(player);
                }
                break;

            case 2:
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter 'exit' to go back to main menu.");

                    Console.WriteLine("Enter Coach Code:");
                    string coachCodeInput = Console.ReadLine();
                    if (coachCodeInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    if (!int.TryParse(coachCodeInput, out int coachCode))
                    {
                        Console.WriteLine("Invalid Coach Code. Please enter a number.");
                        continue;
                    }

                    Console.WriteLine("Enter Coach Name:");
                    string coachName = Console.ReadLine();
                    if (coachName.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    Console.WriteLine("Enter Coach Address:");
                    string coachAddress = Console.ReadLine();
                    if (coachAddress.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    Console.WriteLine("Enter Coach Position:");
                    string coachPosition = Console.ReadLine();
                    if (coachPosition.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    Console.WriteLine("Enter Coach Salary:");
                    string coachSalaryInput = Console.ReadLine();
                    if (coachSalaryInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    if (!decimal.TryParse(coachSalaryInput, out decimal coachSalary))
                    {
                        Console.WriteLine("Invalid Coach Salary. Please enter a valid decimal number.");
                        continue;
                    }

                    Console.WriteLine("Enter Coach Years of Experience:");
                    string yearsOfExperienceInput = Console.ReadLine();
                    if (yearsOfExperienceInput.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                    if (!int.TryParse(yearsOfExperienceInput, out int yearsOfExperience))
                    {
                        Console.WriteLine("Invalid Years of Experience. Please enter a number.");
                        continue;
                    }

                    Coach newCoach = new Coach
                    {
                        Code = coachCode,
                        Name = coachName,
                        Address = coachAddress,
                        Position = coachPosition,
                        Salary = coachSalary,
                        YearOfExperience = yearsOfExperience
                    };
                    teamManager.AddCoach(newCoach);
                }
                break;

            case 3:
                teamManager.ShowPlayer();
                break;

            case 4:
                teamManager.ShowCoach();
                break;

            default:
                Console.WriteLine("Invalid Number");
                break;
        }
    }
}
