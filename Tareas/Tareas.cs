using System.Text.Json;
using System.Text.Json.Serialization;
namespace Tareas;
public class Tarea {
    private int userId;
    private int id;
    private string? title;
    private bool completed;
    //EL JSON VA SIEMPRE ARRIBA DE LA PROPIEDAD
    [JsonPropertyName("userId")]
    public int UserId {get => userId; set => userId=value;}
    [JsonPropertyName("id")]
    public int Id {get => id; set => id=value;}
     [JsonPropertyName("completed")]
    public bool Completed { get => completed; set => completed = value; }
    [JsonPropertyName("title")]
    public string? Title { get => title; set => title = value; }
    
}


