class Goal{

    public string name;
    public string description;
    public int points;
    public bool completed;
    public string type;


    public Goal(){}

    public Goal(string type, string name, string description, int points, bool completed){
        this.type = type;
        this.name = name;
        this.description = description;
        this.points = points;
        this.completed = completed;
    }

    public virtual Goal CreateGoalSelect(){
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which would you like to create? ");
        type = Console.ReadLine();

        if (type == "1"){
            SimpleGoal simple = new SimpleGoal();
            simple.NewGoal();
        } else if (type == "2"){
            EternalGoal eternal = new EternalGoal();
            eternal.NewGoal();
        } else if (type == "3"){
            ChecklistGoal checklist = new ChecklistGoal();
            checklist.NewGoal();
        }

        return this;
    }

    public virtual void DisplayGoal(){
        if (completed){
            Console.WriteLine($"[X] {name} ({description})");
        } else {
            Console.WriteLine($"[ ] {name} ({description})");
        }
    }
}