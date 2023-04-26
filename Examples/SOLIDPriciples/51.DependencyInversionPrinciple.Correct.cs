namespace SOLIDPriciples.DependencyInversionPrinciple.Correct
{
    public class MySQLConnection : IDBConnection
    {
        public string Connect()
        {
            // handle the database connection
            return "Database connection";
        }
    }

    public interface IDBConnection
    {
        string Connect();
    }

    public class PasswordReminder
    {
        private IDBConnection _dbConnection;

        public PasswordReminder(IDBConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }
    }
}
