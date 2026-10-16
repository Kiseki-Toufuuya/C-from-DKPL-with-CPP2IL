namespace UnityEngine.Playables;

public struct ScriptPlayable : IPlayable, IEquatable<ScriptPlayable`1<T>>
{
	private static readonly ScriptPlayable<T> m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	public static ScriptPlayable<T> Null
	{
		 get { } //Length: 123
	}

	private static ScriptPlayable`1() { }

	internal ScriptPlayable`1(PlayableHandle handle) { }

	private static object CloneScriptInstance(IPlayableBehaviour source) { }

	private static object CloneScriptInstanceFromEngineObject(object source) { }

	private static object CloneScriptInstanceFromIClonable(ICloneable source) { }

	public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0) { }

	public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) { }

	private static object CreateScriptInstance() { }

	public override bool Equals(ScriptPlayable<T> other) { }

	public static ScriptPlayable<T> get_Null() { }

	public T GetBehaviour() { }

	public override PlayableHandle GetHandle() { }

	public static ScriptPlayable<T> op_Explicit(Playable playable) { }

	public static Playable op_Implicit(ScriptPlayable<T> playable) { }

}

