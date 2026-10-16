namespace UnityEngine;

[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public sealed class MaterialPropertyBlock
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x8

	public MaterialPropertyBlock() { }

	[ThreadSafe]
	private void Clear(bool keepMemory) { }

	public void Clear() { }

	private static void Clear_Injected(IntPtr _unity_self, bool keepMemory) { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = True)]
	private static IntPtr CreateImpl() { }

	[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = True, IsThreadSafe = True)]
	private static void DestroyImpl(IntPtr mpb) { }

	private void Dispose() { }

	protected virtual void Finalize() { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	[NativeName("SetBufferFromScript")]
	[ThreadSafe]
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetColor(string name, Color value) { }

	[NativeName("SetColorFromScript")]
	[ThreadSafe]
	private void SetColorImpl(int name, Color value) { }

	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetFloat(string name, float value) { }

	[NativeName("SetFloatFromScript")]
	[ThreadSafe]
	private void SetFloatImpl(int name, float value) { }

	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	[NativeName("SetMatrixFromScript")]
	[ThreadSafe]
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	[NativeName("SetTextureFromScript")]
	[ThreadSafe]
	private void SetTextureImpl(int name, Texture value) { }

	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVectorArray(int nameID, Vector4[] values) { }

	private void SetVectorArray(int name, Vector4[] values, int count) { }

	[NativeName("SetVectorArrayFromScript")]
	[ThreadSafe]
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count) { }

	[NativeName("SetVectorFromScript")]
	[ThreadSafe]
	private void SetVectorImpl(int name, Vector4 value) { }

	private static void SetVectorImpl_Injected(IntPtr _unity_self, int name, in Vector4 value) { }

}

