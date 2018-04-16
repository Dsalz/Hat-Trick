using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Hat_Trick.Models
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Club> clubs {get; set;}
        




    //    public League()
    //    {

    //    }

    //    public League(int id, string name, string imagepath)
    //    {
    //        Id = id;
    //        Name = name;
    //        Myimage = Image.FromFile(imagepath);
    //    }
    }
}