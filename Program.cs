string? input;
int numericValue = 0; 

bool validNumber = false; 
Console.WriteLine("Enter an integer value between 5 and 10");

do {
  input = Console.ReadLine();
  validNumber = int.TryParse(input, out numericValue); 

  if (validNumber)
  {
      if (numericValue > 5 && numericValue < 10) 
      {
        Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
      } 
      else 
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
    }
  else 
    Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    break;
} while (validNumber == false);