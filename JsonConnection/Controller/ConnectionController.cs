using JsonConnection.Model;
using System.Text.Json;

namespace JsonConnection.Controller
{
    internal class ConnectionController
    {
            public string fileName;
            public DataSetString defaultsetting { get; set; }

            public ConnectionController(string fileName = "setting.json")
            {

                this.fileName = fileName;
            }
        public void Download()
        {
            try
            {
                if (!File.Exists(fileName))
                    throw new Exception("Ошибка подключения - строка подключение не распознана");
                defaultsetting = JsonSerializer.Deserialize<DataSetString>(File.ReadAllText(fileName));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        } 

    }
}
