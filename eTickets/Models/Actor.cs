using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture Is Required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name Is Required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full Name Must Be Between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Bio Is Required")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
