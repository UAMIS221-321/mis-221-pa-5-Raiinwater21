
bool KeepGoing = true;
while (KeepGoing)
{
    static void mainMenu();
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Employee");
    Console.WriteLine("2. Customer");
    Console.WriteLine("3. Exit the application");
    Console.Write("Please enter the number corresponding to the task you would like to perform: ");
    string choice = Console.ReadLine();
    int input = CheckInputValidInvalid(choice, 1, 3);

        switch (input)
    {
            case 1:
                ManageEmployeeSide();
                continue;
            case 2:
                ManageListingData();
                continue;
            // case 3:
            //     ManageBookingData();
                // continue;
            // case 4:
            //     RunReports();
            //     continue;
            case 3:
                Console.WriteLine("Exiting the application...");
                return;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                continue;
    }
}

static void ManageEmployeeSide();
{System.Console.WriteLine("Employee side");
System.Console.WriteLine("1. Manage Trainer Data");
System.Console.WriteLine("2. Manage Listing Data");
System.Console.WriteLine("3. Return to main menu");
    string choice = Console.ReadLine();
    int input = CheckInputValidInvalid(choice, 1, 3);
}
static void ManageTrainerData()
{
Console.WriteLine("Managing trainer data...");
{
    System.Console.WriteLine("1. Add a trainer");
    System.Console.WriteLine("2. View a trainer's information. Go further to edit.");
    // further submenu edit
    //System.Console.WriteLine(" Edit a trainer data");
    System.Console.WriteLine("3. Delete a trainer's data");
    System.Console.WriteLine("4. Previous menu");
    string choice = Console.ReadLine();
    CheckInputValidInvalid(choice, 1, 4);
    } 
    switch (input)
    {
        case 1: 
        AddTrainer();
        continue;

        case 2:
        ViewEditTrainer();
        continue;

        case 3:
        DeleteTrainer();
        continue;

        default:
        System.Console.WriteLine("Invalid choice. Please enter a number between 1-3");
    }
}

static void ManageListingData()
{
// Code to manage listing data
Console.WriteLine("Managing listing data...");
System.Console.WriteLine("1. Listing ID");
System.Console.WriteLine("2. Trainer Name");
System.Console.WriteLine("3. Date of the session");
System.Console.WriteLine("4. Time of the session");
System.Console.WriteLine("5. Cost of the session");
System.Console.WriteLine("6. Availability of the session");
System.Console.WriteLine("7. Return to main menu");
    string choice = Console.ReadLine();
    CheckInputValidInvalid(choice, 1, 7);
{
        switch (input)
        {
        case 1: 
        ListingIDTrainer();
        continue;

        case 2:
        TrainerNameList();
        continue;

        case 3:
        DateSession();
        continue;

        case 4:
        TimeSession();
        continue;

        case 5:
        CostSession();
        continue;

        case 6:
        AvailSession();
        continue;

        case 7:
        mainMenu();
        continue

        default:
        System.Console.WriteLine("Invalid choice. Please enter a number between 1-3");
        }
    }
}
static void ManageBookingData()
{
// Code to manage customer booking data
Console.WriteLine("Managing customer booking data...");
System.Console.WriteLine("1. View available training sessions");
System.Console.WriteLine("2. Book a session");
System.Console.WriteLine("3. Return to main menu");
    string choice = Console.ReadLine();
    CheckInputValidInvalid(choice, 1, 3);
}

static void RunReports()
{
// Code to run reports
Console.WriteLine("Running reports...");
System.Console.WriteLine("1. Individual Customer Sessions");
System.Console.WriteLine("2. Historical Customer sesions");
System.Console.WriteLine("3. Historical Revenue Report");
System.Console.WriteLine("4. Return to main menu");
    string choice = Console.ReadLine();
    CheckInputValidInvalid(choice, 1, 4);
}
 switch (input)
    {
        case 1: 
        IndividualCustomer();
        continue;

        case 2:
        AllCustomerSessions();
        continue;

        case 3:
        HisRevReport();
        continue;

        default:
        System.Console.WriteLine("Invalid choice. Please enter a number between 1-3");
    }


static int CheckInputValidInvalid(string choice, int Min, int Max)
{
    int input = CheckInputInt(choice);
        if(input <= Max && input >= Min)
        {
            return input;
        }
        else
        {
        System.Console.WriteLine("Invalid option. Pick a valid option");
       choice = Console.ReadLine();
        return CheckInputValidInvalid(choice, Min, Max);
        }
}

static int CheckInputInt(string choice)
{
       if (char.IsDigit(choice[0]))
    {
        return Int32.Parse(choice);
       }
       else
       {
       System.Console.WriteLine("Invalid option. Pick a valid option");
       choice = Console.ReadLine();
        return CheckInputInt(choice);
    }
}