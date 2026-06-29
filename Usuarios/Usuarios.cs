using System.Text.Json;
using System.Text.Json.Serialization;
namespace Usuarios;
public class Usuario
{
    private int id;
    private string? name;
    private string? username;
    private string? email;
    private Address? address;
    private string? phone;
    private string? website;
    private Company? company;
    [JsonPropertyName("id")] //recordar respetar siempre mayusculas o minusculas segun el archivo json para poder darle a la clase el valor deseado
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("username")]
    public string? Username { get => username; set => username = value; }
    [JsonPropertyName("name")]
    public string? Name { get => name; set => name = value; }
    [JsonPropertyName("email")]
    public string? Email { get => email; set => email = value; }
    [JsonPropertyName("address")]
    public Address? Address { get => address; set => address = value; }
    [JsonPropertyName("phone")]
    public string? Phone { get => phone; set => phone = value; }
    [JsonPropertyName("website")]
    public string? Website { get => website; set => website = value; }
    [JsonPropertyName("company")]
    public Company? Company { get => company; set => company = value; }
}
public class Address
{
    private string? street;
    private string? suite;
    private string? city;
    private string? zipcode;
    private Geo? geo;
    [JsonPropertyName("street")]
    public string? Street { get => street; set => street = value; }
    [JsonPropertyName("suite")]
    public string? Suite { get => suite; set => suite = value; }
    [JsonPropertyName("city")]
    public string? City { get => city; set => city = value; }
    [JsonPropertyName("zipcode")]
    public string? Zipcode { get => zipcode; set => zipcode = value; }
    [JsonPropertyName("geo")]
    public Geo? Geo { get => geo; set => geo = value; }
} 
public class Geo
{
    private string? lat;
    private string? lng;
    [JsonPropertyName("lat")]
    public string? Lat { get => lat; set => lat = value; }
    [JsonPropertyName("lng")]
    public string? Lng { get => lng; set => lng = value; }
}
public class Company
{
    private string? name;
    private string? catchphrase;
    private string? bs;
    [JsonPropertyName("name")]
    public string? Name { get => name; set => name = value; }
    [JsonPropertyName("catchPhrase")]
    public string? Catchphrase { get => catchphrase; set => catchphrase = value; }
    [JsonPropertyName("bs")]
    public string? Bs { get => bs; set => bs = value; }
}