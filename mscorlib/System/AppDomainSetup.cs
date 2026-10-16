namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
public sealed class AppDomainSetup
{
	private string application_base; //Field offset: 0x8
	private string application_name; //Field offset: 0xC
	private string cache_path; //Field offset: 0x10
	private string configuration_file; //Field offset: 0x14
	private string dynamic_base; //Field offset: 0x18
	private string license_file; //Field offset: 0x1C
	private string private_bin_path; //Field offset: 0x20
	private string private_bin_path_probe; //Field offset: 0x24
	private string shadow_copy_directories; //Field offset: 0x28
	private string shadow_copy_files; //Field offset: 0x2C
	private bool publisher_policy; //Field offset: 0x30
	private bool path_changed; //Field offset: 0x31
	private int loader_optimization; //Field offset: 0x34
	private bool disallow_binding_redirects; //Field offset: 0x38
	private bool disallow_code_downloads; //Field offset: 0x39
	private object _activationArguments; //Field offset: 0x3C
	private object domain_initializer; //Field offset: 0x40
	private object application_trust; //Field offset: 0x44
	private String[] domain_initializer_args; //Field offset: 0x48
	private bool disallow_appbase_probe; //Field offset: 0x4C
	private Byte[] configuration_bytes; //Field offset: 0x50
	private Byte[] serialized_non_primitives; //Field offset: 0x54
	private string manager_assembly; //Field offset: 0x58
	private string manager_type; //Field offset: 0x5C
	private String[] partial_visible_assemblies; //Field offset: 0x60
	[CompilerGenerated]
	private string <TargetFrameworkName>k__BackingField; //Field offset: 0x64

	public AppDomainSetup() { }

}

