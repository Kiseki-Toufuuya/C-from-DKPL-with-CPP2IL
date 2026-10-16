namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Long", null)]
[UxmlObject]
public class LongVariable : Variable<Int64>
{
	[CompilerGenerated]
	[DisplayName("Long", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Int64>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public LongVariable() { }

}

