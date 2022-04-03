Console.WriteLine("Sonni kiriting: ");
var N= Convert.ToInt32(Console.ReadLine());
int a, b,m=0;
for (int i = 1; i <= N; i++)
{
    a = 0;
    b=0;
    for (int g = 1; g < i; g++)
    {
        if (i % g == 0)
        {
            a = a + g;
        }
    }
    for (int f = 1; f < a; f++)
    {

        if (a % f == 0)
        {
            b = b + f;
        }
    }

        if ( b == i && a!=b && b!=m)
        {
            Console.WriteLine(b.ToString() + "  " + a.ToString());
        m = a;
        }
}
