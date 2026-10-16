namespace System.Reflection;

[ComVisible(True)]
public class CustomAttributeData
{
	private class LazyCAttrData
	{
		internal Assembly assembly; //Field offset: 0x8
		internal IntPtr data; //Field offset: 0xC
		internal uint data_length; //Field offset: 0x10

		public LazyCAttrData() { }

	}

	private ConstructorInfo ctorInfo; //Field offset: 0x8
	private IList<CustomAttributeTypedArgument> ctorArgs; //Field offset: 0xC
	private IList<CustomAttributeNamedArgument> namedArgs; //Field offset: 0x10
	private LazyCAttrData lazyData; //Field offset: 0x14

	public Type AttributeType
	{
		 get { } //Length: 40
	}

	[ComVisible(True)]
	public override ConstructorInfo Constructor
	{
		 get { } //Length: 11
	}

	[ComVisible(True)]
	public override IList<CustomAttributeTypedArgument> ConstructorArguments
	{
		 get { } //Length: 24
	}

	public override IList<CustomAttributeNamedArgument> NamedArguments
	{
		 get { } //Length: 24
	}

	protected CustomAttributeData() { }

	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	internal CustomAttributeData(ConstructorInfo ctorInfo) { }

	internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	public virtual bool Equals(object obj) { }

	public Type get_AttributeType() { }

	public override ConstructorInfo get_Constructor() { }

	public override IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	public override IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	public virtual int GetHashCode() { }

	private void ResolveArguments() { }

	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Object[] ctorArgs, out Object[] namedArgs) { }

	public virtual string ToString() { }

	private static T[] UnboxValues(Object[] values) { }

}

