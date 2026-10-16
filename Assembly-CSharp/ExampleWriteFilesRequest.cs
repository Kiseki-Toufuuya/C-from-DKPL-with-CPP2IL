//Type is in global namespace

public class ExampleWriteFilesRequest : FileOperationRequest
{
	public string myTestData; //Field offset: 0x1C
	public string myOtherTestData; //Field offset: 0x20
	public Byte[] largeData; //Field offset: 0x24

	public ExampleWriteFilesRequest() { }

	public virtual void DoFileOperations(MountPoint mp, FileOperationResponse response) { }

}

