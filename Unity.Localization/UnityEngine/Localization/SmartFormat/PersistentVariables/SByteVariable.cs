namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Signed Byte", null)]
[UxmlObject]
public class SByteVariable : Variable<SByte>
{
	[CompilerGenerated]
	[DisplayName("Signed Byte", null)]
	internal class UxmlSerializedData : UxmlSerializedData<SByte>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public SByteVariable() { }

}

