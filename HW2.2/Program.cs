using System;

namespace HW2._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, count = 10;
            while (true)
			{
                Console.WriteLine("Choose direction (N, S, E, W), Q for exit:");
                char direction = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (Char.ToUpper(direction))
                {
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("error");
                        break;
                }
				Console.WriteLine($"Curren coords: {x}:{y}");
                count--;
                if (count == 0)
				{
                    break;
				} 
            }
			Console.ReadKey();
        }
    }
}
