namespace System.Security;

[AttributeUsage(5501, AllowMultiple = False, Inherited = False)]
[Obsolete("SecurityTreatAsSafe is only used for .NET 2.0 transparency compatibility.  Please use the SecuritySafeCriticalAttribute instead.")]
public sealed class SecurityTreatAsSafeAttribute : Attribute
{

	public SecurityTreatAsSafeAttribute() { }

}

