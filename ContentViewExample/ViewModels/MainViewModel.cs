using ContentViewExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewExample.ViewModels
{
    public class MainViewModel: BaseViewModel
    {

       public NFTOption Token1{ get; }
       public NFTOption Token2{get;}
       public NFTOption Token3{get;}
       public NFTOption Token4{get;}
       public NFTOption Token5{get;}
       public NFTOption Token6{get;}

        public MainViewModel()
        {
           Token1 = new NFTOption("Punk", "a", "1000 ETH");
           Token2 = new NFTOption("Punk", "b", "1500 ETH");
           Token3 = new NFTOption("Punk", "c", "2000 ETH");
           Token4 = new NFTOption("Punk", "d", "11000 ETH");
           Token5 = new NFTOption("Punk", "e", "100 ETH");
           Token6 = new NFTOption("Punk", "f", "500 ETH");
        }
    }
}
