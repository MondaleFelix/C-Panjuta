// See https://aka.ms/new-console-template for more information

// Prints inside whatever inside of ()
Console.WriteLine("Enter a whole number!");




// Take the user input and store it
// Variable with the name "userInput" and the data type "string"
// strings are used for text
string userInput = Console.ReadLine();

int myNumber = int.Parse(userInput);

Console.WriteLine("Enter a whole number!");

userInput = Console.ReadLine();

int myNumber2 = int.Parse(userInput);





Console.WriteLine("The sum is " +  (myNumber + myNumber2));
Console.ReadKey();
