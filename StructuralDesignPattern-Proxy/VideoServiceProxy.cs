using StructuralDesignPattern_Proxy.Abstraction;

namespace StructuralDesignPattern_Proxy;
internal class VideoServiceProxy : IVideoService
{
	private readonly IVideoService _videoService;
	private Dictionary<int, byte[]> _cache = new Dictionary<int, byte[]>();

	public VideoServiceProxy(IVideoService videoService)
	{
		_videoService = videoService;
	}

	public byte[] GetVideo(int videoId)
	{
		Console.WriteLine($"VideoServiceProxy: Trying get video with id: {videoId}");
		if(_cache.TryGetValue(videoId, out var video))
		{
			Console.WriteLine($"VideoServiceProxy: Getting from cache video with id: {videoId}");
			return video;
		}
		
		var downloadedVideo = _videoService.GetVideo(videoId);
		_cache.Add(videoId, downloadedVideo);

		return downloadedVideo;
	}
}
