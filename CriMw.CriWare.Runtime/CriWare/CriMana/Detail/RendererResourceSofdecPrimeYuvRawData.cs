namespace CriWare.CriMana.Detail;

public class RendererResourceSofdecPrimeYuvRawData : RendererResource
{
	private int width; //Field offset: 0x18
	private int height; //Field offset: 0x1C
	private int chromaWidth; //Field offset: 0x20
	private int chromaHeight; //Field offset: 0x24
	private int alphaWidth; //Field offset: 0x28
	private int alphaHeight; //Field offset: 0x2C
	private bool useUserShader; //Field offset: 0x30
	private CodecType codecType; //Field offset: 0x34
	private Vector4 movieTextureST; //Field offset: 0x38
	private Vector4 movieChromaTextureST; //Field offset: 0x48
	private Vector4 movieAlphaTextureST; //Field offset: 0x58
	private Texture2D[][] textures; //Field offset: 0x68
	private int currentTextureSet; //Field offset: 0x6C
	private int drawTextureSet; //Field offset: 0x70
	private IntPtr[] nativePixels; //Field offset: 0x74
	private int playerID; //Field offset: 0x78
	private bool hasTextureUpdated; //Field offset: 0x7C
	private bool hasRenderedNewFrame; //Field offset: 0x7D
	private bool isStoppingForSeek; //Field offset: 0x7E

	private static int NumTextureSets
	{
		private get { } //Length: 6
	}

	public RendererResourceSofdecPrimeYuvRawData(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

	public virtual void AttachToPlayer(int playerId) { }

	private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma) { }

	public virtual bool ContinuePreparing() { }

	private static int get_NumTextureSets() { }

	public virtual bool HasRenderedNewFrame() { }

	public virtual bool IsPrepared() { }

	public virtual bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader) { }

	protected virtual void OnDisposeManaged() { }

	protected virtual void OnDisposeUnmanaged() { }

	public virtual bool OnPlayerStopForSeek() { }

	public virtual bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop) { }

	public virtual bool UpdateMaterial(Material material) { }

	private void UpdateMovieTextureST(uint dispWidth, uint dispHeight) { }

	public virtual void UpdateTextures() { }

}

