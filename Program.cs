using _1209project;
using ConsoleApp1;

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



        Line line = new Line(true);
        double length = line.getLength();
        Console.WriteLine(length.ToString());

        try
        {
            Line line2d = new Line(new Point(5, 3), new Point(8, 7, 10));
            double length2d = line2d.getLength();
            Console.WriteLine(length2d.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



        Triangle tri = new Triangle(new Point(0, 0), new Point(5, 0), new Point(3, 3));
        double[] angles = tri.findAngles();
        for (int i = 0; i < angles.Length; i++)
        {
            Console.WriteLine(angles[i].ToString());
        } 
    }

}