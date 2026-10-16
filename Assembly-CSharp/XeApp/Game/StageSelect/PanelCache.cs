namespace XeApp.Game.StageSelect;

public class PanelCache
{
	internal enum PositionType
	{
		NORMAL = 0,
		COPY = 1,
	}

	private RectTransform rect; //Field offset: 0x8
	private IInfiniteScrollSetup controller; //Field offset: 0xC
	private int index; //Field offset: 0x10
	private Vector2 anchoredPosition; //Field offset: 0x14
	private Vector2 copyAnchoredPosition; //Field offset: 0x1C

	public PanelCache(RectTransform rect, IInfiniteScrollSetup controller, int index) { }

	public void AddAnchoredPositionX(float posX) { }

	public void AddAnchoredPositionX_ByYZero(float posX) { }

	public void AddAnchoredPositionY(float posY) { }

	public void AddAnchoredPositionY_ByXZero(float posY) { }

	public void AddCopyAnchoredPositionX(float posX) { }

	public void AddCopyAnchoredPositionX_ByYZero(float posX) { }

	public void AddCopyAnchoredPositionY(float posY) { }

	public void AddCopyAnchoredPositionY_ByXZero(float posY) { }

	public void DeepCopyAnchoredPosition() { }

	public Vector2 GetAnchoredPosition(PositionType type) { }

	public float GetAnchoredPositionY() { }

	public float GetCopyAnchoredPositionY() { }

	public GameObject GetGameObject() { }

	public int GetIndex() { }

	public int GetItemNo() { }

	public ShortMusicPanelDisp GetShortMusicInfoDisp() { }

	public bool IsMatchGameObjectName(string name) { }

	public void OnUpdateItem(int itenNo, GameObject obj) { }

	public void ReflectAnchoredPositionToGameObject(PositionType type) { }

	public void SetAnchoredPositionX(float posX) { }

	public void SetAnchoredPositionX_ByYZero(float posX) { }

	public void SetAnchoredPositionY(float posY) { }

	public void SetAnchoredPositionY_ByXZero(float posY, PositionType type = 0) { }

	public void SetCopyAnchoredPositionX(float posX) { }

	public void SetCopyAnchoredPositionX_ByYZero(float posX) { }

	public void SetCopyAnchoredPositionY(float posY) { }

	public void SetCopyAnchoredPositionY_ByXZero(float posY, PositionType type = 0) { }

	public void SetPanelAlpha(float value) { }

}

