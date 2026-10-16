namespace CriWare.CriMana.Detail;

public abstract class RendererResource : IDisposable
{
	private bool disposed; //Field offset: 0x8
	protected Shader shader; //Field offset: 0xC
	protected Material currentMaterial; //Field offset: 0x10
	protected bool hasAlpha; //Field offset: 0x14
	protected bool additive; //Field offset: 0x15
	protected bool applyTargetAlpha; //Field offset: 0x16
	protected bool ui; //Field offset: 0x17

	protected RendererResource() { }

	public abstract void AttachToPlayer(int playerId) { }

	public static int Ceiling16(int x) { }

	public static int Ceiling256(int x) { }

	public static int Ceiling32(int x) { }

	public static int Ceiling64(int x) { }

	public static int CeilingWith(int x, int ceilingValue) { }

	public abstract bool ContinuePreparing() { }

	protected static bool CRIWARE10599B11(int player_id, int num_textures, out IntPtr[] tex_ptrs) { }

	protected static sbyte CRIWARE11A720CC(int player_id) { }

	protected static bool CRIWARE2BB33D09(int player_id, int num_textures, IntPtr[] tex_ptrs, out FrameInfo frame_info, ref bool frame_drop) { }

	protected static bool CRIWAREA34E1AD9(int player_id, int num_textures, out IntPtr[] tex_ptrs) { }

	protected static bool CRIWAREC32946DD(int player_id, int num_textures, out IntPtr[] tex_ptrs) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	protected static void DisposeTextures(Texture[] textures) { }

	protected virtual void Finalize() { }

	private void GetBlendModes(out int srcBlendMode, out int dstBlendMode) { }

	public override int GetDisplayedFrameNo() { }

	public int GetNumberOfFrameBeforeDestroy(int playerId) { }

	public override bool HasRenderedNewFrame() { }

	public abstract bool IsPrepared() { }

	public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

	public static uint NextPowerOfTwo(uint x) { }

	public static int NextPowerOfTwo(int x) { }

	protected abstract void OnDisposeManaged() { }

	protected abstract void OnDisposeUnmanaged() { }

	public override void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause) { }

	public override void OnPlayerStart() { }

	public override void OnPlayerStop() { }

	public override bool OnPlayerStopForSeek() { }

	public override void SetApplyTargetAlpha(bool flag) { }

	protected static void SetKeyword(Material material, string keyword, bool flag) { }

	public override void SetUiRenderMode(bool flag) { }

	protected void SetupStaticMaterialProperties() { }

	public override bool ShouldSkipDestroyOnStopForSeek() { }

	public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) { }

	public abstract bool UpdateMaterial(Material material) { }

	public abstract void UpdateTextures() { }

}

