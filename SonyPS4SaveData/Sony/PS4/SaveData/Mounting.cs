namespace Sony.PS4.SaveData;

public class Mounting
{
	[Flags]
	internal enum MountModeFlags
	{
		Invalid = 0,
		ReadOnly = 1,
		ReadWrite = 2,
		Create = 4,
		DestructOff = 8,
		CopyIcon = 16,
		Create2 = 32,
	}

	internal class MountPoint
	{
		internal MountPointName name; //Field offset: 0x8
		internal DateTime openTime; //Field offset: 0x10
		internal int userId; //Field offset: 0x18
		internal MountModeFlags mountMode; //Field offset: 0x1C
		internal DirName dirName; //Field offset: 0x20
		internal bool isMounted; //Field offset: 0x24

		public MountPointName PathName
		{
			 get { } //Length: 11
		}

		public MountPoint() { }

		public MountPointName get_PathName() { }

		public virtual string ToString() { }

	}

	internal struct MountPointName
	{
		public const int MOUNT_POINT_DATA_MAXSIZE = 15; //Field offset: 0x0
		internal string data; //Field offset: 0x0

		public string Data
		{
			 get { } //Length: 10
		}

		public string get_Data() { }

		public virtual string ToString() { }

	}

	internal class MountRequest : RequestBase
	{
		internal DirName dirName; //Field offset: 0x18
		internal ulong blocks; //Field offset: 0x20
		internal MountModeFlags mountMode; //Field offset: 0x28

		public ulong Blocks
		{
			 set { } //Length: 261
		}

		public DirName DirName
		{
			 set { } //Length: 99
		}

		public MountModeFlags MountMode
		{
			 set { } //Length: 85
		}

		public MountRequest() { }

		public void set_Blocks(ulong value) { }

		public void set_DirName(DirName value) { }

		public void set_MountMode(MountModeFlags value) { }

	}

	internal class MountResponse : ResponseBase
	{
		internal MountPoint mountPoint; //Field offset: 0x14

		public MountPoint MountPoint
		{
			 get { } //Length: 82
		}

		public MountResponse() { }

		public MountPoint get_MountPoint() { }

	}

	internal class SaveIconRequest : RequestBase
	{
		internal MountPointName mountPointName; //Field offset: 0x18
		internal string iconPath; //Field offset: 0x1C
		internal Byte[] rawPNG; //Field offset: 0x20
		internal ulong pngDataSize; //Field offset: 0x28

		public string IconPath
		{
			 set { } //Length: 98
		}

		public MountPointName MountPointName
		{
			 set { } //Length: 99
		}

		public Byte[] RawPNG
		{
			 set { } //Length: 145
		}

		public SaveIconRequest() { }

		public void set_IconPath(string value) { }

		public void set_MountPointName(MountPointName value) { }

		public void set_RawPNG(Byte[] value) { }

	}

	internal class SetMountParamsRequest : RequestBase
	{
		internal MountPointName mountPointName; //Field offset: 0x18
		internal string title; //Field offset: 0x1C
		internal string subTitle; //Field offset: 0x20
		internal string detail; //Field offset: 0x24
		internal uint userParam; //Field offset: 0x28

		public MountPointName MountPointName
		{
			 set { } //Length: 99
		}

		public SaveDataParams Params
		{
			 set { } //Length: 136
		}

		public SetMountParamsRequest() { }

		public void set_MountPointName(MountPointName value) { }

		public void set_Params(SaveDataParams value) { }

	}

	internal class UnmountRequest : RequestBase
	{
		internal MountPointName mountPointName; //Field offset: 0x18
		internal bool backup; //Field offset: 0x1C

		public bool Backup
		{
			 set { } //Length: 85
		}

		public MountPointName MountPointName
		{
			 set { } //Length: 99
		}

		public UnmountRequest() { }

		public void set_Backup(bool value) { }

		public void set_MountPointName(MountPointName value) { }

	}

	internal static List<MountPoint> activeMountPoints; //Field offset: 0x0
	internal static object activeMPSync; //Field offset: 0x4

	private static Mounting() { }

	internal static MountPoint FindMountPoint(MountPointName mountPointName) { }

	public static int Mount(MountRequest request, MountResponse response) { }

	private static void PrxSaveDataGetIconSize(Byte[] pngData, out int width, out int height) { }

	public static int SaveIcon(SaveIconRequest request, EmptyResponse response) { }

	public static int SetMountParams(SetMountParamsRequest request, EmptyResponse response) { }

	public static int Unmount(UnmountRequest request, EmptyResponse response) { }

}

