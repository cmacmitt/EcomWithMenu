global using static System.Console;

// a menu is an interative list of options
Website website = new Website("Amazon.com");
string prompt = "Admin Menu: Choose an option";
List<string> options = new List<string> { "List All Products 🤢", "List All Customers", "List All Orders" };

Menu mainMenu = new Menu(prompt, options);
mainMenu.DisplayOptions();
