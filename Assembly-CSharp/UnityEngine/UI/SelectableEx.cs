namespace UnityEngine.UI;

public class SelectableEx : Selectable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameObject, Boolean> <>9__4_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <ApplyInactiveSkip>b__4_0(GameObject gameObject) { }

	}

	public Action<BaseEventData> onSelect; //Field offset: 0xB4
	public Action<BaseEventData> onDeselect; //Field offset: 0xB8
	public UIWrapperButton button; //Field offset: 0xBC
	public Func<GameObject, Boolean> canSelect; //Field offset: 0xC0

	public SelectableEx() { }

	public void ApplyInactiveSkip() { }

	private static bool CanSelect(Selectable selectable) { }

	public virtual Selectable FindSelectableOnDown() { }

	public virtual Selectable FindSelectableOnLeft() { }

	public virtual Selectable FindSelectableOnRight() { }

	public virtual Selectable FindSelectableOnUp() { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnMove(AxisEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

}

