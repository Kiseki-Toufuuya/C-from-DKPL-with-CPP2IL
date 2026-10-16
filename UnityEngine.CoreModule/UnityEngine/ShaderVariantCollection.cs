namespace UnityEngine;

public sealed class ShaderVariantCollection : object
{

	public bool isWarmedUp
	{
		[NativeName("IsWarmedUp")]
		 get { } //Length: 98
	}

	[NativeName("IsWarmedUp")]
	public bool get_isWarmedUp() { }

	private static bool get_isWarmedUp_Injected(IntPtr _unity_self) { }

	[NativeName("WarmupShaders")]
	public void WarmUp() { }

	private static void WarmUp_Injected(IntPtr _unity_self) { }

}

