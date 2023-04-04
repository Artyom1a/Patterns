using Singleton;


class Program
{

    static void Main(string[] args)
    {
        // однопоточность
        //Computer comp = new Computer();
        //comp.Launch("Windows 8.1");
        //Console.WriteLine(comp.OS.Name);

        //// у нас не получится изменить ОС, так как объект уже создан    
        //comp.OS = OS.getInstance("Windows 10");
        //Console.WriteLine(comp.OS.Name);

        //Console.ReadLine();
        // однопоточность

        // многопоточность
        (new Thread(() =>
        {
            Computer comp2 = new Computer();
            comp2.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp2.OS.Name);

        })).Start();

        Computer comp = new Computer();
        comp.Launch("Windows 8.1");
        Console.WriteLine(comp.OS.Name);
        Console.ReadLine();
        // многопоточность
    }
}

