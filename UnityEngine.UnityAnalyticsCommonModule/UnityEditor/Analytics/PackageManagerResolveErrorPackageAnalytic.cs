namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class PackageManagerResolveErrorPackageAnalytic : PackageManagerBaseAnalytic
{
	public string reason; //Field offset: 0x38
	public string action; //Field offset: 0x3C

	public PackageManagerResolveErrorPackageAnalytic() { }

	[RequiredByNativeCode]
	internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic() { }

}

