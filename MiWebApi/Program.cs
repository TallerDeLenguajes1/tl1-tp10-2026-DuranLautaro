using System.Text.Json;
using System.Net.Http;
using apidog;
HttpClient client = new HttpClient();
string url=@"https://dog.ceo/api/breeds/image/random"; //es una API
HttpResponseMessage response = await client.GetAsync(url); 
response.EnsureSuccessStatusCode();
string cuerpo = await response.Content.ReadAsStringAsync();
//Console.WriteLine(cuerpo);
//como es solo un objeto y no una lista, solo debo generar una instancia de la clase
Perro p = JsonSerializer.Deserialize<Perro>(cuerpo);
Console.WriteLine($"Mensaje:{p.Mensaje}");
Console.WriteLine($"Estado: {p.Estado}");
string jsonString=JsonSerializer.Serialize(p); //convierte la instacia de objeto p a un string JSON
//Console.WriteLine(jsonString); //lo mismo que cuerpo
File.WriteAllText("InformacionPerro.json",jsonString); //crea un archivo InformacionPerro y luego escribe lo que hay en json 