namespace CriWare;

public class CriManaConfig
{
	internal class PCH264PlaybackConfig
	{
		public bool useH264Playback; //Field offset: 0x8

		public PCH264PlaybackConfig() { }

	}

	internal class SwitchH264PlaybackConfig
	{
		public bool enableBufferOutput; //Field offset: 0x8

		public SwitchH264PlaybackConfig() { }

	}

	internal class VitaH264PlaybackConfig
	{
		public bool useH264Playback; //Field offset: 0x8
		public int maxWidth; //Field offset: 0xC
		public int maxHeight; //Field offset: 0x10
		public bool getMemoryFromTexture; //Field offset: 0x14

		public VitaH264PlaybackConfig() { }

	}

	internal class WebGLConfig
	{
		public string webworkerPath; //Field offset: 0x8
		public int heapSize; //Field offset: 0xC

		public WebGLConfig() { }

	}

	public int numberOfDecoders; //Field offset: 0x8
	public int numberOfMaxEntries; //Field offset: 0xC
	public readonly bool graphicsMultiThreaded; //Field offset: 0x10
	public bool useStreamerManager; //Field offset: 0x11
	public PCH264PlaybackConfig pcH264PlaybackConfig; //Field offset: 0x14
	public SwitchH264PlaybackConfig switchH264PlaybackConfig; //Field offset: 0x18
	public VitaH264PlaybackConfig vitaH264PlaybackConfig; //Field offset: 0x1C
	public WebGLConfig webglConfig; //Field offset: 0x20

	public CriManaConfig() { }

}

