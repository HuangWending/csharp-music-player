# csharp-music-player
C#音乐播放器
using System; - 引入 System 命名空间，其中包含了一些基本的系统类和方法。
using System.Media; - 引入 System.Media 命名空间，其中包含了音频播放相关的类和方法。
class MusicPlayer - 定义一个名为 MusicPlayer 的类。
static void Main() - 定义一个静态的主函数，程序的入口。
Console.WriteLine("欢迎使用音乐播放器！"); - 在控制台输出欢迎消息。
Console.WriteLine("请输入音乐文件的路径："); - 在控制台提示用户输入音乐文件的路径。
string filePath = Console.ReadLine(); - 从控制台读取用户输入的音乐文件路径，并将其存储在名为 filePath 的字符串变量中。
Console.WriteLine("请选择播放倍速（1-正常速度，2-2倍速，0.5-0.5倍速）："); - 在控制台提示用户选择播放倍速。
double speed = double.Parse(Console.ReadLine()); - 从控制台读取用户输入的播放倍速，并将其转换为双精度浮点数，存储在名为 speed 的变量中。
SoundPlayer player = new SoundPlayer(); - 创建一个名为 player 的 SoundPlayer 实例，用于播放音乐。
player.SoundLocation = filePath; - 设置音乐文件的路径。
player.PlaybackSpeed = speed; - 设置音乐的播放倍速。
player.Play(); - 开始播放音乐。
while (player.Playing) - 在音乐播放期间，循环等待音乐播放完毕。
Console.WriteLine("音乐播放完毕。"); - 在控制台输出音乐播放完毕的消息。
player.Dispose(); - 释放音乐播放器实例所占用的资源。
Console.WriteLine("按任意键退出。"); - 在控制台提示用户按任意键退出程序。
Console.ReadKey(); - 等待用户按下任意键，以便程序退出。
