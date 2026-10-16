namespace UnityEngine.ResourceManagement.Util;

public struct SerializedType
{
	[FormerlySerializedAs("m_assemblyName")]
	[SerializeField]
	private string m_AssemblyName; //Field offset: 0x0
	[FormerlySerializedAs("m_className")]
	[SerializeField]
	private string m_ClassName; //Field offset: 0x4
	private Type m_CachedType; //Field offset: 0x8
	[CompilerGenerated]
	private bool <ValueChanged>k__BackingField; //Field offset: 0xC

	public string AssemblyName
	{
		 get { } //Length: 10
	}

	public string ClassName
	{
		 get { } //Length: 11
	}

	public Type Value
	{
		 get { } //Length: 436
		 set { } //Length: 186
	}

	public bool ValueChanged
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string get_AssemblyName() { }

	public string get_ClassName() { }

	public Type get_Value() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_ValueChanged() { }

	public void set_Value(Type value) { }

	[CompilerGenerated]
	public void set_ValueChanged(bool value) { }

	public virtual string ToString() { }

}

