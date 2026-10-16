namespace System.Security.Permissions;

[ComVisible(True)]
public sealed class SecurityPermission : CodeAccessPermission
{
	private SecurityPermissionFlag flags; //Field offset: 0x8

	public SecurityPermissionFlag Flags
	{
		 set { } //Length: 156
	}

	public SecurityPermission(SecurityPermissionFlag flag) { }

	private SecurityPermission Cast(IPermission target) { }

	private bool IsEmpty() { }

	public virtual bool IsSubsetOf(IPermission target) { }

	public override bool IsUnrestricted() { }

	public void set_Flags(SecurityPermissionFlag value) { }

	public virtual SecurityElement ToXml() { }

}

