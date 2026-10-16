namespace XeSys.Gfx;

public class SpriteEffect
{
	internal enum AnimationState
	{
		in_wait = 0,
		in_anim = 1,
		main_loop = 2,
		out_anim = 3,
		end = 4,
	}

	internal enum AnimationType
	{
		in_loop_out = 0,
		loop = 1,
		loop_out = 2,
		in_out = 3,
	}

	private Layout m_SpriteEffectLayout; //Field offset: 0x8
	private SpriteEffectDrawData[] m_DrawDatas; //Field offset: 0xC
	private bool m_IsYFlip; //Field offset: 0x10
	private bool m_IsXFlip; //Field offset: 0x11
	private float m_PixelPerUnit; //Field offset: 0x14
	private float m_PixelPerUnitInv; //Field offset: 0x18
	private Vector3 m_Position; //Field offset: 0x1C
	private Vector3 m_Rotate; //Field offset: 0x28
	private Vector3 m_Scale; //Field offset: 0x34
	private bool m_DoUpdateMatrix; //Field offset: 0x40
	private Matrix4x4 m_RootMatrix; //Field offset: 0x44
	private bool m_IsAnimation; //Field offset: 0x84
	private bool m_IsDraw; //Field offset: 0x85
	private bool m_IsAlive; //Field offset: 0x86
	private bool m_EndRequest; //Field offset: 0x87
	private AnimationType m_AnimationType; //Field offset: 0x88
	private AnimationState m_AnimState; //Field offset: 0x8C
	private int m_LoopNum; //Field offset: 0x90
	private int m_loopCount; //Field offset: 0x94
	private bool m_IsAutoEnd; //Field offset: 0x98
	private int m_EffectType; //Field offset: 0x9C
	private Matrix4x4 m_RetMatrixWork; //Field offset: 0xA0

	public AnimationState AnimState
	{
		 set { } //Length: 17
	}

	public int EffectType
	{
		 get { } //Length: 14
	}

	public bool EndRequest
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsAlive
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsAnimation
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsAutoEnd
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsDraw
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public bool IsXFlip
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsYFlip
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float PixelPerUnit
	{
		 get { } //Length: 11
		 set { } //Length: 35
	}

	public Vector3 Position
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Vector3 Rotate
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Vector3 Scale
	{
		 get { } //Length: 26
		 set { } //Length: 24
	}

	public Layout SpriteEffectLayout
	{
		 get { } //Length: 11
	}

	public SpriteEffect() { }

	private int CalcDrawData(int count, Matrix4x4 parentMatrix, Color parentColor, AbsoluteLayout layout) { }

	private Matrix4x4 CalcViewMatrix(Matrix4x4 parentMatrix, ViewBase view) { }

	private int CountImageView(AbsoluteLayout layout) { }

	public int get_EffectType() { }

	public bool get_EndRequest() { }

	public bool get_IsAlive() { }

	public bool get_IsAnimation() { }

	public bool get_IsAutoEnd() { }

	public bool get_IsDraw() { }

	public bool get_IsXFlip() { }

	public bool get_IsYFlip() { }

	public float get_PixelPerUnit() { }

	public Vector3 get_Position() { }

	public Vector3 get_Rotate() { }

	public Vector3 get_Scale() { }

	public Layout get_SpriteEffectLayout() { }

	public void Initialize(int effectType, Layout layout) { }

	public void RegistDraw(DynamicPolygonManager polygonManager, SpriteEffectMaterialVal currentMaterialVal) { }

	public void set_AnimState(AnimationState value) { }

	public void set_EndRequest(bool value) { }

	public void set_IsAlive(bool value) { }

	public void set_IsAnimation(bool value) { }

	public void set_IsAutoEnd(bool value) { }

	public void set_IsDraw(bool value) { }

	public void set_IsXFlip(bool value) { }

	public void set_IsYFlip(bool value) { }

	public void set_PixelPerUnit(float value) { }

	public void set_Position(Vector3 value) { }

	public void set_Rotate(Vector3 value) { }

	public void set_Scale(Vector3 value) { }

	public void SetPosition(float x, float y, float z) { }

	public void SetRotate(float x, float y, float z) { }

	public void SetScale(float x, float y, float z) { }

	private void SettingEffetRoot() { }

	private void SettingSpriteEffectDrawDataMaterial(SpriteEffectMaterialVal currentMaterialVal) { }

	public void StartAnimation(AnimationType type, int loopNum, bool autoEnd) { }

	private void StartNextAnimation() { }

	public void Update(float dt) { }

}

