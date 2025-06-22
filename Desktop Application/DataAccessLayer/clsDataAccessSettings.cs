using System.Configuration;

 namespace InstituteDataAccess
{
    public static class clsDataAccessSettings
    { 
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
} 