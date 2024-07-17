class GoalList{

    private int totalPoints = 0;
    private List<Goal> goals = new List<Goal>();
    public void Load() {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        Goal goal = null;

        for (int i = 0; i < lines.Length; i++){
            if (i == 0){
                totalPoints = int.Parse(lines[i]);
            } else {
                string[] parts = lines[i].Split(",");

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = bool.Parse(parts[4]);
                int times = 0;
                int totalTimes = 0;
                int bonus = 0;
                if (type == "Checklist"){
                    times = int.Parse(parts[5]);
                    totalTimes = int.Parse(parts[6]);
                    bonus = int.Parse(parts[7]);
                }
                if (type == "Eternal"){
                    goal = new EternalGoal(type, name, description, points, completed);
                } else if (type == "Checklist"){
                    goal = new ChecklistGoal(type, name, description, points, false, times, totalTimes, bonus);
                } else if (type == "Simple"){
                    goal = new SimpleGoal(type, name, description, points, false);
                }

                goals.Add(goal);
            }
        }
    }

    public void Save() {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = new string[goals.Count + 1];
        lines[0] = totalPoints.ToString();
        for (int i = 0; i < goals.Count; i++){
            Goal goal = goals[i];
            if (goal.GetGoalType() == "Simple"){
                lines[i + 1] = $"{goal.GetGoalType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetCompleted()}";   
            } else if (goal.GetGoalType() == "Eternal"){
                lines[i + 1] = $"{goal.GetGoalType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}";
            } else if (goal.GetGoalType() == "Checklist"){
                lines[i + 1] = $"{goal.GetGoalType()},{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetCompleted()},{goal.GetTimes()},{goal.GetBonus()}";
            }
        }
        File.WriteAllLines(filename, lines);
    }

    public void ListGoals() {
        Console.WriteLine($"You have {totalPoints} points");
        for (int i = 0; i < goals.Count; i++){
            Goal goal = goals[i];
            goal.DisplayGoal();
        }
    }

    public void AppendGoal() {
        Goal goal = null;

        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("What is the name of the goal? ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter a short description for the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("How many points would you like to assign to this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1){
            goal = new SimpleGoal("simple", name, description, points, false);
        } else if (type == 2){
            goal = new EternalGoal("eternal", name, description, points, false);
        } else if (type == 3){
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int totalTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many points are awarded if this goal is met multiple times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal("checklist", name, description, points, false, totalTimes, 0, bonusPoints);
        }

        goals.Add(goal);
    }

    public void RecordEvent() {
        for (int i = 0; i < goals.Count; i++){
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        goals[choice - 1].IsComplete(true);
        totalPoints += goals[choice - 1].GetPoints();
    }
}