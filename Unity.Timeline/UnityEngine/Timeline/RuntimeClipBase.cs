namespace UnityEngine.Timeline;

internal abstract class RuntimeClipBase : RuntimeElement
{

	public abstract double duration
	{
		 get { } //Length: 0
	}

	public virtual long intervalEnd
	{
		 get { } //Length: 143
	}

	public virtual long intervalStart
	{
		 get { } //Length: 112
	}

	public abstract double start
	{
		 get { } //Length: 0
	}

	protected RuntimeClipBase() { }

	public abstract double get_duration() { }

	public virtual long get_intervalEnd() { }

	public virtual long get_intervalStart() { }

	public abstract double get_start() { }

}

