public class Maze
{
    private readonly Dictionary<(int, int), bool[]> _mazeMap;
    private int _currX;
    private int _currY;

    // This constructor matches what the tests expect.
    public Maze(Dictionary<(int, int), bool[]> mazeMap, int startX, int startY)
    {
        _mazeMap = mazeMap;
        _currX = startX;
        _currY = startY;
    }

    /// <summary>
    /// This method is required by the tests to get the current position.
    /// It should return a tuple, not a string.
    /// </summary>
    public (int, int) GetStatus()
    {
        return (_currX, _currY);
    }
    
    public void MoveLeft()
    {
        if (_mazeMap[(_currX, _currY)][0])
        {
            _currX--;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }
    
    public void MoveRight()
    {
        if (_mazeMap[(_currX, _currY)][1])
        {
            _currX++;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }
    
    public void MoveUp()
    {
        if (_mazeMap[(_currX, _currY)][2])
        {
            _currY++;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }
    
    public void MoveDown()
    {
        if (_mazeMap[(_currX, _currY)][3])
        {
            _currY--;
        }
        else
        {
            throw new InvalidOperationException("Can't go that way!");
        }
    }
}