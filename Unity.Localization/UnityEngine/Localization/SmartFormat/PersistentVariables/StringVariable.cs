namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("String", null)]
[UxmlObject]
public class StringVariable : Variable<String>
{
	[CompilerGenerated]
	[DisplayName("String", null)]
	internal class UxmlSerializedData : UxmlSerializedData<String>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public StringVariable() { }

}

