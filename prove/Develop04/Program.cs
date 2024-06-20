using System;

class Program
{
    static void Main(string[] args)
    {
        running = true;
        Menu menu = new Menu();

        while (running)
        {
            menu.DisplayMenu();
            int choice = menu.GetChoice();
            menu.Execute(choice);
        }
    }
}