namespace ConsoleApp1;
public static class ExtensionMethodsExample
{
    public static void Increment(this Example e, int n)
    {
        e.non_static_field += n;
    }
} 

public class Example
{
    public int non_static_field = 0;
        
    public static int static_field = 0;
    public Example()
    {
        non_static_field++;
        static_field++;
    }

    public static void Test()
    {
        static_field++;
    }
}

class Program
{
 
    

    static void Main(string[] args)
    {
        var samples = new List<Example>();
        for(int i = 0; i < 5; i++)
            samples.Add(new Example());
        
        
        ExtensionMethodsExample.Increment(samples[0], 5);
        samples[0].Increment(5);
        Console.WriteLine(samples[0].non_static_field);
        
        
        Example.Test();
        var index = 0;
        foreach(var s in samples)
            Console.WriteLine($@"
index       : {index++}
static      : {Example.static_field}
non static  : {s.non_static_field}
");
        Console.ReadLine();
    }
}