using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Hat_Trick.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte [] Myimage { get; set; }
        public ICollection<League> leagues { get; set; }
        public ICollection<Player> player { get; set; }






        //public Country()
        //{

        //}

        //public Country(int id, string name, string imagepath)
        //{
        //    Id = id;
        //    Name = name;
        //    Myimage = Image.FromFile(imagepath);
        //}
    }








}