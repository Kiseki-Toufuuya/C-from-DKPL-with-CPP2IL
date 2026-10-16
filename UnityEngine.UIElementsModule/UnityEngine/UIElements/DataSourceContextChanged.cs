namespace UnityEngine.UIElements;

[IsReadOnly]
public struct DataSourceContextChanged
{
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	private readonly BindingId m_BindingId; //Field offset: 0x4
	private readonly DataSourceContext m_PreviousContext; //Field offset: 0x50
	private readonly DataSourceContext m_NewContext; //Field offset: 0x9C

	internal DataSourceContextChanged(VisualElement element, in BindingId bindingId, in DataSourceContext previousContext, in DataSourceContext newContext) { }

}

