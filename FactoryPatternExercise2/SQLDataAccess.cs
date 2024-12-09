namespace FactoryPatternExercise2;

public class SQLDataAccess : IDataAccess

{
    public void LoadData()
    {
        Console.WriteLine("Loading the data using SQL Data Access");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving the data using SQL Data Access");
    }
}