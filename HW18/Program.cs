using HW18;

try
{
    Console.WriteLine(">>> Вставте ссылку на YouTube видео <<<");

    string URL = Console.ReadLine();

    VideoManager manager = new VideoManager();

    YoutubeVideo video = new YoutubeVideo(URL);

    manager.SetComand(new YuotubeComand(video));

    await manager.ShowVideoInfo();

    await manager.DownloadVideo();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
