namespace UnityEngine.UIElements;

public class ListView : BaseListView
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlAssetAttributeDescription<VisualTreeAsset> m_ItemTemplate; //Field offset: 0x84

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId itemTemplateProperty; //Field offset: 0x0
	internal static readonly BindingId makeItemProperty; //Field offset: 0x4C
	internal static readonly BindingId bindItemProperty; //Field offset: 0x98
	internal static readonly BindingId unbindItemProperty; //Field offset: 0xE4
	internal static readonly BindingId destroyItemProperty; //Field offset: 0x130
	private Func<VisualElement> m_MakeItem; //Field offset: 0x490
	private Func<VisualElement> m_TemplateMakeItem; //Field offset: 0x494
	private VisualTreeAsset m_ItemTemplate; //Field offset: 0x498
	private Action<VisualElement, Int32> m_BindItem; //Field offset: 0x49C
	private Action<VisualElement, Int32> m_UnbindItem; //Field offset: 0x4A0
	private Action<VisualElement> m_DestroyItem; //Field offset: 0x4A4

	[CreateProperty]
	public Action<VisualElement, Int32> bindItem
	{
		 get { } //Length: 14
		 set { } //Length: 140
	}

	[CreateProperty]
	public Action<VisualElement> destroyItem
	{
		 get { } //Length: 14
		 set { } //Length: 132
	}

	[CreateProperty]
	public VisualTreeAsset itemTemplate
	{
		 get { } //Length: 14
		 set { } //Length: 331
	}

	[CreateProperty]
	public Func<VisualElement> makeItem
	{
		 get { } //Length: 14
		 set { } //Length: 138
	}

	[CreateProperty]
	public Action<VisualElement, Int32> unbindItem
	{
		 get { } //Length: 14
		 set { } //Length: 132
	}

	private static ListView() { }

	public ListView() { }

	protected virtual CollectionViewController CreateViewController() { }

	public Action<VisualElement, Int32> get_bindItem() { }

	public Action<VisualElement> get_destroyItem() { }

	public VisualTreeAsset get_itemTemplate() { }

	public Func<VisualElement> get_makeItem() { }

	public Action<VisualElement, Int32> get_unbindItem() { }

	internal virtual bool HasValidDataAndBindings() { }

	public void set_bindItem(Action<VisualElement, Int32> value) { }

	public void set_destroyItem(Action<VisualElement> value) { }

	public void set_itemTemplate(VisualTreeAsset value) { }

	public void set_makeItem(Func<VisualElement> value) { }

	public void set_unbindItem(Action<VisualElement, Int32> value) { }

	private VisualElement TemplateMakeItem() { }

}

