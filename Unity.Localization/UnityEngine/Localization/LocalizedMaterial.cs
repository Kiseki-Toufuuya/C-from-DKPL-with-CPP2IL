namespace UnityEngine.Localization;

[UxmlObject]
public class LocalizedMaterial : LocalizedAsset<Material>
{
	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData<Material>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public LocalizedMaterial() { }

}

