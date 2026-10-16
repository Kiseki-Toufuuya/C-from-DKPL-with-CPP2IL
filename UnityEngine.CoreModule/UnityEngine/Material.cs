namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : object
{
	private static readonly int k_ColorId; //Field offset: 0x0
	private static readonly int k_MainTexId; //Field offset: 0x4

	public Color color
	{
		 get { } //Length: 246
		 set { } //Length: 257
	}

	public bool doubleSidedGI
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	public LocalKeyword[] enabledKeywords
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	[NativeProperty("EnableInstancingVariants")]
	public bool enableInstancing
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	public MaterialGlobalIlluminationFlags globalIlluminationFlags
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	public Texture mainTexture
	{
		 get { } //Length: 211
		 set { } //Length: 235
	}

	public Vector2 mainTextureOffset
	{
		 get { } //Length: 258
		 set { } //Length: 241
	}

	public Vector2 mainTextureScale
	{
		 get { } //Length: 251
		 set { } //Length: 241
	}

	public int passCount
	{
		[NativeName("GetShader()->GetPassCount")]
		 get { } //Length: 128
	}

	public int rawRenderQueue
	{
		[NativeName("GetCustomRenderQueue")]
		 get { } //Length: 128
	}

	public int renderQueue
	{
		[NativeName("GetActualRenderQueue")]
		 get { } //Length: 128
		[NativeName("SetCustomRenderQueue")]
		 set { } //Length: 131
	}

	public Shader shader
	{
		 get { } //Length: 150
		 set { } //Length: 175
	}

	public String[] shaderKeywords
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	private static Material() { }

	public Material(Shader shader) { }

	[RequiredByNativeCode]
	public Material(Material source) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	public Material(string contents) { }

	public int ComputeCRC() { }

	private static int ComputeCRC_Injected(IntPtr _unity_self) { }

	[FreeFunction("MaterialScripting::CopyMatchingPropertiesFrom", HasExplicitThis = True)]
	public void CopyMatchingPropertiesFromMaterial(Material mat) { }

	private static void CopyMatchingPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	public void CopyPropertiesFromMaterial(Material mat) { }

	private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.", False)]
	public static Material Create(string scriptContents) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial(Material self, Material source) { }

	private static void CreateWithMaterial_Injected(Material self, IntPtr source) { }

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader(Material self, Shader shader) { }

	private static void CreateWithShader_Injected(Material self, IntPtr shader) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString(Material self) { }

	public void DisableKeyword(in LocalKeyword keyword) { }

	public void DisableKeyword(string keyword) { }

	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[FreeFunction("MaterialScripting::DisableKeyword", HasExplicitThis = True)]
	private void DisableLocalKeyword(LocalKeyword keyword) { }

	private static void DisableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	public void EnableKeyword(in LocalKeyword keyword) { }

	public void EnableKeyword(string keyword) { }

	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[FreeFunction("MaterialScripting::EnableKeyword", HasExplicitThis = True)]
	private void EnableLocalKeyword(LocalKeyword keyword) { }

	private static void EnableLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	private void ExtractColorArray(int name, List<Color> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractColorArray", HasExplicitThis = True)]
	private void ExtractColorArrayImpl(int name, out Color[] val) { }

	private static void ExtractColorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	private void ExtractFloatArray(int name, List<Single> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractFloatArray", HasExplicitThis = True)]
	private void ExtractFloatArrayImpl(int name, out Single[] val) { }

	private static void ExtractFloatArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractMatrixArray", HasExplicitThis = True)]
	private void ExtractMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	private static void ExtractMatrixArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	private void ExtractVectorArray(int name, List<Vector4> values) { }

	[FreeFunction(Name = "MaterialScripting::ExtractVectorArray", HasExplicitThis = True)]
	private void ExtractVectorArrayImpl(int name, out Vector4[] val) { }

	private static void ExtractVectorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper val) { }

	public int FindPass(string passName) { }

	private static int FindPass_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName) { }

	public Color get_color() { }

	public bool get_doubleSidedGI() { }

	private static bool get_doubleSidedGI_Injected(IntPtr _unity_self) { }

	public LocalKeyword[] get_enabledKeywords() { }

	public bool get_enableInstancing() { }

	private static bool get_enableInstancing_Injected(IntPtr _unity_self) { }

	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	private static MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(IntPtr _unity_self) { }

	public Texture get_mainTexture() { }

	public Vector2 get_mainTextureOffset() { }

	public Vector2 get_mainTextureScale() { }

	[NativeName("GetShader()->GetPassCount")]
	public int get_passCount() { }

	private static int get_passCount_Injected(IntPtr _unity_self) { }

	[NativeName("GetCustomRenderQueue")]
	public int get_rawRenderQueue() { }

	private static int get_rawRenderQueue_Injected(IntPtr _unity_self) { }

	[NativeName("GetActualRenderQueue")]
	public int get_renderQueue() { }

	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	public Shader get_shader() { }

	private static IntPtr get_shader_Injected(IntPtr _unity_self) { }

	public String[] get_shaderKeywords() { }

	public GraphicsBufferHandle GetBuffer(string name) { }

	[NativeName("GetBufferFromScript")]
	private GraphicsBufferHandle GetBufferImpl(int name) { }

	private static void GetBufferImpl_Injected(IntPtr _unity_self, int name, out GraphicsBufferHandle ret) { }

	public Color GetColor(int nameID) { }

	public Color GetColor(string name) { }

	public void GetColorArray(int nameID, List<Color> values) { }

	public void GetColorArray(string name, List<Color> values) { }

	public Color[] GetColorArray(int nameID) { }

	public Color[] GetColorArray(string name) { }

	[FreeFunction(Name = "MaterialScripting::GetColorArrayCount", HasExplicitThis = True)]
	private int GetColorArrayCountImpl(int name) { }

	private static int GetColorArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[FreeFunction(Name = "MaterialScripting::GetColorArray", HasExplicitThis = True)]
	private Color[] GetColorArrayImpl(int name) { }

	private static void GetColorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[NativeName("GetColorFromScript")]
	private Color GetColorImpl(int name) { }

	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret) { }

	public GraphicsBufferHandle GetConstantBuffer(string name) { }

	[NativeName("GetConstantBufferFromScript")]
	private GraphicsBufferHandle GetConstantBufferImpl(int name) { }

	private static void GetConstantBufferImpl_Injected(IntPtr _unity_self, int name, out GraphicsBufferHandle ret) { }

	internal static Material GetDefaultLineMaterial() { }

	private static IntPtr GetDefaultLineMaterial_Injected() { }

	internal static Material GetDefaultMaterial() { }

	private static IntPtr GetDefaultMaterial_Injected() { }

	internal static Material GetDefaultParticleMaterial() { }

	private static IntPtr GetDefaultParticleMaterial_Injected() { }

	[FreeFunction("MaterialScripting::GetEnabledKeywords", HasExplicitThis = True)]
	private LocalKeyword[] GetEnabledKeywords() { }

	private static LocalKeyword[] GetEnabledKeywords_Injected(IntPtr _unity_self) { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag) { }

	public float GetFloat(string name) { }

	public float GetFloat(int nameID) { }

	public Single[] GetFloatArray(int nameID) { }

	public void GetFloatArray(int nameID, List<Single> values) { }

	public void GetFloatArray(string name, List<Single> values) { }

	public Single[] GetFloatArray(string name) { }

	[FreeFunction(Name = "MaterialScripting::GetFloatArrayCount", HasExplicitThis = True)]
	private int GetFloatArrayCountImpl(int name) { }

	private static int GetFloatArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[FreeFunction(Name = "MaterialScripting::GetFloatArray", HasExplicitThis = True)]
	private Single[] GetFloatArrayImpl(int name) { }

	private static void GetFloatArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name) { }

	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	public int GetInt(string name) { }

	public int GetInt(int nameID) { }

	public int GetInteger(int nameID) { }

	public int GetInteger(string name) { }

	[NativeName("GetIntFromScript")]
	private int GetIntImpl(int name) { }

	private static int GetIntImpl_Injected(IntPtr _unity_self, int name) { }

	public Matrix4x4 GetMatrix(string name) { }

	public Matrix4x4 GetMatrix(int nameID) { }

	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	public Matrix4x4[] GetMatrixArray(string name) { }

	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	public Matrix4x4[] GetMatrixArray(int nameID) { }

	[FreeFunction(Name = "MaterialScripting::GetMatrixArrayCount", HasExplicitThis = True)]
	private int GetMatrixArrayCountImpl(int name) { }

	private static int GetMatrixArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[FreeFunction(Name = "MaterialScripting::GetMatrixArray", HasExplicitThis = True)]
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	private static void GetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	[NativeName("GetMatrixFromScript")]
	private Matrix4x4 GetMatrixImpl(int name) { }

	private static void GetMatrixImpl_Injected(IntPtr _unity_self, int name, out Matrix4x4 ret) { }

	public string GetPassName(int pass) { }

	private static void GetPassName_Injected(IntPtr _unity_self, int pass, out ManagedSpanWrapper ret) { }

	public String[] GetPropertyNames(MaterialPropertyType type) { }

	[FreeFunction("MaterialScripting::GetPropertyNames", HasExplicitThis = True)]
	private String[] GetPropertyNamesImpl(int propertyType) { }

	private static String[] GetPropertyNamesImpl_Injected(IntPtr _unity_self, int propertyType) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	private String[] GetShaderKeywords() { }

	private static String[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	[FreeFunction("MaterialScripting::GetShaderPassEnabled", HasExplicitThis = True)]
	public bool GetShaderPassEnabled(string passName) { }

	private static bool GetShaderPassEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	private static void GetTagImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag, bool currentSubShaderOnly, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret) { }

	public Texture GetTexture(int nameID) { }

	public Texture GetTexture(string name) { }

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name) { }

	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }

	public Vector2 GetTextureOffset(string name) { }

	public Vector2 GetTextureOffset(int nameID) { }

	public void GetTexturePropertyNameIDs(List<Int32> outNames) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDs", HasExplicitThis = True)]
	public Int32[] GetTexturePropertyNameIDs() { }

	private static void GetTexturePropertyNameIDs_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNameIDsInternal", HasExplicitThis = True)]
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	private static void GetTexturePropertyNameIDsInternal_Injected(IntPtr _unity_self, object outNames) { }

	public void GetTexturePropertyNames(List<String> outNames) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNames", HasExplicitThis = True)]
	public String[] GetTexturePropertyNames() { }

	private static String[] GetTexturePropertyNames_Injected(IntPtr _unity_self) { }

	[FreeFunction("MaterialScripting::GetTexturePropertyNamesInternal", HasExplicitThis = True)]
	private void GetTexturePropertyNamesInternal(object outNames) { }

	private static void GetTexturePropertyNamesInternal_Injected(IntPtr _unity_self, object outNames) { }

	public Vector2 GetTextureScale(string name) { }

	public Vector2 GetTextureScale(int nameID) { }

	[NativeName("GetTextureScaleAndOffsetFromScript")]
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	private static void GetTextureScaleAndOffsetImpl_Injected(IntPtr _unity_self, int name, out Vector4 ret) { }

	public Vector4 GetVector(int nameID) { }

	public Vector4 GetVector(string name) { }

	public Vector4[] GetVectorArray(string name) { }

	public void GetVectorArray(string name, List<Vector4> values) { }

	public void GetVectorArray(int nameID, List<Vector4> values) { }

	public Vector4[] GetVectorArray(int nameID) { }

	[FreeFunction(Name = "MaterialScripting::GetVectorArrayCount", HasExplicitThis = True)]
	private int GetVectorArrayCountImpl(int name) { }

	private static int GetVectorArrayCountImpl_Injected(IntPtr _unity_self, int name) { }

	[FreeFunction(Name = "MaterialScripting::GetVectorArray", HasExplicitThis = True)]
	private Vector4[] GetVectorArrayImpl(int name) { }

	private static void GetVectorArrayImpl_Injected(IntPtr _unity_self, int name, out BlittableArrayWrapper ret) { }

	public bool HasBuffer(string name) { }

	public bool HasBuffer(int nameID) { }

	[NativeName("HasBufferFromScript")]
	private bool HasBufferImpl(int name) { }

	private static bool HasBufferImpl_Injected(IntPtr _unity_self, int name) { }

	public bool HasColor(int nameID) { }

	public bool HasColor(string name) { }

	public bool HasConstantBuffer(int nameID) { }

	public bool HasConstantBuffer(string name) { }

	[NativeName("HasConstantBufferFromScript")]
	private bool HasConstantBufferImpl(int name) { }

	private static bool HasConstantBufferImpl_Injected(IntPtr _unity_self, int name) { }

	public bool HasFloat(int nameID) { }

	public bool HasFloat(string name) { }

	[NativeName("HasFloatFromScript")]
	private bool HasFloatImpl(int name) { }

	private static bool HasFloatImpl_Injected(IntPtr _unity_self, int name) { }

	public bool HasInt(string name) { }

	public bool HasInt(int nameID) { }

	public bool HasInteger(int nameID) { }

	public bool HasInteger(string name) { }

	[NativeName("HasIntegerFromScript")]
	private bool HasIntImpl(int name) { }

	private static bool HasIntImpl_Injected(IntPtr _unity_self, int name) { }

	public bool HasMatrix(string name) { }

	public bool HasMatrix(int nameID) { }

	[NativeName("HasMatrixFromScript")]
	private bool HasMatrixImpl(int name) { }

	private static bool HasMatrixImpl_Injected(IntPtr _unity_self, int name) { }

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	private static bool HasProperty_Injected(IntPtr _unity_self, int nameID) { }

	public bool HasTexture(int nameID) { }

	public bool HasTexture(string name) { }

	[NativeName("HasTextureFromScript")]
	private bool HasTextureImpl(int name) { }

	private static bool HasTextureImpl_Injected(IntPtr _unity_self, int name) { }

	public bool HasVector(int nameID) { }

	public bool HasVector(string name) { }

	[NativeName("HasVectorFromScript")]
	private bool HasVectorImpl(int name) { }

	private static bool HasVectorImpl_Injected(IntPtr _unity_self, int name) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool IsKeywordEnabled(in LocalKeyword keyword) { }

	private static bool IsKeywordEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	[FreeFunction("MaterialScripting::IsKeywordEnabled", HasExplicitThis = True)]
	private bool IsLocalKeywordEnabled(LocalKeyword keyword) { }

	private static bool IsLocalKeywordEnabled_Injected(IntPtr _unity_self, in LocalKeyword keyword) { }

	[FreeFunction("MaterialScripting::Lerp", HasExplicitThis = True)]
	[NativeThrows]
	public void Lerp(Material start, Material end, float t) { }

	private static void Lerp_Injected(IntPtr _unity_self, IntPtr start, IntPtr end, float t) { }

	public void set_color(Color value) { }

	public void set_doubleSidedGI(bool value) { }

	private static void set_doubleSidedGI_Injected(IntPtr _unity_self, bool value) { }

	public void set_enabledKeywords(LocalKeyword[] value) { }

	public void set_enableInstancing(bool value) { }

	private static void set_enableInstancing_Injected(IntPtr _unity_self, bool value) { }

	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	private static void set_globalIlluminationFlags_Injected(IntPtr _unity_self, MaterialGlobalIlluminationFlags value) { }

	public void set_mainTexture(Texture value) { }

	public void set_mainTextureOffset(Vector2 value) { }

	public void set_mainTextureScale(Vector2 value) { }

	[NativeName("SetCustomRenderQueue")]
	public void set_renderQueue(int value) { }

	private static void set_renderQueue_Injected(IntPtr _unity_self, int value) { }

	public void set_shader(Shader value) { }

	private static void set_shader_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_shaderKeywords(String[] value) { }

	public void SetBuffer(string name, GraphicsBuffer value) { }

	public void SetBuffer(int nameID, GraphicsBuffer value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	[NativeName("SetBufferFromScript")]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	private void SetColorArray(int name, Color[] values, int count) { }

	public void SetColorArray(int nameID, Color[] values) { }

	public void SetColorArray(string name, Color[] values) { }

	public void SetColorArray(string name, List<Color> values) { }

	public void SetColorArray(int nameID, List<Color> values) { }

	[FreeFunction(Name = "MaterialScripting::SetColorArray", HasExplicitThis = True)]
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	private static void SetColorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[NativeName("SetColorFromScript")]
	private void SetColorImpl(int name, Color value) { }

	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	private static void SetConstantBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size) { }

	[NativeName("SetConstantBufferFromScript")]
	private void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	private static void SetConstantGraphicsBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size) { }

	[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = True)]
	private void SetEnabledKeywords(LocalKeyword[] keywords) { }

	private static void SetEnabledKeywords_Injected(IntPtr _unity_self, LocalKeyword[] keywords) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloatArray(string name, List<Single> values) { }

	public void SetFloatArray(int nameID, List<Single> values) { }

	public void SetFloatArray(string name, Single[] values) { }

	public void SetFloatArray(int nameID, Single[] values) { }

	private void SetFloatArray(int name, Single[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = True)]
	private void SetFloatArrayImpl(int name, Single[] values, int count) { }

	private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value) { }

	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	[NativeName("SetBufferFromScript")]
	private void SetGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	private static void SetGraphicsBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	public void SetInt(int nameID, int value) { }

	public void SetInt(string name, int value) { }

	public void SetInteger(string name, int value) { }

	public void SetInteger(int nameID, int value) { }

	[NativeName("SetIntFromScript")]
	private void SetIntImpl(int name, int value) { }

	private static void SetIntImpl_Injected(IntPtr _unity_self, int name, int value) { }

	public void SetKeyword(in LocalKeyword keyword, bool value) { }

	[FreeFunction("MaterialScripting::SetKeyword", HasExplicitThis = True)]
	private void SetLocalKeyword(LocalKeyword keyword, bool value) { }

	private static void SetLocalKeyword_Injected(IntPtr _unity_self, in LocalKeyword keyword, bool value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = True)]
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	private static void SetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[NativeName("SetMatrixFromScript")]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	public void SetOverrideTag(string tag, string val) { }

	private static void SetOverrideTag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag, ref ManagedSpanWrapper val) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	public bool SetPass(int pass) { }

	private static bool SetPass_Injected(IntPtr _unity_self, int pass) { }

	[NativeName("SetRenderTextureFromScript")]
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	private static void SetRenderTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value, RenderTextureSubElement element) { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(String[] names) { }

	private static void SetShaderKeywords_Injected(IntPtr _unity_self, String[] names) { }

	[FreeFunction("MaterialScripting::SetShaderPassEnabled", HasExplicitThis = True)]
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	private static void SetShaderPassEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName, bool enabled) { }

	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value) { }

	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	public void SetTextureOffset(int nameID, Vector2 value) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	[NativeName("SetTextureOffsetFromScript")]
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	private static void SetTextureOffsetImpl_Injected(IntPtr _unity_self, int name, in Vector2 offset) { }

	public void SetTextureScale(int nameID, Vector2 value) { }

	public void SetTextureScale(string name, Vector2 value) { }

	[NativeName("SetTextureScaleFromScript")]
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private static void SetTextureScaleImpl_Injected(IntPtr _unity_self, int name, in Vector2 scale) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVectorArray(int nameID, List<Vector4> values) { }

	public void SetVectorArray(string name, Vector4[] values) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	public void SetVectorArray(string name, List<Vector4> values) { }

	[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = True)]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

}

