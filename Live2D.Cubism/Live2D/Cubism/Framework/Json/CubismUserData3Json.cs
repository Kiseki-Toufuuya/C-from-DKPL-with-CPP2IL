namespace Live2D.Cubism.Framework.Json;

public sealed class CubismUserData3Json
{
	internal struct SerializableMeta
	{
		[SerializeField]
		public int UserDataCount; //Field offset: 0x0
		[SerializeField]
		public int TotalUserDataCount; //Field offset: 0x4

	}

	internal struct SerializableUserData
	{
		[SerializeField]
		public string Target; //Field offset: 0x0
		[SerializeField]
		public string Id; //Field offset: 0x4
		[SerializeField]
		public string Value; //Field offset: 0x8

	}

	[SerializeField]
	public int Version; //Field offset: 0x8
	[SerializeField]
	public SerializableMeta Meta; //Field offset: 0xC
	[SerializeField]
	public SerializableUserData[] UserData; //Field offset: 0x14

	public CubismUserData3Json() { }

	public static CubismUserData3Json LoadFrom(string userData3Json) { }

	public static CubismUserData3Json LoadFrom(TextAsset userData3JsonAsset) { }

	public CubismUserDataBody[] ToBodyArray(CubismUserDataTargetType targetType) { }

}

