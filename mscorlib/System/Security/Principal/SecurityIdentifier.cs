namespace System.Security.Principal;

[ComVisible(False)]
public sealed class SecurityIdentifier : IdentityReference
{
	public static readonly int MaxBinaryLength; //Field offset: 0x0
	public static readonly int MinBinaryLength; //Field offset: 0x4
	private Byte[] buffer; //Field offset: 0x8

	public int BinaryLength
	{
		 get { } //Length: 23
	}

	private static SecurityIdentifier() { }

	public int get_BinaryLength() { }

	public void GetBinaryForm(Byte[] binaryForm, int offset) { }

}

