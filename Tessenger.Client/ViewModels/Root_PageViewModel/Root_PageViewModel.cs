using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tessenger.Client.ViewModels.Root_PageViewModel
{
    internal class Root_PageViewModel : BaseViewModel
    {



        Root_Page Root_Page_ { get; set; }
        public Root_PageViewModel(Root_Page obj)
        {
            Root_Page_ = obj;
        }
    }
}
