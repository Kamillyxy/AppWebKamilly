using MySql.Data.MySqlClient;
namespace AppWebExemplo.Configs
{
 public static class DAOHelper
 {
 // Lê uma string; se a coluna for NULL, devolve str
ing vazia
 public static string GetString(MySqlDataReader read
er, string column_name)
 {
 string text = string.Empty;
 if (!reader.IsDBNull(reader.GetOrdinal(column_n
ame)))
 text = reader.GetString(column_name);
 return text;
 }
 // Lê um double; se a coluna for NULL, devolve 0.0
 public static double GetDouble(MySqlDataReader read
er, string column_name)
 {
 double value = 0.0;
 if (!reader.IsDBNull(reader.GetOrdinal(column_n
ame)))
 value = reader.GetDouble(column_name);
 return value;
 }
 // Lê uma data; se a coluna for NULL, devolve null
 public static DateTime? GetDateTime(MySqlDataReader
reader, string column_name)
 {
 DateTime? value = null;
 if (!reader.IsDBNull(reader.GetOrdinal(column_name)))
 value = reader.GetDateTime(column_name);
 return value;
 }
 // Indica se uma coluna está NULL
 public static bool IsNull(MySqlDataReader reader, s
tring column_name)
 {
 return reader.IsDBNull(reader.GetOrdinal(column
_name));
 }
 }
}
