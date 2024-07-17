class EternalGoal : Goal{

    public EternalGoal(string type, string name, string description, int points, bool completed) : base(type, name, description, points, completed){}

    public override void IsComplete (bool complete){}
}