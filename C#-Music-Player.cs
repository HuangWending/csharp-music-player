using System;
using System.Media;

class MusicPlayer
{
    static void Main()
    {
        Console.WriteLine("欢迎使用黄文定音乐播放器！");

        // 获取音乐文件路径
        Console.WriteLine("请输入音乐文件的路径：");
        string filePath = Console.ReadLine();

        // 获取播放倍速
        Console.WriteLine("请选择播放倍速（1-正常速度，2-2倍速，0.5-0.5倍速）：");
        double speed = double.Parse(Console.ReadLine());

        // 创建音乐播放器实例
        SoundPlayer player = new SoundPlayer();

        try
        {
            // 设置音乐文件路径
            player.SoundLocation = filePath;

            // 设置播放倍速
            player.PlaybackSpeed = speed;

            // 播放音乐
            player.Play();
            Console.WriteLine("正在播放音乐...");

            // 等待播放完毕
            while (player.Playing)
            {
                // 什么都不做，等待音乐播放完毕
            }

            Console.WriteLine("音乐播放完毕。");
        }
        catch (Exception ex)
        {
            Console.WriteLine("播放音乐时出现错误：" + ex.Message);
        }
        finally
        {
            // 释放音乐播放器资源
            player.Dispose();
        }

        Console.WriteLine("按任意键退出。");
        Console.ReadKey();
    }
}
