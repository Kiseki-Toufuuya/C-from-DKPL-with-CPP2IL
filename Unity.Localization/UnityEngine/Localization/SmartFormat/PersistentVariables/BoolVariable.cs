namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Boolean", null)]
[UxmlObject]
public class BoolVariable : Variable<Boolean>
{
	[CompilerGenerated]
	[DisplayName("Boolean", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Boolean>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public BoolVariable() { }

}

