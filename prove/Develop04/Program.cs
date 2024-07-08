using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        Menu menu = new Menu();

        while (running)
        {
            menu.DisplayMenu();
            int choice = menu.GetChoice();
            running = menu.Execute(choice);
        }
    }
}