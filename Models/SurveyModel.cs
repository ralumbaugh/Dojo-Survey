using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required (ErrorMessage="You must input a name")]
        [MinLength(2, ErrorMessage = "Your name must be at least two characters long")]
        [Display(Name = "Name: ")]
        public string Name {get; set;}
        [Required (ErrorMessage="Did you really have to remove locations from my list?")]
        [Display(Name = "Location: ")]
        public string Location {get; set;}
        [Required (ErrorMessage="Why must you test me like this? Put a language in.")]
        [Display(Name = "Language: ")]
        public string Language {get; set;}
        [MaxLength(20, ErrorMessage = "Your comment should be no more than 20 characters")]
        [Display(Name = "Comment: ")]
        public string Comment {get; set;}

        public Survey ()
        {}

        public Survey (string name, string location, string language, string comment)
        {
            Name = name;
            Location = location;
            Language = language;
            Comment = comment;
        }
    }
}