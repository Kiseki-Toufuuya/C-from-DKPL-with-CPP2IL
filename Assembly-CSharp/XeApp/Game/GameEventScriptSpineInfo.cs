namespace XeApp.Game;

public class GameEventScriptSpineInfo
{
	internal enum eCharaAnimeType
	{
		NONE = 0,
		ACT_00_WAIT = 1,
		ACT_01_WAIT_BTL = 2,
		ACT_10_ATK = 3,
		ACT_20_ATK_PRE = 4,
		ACT_30_DMG = 5,
		ACT_40_DOWN = 6,
		ACT_50_PRV = 7,
		ACT_02_WAIT_TRB = 8,
		ACT_20_PRV = 9,
		ACT_30_SPR = 10,
		ACT_40_CIG = 11,
		ACT_41_WAIT_CIG = 12,
		ACT_H00_WAIT = 13,
		ACT_H01_WAIT_02 = 14,
		ACT_H10_JOY = 15,
		ACT_H11_JOY2 = 16,
		ACT_H20_SRW = 17,
		ACT_H21_SRW2 = 18,
		ACT_H30_TCH = 19,
		ACT_H31_TCH2 = 20,
		ACT_H32_TCH3 = 21,
		NUM = 22,
	}

	internal enum eCharaSkinType
	{
		NONE = 0,
		NML = 1,
		NML_DMG = 2,
		SML = 3,
		SML_DMG = 4,
		ANG = 5,
		ANG_DMG = 6,
		SPR = 7,
		SPR_DMG = 8,
		SRW = 9,
		SRW_DMG = 10,
		SML_02 = 11,
		ANG_02 = 12,
		SPR_02 = 13,
		SRW_02 = 14,
		H_NML = 15,
		H_SML = 16,
		H_JOY = 17,
		H_ANG = 18,
		H_SRW = 19,
		H_SPR = 20,
		H_NML_BLU = 21,
		H_SML_BLU = 22,
		H_SER = 23,
		NUM = 24,
	}

	internal enum eMoveDierction
	{
		UP = 0,
		DOWN = 1,
		LEFT = 2,
		RIGHT = 3,
		NUM = 4,
	}

	private const float m_Default_Z_Position = 10; //Field offset: 0x0
	private String[] m_CharaAnimeName; //Field offset: 0x8
	private String[] m_HostessAnimeName; //Field offset: 0xC
	private String[] m_CharaSkin; //Field offset: 0x10
	private int m_ModelId; //Field offset: 0x14
	private GameObject m_SpineObject; //Field offset: 0x18
	private Action m_UpdateSpine; //Field offset: 0x1C
	private float m_Alpha; //Field offset: 0x20
	private Action m_UpdateFade; //Field offset: 0x24
	private Action m_UpdateMove; //Field offset: 0x28
	private Action m_UpdateMain; //Field offset: 0x2C
	private float m_MoveValue; //Field offset: 0x30
	private List<Shader> m_DefaultShaderList; //Field offset: 0x34
	private List<Shader> m_CurrentShaderList; //Field offset: 0x38
	private bool m_DispFlag; //Field offset: 0x3C
	private string m_AssetName; //Field offset: 0x40
	private string m_PrefabName; //Field offset: 0x44
	private float m_PosId; //Field offset: 0x48
	private String[] m_AnimNameArray; //Field offset: 0x4C
	private String[] m_SkinNameArray; //Field offset: 0x50
	private eLayoutType m_LayoutType; //Field offset: 0x54
	private Camera m_Camera; //Field offset: 0x58
	private float m_baraTest; //Field offset: 0x5C
	private Action m_baraFunc; //Field offset: 0x60
	private bool m_Call; //Field offset: 0x64
	private float m_MoveTo; //Field offset: 0x68
	private float m_MoveFrom; //Field offset: 0x6C

	public Camera camera
	{
		 set { } //Length: 27
	}

	public bool CameraEnable
	{
		 set { } //Length: 3
	}

	public bool DispFlag
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public int Id
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public GameEventScriptSpineInfo(int id, string prefabName, string assetName, int listNo, eLayoutType layoutType) { }

	public void Active(bool flg) { }

	public void AnimSpeed(float speed) { }

	public void ChangeShader(Material mat) { }

	public bool CheckMove() { }

	public void Destroy() { }

	public void DispOff() { }

	public void FadeIn(float start = -0.3) { }

	public void FadeOut(float start = 1) { }

	public bool get_DispFlag() { }

	public int get_Id() { }

	public void Init() { }

	public void IO_MoveInit(eMoveDierction dir, bool toHome = true) { }

	public bool IsFade() { }

	public void set_camera(Camera value) { }

	public void set_CameraEnable(bool value) { }

	public void set_DispFlag(bool value) { }

	public void set_Id(int value) { }

	public void SetAnim(int animNo, int nextAnimNo = -1) { }

	public bool SetAnimName(string name, string next) { }

	private void SetAnimType(int type, bool loop = false, bool force = false) { }

	private void SetNextAnimeType(int type, bool loop = false) { }

	public bool SetPosition(int posid, int mot_init = 0) { }

	public void SetPosition(RawImageEx image) { }

	public bool SetPriority(int value) { }

	public bool SetScale(float size) { }

	public bool SetSkin(int skinNo) { }

	public bool SetSkinName(string name) { }

	public void Update() { }

	private void Update_IO_SideMove() { }

	private void Update_IO_VerticalMove() { }

	private void UpdateBara() { }

	private void UpdateChangeShader() { }

	private void UpdateFadeIn() { }

	private void UpdateFadeOut() { }

	private void UpdateMain() { }

	private void UpdateSpineCallWait() { }

	public void UpdateSpineInit() { }

	private void UpdateSpineLoadWait() { }

}

