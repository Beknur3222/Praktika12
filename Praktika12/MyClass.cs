using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika12
{
    public class MyClass : iPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnNameChanged();
                }
            }
        }

        public event PropertyEventHandler PropertyChanged;

        protected virtual void OnNameChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs("Name"));
        }
    }

}
