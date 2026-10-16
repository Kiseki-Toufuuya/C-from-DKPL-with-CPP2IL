namespace Live2D.Cubism.Framework.Json;

public sealed class CubismPose3Json
{
	internal struct SerializablePoseGroup
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public String[] Link; //Field offset: 0x4

	}

	[SerializeField]
	public string Type; //Field offset: 0x8
	[SerializeField]
	public float FadeInTime; //Field offset: 0xC
	[SerializeField]
	public SerializablePoseGroup[][] Groups; //Field offset: 0x10

	public CubismPose3Json() { }

	public static CubismPose3Json LoadFrom(TextAsset pose3JsonAsset) { }

	public static CubismPose3Json LoadFrom(string pose3Json) { }

}

