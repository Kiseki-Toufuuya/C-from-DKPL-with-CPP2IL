namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic
{
	public String[] packages; //Field offset: 0x38
	public String[] package_registries; //Field offset: 0x3C
	public String[] package_signatures; //Field offset: 0x40
	public String[] package_sources; //Field offset: 0x44
	public String[] package_types; //Field offset: 0x48
	public String[] package_compliance_statuses; //Field offset: 0x4C

	public PackageManagerResolvePackageAnalytic() { }

	[RequiredByNativeCode]
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }

}

