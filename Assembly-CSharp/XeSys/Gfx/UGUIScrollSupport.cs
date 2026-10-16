namespace XeSys.Gfx;

public class UGUIScrollSupport : UGUIScrollSupportBase
{

	public UGUIScrollSupport() { }

	public virtual void AddView(GameObject obj, float offsetX, float offsetY) { }

	public virtual void RemoveView(int childIndex, bool isDestroy) { }

}

