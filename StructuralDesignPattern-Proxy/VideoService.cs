using StructuralDesignPattern_Proxy.Abstraction;

namespace StructuralDesignPattern_Proxy;
internal class VideoService : IVideoService
{
	public byte[] GetVideo(int videoId)
	{
		Console.WriteLine($"VideoService: Download video with ID: {videoId}");
		return new byte[videoId];
	}
}
