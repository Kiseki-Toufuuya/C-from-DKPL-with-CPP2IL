namespace Cysharp.Threading.Tasks;

internal sealed class PooledTweenCallback
{
	private static readonly ConcurrentQueue<PooledTweenCallback> pool; //Field offset: 0x0
	private readonly TweenCallback runDelegate; //Field offset: 0x8
	private Action continuation; //Field offset: 0xC

	private static PooledTweenCallback() { }

	private PooledTweenCallback() { }

	public static TweenCallback Create(Action continuation) { }

	private void Run() { }

}

