namespace FactoryPatternExercise2;

public static class DataFactory
{
    public static IDataAccess BuildDataBase(string databaseType)
    {
        switch (databaseType.ToLower())
        {
            case "mysql":
                case "sql":
                    return new SQLDataAccess();
            case "mongo":
                return new MongoDataAccess();
            case "listdata":
                return new ListDataAccess(); 
            default:
                return new SQLDataAccess();
        }
    }
}