namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct ScriptPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	public static ScriptPlayableOutput Null
	{
		 get { } //Length: 149
	}

	internal ScriptPlayableOutput(PlayableOutputHandle handle) { }

	public static ScriptPlayableOutput Create(PlayableGraph graph, string name) { }

	public static ScriptPlayableOutput get_Null() { }

	public override PlayableOutputHandle GetHandle() { }

	public static PlayableOutput op_Implicit(ScriptPlayableOutput output) { }

}

