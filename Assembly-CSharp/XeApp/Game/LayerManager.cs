namespace XeApp.Game;

public class LayerManager
{
	private class BaseLayerInfo
	{
		public string m_Tag; //Field offset: 0x8
		public LayerBase m_Layer; //Field offset: 0xC

		public BaseLayerInfo() { }

	}

	private enum eStepMain
	{
		NONE = 0,
		INIT1 = 1,
		INIT2 = 2,
		MAIN = 3,
		TRANSIT_WAIT = 4,
		TRANSIT_FADE = 5,
		NUM = 6,
	}

	internal class PrevTouch
	{
		public bool m_enable; //Field offset: 0x8
		public int m_RefCounter; //Field offset: 0xC

		public PrevTouch() { }

	}

	public const int TRANSITION_LAYER_ID = 1000001; //Field offset: 0x0
	public const int DIALOG_LAYER_ID = 1000000; //Field offset: 0x0
	public const int AUTO_ORDER_NUMBERING_MAX = 99999; //Field offset: 0x0
	private static LayerManager m_Instance; //Field offset: 0x0
	private List<LayerBase> m_LayerList; //Field offset: 0x8
	private LayerBase m_LayerRoot; //Field offset: 0xC
	private LayerBase m_LayerNext; //Field offset: 0x10
	private uint m_LayerSequence; //Field offset: 0x14
	private int m_NextOrderId; //Field offset: 0x18
	private Dictionary<String, PrevTouch> m_PrevTouchDictionary; //Field offset: 0x1C
	private eStepMain m_StepMain; //Field offset: 0x20
	private List<BaseLayerInfo> m_BaseLayerTagList; //Field offset: 0x24
	private List<LayerBase> m_ForceHideLayerList; //Field offset: 0x28

	public static LayerManager Instance
	{
		 get { } //Length: 40
	}

	public LayerManager() { }

	private void AddSequence() { }

	public static void Create(LayerBase layer_root) { }

	public LayerBase CreateLayer(int order_id, string tag, Action<LayerBase> setParamAction = null, Action startAction = null, Action endAction = null) { }

	public void DeleteAllLayer() { }

	public void DeleteBaseLayerTag(LayerBase layer) { }

	public void DeleteBaseLayerTagList(List<LayerBase> layer_list) { }

	public void DeleteCurrentLayer() { }

	public void DeleteLayer(LayerBase layer) { }

	public void DeleteLayer(string tag) { }

	public List<LayerBase> DeleteLayerAtoB(string tagA, string tagB) { }

	public void DeleteLayerIndexOf(string tag) { }

	public LayerBase FindCurrentBaseLayer() { }

	public LayerBase FindLayer() { }

	public LayerBase FindLayer(string tag) { }

	public LayerBase FindLayer(uint sequence) { }

	public static LayerManager get_Instance() { }

	public string GetOldBaseLayerTag() { }

	public void HideTransitionLayer() { }

	public bool IsActiveLayer(uint sequence) { }

	public bool IsActiveLayer(string tag) { }

	public bool IsAllLayerDestroy() { }

	public bool IsDeleteLayer(string tag) { }

	public bool IsInitManeger() { }

	public bool IsReadyLayer() { }

	public void LateUpDate() { }

	public void ResetHideTransitionLayer() { }

	public void SetAllLayerTouch(bool active) { }

	private void SetStepMain(eStepMain step) { }

	public LayerBase Transition(int order_id, string tag, object argument = null) { }

	public LayerBase TransitionCreateLayer(int order_id, string tag, Action<LayerBase> setParamAction = null, Action startAction = null, Action endAction = null, bool isHeaderOut = true) { }

	public LayerBase TransitionCreateLayerChild(int order_id, string tag, Action<LayerBase> setParamAction = null, Action startAction = null, Action endAction = null, bool isHeaderOut = true) { }

	public void Update() { }

}

