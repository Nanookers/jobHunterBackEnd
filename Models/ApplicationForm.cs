
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace jobHunterBackEnd;

public class Application
{

    public enum LanguageType
    {
        Javascript,
        Csharp,
        Python,
        Java,
        SQL,

    }
    public int id { get; set; }   
    public string title  { get; set; }

    [ForeignKey("id")]
    public Company company {get; set;}
    
    public string contact { get; set; }

    // Using Enums to determine what language each Company is
    [Required]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public LanguageType language { get; set; }

}
