namespace CriWare;

[AddComponentMenu("CRIWARE/Library Initializer")]
public class CriWareInitializer : CriMonoBehaviour
{
	private static int initializationCount; //Field offset: 0x0
	public bool initializesFileSystem; //Field offset: 0x20
	public CriFsConfig fileSystemConfig; //Field offset: 0x24
	public bool initializesAtom; //Field offset: 0x28
	public CriAtomConfig atomConfig; //Field offset: 0x2C
	public bool initializesMana; //Field offset: 0x30
	public CriManaConfig manaConfig; //Field offset: 0x34
	public bool useDecrypter; //Field offset: 0x38
	public Config DecrypterConfig; //Field offset: 0x3C
	public bool dontInitializeOnAwake; //Field offset: 0x40
	public bool dontDestroyOnLoad; //Field offset: 0x41

	public CriWareInitializer() { }

	public static void AddAudioEffectInterface(IntPtr effect_interface) { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	public void Initialize() { }

	public static bool InitializeAtom(CriAtomConfig config) { }

	public static bool InitializeFileSystem(CriFsConfig config) { }

	public static bool InitializeMana(CriManaConfig config) { }

	public static bool IsInitialized() { }

	private void OnDestroy() { }

	protected virtual void OnEnable() { }

	private void OnValidate() { }

	public void Shutdown() { }

	private void Start() { }

	private void ValidateConfig() { }

	private void ValidateConfigEditor() { }

	private void ValidateConfigEditorForNotPublic() { }

	private void ValidateConfigForNotPublic() { }

}

