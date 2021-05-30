using System;

namespace BoxTask
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.CalcSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalcLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.CalcVolume():F2}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);                
            }            
        }
    }
}
