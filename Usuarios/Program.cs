using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using Usuarios;
HttpClient client = new HttpClient();
string url=@"https://jsonplaceholder.typicode.com/users/";
HttpResponseMessage response = await client.GetAsync(url); 
response.EnsureSuccessStatusCode();
string cuerpo = await response.Content.ReadAsStringAsync();
Console.WriteLine($"{cuerpo}");
List<Usuario>? ListaUsuario=JsonSerializer.Deserialize<List<Usuario>>(cuerpo);
//Console.WriteLine($"{ListaUsuario[0].Username}");
//Console.WriteLine($"{ListaUsuario[0].Address.City}");
//Console.WriteLine($"{ListaUsuario.Count}");
for(int i=0;i<5;i++)
{
    //Console.WriteLine($"Usuario {i+1}");
    Console.WriteLine($"Nombre:{ListaUsuario[i].Name}-Correo electronico:{ListaUsuario[i].Email}-Domicilio:{ListaUsuario[i].Address.Street},{ListaUsuario[i].Address.City}");
}




