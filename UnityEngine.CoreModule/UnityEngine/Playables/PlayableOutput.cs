namespace UnityEngine.Playables;

[RequiredByNativeCode]
public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput>
{
	private static readonly PlayableOutput m_NullPlayableOutput; //Field offset: 0x0
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	public static PlayableOutput Null
	{
		 get { } //Length: 65
	}

	private static PlayableOutput() { }

	[VisibleToOtherModules]
	internal PlayableOutput(PlayableOutputHandle handle) { }

	public override bool Equals(PlayableOutput other) { }

	public static PlayableOutput get_Null() { }

	public override PlayableOutputHandle GetHandle() { }

	public bool IsPlayableOutputOfType() { }

}

