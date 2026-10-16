namespace Live2D.Cubism.Framework.Json;

public sealed class CubismPhysics3Json
{
	internal struct PhysicsDictionaryItem
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public string Name; //Field offset: 0x4

	}

	internal struct SerializableEffectiveForces
	{
		[SerializeField]
		public SerializableVector2 Gravity; //Field offset: 0x0
		[SerializeField]
		public SerializableVector2 Wind; //Field offset: 0x8

	}

	internal struct SerializableInput
	{
		[SerializeField]
		public SerializableParameter Source; //Field offset: 0x0
		[SerializeField]
		public float Weight; //Field offset: 0x8
		[SerializeField]
		public string Type; //Field offset: 0xC
		[SerializeField]
		public bool Reflect; //Field offset: 0x10

	}

	internal struct SerializableMeta
	{
		[SerializeField]
		public int PhysicsSettingCount; //Field offset: 0x0
		[SerializeField]
		public int TotalInputCount; //Field offset: 0x4
		[SerializeField]
		public int TotalOutputCount; //Field offset: 0x8
		[SerializeField]
		public int TotalVertexCount; //Field offset: 0xC
		[SerializeField]
		public SerializableEffectiveForces EffectiveForces; //Field offset: 0x10
		[SerializeField]
		public float Fps; //Field offset: 0x20
		[SerializeField]
		public PhysicsDictionaryItem[] PhysicsDictionary; //Field offset: 0x24

	}

	internal struct SerializableNormalization
	{
		[SerializeField]
		public SerializableNormalizationValue Position; //Field offset: 0x0
		[SerializeField]
		public SerializableNormalizationValue Angle; //Field offset: 0xC

	}

	internal struct SerializableNormalizationValue
	{
		[SerializeField]
		public float Minimum; //Field offset: 0x0
		[SerializeField]
		public float Default; //Field offset: 0x4
		[SerializeField]
		public float Maximum; //Field offset: 0x8

	}

	internal struct SerializableOutput
	{
		[SerializeField]
		public SerializableParameter Destination; //Field offset: 0x0
		[SerializeField]
		public int VertexIndex; //Field offset: 0x8
		[SerializeField]
		public float Scale; //Field offset: 0xC
		[SerializeField]
		public float Weight; //Field offset: 0x10
		[SerializeField]
		public string Type; //Field offset: 0x14
		[SerializeField]
		public bool Reflect; //Field offset: 0x18

	}

	internal struct SerializableParameter
	{
		[SerializeField]
		public string Target; //Field offset: 0x0
		[SerializeField]
		public string Id; //Field offset: 0x4

	}

	internal struct SerializablePhysicsSettings
	{
		[SerializeField]
		public string Id; //Field offset: 0x0
		[SerializeField]
		public SerializableInput[] Input; //Field offset: 0x4
		[SerializeField]
		public SerializableOutput[] Output; //Field offset: 0x8
		[SerializeField]
		public SerializableVertex[] Vertices; //Field offset: 0xC
		[SerializeField]
		public SerializableNormalization Normalization; //Field offset: 0x10

	}

	internal struct SerializableVector2
	{
		[SerializeField]
		public float X; //Field offset: 0x0
		[SerializeField]
		public float Y; //Field offset: 0x4

	}

	internal struct SerializableVertex
	{
		[SerializeField]
		public SerializableVector2 Position; //Field offset: 0x0
		[SerializeField]
		public float Mobility; //Field offset: 0x8
		[SerializeField]
		public float Delay; //Field offset: 0xC
		[SerializeField]
		public float Acceleration; //Field offset: 0x10
		[SerializeField]
		public float Radius; //Field offset: 0x14

	}

	[SerializeField]
	public int Version; //Field offset: 0x8
	[SerializeField]
	public SerializableMeta Meta; //Field offset: 0xC
	[SerializeField]
	public SerializablePhysicsSettings[] PhysicsSettings; //Field offset: 0x34

	public CubismPhysics3Json() { }

	public static CubismPhysics3Json LoadFrom(string physics3Json) { }

	public static CubismPhysics3Json LoadFrom(TextAsset physics3JsonAsset) { }

	private CubismPhysicsInput[] ReadInput(SerializableInput[] source) { }

	private CubismPhysicsNormalization ReadNormalization(SerializableNormalization source) { }

	private CubismPhysicsOutput[] ReadOutput(SerializableOutput[] source) { }

	private CubismPhysicsParticle[] ReadParticles(SerializableVertex[] source) { }

	public CubismPhysicsRig ToRig() { }

}

