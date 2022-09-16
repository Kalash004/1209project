using _1209project;

class Program
{
    public static void Main(string[] args)
    {
        Interval inter = new Interval(40, 70);
        Console.WriteLine(inter.ToString());
        Interval inter2 = new Interval(80, 10);
        Console.WriteLine(inter2.ToString()); ;
        Interval inter3 = inter.findUnion(inter2);
        if (inter3 != null) Console.WriteLine(value: inter3.ToString());
        else Console.WriteLine("There was no intersections in interval");

        Console.WriteLine(inter.isInInterval(40));
    }

}