//Type is in global namespace

public class VirtualMouseScaler : InputProcessor<Vector2>
{
	private const string ProcessorName = "VirtualMouseScaler"; //Field offset: 0x0
	public float scale; //Field offset: 0x8

	public VirtualMouseScaler() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void Initialize() { }

	public virtual Vector2 Process(Vector2 value, InputControl control) { }

}

