public class ChecklistGoal : Goal
{
    private int _status = 0;
    private int _count = 2;
    private int _bonus = 100;
    public ChecklistGoal(int type, string name, string desc, bool complete, int value, int status, int count, int bonus) : base(type, name, desc, complete, value)
    {
        _status = status;
        _count = count;
        _bonus = bonus;
    }
    
    public override int GoalAchieved()
    {
        int points = 0;
        SetSatus();
        if (_status == _count)
        {
            Console.WriteLine("Congrats on completing this goal, a bonus has been added to your reward.");
            Thread.Sleep(3000);
            SetGoalBool();
            points = _bonus + GetGoalPoints();
        }
        else if(_status < _count)
        {
            points += GetGoalPoints();
        }
        else
        {
            Console.WriteLine("You have already completed this goal. ");
            Thread.Sleep(3000);
            points = 0;
        }
        
        return points;
    }
    public override string DisplayGoal()
    {
        if (GetGoalBool() == true)
        {
            return $"[x] - {GetGoalName()} ({GetGoalDesc()}) -- Currently Completed {_status}/{_count}";
        }

        else
            return $"[ ] - {GetGoalName()} ({GetGoalDesc()}) -- Currently Completed {_status}/{_count}";
        
    }

    public override int GetBonus()
    {
        return _bonus;
    }
    public override int GetStatus()
    {
        return _status;
    }
    public override int GetCount()
    {
        return _count;
    }

    public void SetSatus()
    {
        _status += 1;
    }

}