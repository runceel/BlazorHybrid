using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared;
public interface IPlatformNameProvider
{
    string GetPlatformName();
}
