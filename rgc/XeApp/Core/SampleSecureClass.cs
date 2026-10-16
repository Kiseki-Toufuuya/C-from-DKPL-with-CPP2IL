namespace XeApp.Core;

public class SampleSecureClass
{
	public SecureInt a; //Field offset: 0x8
	public SecureInt b; //Field offset: 0x14
	public SecureInt c; //Field offset: 0x20

	public bool IsFalsifed
	{
		 get { } //Length: 68
	}

	public SampleSecureClass() { }

	public bool get_IsFalsifed() { }

}

