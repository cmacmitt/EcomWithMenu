global using static System.Console;

// a menu is an interative list of options
Website website = new Website("Amazon.com");
string prompt = @"
   ____   ____  _____     _____  _  _   
  / __ \ / __ \|  __ \   / ____|| || |_ 
 | |  | | |  | | |__) | | |   |_  __  _|
 | |  | | |  | |  ___/  | |    _| || |_ 
 | |__| | |__| | |      | |___|_  __  _|
  \____/ \____/|_|       \_____||_||_|  
    Admin Menu: Choose an option";
List<string> options = new List<string> { "List All Products", "List All Customers", "List All Orders" };

Menu mainMenu = new Menu(prompt, options);
//mainMenu.RunMenu();
// create a simple switch case to do something when the option is selected
switch (mainMenu.RunMenu())
{
    case 0:
        WriteLine("Option 1 was selected");
        break;
    case 1:
        WriteLine("Option 2 was selected");
        break;
    case 2:
        WriteLine("Option 3 was selected");
        break;
}
