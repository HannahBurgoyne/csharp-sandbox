
string? input; 
 
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do {
  input = Console.ReadLine();
  string massagedInput = input.Trim().ToLower();

  if (massagedInput.Contains("administrator") || massagedInput.Contains("manager") || massagedInput.Contains("user")) 
  {
    Console.WriteLine($"Your input value ({input}) has been accepted.");
    break;
  }
  else 
  {
    Console.WriteLine($"The role that you entered, {input}, is not valid. Please try again.");
    break;
  }
  

} while (input != null);