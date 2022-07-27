using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace HW18
{
    class YoutubeVideo
    {
        private string videoUrl;

        private YoutubeClient youtube;

        public YoutubeVideo(string videoUrl)
        {
            this.videoUrl = videoUrl;

            youtube = new YoutubeClient();
        }

        public async Task DownloadAsync()
        {
            Console.WriteLine(">>> Загрузка видое началась <<<");

            await youtube.Videos.DownloadAsync(videoUrl, "видос.mp4");

            Console.WriteLine(">>> Загрузка видео завершена <<<");
        }
        public async Task ShowInfoAsync()
        {
            var info = await youtube.Videos.GetAsync(videoUrl);

            Console.WriteLine($"> Название видео: {info.Title}\n> Автор видео: {info.Author}\n> Длина видео: {info.Duration}");
        }
    }
}
