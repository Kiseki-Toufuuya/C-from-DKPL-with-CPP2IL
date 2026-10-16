namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Unsigned Short", null)]
[UxmlObject]
public class UShortVariable : Variable<UInt16>
{
	[CompilerGenerated]
	[DisplayName("Unsigned Short", null)]
	internal class UxmlSerializedData : UxmlSerializedData<UInt16>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public UShortVariable() { }

}

