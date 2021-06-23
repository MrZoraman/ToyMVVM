using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyMvvm
{
    class BusinessLogicModel
    {
        public bool IsFooSet { get; private set; } = false;

        public void ToggleFoo()
        {
            IsFooSet = !IsFooSet;
        }
    }
}
