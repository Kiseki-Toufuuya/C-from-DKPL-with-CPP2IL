namespace UnityEngine.Localization;

[UxmlObject]
public class LocalizedGameObject : LocalizedAsset<GameObject>
{
	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData<GameObject>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public LocalizedGameObject() { }

}

