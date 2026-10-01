using MySql.Data.MySqlClient;

namespace AppWebKamilly.Configs
{
    public static class DAOHelper
    {
        public static string GetString(
            MySqlDataReader reader,
            string columnName)
        {
            string text = string.Empty;

            if (!reader.IsDBNull(
                reader.GetOrdinal(columnName)))
            {
                text = reader.GetString(columnName);
            }

            return text;
        }

        public static double GetDouble(
            MySqlDataReader reader,
            string columnName)
        {
            double value = 0.0;

            if (!reader.IsDBNull(
                reader.GetOrdinal(columnName)))
            {
                value = reader.GetDouble(columnName);
            }

            return value;
        }

        public static DateTime? GetDateTime(
            MySqlDataReader reader,
            string columnName)
        {
            DateTime? value = null;

            if (!reader.IsDBNull(
                reader.GetOrdinal(columnName)))
            {
                value = reader.GetDateTime(columnName);
            }

            return value;
        }

        public static bool IsNull(
            MySqlDataReader reader,
            string columnName)
        {
            return reader.IsDBNull(
                reader.GetOrdinal(columnName));
        }
    }
}