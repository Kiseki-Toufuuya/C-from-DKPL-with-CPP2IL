namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Short", null)]
[UxmlObject]
public class ShortVariable : Variable<Int16>
{
	[CompilerGenerated]
	[DisplayName("Short", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Int16>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public ShortVariable() { }

}

