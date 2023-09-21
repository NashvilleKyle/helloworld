////// See https://aka.ms/new-console-template for more information :)
////Console.WriteLine("Fuck you very much!" +
////    "");
////Console.WriteLine("Put me in the code and run me");
////var userInput = Console.ReadLine();
////Console.WriteLine("You just said " + userInput);
////int myNumber = 123;
////string myText = "This is words";
////bool myBool = true;
////List<string> myListOfStrings = new List<string>();
////myListOfStrings.Add(myText);


//// create moneylist to hold money values
//List<int> moneyList = new List<int>();
////create total variable to hold the total of all money
//int total = 0;
//Console.WriteLine("Kyle's Big Money Makin' Hustlas 4 Life We Own The Web");
//Console.WriteLine("-----------------------------------------------------");

////start a while loop that runs forever
//while (true)
//{
//    Console.WriteLine("How Much Money You Make Today Mutha Fucka?");
//    //get user input
//    var userInput = Console.ReadLine();
//    var number = 0;
//    //parsed user input into a number
//    bool success = int.TryParse(userInput, out number);

//    //if successful, process
//    if (success)
//    {
//        moneyList.Add(number);
//        foreach (var cash in moneyList)
//        {
//            total = total + cash;
//        }
//        Console.WriteLine("Hell Yeah, Gangsta! You Made " + total + "!");
//        moneyList = new List<int>();
//    }
//    else
//    {
//        //if not successful, tell user to enter a number
//        Console.WriteLine("Get outta here with those banana dicks, Terry!");
//    }

//}

//// create moneylist to hold money values
////create total variable to hold the total of all money
////start a while loop that runs forever
////get user input
////parsed user input into a number
////if successful, process
////if not successful, tell user to enter a number



// Create a List to hold money values
var moneyList = new List<decimal>();

// Create a variable to hold the total of all money
decimal total = 0;

// Start a while loop that runs forever
while (true)
{
    Console.Write("Enter a money value (or 'exit' to quit): ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "exit")
    {
        break; // Exit the loop if the user enters "exit"
    }

    if (decimal.TryParse(userInput, out decimal moneyValue))
    {
        // If successful, add the money value to the list and update the total
        moneyList.Add(moneyValue);
        total += moneyValue;

        // Display the running total to the user
        Console.WriteLine("Running Total: " + total);
    }
    else
    {
        // If not successful, tell the user to enter a number
        Console.WriteLine("Please enter a valid number.");
    }
}

// Display the money values entered and the final total
Console.WriteLine("Money values entered:");
foreach (var moneyValue in moneyList)
{
    Console.WriteLine(moneyValue);
}

Console.WriteLine("Final Total: " + total);