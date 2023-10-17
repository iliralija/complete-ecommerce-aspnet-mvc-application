using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Actor
{
    [Key]
    public int ActorId { get; set; }
    
    [Display(Name = "Profile Picture URL")]
    public string ProfilePictureURL { get; set; }

    [Display(Name = "Fullname")]
    public string FullName { get; set; }

    [Display(Name = "Biography")]
    public string Bio { get; set; }
    
    //Relationships

    public List<Actors_Movies> Actors_Movies { get; set; }
}