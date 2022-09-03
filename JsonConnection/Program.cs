using JsonConnection.Controller;
using JsonConnection.Model;
using System.Data.SqlClient;

//DataSetString connection = new DataSetString("DESKTOP-F71Q6SL", "ProductDB", true);
//Console.WriteLine(connection);
ConnectionController first = new ConnectionController(@"D:\Projects\Fruit - People\JsonConnection\ConnectionString\setting.json");
first.Download();
SqlConnection sqlConnection = new SqlConnection(first.defaultsetting.ToString());
string sqlStr = "SELECT * FROM [HelloWorld].[dbo].[Table_1];";
sqlConnection.Open();
SqlCommand SqlCommand = new SqlCommand(sqlStr, sqlConnection);
SqlDataReader reader = SqlCommand.ExecuteReader();
while (reader.Read())
{
    for (int i = 0; i < reader.FieldCount; i++)
    {
        Console.Write($"{reader.GetValue(i).ToString()}\t");
    }
    Console.WriteLine();
}
sqlConnection.Close();
Console.WriteLine("------------------------");
first = new ConnectionController(@"С:\Projects\Fruit - People\JsonConnection\ConnectionString\setting.json");
first.Download();