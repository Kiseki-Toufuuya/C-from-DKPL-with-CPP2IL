namespace System.Security.Principal;

[ComVisible(True)]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
{
	private static IntPtr invalidWindows; //Field offset: 0x0
	private IntPtr _token; //Field offset: 0x3C
	private string _type; //Field offset: 0x40
	private WindowsAccountType _account; //Field offset: 0x44
	private bool _authenticated; //Field offset: 0x48
	private string _name; //Field offset: 0x4C
	private SerializationInfo _info; //Field offset: 0x50

	public virtual string AuthenticationType
	{
		 get { } //Length: 11
	}

	public virtual string Name
	{
		 get { } //Length: 95
	}

	[ComVisible(False)]
	[MonoTODO("not implemented")]
	public SecurityIdentifier User
	{
		 get { } //Length: 47
	}

	private static WindowsIdentity() { }

	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	public WindowsIdentity(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	public override void Dispose() { }

	public virtual string get_AuthenticationType() { }

	public virtual string get_Name() { }

	public SecurityIdentifier get_User() { }

	public static WindowsIdentity GetCurrent() { }

	internal static IntPtr GetCurrentToken() { }

	private static string GetTokenName(IntPtr token) { }

	public override WindowsImpersonationContext Impersonate() { }

	private void SetToken(IntPtr token) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

