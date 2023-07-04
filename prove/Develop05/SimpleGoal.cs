public class SimpleGoal : Goal
{
    public SimpleGoal(int type, string name, string desc, bool complete, int value) : base(type, name, desc, complete, value)
    {

    }

    public override int GoalAchieved()
    {
        if (GetGoalBool() == false)
        {
        SetGoalBool();
        int points = GetGoalPoints();
        return points;
        }
        else
            Console.WriteLine("You have already completed this goal. ");
            Thread.Sleep(3000);
        return 0;
    }
    public override string DisplayGoal()
    {
        if (GetGoalBool() == true)
        {
            return $"[x] - {GetGoalName()} ({GetGoalDesc()})";
        }

        else
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