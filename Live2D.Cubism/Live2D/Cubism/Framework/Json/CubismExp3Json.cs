namespace Live2D.Cubism.Framework.Json;

public sealed class CubismExp3Json
{
	internal struct SerializableExpressionParameter
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public float Value; //Field offset: 0x4
		[SerializeField]
		public string Blend; //Field offset: 0x8

	}

	[SerializeField]
	public string Type; //Field offset: 0x8
	[SerializeField]
	public float FadeInTime; //Field offset: 0xC
	[SerializeField]
	public float FadeOutTime; //Field offset: 0x10
	[SerializeField]
	public SerializableExpressionParameter[] Parameters; //Field offset: 0x14

	public CubismExp3Json() { }

	public static CubismExp3Json LoadFrom(TextAsset exp3JsonAsset) { }

	public static CubismExp3Json LoadFrom(string exp3Json) { }

}

