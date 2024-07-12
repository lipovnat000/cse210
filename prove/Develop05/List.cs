class List{

    private int totalPoints = 0;
    private List<Goal> goals = new List<Goal>();
    public void Load() {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

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
                Goal goal = new Goal(type, name, description, points, completed);

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
            lines[i + 1] = $"{goal.type},{goal.name},{goal.description},{goal.points},{goal.completed}";
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
        Goal goal = new Goal();
        goal = goal.CreateGoalSelect();
        goals.Add(goal);
    }
}