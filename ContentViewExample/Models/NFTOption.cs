using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewExample.Models
{
    public class NFTOption
    {
        public NFTOption(string title, string image, string price)
        {
            Title = title;
            Image = image;
            Price = price;
        }

        public string Title { get; }
        public string Image { get; }
        public string Price { get; }
    }
}
