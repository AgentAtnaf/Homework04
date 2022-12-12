class Program
{
    public static Tree<string> tree = new Tree<string>();
    static void Main(string[] args)
    {
        string name = InputName();
        int position = -1;
        int slave = Inputslave();
        tree.AddChild(name,position);
        if(slave > 1)
        {
            addslavelooper(ref slave,ref position);
        }
        /*tree.AddChild("Tim",-1);
        tree.AddChild("nhong",0);
        tree.AddChild("nap",1);
        tree.AddSibling("net",1);
        tree.AddSibling("toddy",0);
        tree.AddChild("bass",4);*/
        for(int i = 0; i < tree.GetLength(); i++)
        {
            Console.WriteLine("{0} Position:{1}",tree.Get(i),i);
        }
    }
     static string InputName()
    {
        return Console.ReadLine();
    }
    static int Inputslave()
    {
        return int.Parse(Console.ReadLine());
    }
    static void addslavelooper(ref int slave,ref int position)
    {
        
        if(slave == 1)
        {
            position++;
            string name = InputName();
            int slave1 = Inputslave();
            tree.AddChild(name,position);
            if(slave1 > 0)
            {
             addslavelooper(ref slave1,ref position);
            }
        }
        else if(slave > 1)
        {
            position++;
            int Siblingposition = position;
            string name = InputName();
            int slave1 = Inputslave();
            tree.AddChild(name,position);
            slave--;
            if(slave1 > 0)
            {
             addslavelooper(ref slave1,ref position);
            }
            for(int i = 0; i < slave; i++)
            {
            addslavesibling(ref Siblingposition);
            }
        }
    }
    static void addslavesibling(ref int position)
    {
            string name = InputName();
            int slave1 = Inputslave();
            tree.AddSibling(name,position);
            if(slave1 > 0)
            {
             addslavelooper(ref slave1,ref position);
            }
    }
}