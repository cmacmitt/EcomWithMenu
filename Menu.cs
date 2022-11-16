// a menu is an interative list of options
internal class Menu
{
    private List<string> Options;
    private string Prompt;
    private int SelectedOption = 0;

    public Menu(string prompt, List<string> option)
    {
        Prompt = prompt;
        Options = option;
    }

     private void DisplayOptions()
    {
        WriteLine(Prompt);
        for (int i = 0; i < Options.Count; i++)
        {
            string currentOption = Options[i];
            int currentIndex = i + 1;
            

            if (i == SelectedOption)
            {
                ForegroundColor = ConsoleColor.Green;
                BackgroundColor = ConsoleColor.Red;
            }
            WriteLine($"{currentIndex}. {currentOption}");
            ResetColor();
        }
    }

    private void OptionInRange()
    {
        if (SelectedOption < 0)
        {
            SelectedOption = Options.Count - 1;
        }
        else if (SelectedOption > Options.Count - 1)
        {
            SelectedOption = 0;
        }
    }

    public int RunMenu()
    {
        ConsoleKey keyPressed;

        do
        {            
            Clear();
            DisplayOptions();
            keyPressed = ReadKey(true).Key;
            if (keyPressed == ConsoleKey.UpArrow)
            {
                SelectedOption--;
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                SelectedOption++;
            }

            OptionInRange();

        } while (keyPressed != ConsoleKey.Enter);

        // while the key pressed is not the enter key
        // keep on keepin on
        return SelectedOption;
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