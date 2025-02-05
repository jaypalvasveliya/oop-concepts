// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

company obj = new company();
obj.GetcompanyName();

employee objj = new employee();
objj.GetcompanyName();





//testing puss
 class company
 {

    public void GetcompanyName()
    {
        Console.WriteLine("it will return company name");
    }
 }


class employee : company
{

    public string Getemployeename()
    {
        Console.WriteLine("enter  employeename ");
        return Console.ReadLine();

    }


    public int Getemployeename(int age)
    {
        Console.WriteLine("age");
        return Convert.ToInt32(Console.ReadLine());
    }

    public int Getemployeename(double salary)
    {
        Console.WriteLine("salary");
        return Convert.ToInt32(Console.ReadLine());
    }
}
    public class j
    {
        public void overriding()
        {
            Console.WriteLine("method overriding");
        }
    }

    public class p : j
    {
        public void overriding()
        {
            Console.WriteLine("method overriding");
        }

    }

    abstract class toyota
    {
        public void car()
        {
            Console.WriteLine("****car*****");
        }
    }

    sealed class hello
    {
        public void hello1()
        {
            Console.WriteLine("sealed class");
        }
    }
    static class food
    {
        public static void veg()
        {
            Console.WriteLine("veg food");
        }
    }





    //partial class

    public partial class employee1
    {

    }

























