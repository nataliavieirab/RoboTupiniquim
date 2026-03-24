using System.Collections.Specialized;

class Robot
{
  private int x;
  private int y;
  private string direction;

  public Robot(int x, int y, string direction)
  {
    this.x = x;
    this.y = y;
    this.direction = direction;
  }

  public void ExecuteCommands(string commands)
  {
    foreach (char command in commands)
    {
      if (command == 'E')
        TurnLeft();

      if (command == 'D')
        TurnRight();

      if (command == 'M')
        Move();
    }
  }

  private void TurnLeft()
  {
    if (direction == "N")
      direction = "O";

    else if (direction == "O")
      direction = "S";

    else if (direction == "S")
      direction = "L";

    else
      direction = "N";
  }

  private void TurnRight()
  {
    if (direction == "N")
      direction = "L";

    else if (direction == "L")
      direction = "S";

    else if (direction == "S")
      direction = "O";

    else
      direction = "N";
  }

  public void Move()
  {
    if (direction == "N")
      y += 1;

    else if (direction == "L")
      x += 1;

    else if (direction == "S")
      y -= 1;

    else
      x -= 1;
  }

  public string GetFinalPosition()
  {
    return $"{x} {y} {direction}";
  }

}