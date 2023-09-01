#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace PetParty.Models;


public class Pet
{
    [Required(ErrorMessage = "Please tell me your pet's name!")]
    [NoZNames]
    public string Name {get;set;}

    [Required]
    [PetType2("Dog", "Cat", "Turtle", "Panda")]
    [Display(Name="Type of Pet:")]
    public string Species {get;set;}

    [Required]
    [Range(1,int.MaxValue)]
    public int Age {get;set;}
    public bool IsTheGoodest {get;set;}
}


// Create a class that inherits from ValidationAttribute
public class NoZNamesAttribute : ValidationAttribute
{    
    // Call upon the protected IsValid method
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        // We are expecting the value coming in to be a string
        // so we need to do a bit of type casting to our object
        // Strings work similarly to arrays under the hood 
        // so we can grab the first letter using its index   
        // If we discover that the first letter of our string is z...  
        if (value == null || ((string)value).ToLower()[0] == 'z')
        {        
            // we return an error message in ValidationResult we want to render    
            return new ValidationResult("No names that start with Z allowed!");   
        } else {   
            // Otherwise, we were successful and can report our success  
            return ValidationResult.Success;  
        }  
    }
}

// Create a class that inherits from ValidationAttribute
public class PetTypeAttribute : ValidationAttribute
{    
    // Call upon the protected IsValid method
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        string[] Options = new string[] {"Dog", "Cat", "Turtle"};

        if (value == null || Options.Contains((string)value))
        {        
            // we return an error message in ValidationResult we want to render    
            return ValidationResult.Success;  
        } else {   
            // Otherwise, we were successful and can report our success  
            return new ValidationResult("Invalid Pet Type, Get out of here Gru");   
        }  
    }
}


// Create a class that inherits from ValidationAttribute
public class PetType2Attribute : ValidationAttribute
{    

    // property 
    public string[]? Options {get;set;}

    // constructor
    public PetType2Attribute(params string[] options)
    {
        this.Options = options;
    }


    // Call upon the protected IsValid method
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)    
    {   
        // string[] Options = new string[] {"Dog", "Cat", "Turtle"};

        if (value == null || Options.Contains((string)value))
        {        
            // we return an error message in ValidationResult we want to render    
            return ValidationResult.Success;  
        } else {   
            // Otherwise, we were successful and can report our success  
            return new ValidationResult("Invalid Pet Type, Get out of here Gru");   
        }  
    }
}
