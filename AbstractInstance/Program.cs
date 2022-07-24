using System;

namespace AbstractInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Delete();
            Console.WriteLine("---------------\t");

            Database database2 = new MySqlServer();
            database2.Add();
            database2.Delete();
            Console.WriteLine("--------------\t");

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Default olarak eklendi.");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Sql tarafından silindi.");
        }
    }
    class MySqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("MySqlServer tarafından silindi.");
        }
    }
}
