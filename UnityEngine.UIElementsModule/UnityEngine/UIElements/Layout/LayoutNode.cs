namespace UnityEngine.UIElements.Layout;

[DefaultMember("Item")]
internal struct LayoutNode : IEquatable<LayoutNode>
{
	private const int k_DefaultChildCapacity = 4; //Field offset: 0x0
	private readonly LayoutDataAccess m_Access; //Field offset: 0x0
	private readonly LayoutHandle m_Handle; //Field offset: 0x14

	public LayoutAlign AlignContent
	{
		 set { } //Length: 65
	}

	public LayoutAlign AlignItems
	{
		 set { } //Length: 65
	}

	public LayoutAlign AlignSelf
	{
		 set { } //Length: 65
	}

	public LayoutBaselineFunction Baseline
	{
		 get { } //Length: 25
	}

	public float BorderBottomWidth
	{
		 set { } //Length: 82
	}

	public float BorderLeftWidth
	{
		 set { } //Length: 82
	}

	public float BorderRightWidth
	{
		 set { } //Length: 82
	}

	public float BorderTopWidth
	{
		 set { } //Length: 82
	}

	public LayoutValue Bottom
	{
		 set { } //Length: 26
	}

	private LayoutList<LayoutHandle> Children
	{
		private get { } //Length: 31
	}

	public float ComputedFlexBasis
	{
		 get { } //Length: 28
	}

	public LayoutConfig Config
	{
		 set { } //Length: 37
	}

	public int Count
	{
		 get { } //Length: 153
	}

	public LayoutDisplay Display
	{
		 set { } //Length: 65
	}

	public LayoutValue FlexBasis
	{
		 set { } //Length: 45
	}

	public LayoutFlexDirection FlexDirection
	{
		 set { } //Length: 65
	}

	public float FlexGrow
	{
		 set { } //Length: 78
	}

	public float FlexShrink
	{
		 set { } //Length: 78
	}

	public LayoutHandle Handle
	{
		 get { } //Length: 14
	}

	public bool HasNewLayout
	{
		 get { } //Length: 33
		 set { } //Length: 46
	}

	public LayoutValue Height
	{
		 set { } //Length: 76
	}

	public bool IsDirty
	{
		 get { } //Length: 30
		 set { } //Length: 46
	}

	public bool IsMeasureDefined
	{
		 get { } //Length: 32
	}

	public bool IsUndefined
	{
		 get { } //Length: 26
	}

	public LayoutJustify JustifyContent
	{
		 set { } //Length: 65
	}

	public LayoutComputedData Layout
	{
		 get { } //Length: 25
	}

	public float LayoutBorderBottom
	{
		 get { } //Length: 34
	}

	public float LayoutBorderLeft
	{
		 get { } //Length: 81
	}

	public float LayoutBorderRight
	{
		 get { } //Length: 81
	}

	public float LayoutBorderTop
	{
		 get { } //Length: 34
	}

	public float LayoutBottom
	{
		 get { } //Length: 28
	}

	public float LayoutHeight
	{
		 get { } //Length: 28
	}

	public float LayoutMarginBottom
	{
		 get { } //Length: 34
	}

	public float LayoutMarginLeft
	{
		 get { } //Length: 81
	}

	public float LayoutMarginRight
	{
		 get { } //Length: 81
	}

	public float LayoutMarginTop
	{
		 get { } //Length: 34
	}

	public float LayoutPaddingBottom
	{
		 get { } //Length: 34
	}

	public float LayoutPaddingLeft
	{
		 get { } //Length: 81
	}

	public float LayoutPaddingRight
	{
		 get { } //Length: 81
	}

	public float LayoutPaddingTop
	{
		 get { } //Length: 34
	}

	public float LayoutRight
	{
		 get { } //Length: 28
	}

	public float LayoutWidth
	{
		 get { } //Length: 28
	}

	public float LayoutX
	{
		 get { } //Length: 27
	}

	public float LayoutY
	{
		 get { } //Length: 28
	}

	public LayoutValue Left
	{
		 set { } //Length: 26
	}

	public LayoutValue MarginBottom
	{
		 set { } //Length: 26
	}

	public LayoutValue MarginLeft
	{
		 set { } //Length: 26
	}

	public LayoutValue MarginRight
	{
		 set { } //Length: 26
	}

	public LayoutValue MarginTop
	{
		 set { } //Length: 26
	}

	public LayoutValue MaxHeight
	{
		 set { } //Length: 96
	}

	public LayoutValue MaxWidth
	{
		 set { } //Length: 96
	}

	public LayoutMeasureFunction Measure
	{
		 get { } //Length: 25
		 set { } //Length: 28
	}

	public LayoutValue MinHeight
	{
		 set { } //Length: 96
	}

	public LayoutValue MinWidth
	{
		 set { } //Length: 96
	}

	public LayoutOverflow Overflow
	{
		 set { } //Length: 65
	}

	public LayoutValue PaddingBottom
	{
		 set { } //Length: 26
	}

	public LayoutValue PaddingLeft
	{
		 set { } //Length: 26
	}

	public LayoutValue PaddingRight
	{
		 set { } //Length: 26
	}

	public LayoutValue PaddingTop
	{
		 set { } //Length: 26
	}

	public LayoutNode Parent
	{
		 get { } //Length: 71
		 set { } //Length: 37
	}

	public LayoutPositionType PositionType
	{
		 set { } //Length: 65
	}

	public LayoutValue Right
	{
		 set { } //Length: 26
	}

	public LayoutStyleData Style
	{
		 get { } //Length: 25
	}

	public LayoutValue Top
	{
		 set { } //Length: 26
	}

	public static LayoutNode Undefined
	{
		 get { } //Length: 35
	}

	public LayoutValue Width
	{
		 set { } //Length: 76
	}

	public LayoutWrap Wrap
	{
		 set { } //Length: 65
	}

	internal LayoutNode(LayoutDataAccess access, LayoutHandle handle) { }

	public void CalculateLayout(float width = NaN, float height = NaN) { }

	public void Clear() { }

	public void CopyFromComputedStyle(ComputedStyle style) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(LayoutNode other) { }

	public LayoutBaselineFunction get_Baseline() { }

	private LayoutList<LayoutHandle> get_Children() { }

	public float get_ComputedFlexBasis() { }

	public int get_Count() { }

	public LayoutHandle get_Handle() { }

	public bool get_HasNewLayout() { }

	public bool get_IsDirty() { }

	public bool get_IsMeasureDefined() { }

	public bool get_IsUndefined() { }

	public LayoutComputedData get_Layout() { }

	public float get_LayoutBorderBottom() { }

	public float get_LayoutBorderLeft() { }

	public float get_LayoutBorderRight() { }

	public float get_LayoutBorderTop() { }

	public float get_LayoutBottom() { }

	public float get_LayoutHeight() { }

	public float get_LayoutMarginBottom() { }

	public float get_LayoutMarginLeft() { }

	public float get_LayoutMarginRight() { }

	public float get_LayoutMarginTop() { }

	public float get_LayoutPaddingBottom() { }

	public float get_LayoutPaddingLeft() { }

	public float get_LayoutPaddingRight() { }

	public float get_LayoutPaddingTop() { }

	public float get_LayoutRight() { }

	public float get_LayoutWidth() { }

	public float get_LayoutX() { }

	public float get_LayoutY() { }

	public LayoutMeasureFunction get_Measure() { }

	public LayoutNode get_Parent() { }

	public LayoutStyleData get_Style() { }

	public static LayoutNode get_Undefined() { }

	public virtual int GetHashCode() { }

	private float GetLayoutValue(Single* buffer, LayoutEdge edge) { }

	public VisualElement GetOwner() { }

	public void Insert(int index, LayoutNode child) { }

	public void MarkDirty() { }

	public void MarkLayoutSeen() { }

	public void RemoveAt(int index) { }

	public void set_AlignContent(LayoutAlign value) { }

	public void set_AlignItems(LayoutAlign value) { }

	public void set_AlignSelf(LayoutAlign value) { }

	public void set_BorderBottomWidth(float value) { }

	public void set_BorderLeftWidth(float value) { }

	public void set_BorderRightWidth(float value) { }

	public void set_BorderTopWidth(float value) { }

	public void set_Bottom(LayoutValue value) { }

	public void set_Config(LayoutConfig value) { }

	public void set_Display(LayoutDisplay value) { }

	public void set_FlexBasis(LayoutValue value) { }

	public void set_FlexDirection(LayoutFlexDirection value) { }

	public void set_FlexGrow(float value) { }

	public void set_FlexShrink(float value) { }

	public void set_HasNewLayout(bool value) { }

	public void set_Height(LayoutValue value) { }

	public void set_IsDirty(bool value) { }

	public void set_JustifyContent(LayoutJustify value) { }

	public void set_Left(LayoutValue value) { }

	public void set_MarginBottom(LayoutValue value) { }

	public void set_MarginLeft(LayoutValue value) { }

	public void set_MarginRight(LayoutValue value) { }

	public void set_MarginTop(LayoutValue value) { }

	public void set_MaxHeight(LayoutValue value) { }

	public void set_MaxWidth(LayoutValue value) { }

	public void set_Measure(LayoutMeasureFunction value) { }

	public void set_MinHeight(LayoutValue value) { }

	public void set_MinWidth(LayoutValue value) { }

	public void set_Overflow(LayoutOverflow value) { }

	public void set_PaddingBottom(LayoutValue value) { }

	public void set_PaddingLeft(LayoutValue value) { }

	public void set_PaddingRight(LayoutValue value) { }

	public void set_PaddingTop(LayoutValue value) { }

	public void set_Parent(LayoutNode value) { }

	public void set_PositionType(LayoutPositionType value) { }

	public void set_Right(LayoutValue value) { }

	public void set_Top(LayoutValue value) { }

	public void set_Width(LayoutValue value) { }

	public void set_Wrap(LayoutWrap value) { }

	public void SetOwner(VisualElement func) { }

	private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value) { }

	private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value) { }

	private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value) { }

	private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue) { }

	private void SetStyleValueAuto(ref LayoutValue currentValue) { }

	private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue) { }

	private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue) { }

	private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue) { }

	private void SetValue(ref float currentValue, float newValue) { }

	public void SoftReset() { }

	private void StyleEdgeSetAuto(ref LayoutValue value) { }

	private void StyleEdgeSetPercent(ref LayoutValue value, float newValue) { }

	private void StyleEdgeSetPoint(ref LayoutValue value, float newValue) { }

}

