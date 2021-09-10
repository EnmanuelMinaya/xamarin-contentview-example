using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewExample.Models
{
    public class NftOption
    {
        public NftOption(string title, string image, string price)
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
