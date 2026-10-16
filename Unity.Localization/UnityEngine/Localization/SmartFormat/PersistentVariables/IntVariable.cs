namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Integer", null)]
[UxmlObject]
public class IntVariable : Variable<Int32>
{
	[CompilerGenerated]
	[DisplayName("Integer", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Int32>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public IntVariable() { }

}

