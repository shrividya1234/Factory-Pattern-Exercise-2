namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of database you would like to use:"+
                              "\n1.Is it Mongo? \n 2. Is it List? \n 3. Is it SQL?");
            var databaseType = Console.ReadLine();
            var dataaccess = DataFactory.BuildDataBase(databaseType);
            dataaccess.LoadData();
            dataaccess.SaveData();
        }
    }
}
