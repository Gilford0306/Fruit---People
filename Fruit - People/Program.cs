using FruitPeople;
using System.Text.Json;


//string strJSON = File.ReadAllText("sample1.json");
//Fruit jUser = JsonSerializer.Deserialize<Fruit>(strJSON);
//Console.WriteLine(jUser);



Peoples peops = JsonSerializer.Deserialize<Peoples>(File.ReadAllText("sample4.json"));
peops.Show();

