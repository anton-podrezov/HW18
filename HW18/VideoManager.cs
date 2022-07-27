using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    class VideoManager
    {
        private IVideoComand Comand;
        internal async Task DownloadVideo()
        {
            await Comand.Download();
        }

        internal async Task ShowVideoInfo()
        {
            await Comand.ShowInfo();
        }

        internal void SetComand(IVideoComand Comand)
        {
            this.Comand = Comand;
        }
    }
}
