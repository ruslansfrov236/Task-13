
        Thread th1 = new Thread(CreateContent);
        Thread th2 = new Thread(ContinueKey);

        th1.Start();
        th1.Join();
        th2.Start();
    

    static void ContinueKey()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void CreateContent()
    {
       
        string data = Console.ReadLine();
        
    }

