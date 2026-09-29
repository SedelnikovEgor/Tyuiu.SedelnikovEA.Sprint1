using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SedelnikovEA.Sprint1.Task3.V1.Lib
{
    public class DataService : ISprint1Task3V1
    {
        public double CylinderVolume(double a, double b)
        {
            return Math.Round(Math.PI * Math.Pow(b, 2) * a, 3);
        }
    }
}