namespace XeApp.Game;

public class AdventureDisp : DispBase
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_NAME = 0,
		TEXT_MESSAGE = 1,
		TEXT_NUM = 2,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private AdventureLayerRoot m_Layer; //Field offset: 0x114
	private AdvMessageBoxDisp MessageBoxUIDisp; //Field offset: 0x118
	private AdvMenuUiDisp MenuUIDisp; //Field offset: 0x11C
	private GameEventScriptBase EventScript; //Field offset: 0x120
	private bool m_IsFinish; //Field offset: 0x124
	private Action m_UpdateLoadAsync; //Field offset: 0x128
	public Action FinishCallBack; //Field offset: 0x12C

	private static AdventureDisp() { }

	public AdventureDisp() { }

	public void AllDisp(bool active) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public GameEventScriptBase GetEventScript() { }

	protected virtual void InitUguiOther() { }

	public bool IsFinish() { }

	protected virtual void LateUpdate() { }

	private void LoadAsyncInit() { }

	private void LoadAsyncWait() { }

	public virtual void ReleaseAll() { }

	protected virtual void UpdateDispMain() { }

}

