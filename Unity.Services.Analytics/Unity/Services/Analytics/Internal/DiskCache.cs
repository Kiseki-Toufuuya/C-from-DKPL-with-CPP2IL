namespace Unity.Services.Analytics.Internal;

internal class DiskCache : IDiskCache
{
	private readonly string k_CacheFilePath; //Field offset: 0x8
	private readonly IFileSystemCalls k_SystemCalls; //Field offset: 0xC
	private readonly long k_CacheFileMaximumSize; //Field offset: 0x10

	internal DiskCache(IFileSystemCalls systemCalls) { }

	public override void Clear() { }

	public override bool Read(List<EventSummary> eventSummaries, Stream buffer) { }

	private void ReadVersionOneCacheFile(in List<EventSummary>& eventEndIndices, BinaryReader reader, in Stream buffer) { }

	private void ReadVersionTwoCacheFile(in List<EventSummary>& eventSummaries, BinaryReader reader, in Stream buffer) { }

	public override void Write(List<EventSummary> eventSummaries, Stream payload) { }

}

