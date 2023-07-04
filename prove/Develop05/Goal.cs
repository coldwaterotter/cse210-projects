public abstract class Goal
{
    protected int _goalType;
    private string _goalName;
    private string _goalDesc;
    protected bool _goalComplete;
    private int _goalValue;

    public Goal(int type, string name, string desc, bool complete, int value)
    {
        _goalType = type;
        _goalName = name;
        _goalDesc = desc;
        _goalComplete = complete;
        _goalValue = value;

    }

    public abstract string DisplayGoal();
    public abstract int GoalAchieved();
    public abstract int GetStatus();
    public abstract int GetBonus();
    public abstract int GetCount();

    public int GetGoalType()
    {
        return _goalType;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDesc()
    {
        return _goalDesc;
    }
    
    public bool GetGoalBool()
    {
        return _goalComplete;
    }

    public void SetGoalBool()
    {
        _goalComplete = true;
    }

    public int GetGoalPoints()
    {
        return _goalValue;
    }
}