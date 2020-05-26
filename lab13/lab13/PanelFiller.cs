using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace lab13
{
    public class PanelFiller : IPanelFiller
    {
        public IDataProvider DataProvider { get; private set; }
        public IControlGenerator ControlGenerator { get; private set; }

        public PanelFiller(IControlGenerator controlGenerator, IDataProvider DataProvider)
        {
            ControlGenerator = controlGenerator;
            this.DataProvider = DataProvider;
        }

        public void Fill(Panel panel)
        {
            var number = DataProvider.GetData();
            for (int i = 0; i < number; i++)
            {
                panel.Children.Add(ControlGenerator.GenerateControl());
            }
        }
    }
}
