// 1112410005廖筠珊
using System;

class Program
{

    public static double CountPi(int n)
    {
        if (n < 4 || n > 15)
        {
            return -1;
        }

        double pi = 0.0;

        for (int i = 0; i < n; i++)
        {
            double term = 1.0 / (2 * i + 1);
            if (i % 2 == 0)
            {
                pi += term;
            }
            else
            {
                pi -= term;
            }
        }
        pi *= 4;

        return pi;
    }
    
    // 圓周長
    public static double GetCircumference(double r)
    {
        if (r <= 0)
        {
            return -1; 
        }

        double pi = CountPi(10); // 假設 n = 10 
        if (pi == -1)
        {
            return -1; 
        }

        double circumference = pi * r;
        return circumference;
    }

    // 圓的面積
    public static double GetCircleArea(double r)
    {
        if (r <= 0)
        {
            return -1;
        }

        double pi = CountPi(10); // 假設n = 10 
        if (pi == -1)
        {
            return -1; 
        }

        double area = pi * r * r;
        return area;
    }

    static void Main(string[] args)
    {
        // 計算圓周率
        int n = 10; 
        double piResult = CountPi(n);
        {
            Console.WriteLine($"根據傳入的 n 值計算出來的圓周率值 = {piResult}");
        }

        // 計算圓周長
        double radius = 5.0; // 半徑
        double circumferenceResult = GetCircumference(radius);
       
          Console.WriteLine($"半徑為 {radius} 的圓的周長是: {circumferenceResult}");
     
        // 計算圓面積
        double areaResult = GetCircleArea(radius);
        Console.WriteLine($"半徑為 {radius} 的圓的面積是: {areaResult}");

        }
}
