namespace UnityEngine;

[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		 get { } //Length: 117
	}

	public bool enabled
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool isVisible
	{
		[NativeName("IsVisibleInScene")]
		 get { } //Length: 98
	}

	public LightProbeUsage lightProbeUsage
	{
		 set { } //Length: 101
	}

	public Bounds localBounds
	{
		[NativeName("SetLocalAABB")]
		 set { } //Length: 102
	}

	public Material material
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public Material[] materials
	{
		 get { } //Length: 98
	}

	public bool receiveShadows
	{
		 set { } //Length: 101
	}

	public ShadowCastingMode shadowCastingMode
	{
		 set { } //Length: 101
	}

	public Material sharedMaterial
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public Material[] sharedMaterials
	{
		 set { } //Length: 158
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 98
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 98
	}

	public int sortingLayerID
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public string sortingLayerName
	{
		 set { } //Length: 420
	}

	public int sortingOrder
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Renderer() { }

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	public Bounds get_bounds() { }

	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	public bool get_enabled() { }

	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[NativeName("IsVisibleInScene")]
	public bool get_isVisible() { }

	private static bool get_isVisible_Injected(IntPtr _unity_self) { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public Material get_sharedMaterial() { }

	internal int get_sortingGroupID() { }

	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	internal int get_sortingGroupOrder() { }

	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	public int get_sortingLayerID() { }

	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	public int get_sortingOrder() { }

	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	private Material GetMaterial() { }

	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private Material[] GetMaterialArray() { }

	private static Material[] GetMaterialArray_Injected(IntPtr _unity_self) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	private Material GetSharedMaterial() { }

	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties) { }

	public void set_enabled(bool value) { }

	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	private static void set_lightProbeUsage_Injected(IntPtr _unity_self, LightProbeUsage value) { }

	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	public void set_material(Material value) { }

	public void set_receiveShadows(bool value) { }

	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerID(int value) { }

	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	public void set_sortingLayerName(string value) { }

	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_sortingOrder(int value) { }

	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	private void SetMaterial(Material m) { }

	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	private void SetMaterialArray(Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	private void SetMaterialArray(Material[] m, int length) { }

	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

