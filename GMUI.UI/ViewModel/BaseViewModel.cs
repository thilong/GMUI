using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMUI.UI.ViewModel;

internal class BaseViewModel<T>
{
    public T Value { get; set; }

    public bool IsSelected { get; set; }
    public bool IsChecked { get; set; }

    public bool IsVisiable { get; set; }
}
