using System.Text.Json;
using Tareas;

HttpClient client = new HttpClient();
string url="https://jsonplaceholder.typicode.com/todos/";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();  
string body = await response.Content.ReadAsStringAsync();
List<Tarea>? ListaTarea = JsonSerializer.Deserialize<List<Tarea>>(body);

Console.WriteLine("LISTA DE TAREAS INCOMPLETAS");
foreach(var T in ListaTarea) {
    if(T.Completed==false) {
        Console.WriteLine($"Titulo:{T.Title},Estado:{T.Completed}");
    }
}
Console.WriteLine("LISTA DE TAREAS COMPLETAS");
foreach(var T in ListaTarea) {
    if(T.Completed==true) {
        Console.WriteLine($"Titulo:{T.Title},Estado:{T.Completed}");
    }
}