using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class Profile
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string Name { get; set; }

        [StringLength(250, MinimumLength = 3)]
        [Required]
        public string Bio { get; set; }
        [Required]
        public int Rating { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Favorite { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string LastAte { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public virtual ICollection<Hotdog> Hotdogs { get; set; }
    }

    public class ProfileDBContext : ApplicationDbContext
    {
        public DbSet<Profile> Profile { get; set; }
    }
}