using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int room_number = int.Parse(Console.ReadLine());
                int floor = 0, cell = 0, dim = 0, row = 0;
                for (int i = 1; i <= room_number; i++)
                {
                    if (cell + 1 > dim)
                    {
                        if (row + 1 > dim)
                        {
                            dim++;
                            row = 0;
                        }
                        row++;
                        floor++;
                        cell = 1;
                    }
                    else cell++;
                }
                Console.WriteLine("Этаж: {0}. Ячейка: {1}", floor, cell);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
