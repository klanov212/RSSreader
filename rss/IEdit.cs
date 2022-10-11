using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rss
{
    internal interface IEdit
    {
        void Delete();
        void ChangeName();
        void Add();
    }
}
