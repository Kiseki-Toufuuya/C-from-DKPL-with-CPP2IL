namespace Live2D.Cubism.Framework.Json;

public sealed class CubismDisplayInfo3Json
{
	internal struct CombinedParameter
	{
		[SerializeField]
		public string HorizontalParameterId; //Field offset: 0x0
		[SerializeField]
		public string VerticalParameterId; //Field offset: 0x4

	}

	internal struct SerializableCombinedParameterIds
	{
		[SerializeField]
		public String[] Ids; //Field offset: 0x0

	}

	internal struct SerializableParameterGroups
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public string GroupId; //Field offset: 0x4
		[SerializeField]
		public string Name; //Field offset: 0x8

	}

	internal struct SerializableParameters
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public string GroupId; //Field offset: 0x4
		[SerializeField]
		public string Name; //Field offset: 0x8

	}

	internal struct SerializableParts
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public string Name; //Field offset: 0x4

	}

	[SerializeField]
	public int Version; //Field offset: 0x8
	[SerializeField]
	public SerializableParameters[] Parameters; //Field offset: 0xC
	[SerializeField]
	public SerializableParameterGroups[] ParameterGroups; //Field offset: 0x10
	[SerializeField]
	public SerializableParts[] Parts; //Field offset: 0x14
	[SerializeField]
	public SerializableCombinedParameterIds[] CombinedParameters; //Field offset: 0x18

	public CubismDisplayInfo3Json() { }

	public static CubismDisplayInfo3Json LoadFrom(string cdi3Json) { }

}

