while (!AtGoal()) 
{
    if (Peek()) 
    {
        Move();
    } 
    else
    {
        Turn();
        if (!Peek())
        {
            TurnAround();
        }
        else
        {
            TurnLeft();
        }
    }
}

static bool AtGoal()
{
    // checking if the car is at the goal
    
    return false;
}

static bool Peek()
{
    // checking if the next cell is open
    
    return true;
}

static void Move()
{
    // moving the car 1 space in the current direction
    
    Console.WriteLine("Move");
}

static void Turn()
{
    //turning the car 90 degrees clockwise
    
    Console.WriteLine("Turn Right");
}
static void TurnLeft()
{
    Turn();
    Turn();
    Turn();
    Console.WriteLine("Turn Left");
}
static void TurnAround()
{
    Turn();
    Turn();
}
