namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int hours;
                int minutes;
                try
                {
                    Console.Write("Pass hours: ");
                    hours = int.Parse(Console.ReadLine());
                    if (hours < 0 || hours > 23) throw new Exception();

                    Console.Write("Pass minutes: ");
                    minutes = int.Parse(Console.ReadLine());
                    if(minutes < 0 || minutes > 59) throw new Exception();
                } 
                catch
                {
                    Console.WriteLine("Pass proper input!\n");

                    continue;
                }

                Console.WriteLine($"Angle between hours arrow and minutes arrow: { GetAngle(hours, minutes) } degrees\n");
            }
        }

        private static int GetAngle(int hours, int minutes)
        {
            var hoursAngle = (hours % 12) * 360 / 12;
            var minutesAngle = (minutes) * 360 / 60;

            var degrees = hoursAngle - minutesAngle;

            if (degrees < 0) degrees *= -1;
            if (degrees > 180) degrees = 360 - degrees;

            return degrees;
        }
    }
}