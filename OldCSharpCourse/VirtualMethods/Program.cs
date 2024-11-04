using System;

namespace VirtualMethods //o kodu evrensel yapıyor
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }


        class DataBase
        {
            public virtual void Add() 
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer:DataBase
        {
            public override void Add()
            {
                Console.WriteLine("Sql eklendi");
                //base.Add();
            }

            public override void Delete()
            {
                base.Delete();
            }
        }

        class MySql:DataBase
        {
            
        }
    }
}
