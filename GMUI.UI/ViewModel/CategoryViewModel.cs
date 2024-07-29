using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMUI.UI.ViewModel;

internal class CategoryViewModel : BaseViewModel<string>
{
    public CategoryViewModel(string category)
    {
        Value = category;
    }

    public string Name
    {
        get
        {
            return Value;
        }
    }
}
