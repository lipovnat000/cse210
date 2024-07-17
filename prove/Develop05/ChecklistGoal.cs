class ChecklistGoal : Goal{

    protected int times;
    protected int bonus;
    protected int totalTimes;
    
    public ChecklistGoal(string type, string name, string description, int points, bool completed, int totalTimes, int times, int bonus) : base(type, name, description, points, completed){
        this.completed = completed;
        this.times = times;
        this.totalTimes = totalTimes;
        this.bonus = bonus;
    }

    public override void IsComplete(bool complete){
        if (times < totalTimes) {
            times += 1;
            if (times == totalTimes) {
                completed = true;
            }
        }
    }

    public override int GetPoints(){
        if (completed) {
            return points + bonus;
        } else {
            return points;
        }
    }
    public override int GetTimes(){
        return times;
    }

    public override int GetBonus(){
        return bonus;
    }

}