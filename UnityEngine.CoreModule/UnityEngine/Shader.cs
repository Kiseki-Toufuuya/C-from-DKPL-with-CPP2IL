namespace UnityEngine;

[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
public sealed class Shader : object
{

	internal DisableBatchingType disableBatching
	{
		[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
		internal get { } //Length: 98
	}

	public static GlobalKeyword[] enabledGlobalKeywords
	{
		 get { } //Length: 29
	}

	public static GlobalKeyword[] globalKeywords
	{
		 get { } //Length: 29
	}

	[NativeProperty("GlobalMaximumShaderLOD")]
	public static int globalMaximumLOD
	{
		 get { } //Length: 29
		 set { } //Length: 40
	}

	public static string globalRenderPipeline
	{
		 get { } //Length: 216
		 set { } //Length: 376
	}

	[Obsolete("Use Graphics.activeTier instead (UnityUpgradable) -> UnityEngine.Graphics.activeTier", False)]
	public static ShaderHardwareTier globalShaderHardwareTier
	{
		 get { } //Length: 60
		 set { } //Length: 65
	}

	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		 get { } //Length: 98
	}

	public LocalKeywordSpace keywordSpace
	{
		 get { } //Length: 115
	}

	[NativeProperty("MaxChunksRuntimeOverride")]
	public static int maximumChunksOverride
	{
		 get { } //Length: 29
		 set { } //Length: 40
	}

	[NativeProperty("MaximumShaderLOD")]
	public int maximumLOD
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int passCount
	{
		[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public int renderQueue
	{
		[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public int subshaderCount
	{
		[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	private Shader() { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	public static void DisableKeyword(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	public static void DisableKeyword(string keyword) { }

	private static void DisableKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	internal static void DisableKeywordFast(GlobalKeyword keyword) { }

	private static void DisableKeywordFast_Injected(in GlobalKeyword keyword) { }

	public static void EnableKeyword(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	public static void EnableKeyword(string keyword) { }

	private static void EnableKeyword_Injected(ref ManagedSpanWrapper keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	internal static void EnableKeywordFast(GlobalKeyword keyword) { }

	private static void EnableKeywordFast_Injected(in GlobalKeyword keyword) { }

	private static void ExtractGlobalFloatArray(int name, List<Single> values) { }

	[FreeFunction("ShaderScripting::ExtractGlobalFloatArray")]
	private static void ExtractGlobalFloatArrayImpl(int name, out Single[] val) { }

	private static void ExtractGlobalFloatArrayImpl_Injected(int name, out BlittableArrayWrapper val) { }

	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	[FreeFunction("ShaderScripting::ExtractGlobalMatrixArray")]
	private static void ExtractGlobalMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	private static void ExtractGlobalMatrixArrayImpl_Injected(int name, out BlittableArrayWrapper val) { }

	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	[FreeFunction("ShaderScripting::ExtractGlobalVectorArray")]
	private static void ExtractGlobalVectorArrayImpl(int name, out Vector4[] val) { }

	private static void ExtractGlobalVectorArrayImpl_Injected(int name, out BlittableArrayWrapper val) { }

	public static Shader Find(string name) { }

	[FreeFunction("GetBuiltinResource<Shader>")]
	internal static Shader FindBuiltin(string name) { }

	private static IntPtr FindBuiltin_Injected(ref ManagedSpanWrapper name) { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	public ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, ShaderTagId tagName) { }

	public int FindPropertyIndex(string propertyName) { }

	private static int FindPropertyIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper propertyName) { }

	public ShaderTagId FindSubshaderTagValue(int subshaderIndex, ShaderTagId tagName) { }

	public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex) { }

	[FreeFunction("ShaderScripting::FindTextureStack")]
	private static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex) { }

	private static bool FindTextureStackImpl_Injected(IntPtr s, int propertyIdx, out ManagedSpanWrapper stackName, out int layerIndex) { }

	[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
	internal DisableBatchingType get_disableBatching() { }

	private static DisableBatchingType get_disableBatching_Injected(IntPtr _unity_self) { }

	public static GlobalKeyword[] get_enabledGlobalKeywords() { }

	public static GlobalKeyword[] get_globalKeywords() { }

	public static int get_globalMaximumLOD() { }

	public static string get_globalRenderPipeline() { }

	private static void get_globalRenderPipeline_Injected(out ManagedSpanWrapper ret) { }

	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	[NativeMethod("IsSupported")]
	public bool get_isSupported() { }

	private static bool get_isSupported_Injected(IntPtr _unity_self) { }

	public LocalKeywordSpace get_keywordSpace() { }

	private static void get_keywordSpace_Injected(IntPtr _unity_self, out LocalKeywordSpace ret) { }

	public static int get_maximumChunksOverride() { }

	public int get_maximumLOD() { }

	private static int get_maximumLOD_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
	public int get_passCount() { }

	private static int get_passCount_Injected(IntPtr _unity_self) { }

	[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
	public int get_renderQueue() { }

	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
	public int get_subshaderCount() { }

	private static int get_subshaderCount_Injected(IntPtr _unity_self) { }

	[FreeFunction("keywords::GetAllGlobalKeywords")]
	internal static GlobalKeyword[] GetAllGlobalKeywords() { }

	public Shader GetDependency(string name) { }

	private static IntPtr GetDependency_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[FreeFunction("keywords::GetEnabledGlobalKeywords")]
	internal static GlobalKeyword[] GetEnabledGlobalKeywords() { }

	public static Color GetGlobalColor(string name) { }

	public static Color GetGlobalColor(int nameID) { }

	public static float GetGlobalFloat(string name) { }

	public static float GetGlobalFloat(int nameID) { }

	public static Single[] GetGlobalFloatArray(int nameID) { }

	public static Single[] GetGlobalFloatArray(string name) { }

	public static void GetGlobalFloatArray(string name, List<Single> values) { }

	public static void GetGlobalFloatArray(int nameID, List<Single> values) { }

	[FreeFunction("ShaderScripting::GetGlobalFloatArrayCount")]
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalFloatArray")]
	private static Single[] GetGlobalFloatArrayImpl(int name) { }

	private static void GetGlobalFloatArrayImpl_Injected(int name, out BlittableArrayWrapper ret) { }

	[FreeFunction("ShaderScripting::GetGlobalFloat")]
	private static float GetGlobalFloatImpl(int name) { }

	public static int GetGlobalInt(string name) { }

	public static int GetGlobalInt(int nameID) { }

	public static int GetGlobalInteger(int nameID) { }

	public static int GetGlobalInteger(string name) { }

	[FreeFunction("ShaderScripting::GetGlobalInt")]
	private static int GetGlobalIntImpl(int name) { }

	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	public static Matrix4x4 GetGlobalMatrix(string name) { }

	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrixArrayCount")]
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrixArray")]
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	private static void GetGlobalMatrixArrayImpl_Injected(int name, out BlittableArrayWrapper ret) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrix")]
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	public static Texture GetGlobalTexture(int nameID) { }

	public static Texture GetGlobalTexture(string name) { }

	[FreeFunction("ShaderScripting::GetGlobalTexture")]
	private static Texture GetGlobalTextureImpl(int name) { }

	private static IntPtr GetGlobalTextureImpl_Injected(int name) { }

	public static Vector4 GetGlobalVector(int nameID) { }

	public static Vector4 GetGlobalVector(string name) { }

	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	public static Vector4[] GetGlobalVectorArray(string name) { }

	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[FreeFunction("ShaderScripting::GetGlobalVectorArrayCount")]
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalVectorArray")]
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	private static void GetGlobalVectorArrayImpl_Injected(int name, out BlittableArrayWrapper ret) { }

	[FreeFunction("ShaderScripting::GetGlobalVector")]
	private static Vector4 GetGlobalVectorImpl(int name) { }

	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	[FreeFunction(Name = "ShaderScripting::GetPassCountInSubshader", HasExplicitThis = True)]
	public int GetPassCountInSubshader(int subshaderIndex) { }

	private static int GetPassCountInSubshader_Injected(IntPtr _unity_self, int subshaderIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyAttributes")]
	private static String[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	public String[] GetPropertyAttributes(int propertyIndex) { }

	private static String[] GetPropertyAttributes_Injected(IntPtr shader, int propertyIndex) { }

	public int GetPropertyCount() { }

	private static int GetPropertyCount_Injected(IntPtr _unity_self) { }

	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	public int GetPropertyDefaultIntValue(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDefaultIntValue")]
	private static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex) { }

	private static int GetPropertyDefaultIntValue_Injected(IntPtr shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDefaultValue")]
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	private static void GetPropertyDefaultValue_Injected(IntPtr shader, int propertyIndex, out Vector4 ret) { }

	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDescription")]
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	public string GetPropertyDescription(int propertyIndex) { }

	private static void GetPropertyDescription_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret) { }

	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyFlags")]
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	private static ShaderPropertyFlags GetPropertyFlags_Injected(IntPtr shader, int propertyIndex) { }

	public string GetPropertyName(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyName")]
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	private static void GetPropertyName_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret) { }

	[FreeFunction("ShaderScripting::GetPropertyNameId")]
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	public int GetPropertyNameId(int propertyIndex) { }

	private static int GetPropertyNameId_Injected(IntPtr shader, int propertyIndex) { }

	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyTextureDefaultName")]
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	private static void GetPropertyTextureDefaultName_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret) { }

	[FreeFunction("ShaderScripting::GetPropertyTextureDimension")]
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	private static TextureDimension GetPropertyTextureDimension_Injected(IntPtr shader, int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyType")]
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	private static ShaderPropertyType GetPropertyType_Injected(IntPtr shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::IDToTag")]
	internal static string IDToTag(int name) { }

	private static void IDToTag_Injected(int name, out ManagedSpanWrapper ret) { }

	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	private static int Internal_FindPassTagValue_Injected(IntPtr _unity_self, int passIndex, int tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	private int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName) { }

	private static int Internal_FindPassTagValueInSubShader_Injected(IntPtr _unity_self, int subShaderIndex, int passIndex, int tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindSubshaderTagValue", HasExplicitThis = True)]
	private int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName) { }

	private static int Internal_FindSubshaderTagValue_Injected(IntPtr _unity_self, int subShaderIndex, int tagName) { }

	public static bool IsKeywordEnabled(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	public static bool IsKeywordEnabled(string keyword) { }

	private static bool IsKeywordEnabled_Injected(ref ManagedSpanWrapper keyword) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	internal static bool IsKeywordEnabledFast(GlobalKeyword keyword) { }

	private static bool IsKeywordEnabledFast_Injected(in GlobalKeyword keyword) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	public static int PropertyToID(string name) { }

	private static int PropertyToID_Injected(ref ManagedSpanWrapper name) { }

	public static void set_globalMaximumLOD(int value) { }

	public static void set_globalRenderPipeline(string value) { }

	private static void set_globalRenderPipeline_Injected(ref ManagedSpanWrapper value) { }

	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	public static void set_maximumChunksOverride(int value) { }

	public void set_maximumLOD(int value) { }

	private static void set_maximumLOD_Injected(IntPtr _unity_self, int value) { }

	public static void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	public static void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	private static void SetGlobalBufferImpl_Injected(int name, IntPtr value) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	private static void SetGlobalConstantBufferImpl_Injected(int name, IntPtr value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	private static void SetGlobalConstantGraphicsBufferImpl_Injected(int name, IntPtr value, int offset, int size) { }

	public static void SetGlobalFloat(string name, float value) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	private static void SetGlobalFloatArray(int name, Single[] values, int count) { }

	public static void SetGlobalFloatArray(int nameID, List<Single> values) { }

	public static void SetGlobalFloatArray(string name, Single[] values) { }

	public static void SetGlobalFloatArray(int nameID, Single[] values) { }

	public static void SetGlobalFloatArray(string name, List<Single> values) { }

	[FreeFunction("ShaderScripting::SetGlobalFloatArray")]
	private static void SetGlobalFloatArrayImpl(int name, Single[] values, int count) { }

	private static void SetGlobalFloatArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	private static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	private static void SetGlobalGraphicsBufferImpl_Injected(int name, IntPtr value) { }

	public static void SetGlobalInt(int nameID, int value) { }

	public static void SetGlobalInt(string name, int value) { }

	public static void SetGlobalInteger(string name, int value) { }

	public static void SetGlobalInteger(int nameID, int value) { }

	[FreeFunction("ShaderScripting::SetGlobalInt")]
	private static void SetGlobalIntImpl(int name, int value) { }

	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	private static void SetGlobalMatrixArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, in Matrix4x4 value) { }

	public static void SetGlobalRayTracingAccelerationStructure(string name, RayTracingAccelerationStructure value) { }

	public static void SetGlobalRayTracingAccelerationStructure(int nameID, RayTracingAccelerationStructure value) { }

	[FreeFunction("ShaderScripting::SetGlobalRayTracingAccelerationStructure")]
	private static void SetGlobalRayTracingAccelerationStructureImpl(int name, RayTracingAccelerationStructure accelerationStructure) { }

	private static void SetGlobalRayTracingAccelerationStructureImpl_Injected(int name, IntPtr accelerationStructure) { }

	[FreeFunction("ShaderScripting::SetGlobalRenderTexture")]
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	private static void SetGlobalRenderTextureImpl_Injected(int name, IntPtr value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	private static void SetGlobalTextureImpl_Injected(int name, IntPtr value) { }

	public static void SetGlobalVector(int nameID, Vector4 value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	private static void SetGlobalVectorArrayImpl_Injected(int name, ref ManagedSpanWrapper values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	private static void SetGlobalVectorImpl_Injected(int name, in Vector4 value) { }

	public static void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::SetKeyword")]
	internal static void SetKeywordFast(GlobalKeyword keyword, bool value) { }

	private static void SetKeywordFast_Injected(in GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name) { }

	private static int TagToID_Injected(ref ManagedSpanWrapper name) { }

	[FreeFunction]
	public static void WarmupAllShaders() { }

}

