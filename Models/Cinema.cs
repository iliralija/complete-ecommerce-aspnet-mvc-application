using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Cinema
{
    [Key]
    public int CinemaId { get; set; }
    
    [Display(Name = "Cinema Logo")]
    public string Logo { get; set; }

    [Display(Name = "Cinema Name")]
    public string Name { get; set; }

    [Display(Name = "Description")]
    public string Description { get; set; }
    
    //Relastionships

    public List<Movie> Movies { get; set; }
}