using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImdbFinal
{
    public class Picture
    {
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }

        public Picture(string name,string url)
        {
            this.ImageName = name;
            this.ImageUrl = url;
        }
    }
}
