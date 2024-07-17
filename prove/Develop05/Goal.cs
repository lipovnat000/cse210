class Goal{

    protected string name;
    protected string description;
    protected int points;
    protected bool completed;
    protected string type;

    public Goal(string type, string name, string description, int points, bool completed){
        this.name = name;
        this.description = description;
        this.points = points;
        this.completed = completed;
        this.type = type;
    }

    public virtual void DisplayGoal(){
        if (completed){
            Console.WriteLine($"[X] {name} ({description})");
        } else {
            Console.WriteLine($"[ ] {name} ({description})");
        }
    }

    public virtual void IsComplete(bool complete) {
        completed = complete;
    }

    public bool GetCompleted() {
        return completed;
    }

    public string GetName() {
        return name;
    }

    public string GetGoalType() {
        return type;
    }

    public string GetDescription() {
        return description;
    }

    public virtual int GetPoints() {
        return points;
    }

    public virtual int GetTimes() {
        return 0;
    }

    public virtual int GetBonus() {
        return 0;
    }

}