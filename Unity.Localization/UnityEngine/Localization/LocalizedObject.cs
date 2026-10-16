namespace UnityEngine.Localization;

[UxmlObject]
public class LocalizedObject : LocalizedAsset<Object>
{
	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData<Object>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public LocalizedObject() { }

}

