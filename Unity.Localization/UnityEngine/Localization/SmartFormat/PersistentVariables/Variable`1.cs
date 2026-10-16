namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[UxmlObject]
public class Variable : IVariableValueChanged, IVariable
{
	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData
	{
		[SerializeField]
		[UxmlAttribute("value")]
		private T ValueUXML; //Field offset: 0x0
		[HideInInspector]
		[SerializeField]
		[UxmlIgnore]
		private UxmlAttributeFlags ValueUXML_UxmlAttributeFlags; //Field offset: 0x0

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		public virtual void Deserialize(object obj) { }

		[Conditional("UNITY_EDITOR")]
		public static void Register() { }

	}

	[SerializeField]
	private T m_Value; //Field offset: 0x0
	[CompilerGenerated]
	private Action<IVariable> ValueChanged; //Field offset: 0x0

	public override event Action<IVariable> ValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public T Value
	{
		 get { } //Length: 11
		 set { } //Length: 121
	}

	[UxmlAttribute("value")]
	public T ValueUXML
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	public Variable`1() { }

	[CompilerGenerated]
	public override void add_ValueChanged(Action<IVariable> value) { }

	public T get_Value() { }

	public T get_ValueUXML() { }

	public override object GetSourceValue(ISelectorInfo _) { }

	[CompilerGenerated]
	public override void remove_ValueChanged(Action<IVariable> value) { }

	private void SendValueChangedEvent() { }

	public void set_Value(T value) { }

	public void set_ValueUXML(T value) { }

	public virtual string ToString() { }

}

