public class EternalGoal : Goal
{
    public EternalGoal(int type, string name, string desc, bool complete, int value) : base(type, name, desc, complete, value)
    {

    }
    
    public override int GoalAchieved()
    {
        SetGoalBool();
        int points = GetGoalPoints();
        return points;
    }
    public override string DisplayGoal()
    {
        return $"[ ] - {GetGoalName()} ({GetGoalDesc()})";
        
    }

    public override int GetStatus()
    {
        throw new NotImplementedException();
    }

    public override int GetCount()
    {
        throw new NotImplementedException();
    }

    public override int GetBonus()
    {
        throw new NotImplementedException();
    }




}