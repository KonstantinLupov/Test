using System.ComponentModel.DataAnnotations;

namespace Whatever.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]
        public string TeamName { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]

        public string FirstPlayerName { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]


        public string FirstPlayerSchool { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]


        public string FirstPlayerClass { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]


        public string FirstPlayerEmail { get; set; }
        public string FirstPlayerPhoneNumber { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]

        public string SecondPlayerName { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]


        public string SecondPlayerSchool { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]


        public string SecondPlayerClass { get; set; }
        [Required(ErrorMessage = "Полето е задължително")]


        public string SecondPlayerEmail { get; set; }
        public string SecondPlayerPhoneNumber { get; set; }
    }
}