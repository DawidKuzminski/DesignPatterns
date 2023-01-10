// See https://aka.ms/new-console-template for more information
using StructuralDesignPattern_Proxy;

Console.WriteLine("Structural Design Pattern - Proxy");
Console.WriteLine("VideoService");
var videoService = new VideoService();
videoService.GetVideo(11);
videoService.GetVideo(11);

Console.WriteLine("---------------------------------------");
Console.WriteLine("VideoServiceProxy");
var proxy = new VideoServiceProxy(videoService);
proxy.GetVideo(11);
proxy.GetVideo(11);




