internal class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3); 
        list.Add(4);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(list[i]);
        }
        IterateNext(list);

        Console.WriteLine("---------------------------");

        var enumerator = list.GetEnumerator();

        for (int i = 0; i < 2; i++)
        {
            if (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        IterateNext(enumerator);

    }

    public static void IterateNext(IEnumerator<int> enumerator)
    {
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }

    public static void IterateNext(IEnumerable<int> enumerable)
    {
        foreach (var item in enumerable)
        {
            Console.WriteLine(item);
        }
    }
}
