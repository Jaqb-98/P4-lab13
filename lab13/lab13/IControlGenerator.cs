using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace lab13
{
    public interface IControlGenerator
    {
        FrameworkElement GenerateControl();
    }
}
