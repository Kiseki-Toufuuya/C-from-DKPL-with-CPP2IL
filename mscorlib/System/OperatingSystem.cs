namespace System;

public sealed class OperatingSystem : ISerializable, ICloneable
{
	private readonly Version _version; //Field offset: 0x8
	private readonly PlatformID _platform; //Field offset: 0xC
	private readonly string _servicePack; //Field offset: 0x10
	private string _versionString; //Field offset: 0x14

	public PlatformID Platform
	{
		 get { } //Length: 11
	}

	public Version Version
	{
		 get { } //Length: 11
	}

	public string VersionString
	{
		 get { } //Length: 404
	}

	public OperatingSystem(PlatformID platform, Version version) { }

	internal OperatingSystem(PlatformID platform, Version version, string servicePack) { }

	public override object Clone() { }

	public PlatformID get_Platform() { }

	public Version get_Version() { }

	public string get_VersionString() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

