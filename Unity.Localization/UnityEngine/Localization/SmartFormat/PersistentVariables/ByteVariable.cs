namespace UnityEngine.Localization.SmartFormat.PersistentVariables;

[DisplayName("Byte", null)]
[UxmlObject]
public class ByteVariable : Variable<Byte>
{
	[CompilerGenerated]
	[DisplayName("Byte", null)]
	internal class UxmlSerializedData : UxmlSerializedData<Byte>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public ByteVariable() { }

}

