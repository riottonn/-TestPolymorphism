class TestOverload
{
    public void DisplayOverload()
    {
        Console.WriteLine("DisplayOverload void");
    }

    public int DisplayOverload(int x)
    {
        Console.WriteLine("DisplayOverload int");
        return x;
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestOverload to = new TestOverload();
        to.DisplayOverload();
        int i = to.DisplayOverload(5);
        Console.ReadKey();
    }
}
