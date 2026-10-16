namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Float", null)]
[UxmlObject]
public class FloatVariable : Variable<Single>
{
	[CompilerGenerated]
	[DisplayName("Float", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Single>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public FloatVariable() { }

}

