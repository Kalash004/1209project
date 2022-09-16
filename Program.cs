using _1209project;

class Program
{
    public static void Main(string[] args)
    {
        Interval inter = new Interval(40, 45);
        Console.WriteLine(inter.ToString());
        Interval inter2 = new Interval(60, 70);
        Console.WriteLine(inter2.ToString()); ;
        Interval inter3 = inter.findUnion(inter2);
        Console.WriteLine(value: inter3.ToString());
    }

}