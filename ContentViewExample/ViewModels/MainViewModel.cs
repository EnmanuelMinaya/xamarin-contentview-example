using ContentViewExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewExample.ViewModels
{
    public class MainViewModel: BaseViewModel
    {

       public NftOption Token1{ get; }
       public NftOption Token2{get;}
       public NftOption Token3{get;}
       public NftOption Token4{get;}
       public NftOption Token5{get;}
       public NftOption Token6{get;}

        public MainViewModel()
        {
           Token1 = new NftOption("Punk", "a", "1000 ETH");
           Token2 = new NftOption("Punk", "b", "1500 ETH");
           Token3 = new NftOption("Punk", "c", "2000 ETH");
           Token4 = new NftOption("Punk", "d", "11000 ETH");
           Token5 = new NftOption("Punk", "e", "100 ETH");
           Token6 = new NftOption("Punk", "f", "500 ETH");
        }
    }
}
