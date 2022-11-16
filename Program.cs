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
mainMenu.RunMenu();
// 
