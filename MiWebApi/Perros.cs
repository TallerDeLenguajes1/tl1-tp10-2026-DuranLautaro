using System.Text.Json;
using System.Text.Json.Serialization;
namespace apidog;
public class Perro
{
    private string? mensaje;
    private string? estado;
    [JsonPropertyName("message")]
    public string? Mensaje { get => mensaje; set => mensaje = value; }
    [JsonPropertyName("status")]
    public string? Estado { get => estado; set => estado = value; }
}