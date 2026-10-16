namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Unsigned Integer", null)]
[UxmlObject]
public class UIntVariable : Variable<UInt32>
{
	[CompilerGenerated]
	[DisplayName("Unsigned Integer", null)]
	internal class UxmlSerializedData : UxmlSerializedData<UInt32>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public UIntVariable() { }

}

