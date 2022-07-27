using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    public interface IVideoComand
    {
        public async Task Download() { }
        public async Task ShowInfo() { }
    }
}
