public class elevator
{
    protected List<int> _allFloors = new List<int>(0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30);
    private int _currentFloor;
    private int _requestFloor;
    private bool _doorStatus = false;

    elevator()
    {

    }

    public void MoveElevator()
    {

    }

    public void DisplayFloor()
    {

    }

    public void ListFloors(List<int> floors)
    {
        foreach (int floor in floors)
        {
            Console.WriteLine(floor);
        }

    }

    public bool CloseDoor()
    {
        _doorStatus = false;
        return _doorStatus;
    }

    public void OpenDoor()
    {
        _doorStatus = true;
        return _doorStatus;
    }


}