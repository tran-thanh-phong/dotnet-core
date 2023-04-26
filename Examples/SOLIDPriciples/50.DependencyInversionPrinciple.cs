namespace SOLIDPriciples.DependencyInversionPrinciple
{
    public class MySQLConnection
    {
        public string Connect()
        {
            // handle the database connection
            return "Database connection";
        }
    }

    public class PasswordReminder
    {
        private MySQLConnection _dbConnection;

        public PasswordReminder(MySQLConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }
    }
}
