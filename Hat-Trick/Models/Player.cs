using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Hat_Trick.Models
{
    public class Player
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        
        public int Age { get; set; }
        public string Position { get; set; }
        public int? ClubId { get; set; }
        public virtual Club Club { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }


        //public Player()
        //{

        //}

        //public Player(int id, string name, string imagepath, decimal age, string position)
        //{
        //    Id = id;
        //    Name = name;
        //    Myimage = Image.FromFile(imagepath);
        //    Age = age;
        //    Position = position;
        //}
    }
}