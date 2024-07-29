using GMUI.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMUI.UI.ViewModel;

internal class PlatformViewModel : BaseViewModel<Platform>
{
    public PlatformViewModel(Platform platform)
    {
        Value = platform;
    }

    public string Name
    {
        get
        {
            return "Platform Name";
        }
    }

    public string Description
    {
        get
        {
            return "Platform description";
        }
    }
}
