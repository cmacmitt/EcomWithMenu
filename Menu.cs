// a menu is an interative list of options
internal class Menu
{
    private List<string> Options;
    private string Prompt;

    public Menu(string prompt, List<string> option)
    {
        Prompt = prompt;
        Options = option;
    }

     public void DisplayOptions()
    {
        for (int i = 0; i < Options.Count; i++)
        {
            string currentOption = Options[i];
            int currentIndex = i + 1;
            WriteLine($"{currentIndex}. {currentOption}");
        }

        WriteLine("Press any key to exit the menu.");
        ReadKey();
    }

    public void RunMenu()
    {
        Clear();
        DisplayOptions();
        // while the key pressed is not the enter key
        // keep on keepin on
    }

    // how do we...
    // capture the key that's pressed
    // ReadKey();
    // respond based on the keypressed
    // change the color of the text and/or background
    // ForegroundColor = ConsoleColor.Magenta
    // BackgroundColor - ConsoleColor.DarkYellow
    // identify the currently selected option
    // track the current option
    // change the option based on the key pressed
    // clear the console
    // Clear();
    // re-render the menu
    // DisplayOptions
}