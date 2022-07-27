using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    class YuotubeComand : IVideoComand
    {
        private YoutubeVideo video;
        public YuotubeComand(YoutubeVideo video)
        {
            this.video = video;
        }

        public async Task Download()
        {
            await video.DownloadAsync();
        }

        public async Task ShowInfo()
        {
            await video.ShowInfoAsync();
        }
    }
}
