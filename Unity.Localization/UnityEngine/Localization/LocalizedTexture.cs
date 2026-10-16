namespace UnityEngine.Localization;

[UxmlObject]
public class LocalizedTexture : LocalizedAsset<Texture>
{
	[CompilerGenerated]
	internal class UxmlSerializedData : UxmlSerializedData<Texture>
	{

		public UxmlSerializedData() { }

		public virtual object CreateInstance() { }

		[Conditional("UNITY_EDITOR")]
		[RegisterUxmlCache]
		public static void Register() { }

	}


	public LocalizedTexture() { }

	protected virtual BindingResult ApplyDataBindingValue(in BindingContext context, Texture value) { }

}

