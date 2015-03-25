using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    public class Hotdog
    {
        public int HotDogID { get; set; }
        public int ProfileID { get; set; }
        public string Name { get; set; }
        public virtual Profile Profile { get; set; }
    }
}