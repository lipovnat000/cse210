using System;

class Program
{
    static void Main(string[] args)
    {
        
        GoalList goals = new GoalList();

        bool running = true;
        Menu menu = new Menu();

        while (running)
        {
            menu.DisplayMenu();
            int choice = menu.GetChoice();
            running = menu.Execute(choice, goals);
        }
    }
}