#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;


public class Pet
{
    [Required(ErrorMessage = "Please tell me your pet's name!")]
    public string Name {get;set;}
    [Required]
    [Display(Name="Type of Pet:")]
    public string Species {get;set;}
    [Required]
    [Range(1,int.MaxValue)]
    public int Age {get;set;}
    public bool IsTheGoodest {get;set;}
}