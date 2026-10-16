namespace Coffee.UIEffects;

[DisallowMultipleComponent]
public abstract class BaseMaterialEffect : BaseMeshEffect, IParameterTexture, IMaterialModifier
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Object, Boolean> <>9__15_0; //Field offset: 0x4
		public static Func<Object, String> <>9__15_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SetShaderVariants>b__15_0(object x) { }

		internal string <SetShaderVariants>b__15_1(object x) { }

	}

	protected static readonly Hash128 k_InvalidHash; //Field offset: 0x0
	protected static readonly List<UIVertex> s_TempVerts; //Field offset: 0x10
	private static readonly StringBuilder s_StringBuilder; //Field offset: 0x14
	private Hash128 _effectMaterialHash; //Field offset: 0x20
	[CompilerGenerated]
	private int <parameterIndex>k__BackingField; //Field offset: 0x30

	public override int parameterIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override ParameterTexture paramTex
	{
		 get { } //Length: 3
	}

	private static BaseMaterialEffect() { }

	protected BaseMaterialEffect() { }

	[CompilerGenerated]
	public override int get_parameterIndex() { }

	public override ParameterTexture get_paramTex() { }

	public override Hash128 GetMaterialHash(Material baseMaterial) { }

	public override Material GetModifiedMaterial(Material baseMaterial) { }

	public override Material GetModifiedMaterial(Material baseMaterial, Graphic graphic) { }

	public override void ModifyMaterial(Material newMaterial, Graphic graphic) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	[CompilerGenerated]
	public override void set_parameterIndex(int value) { }

	public void SetMaterialDirty() { }

	protected void SetShaderVariants(Material newMaterial, Object[] variants) { }

}

