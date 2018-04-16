using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Hat_Trick.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte [] Image { get; set; }
        public ICollection<Player> players { get; set; }
        public int LeagueId { get; set; }
        public virtual League League { get; set; }



      


    }
}