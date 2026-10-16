namespace XeSys.uGUI;

public abstract class uGUINoLayoutButton : uGUILayoutButtonBase
{
	private Int32[] m_ChgSliceIdxData; //Field offset: 0x40
	private IChgImageSlice m_ChgTexComponet; //Field offset: 0x44

	public IChgImageSlice ChgTexComponet
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public uGUINoLayoutButton(GameObject buttonHitObject, IChgImageSlice chgImage, Action onClick, bool isWaitClickAnim, Action<TouchInfo> onTouch, bool isDrag) { }

	public void ChgSlice(int idx) { }

	public virtual void Clear() { }

	public IChgImageSlice get_ChgTexComponet() { }

	public void set_ChgTexComponet(IChgImageSlice value) { }

	public void SetChgSliceIdxData(State state, int idx) { }

	public void SetNoChgSlice() { }

	protected virtual void StartAnim(State state) { }

}

