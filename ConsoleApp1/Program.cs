using System;

class Program
{
    static void Main(string[] args)
    {
        const int MAP_WIDTH = 30;
        const int MAP_HEIGHT = 10;

        int carX = MAP_WIDTH / 2;
        int carY = MAP_HEIGHT - 1;
        bool gameRunning = true;

        while (gameRunning)
        {
            Console.Clear();

            // Map drawing
            for (int y = 0; y < MAP_HEIGHT; y++)
            {
                for (int x = 0; x < MAP_WIDTH; x++)
                {
                    if (y == carY && x == carX)
                    {
                        Console.Write("C");
                    }
                    else if (y == 0 || y == MAP_HEIGHT - 1)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Player input
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.LeftArrow && carX > 0)
            {
                carX--;
            }
            else if (key.Key == ConsoleKey.RightArrow && carX < MAP_WIDTH - 1)
            {
                carX++;
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                gameRunning = false;
            }
        }

        Console.WriteLine("Oyun bitti.");
    }
}

