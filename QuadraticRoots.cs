using System;
class Program
{
    static void Main() 
    {
        SolutionRoots(2,4,3);
    }

    //function and logic
    static void SolutionRoots(double a, double b, double c)
    {
        //where a = 0, bx +- c = 0
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Infinitely many solutions." : "No solution at all, invalid equation");
            }
            else
            {
                double SingleSolutionx = -c / b;
                Console.WriteLine($"The root solution of the equation is {SingleSolutionx}");

            }
        }
        else
        {
            double DescriminantValue = (b*b)-(4*a*c);

            if (DescriminantValue > 0)
            {
                double Valuex1 = (-b+ Math.Sqrt(DescriminantValue))/(2*a);
                double Valuex2 = (-b - Math.Sqrt(DescriminantValue)) / (2 * a);
                Console.WriteLine($"The solution roots are x1 = {Valuex1} and x2 = {Valuex2}");
            }
            else if (DescriminantValue==0)
            {
                double Valuex = -b/ (2 * a);
                Console.WriteLine($"The solution root is x = {Valuex}");
            }
            else if (DescriminantValue < 0)
            {
                double RealValuex = (-b) / (2 * a);
                double ImaValuex = Math.Sqrt(-DescriminantValue) / (2 * a);
                Console.WriteLine($"The real root solution is x1 = {RealValuex}+i{ImaValuex} and the imaginary root solution is x2= {RealValuex}-i{ImaValuex}");
            }
            else
            {
                return;
            }
        }
    }
}
