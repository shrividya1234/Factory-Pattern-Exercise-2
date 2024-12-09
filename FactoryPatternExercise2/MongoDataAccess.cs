namespace FactoryPatternExercise2;

public class MongoDataAccess : IDataAccess
{
    public void LoadData()
    {
        Console.WriteLine("Loading the list of Mongo DB access.....");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving the list of Mongo DB access.....");
    }
}