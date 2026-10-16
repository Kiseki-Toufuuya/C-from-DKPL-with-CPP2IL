namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Unsigned Long", null)]
[UxmlObject]
public class ULongVariable : Variable<UInt64>
{
	[CompilerGenerated]
	[DisplayName("Unsigned Long", null)]
	internal class UxmlSerializedData : UxmlSerializedData<UInt64>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public ULongVariable() { }

}

