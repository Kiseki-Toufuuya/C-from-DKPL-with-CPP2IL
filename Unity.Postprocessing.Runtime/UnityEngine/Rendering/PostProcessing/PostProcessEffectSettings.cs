namespace UnityEngine.Rendering.PostProcessing;

public class PostProcessEffectSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FieldInfo, Boolean> <>9__3_0; //Field offset: 0x4
		public static Func<FieldInfo, Int32> <>9__3_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnEnable>b__3_0(FieldInfo t) { }

		internal int <OnEnable>b__3_1(FieldInfo t) { }

	}

	public bool active; //Field offset: 0xC
	public BoolParameter enabled; //Field offset: 0x10
	internal ReadOnlyCollection<ParameterOverride> parameters; //Field offset: 0x14

	public PostProcessEffectSettings() { }

	[CompilerGenerated]
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

	public int GetHash() { }

	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void SetAllOverridesTo(bool state, bool excludeEnabled = true) { }

}

