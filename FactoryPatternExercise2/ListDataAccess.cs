namespace FactoryPatternExercise2;

public class ListDataAccess: IDataAccess 
{
    public void LoadData()
    {
        Console.WriteLine("Loading the list of data access.....");
    }

    public void SaveData()
    {
        Console.WriteLine("Saving the list of data access.....");
    }
}