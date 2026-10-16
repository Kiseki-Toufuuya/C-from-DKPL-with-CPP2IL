namespace XeSys.Gfx;

public class LayoutUGUIScrollSupport : UGUIScrollSupportBase, ILayoutUGUIInitializeFromLayout
{
	private ScrollView m_scrollView; //Field offset: 0x24

	public LayoutUGUIScrollSupport() { }

	public virtual void AddView(GameObject obj, float offsetX, float offsetY) { }

	public override bool InitializeFromLayout(Layout layout, TexUVListManager[] uvManList) { }

	public virtual void RemoveView(int childIndex, bool isDestroy) { }

}

