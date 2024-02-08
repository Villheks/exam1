
const int FullMoveSteps = 4;
const int shortMove = 1;
const int mediumMove = 3;
const int longMove = 5;

MoveAndTurn(FullMoveSteps, Turn);
MoveAndTurn(mediumMove, TurnLeft);
MoveAndTurn(FullMoveSteps, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(mediumMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(longMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(mediumMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(mediumMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(longMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(FullMoveSteps, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(mediumMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(longMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(FullMoveSteps, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(mediumMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(mediumMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
MoveAndTurn(longMove, Turn);
MoveAndTurn(shortMove, TurnLeft);
bool AtGoal = true;
// Check if at the goal
if (AtGoal())
{
    Console.WriteLine("Winner!");
    return;
}


#region Basic functions
// These functions are just here to make your IntelliSense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return false;
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return false; 
}

void TurnLeft()
{
    Turn();
    Turn();
    Turn();
    
}

void MoveAndTurn(int moveSteps, Action turnAction)
{
    for (int i = 0; i < moveSteps; i++)
    {
        Move();
    }
    turnAction();
}


#endregion





