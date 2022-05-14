namespace ADS.Homework.Karatsuba;

public class KaratsubaFastMult
{
    public static double Karatsuba(double a, double b)
    {
        if (a < 10 && b < 10)
        {
            return a * b;
        }

        var n = Math.Max(a.ToString().Length, b.ToString().Length);
        var m = n / 2;

        var a0 = Math.Floor(a / Math.Pow(10, m));
        var a1 = a % Math.Pow(10, m);
        var b0 = Math.Floor(b / Math.Pow(10, m));
        var b1 = b % Math.Pow(10, m);

        var x = Karatsuba(a0, b0);
        var y = Karatsuba(a1, b1);
        var e = Karatsuba(a0 + a1, b0 + b1);

        return x * Math.Pow(10, m * 2) + (e - x - y) * Math.Pow(10, m) + y;

    }
}
