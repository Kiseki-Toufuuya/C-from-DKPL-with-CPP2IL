namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsField : BaseField<Bounds>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Bounds>
	{
		private UxmlFloatAttributeDescription m_CenterXValue; //Field offset: 0x4C
		private UxmlFloatAttributeDescription m_CenterYValue; //Field offset: 0x50
		private UxmlFloatAttributeDescription m_CenterZValue; //Field offset: 0x54
		private UxmlFloatAttributeDescription m_ExtentsXValue; //Field offset: 0x58
		private UxmlFloatAttributeDescription m_ExtentsYValue; //Field offset: 0x5C
		private UxmlFloatAttributeDescription m_ExtentsZValue; //Field offset: 0x60

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x4
	public static readonly string inputUssClassName; //Field offset: 0x8
	public static readonly string centerFieldUssClassName; //Field offset: 0xC
	public static readonly string extentsFieldUssClassName; //Field offset: 0x10
	private Vector3Field m_CenterField; //Field offset: 0x3C8
	private Vector3Field m_ExtentsField; //Field offset: 0x3CC

	private static BoundsField() { }

	public BoundsField() { }

	public BoundsField(string label) { }

	[CompilerGenerated]
	private void <.ctor>b__11_0(ChangeEvent<Vector3> e) { }

	[CompilerGenerated]
	private void <.ctor>b__11_1(ChangeEvent<Vector3> e) { }

	public virtual void SetValueWithoutNotify(Bounds newValue) { }

	protected virtual void UpdateMixedValueContent() { }

}

