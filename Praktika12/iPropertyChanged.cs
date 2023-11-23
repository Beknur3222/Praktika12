using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika12
{
    public interface iPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

}
