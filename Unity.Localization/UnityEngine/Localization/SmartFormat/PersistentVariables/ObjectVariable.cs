namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Object Reference", null)]
[UxmlObject]
public class ObjectVariable : Variable<Object>
{
	[CompilerGenerated]
	[DisplayName("Object Reference", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Object>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public ObjectVariable() { }

}

