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

    Robot robot = new Robot(x, y, direction!);

    robot.ExecuteCommands(commands!);

    Console.WriteLine($"Posição alcançada: {robot.GetFinalPosition()}");
  }

  static void ShowHeader()
  {
    Console.WriteLine("===========================");
    Console.WriteLine("----- Robô Tupiniquim -----");
    Console.WriteLine("===========================");
    Console.WriteLine();
  }
}