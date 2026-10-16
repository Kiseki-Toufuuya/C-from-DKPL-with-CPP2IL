namespace CriWare;

public class CriFsConfig
{
	public const int defaultAndroidDeviceReadBitrate = 50000000; //Field offset: 0x0
	public int numberOfLoaders; //Field offset: 0x8
	public int numberOfBinders; //Field offset: 0xC
	public int numberOfInstallers; //Field offset: 0x10
	public int installBufferSize; //Field offset: 0x14
	public int maxPath; //Field offset: 0x18
	public string userAgentString; //Field offset: 0x1C
	public bool minimizeFileDescriptorUsage; //Field offset: 0x20
	public bool enableCrcCheck; //Field offset: 0x21
	public int androidDeviceReadBitrate; //Field offset: 0x24

	public CriFsConfig() { }

}

