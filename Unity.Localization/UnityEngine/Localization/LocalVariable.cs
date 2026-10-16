namespace UnityEngine.Localization;

[UxmlObject]
internal class LocalVariable
{
	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData
	{
		[SerializeReference]
		[UxmlObjectReference]
		private UxmlSerializedData Variable; //Field offset: 0xC
		[SerializeField]
		private string Name; //Field offset: 0x10
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags Variable_UxmlAttributeFlags; //Field offset: 0x14
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags Name_UxmlAttributeFlags; //Field offset: 0x15

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		public virtual void Deserialize(object obj) { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}

	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private IVariable <Variable>k__BackingField; //Field offset: 0xC

	[UxmlAttribute]
	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	[UxmlObjectReference]
	public IVariable Variable
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public LocalVariable() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public IVariable get_Variable() { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Variable(IVariable value) { }

}

