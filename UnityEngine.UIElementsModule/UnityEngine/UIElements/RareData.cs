namespace UnityEngine.UIElements;

internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
{
	public Cursor cursor; //Field offset: 0x0
	public TextOverflow textOverflow; //Field offset: 0x10
	public Color unityBackgroundImageTintColor; //Field offset: 0x14
	public OverflowClipBox unityOverflowClipBox; //Field offset: 0x24
	public int unitySliceBottom; //Field offset: 0x28
	public int unitySliceLeft; //Field offset: 0x2C
	public int unitySliceRight; //Field offset: 0x30
	public float unitySliceScale; //Field offset: 0x34
	public int unitySliceTop; //Field offset: 0x38
	public SliceType unitySliceType; //Field offset: 0x3C
	public TextOverflowPosition unityTextOverflowPosition; //Field offset: 0x40

	public override RareData Copy() { }

	public override void CopyFrom(ref RareData other) { }

	public override bool Equals(RareData other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RareData lhs, RareData rhs) { }

}

