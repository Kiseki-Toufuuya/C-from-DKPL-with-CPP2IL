namespace UnityEngine.InputSystem;

internal struct InputBindingResolver : IDisposable
{
	public int totalProcessorCount; //Field offset: 0x0
	public int totalCompositeCount; //Field offset: 0x4
	public int totalInteractionCount; //Field offset: 0x8
	public InputActionMap[] maps; //Field offset: 0xC
	public InputControl[] controls; //Field offset: 0x10
	public UnmanagedMemory memory; //Field offset: 0x14
	public IInputInteraction[] interactions; //Field offset: 0x60
	public InputProcessor[] processors; //Field offset: 0x64
	public InputBindingComposite[] composites; //Field offset: 0x68
	public Nullable<InputBinding> bindingMask; //Field offset: 0x6C
	private bool m_IsControlOnlyResolve; //Field offset: 0x9C
	private List<NameAndParameters> m_Parameters; //Field offset: 0xA0

	public int totalActionCount
	{
		 get { } //Length: 11
	}

	public int totalBindingCount
	{
		 get { } //Length: 11
	}

	public int totalControlCount
	{
		 get { } //Length: 11
	}

	public int totalMapCount
	{
		 get { } //Length: 11
	}

	public void AddActionMap(InputActionMap actionMap) { }

	private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters) { }

	private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount) { }

	public override void Dispose() { }

	public int get_totalActionCount() { }

	public int get_totalBindingCount() { }

	public int get_totalControlCount() { }

	public int get_totalMapCount() { }

	private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap) { }

	private int InstantiateWithParameters(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding) { }

	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve) { }

}

