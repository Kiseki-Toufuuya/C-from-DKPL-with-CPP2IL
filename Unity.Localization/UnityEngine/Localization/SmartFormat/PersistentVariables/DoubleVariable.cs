namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Double", null)]
[UxmlObject]
public class DoubleVariable : Variable<Double>
{
	[CompilerGenerated]
	[DisplayName("Double", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Double>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public DoubleVariable() { }

}

