namespace UnityEngine;

[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random
{

	public static float value
	{
		[FreeFunction]
		 get { } //Length: 33
	}

	[FreeFunction]
	public static float get_value() { }

	[NativeMethod("SetSeed")]
	[StaticAccessor("GetScriptingRand()", StaticAccessorType::Dot (0))]
	public static void InitState(int seed) { }

	[FreeFunction]
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	public static float Range(float minInclusive, float maxInclusive) { }

	public static int Range(int minInclusive, int maxExclusive) { }

}

