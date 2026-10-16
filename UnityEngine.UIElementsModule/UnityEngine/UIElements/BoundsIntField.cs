namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsIntField : BaseField<BoundsInt>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<BoundsIntField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<BoundsInt>
	{
		private UxmlIntAttributeDescription m_PositionXValue; //Field offset: 0x4C
		private UxmlIntAttributeDescription m_PositionYValue; //Field offset: 0x50
		private UxmlIntAttributeDescription m_PositionZValue; //Field offset: 0x54
		private UxmlIntAttributeDescription m_SizeXValue; //Field offset: 0x58
		private UxmlIntAttributeDescription m_SizeYValue; //Field offset: 0x5C
		private UxmlIntAttributeDescription m_SizeZValue; //Field offset: 0x60

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x4
	public static readonly string inputUssClassName; //Field offset: 0x8
	public static readonly string positionUssClassName; //Field offset: 0xC
	public static readonly string sizeUssClassName; //Field offset: 0x10
	private Vector3IntField m_PositionField; //Field offset: 0x3C8
	private Vector3IntField m_SizeField; //Field offset: 0x3CC

	private static BoundsIntField() { }

	public BoundsIntField() { }

	public BoundsIntField(string label) { }

	[CompilerGenerated]
	private void <.ctor>b__11_0(ChangeEvent<Vector3Int> e) { }

	[CompilerGenerated]
	private void <.ctor>b__11_1(ChangeEvent<Vector3Int> e) { }

	public virtual void SetValueWithoutNotify(BoundsInt newValue) { }

	protected virtual void UpdateMixedValueContent() { }

}

