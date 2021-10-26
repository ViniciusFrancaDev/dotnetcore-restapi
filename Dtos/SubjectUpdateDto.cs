using System.ComponentModel.DataAnnotations;

namespace dotnetcore_restapi.Dtos
{
    public class SubjectUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Summary { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
