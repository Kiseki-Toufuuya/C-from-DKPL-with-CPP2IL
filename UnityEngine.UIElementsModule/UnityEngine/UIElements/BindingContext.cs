namespace UnityEngine.UIElements;

[IsReadOnly]
public struct BindingContext
{
	private readonly VisualElement m_TargetElement; //Field offset: 0x0
	private readonly BindingId m_BindingId; //Field offset: 0x4
	private readonly PropertyPath m_DataSourcePath; //Field offset: 0x50
	private readonly object m_DataSource; //Field offset: 0x98

	public BindingId bindingId
	{
		 get { } //Length: 58
	}

	public object dataSource
	{
		 get { } //Length: 14
	}

	public PropertyPath dataSourcePath
	{
		 get { } //Length: 58
	}

	public VisualElement targetElement
	{
		 get { } //Length: 10
	}

	internal BindingContext(VisualElement targetElement, in BindingId bindingId, in PropertyPath resolvedDataSourcePath, object resolvedDataSource) { }

	public BindingId get_bindingId() { }

	public object get_dataSource() { }

	public PropertyPath get_dataSourcePath() { }

	public VisualElement get_targetElement() { }

}

