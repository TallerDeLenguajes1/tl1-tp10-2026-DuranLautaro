using System.Text.Json;
using Tareas;

HttpClient client = new HttpClient(); // 
string url="https://jsonplaceholder.typicode.com/todos/";
/*await lo que hace es esperar a que se complete la tarea asincrónica, en este caso la petición GET 
.GetAsync(url) hace una petición GET para pedir datos a esa url
response es el objeto que contiene la respuesta del servidor*/
HttpResponseMessage response = await client.GetAsync(url); 
response.EnsureSuccessStatusCode(); //asegura que la respuesta fue exitosa, si no lo fue lanza una excepción
string body = await response.Content.ReadAsStringAsync(); //response tiene varias partes, Content es el cuerpo de la respuesta. Esta línea lo convierte a string, obteniendo el JSON crudo como texto.
List<Tarea>? ListaTarea = JsonSerializer.Deserialize<List<Tarea>>(body); //toma el texto JSON y lo convierte en una lista de objetos Tarea, usando la clase Tarea que definimos antes.

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
string jsonString=JsonSerializer.Serialize(ListaTarea); //convierte la lista de objetos Tarea a un string JSON
//Console.WriteLine(jsonString);
File.WriteAllText("tareas.json",jsonString); //crea un archivo tareas.json y luego escribe la lista json 