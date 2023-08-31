using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data;
using System.Data;

namespace eTickets.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }    
    
    public string Description { get; set; }
    
    public double Price { get; set; }
    
    public string ImageURl { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public MovieCategory MovieCategory { get; set; }
    
    //Relationships

    public List<Actors_Movies> Actors_Movies { get; set; }
    
    //Cinema
    public int CinemaId { get; set; }
    [ForeignKey("CinemaId")]

    public Cinema Cinema { get; set; }
    
    //Producer
    public int ProducerId { get; set; }
    [ForeignKey("ProducerId")]

    public Producer Producer { get; set; }
}