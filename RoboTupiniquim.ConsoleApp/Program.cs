namespace RoboTupiniquim.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {

    ShowHeader();

    Console.WriteLine("Digite o valor da posição X: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o valor da posição Y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a orientação: ");
    string? direction = Console.ReadLine()?.ToUpper();

    Console.WriteLine("Digite a sequência de comandos: ");
    string? commands = Console.ReadLine()?.ToUpper();


    foreach (char command in commands)
    {

      if (command == 'E')
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

      if (command == 'D')
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

      if (command == 'M')
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

    }

    Console.WriteLine($"Posição alcançada: {x} {y} {direction}");

  }

  static void ShowHeader()
  {
    Console.WriteLine("===========================");
    Console.WriteLine("----- Robô Tupiniquim -----");
    Console.WriteLine("===========================");
    Console.WriteLine();
  }

}