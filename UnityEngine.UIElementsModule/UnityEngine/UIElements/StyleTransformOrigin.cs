namespace UnityEngine.UIElements;

public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
{
	private TransformOrigin m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x14

	public override StyleKeyword keyword
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override TransformOrigin value
	{
		 get { } //Length: 140
		 set { } //Length: 28
	}

	public StyleTransformOrigin(TransformOrigin v) { }

	public StyleTransformOrigin(StyleKeyword keyword) { }

	internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword) { }

	public override bool Equals(StyleTransformOrigin other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override TransformOrigin get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	public static StyleTransformOrigin op_Implicit(TransformOrigin v) { }

	public override void set_keyword(StyleKeyword value) { }

	public override void set_value(TransformOrigin value) { }

	public virtual string ToString() { }

}

