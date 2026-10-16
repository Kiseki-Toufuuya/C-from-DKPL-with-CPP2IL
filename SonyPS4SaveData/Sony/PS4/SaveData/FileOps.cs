namespace Sony.PS4.SaveData;

public class FileOps
{
	internal abstract class FileOperationRequest : RequestBase
	{
		internal MountPointName mountPointName; //Field offset: 0x18

		public MountPointName MountPointName
		{
			 set { } //Length: 99
		}

		public FileOperationRequest() { }

		public abstract void DoFileOperations(MountPoint mp, FileOperationResponse response) { }

		public void set_MountPointName(MountPointName value) { }

	}

	internal abstract class FileOperationResponse : ResponseBase
	{
		internal float progress; //Field offset: 0x14

		public FileOperationResponse() { }

		public void UpdateProgress(float progress) { }

	}


	public static int CustomFileOp(FileOperationRequest request, FileOperationResponse response) { }

}

