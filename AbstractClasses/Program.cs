﻿using System;

namespace AbstractClasses //içi dolu olmanyan virtual method
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
                database.Add();
                database.Delete();

                Database database2 = new SqlServer();
                database2.Add();
                database2.Delete();

                Console.ReadLine();

        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();   // ADD HERKESDE AYNI AMA DELETE FARKLI 
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
