//Type is in global namespace

public class SettingPreviewNotesPrefab : MonoBehaviour
{
	private int m_ID; //Field offset: 0x10
	[SerializeField]
	private SpriteRenderer m_Renderer; //Field offset: 0x14
	[CompilerGenerated]
	private bool <isReady>k__BackingField; //Field offset: 0x18

	public int GetID
	{
		 get { } //Length: 11
	}

	public bool isReady
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public SettingPreviewNotesPrefab() { }

	public void Disp(bool enable) { }

	public int get_GetID() { }

	[CompilerGenerated]
	public bool get_isReady() { }

	public void MoveY(float distance) { }

	[CompilerGenerated]
	public void set_isReady(bool value) { }

	public void SetPositon(Vector3 position) { }

	public void SetSprite(Sprite sprite) { }

	public void Setup(int id) { }

}

