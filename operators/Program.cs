
namespace OperatorsInClass
{
    class program
    {
        static void Main(string [] args)
        {
            int a = 17;

            int b = 4;

            int remainder = a % b;

            int quotient = a / b;

            var str1 = (a == 17 && b == 4) ? $"17/4 is {quotient} remainder is {remainder}" : "incorrect";

            Console.WriteLine(str1);
            






            Console.WriteLine("what is the radius of your circle?");
            

            var input = Console.ReadLine();

            var radius = double.Parse(input);

            Console.WriteLine(AreaOfCircle(radius));

            AreaOfCircle(radius);
        }

        public static double AreaOfCircle(double radius)

        {
            var area = Math.PI * Math.Pow(radius, 2);
            
            return area;
            
        }
    }
}

