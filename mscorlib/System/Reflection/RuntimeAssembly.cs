namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
internal class RuntimeAssembly : Assembly
{
	public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
	{
		private Module module; //Field offset: 0x50

		public UnmanagedMemoryStreamForModule(Byte* pointer, long length, Module module) { }

		protected virtual void Dispose(bool disposing) { }

	}

	internal IntPtr _mono_assembly; //Field offset: 0x8
	private object _evidence; //Field offset: 0xC
	internal ResolveEventHolder resolve_event_holder; //Field offset: 0x10
	private object _minimum; //Field offset: 0x14
	private object _optional; //Field offset: 0x18
	private object _refuse; //Field offset: 0x1C
	private object _granted; //Field offset: 0x20
	private object _denied; //Field offset: 0x24
	internal bool fromByteArray; //Field offset: 0x28
	internal string assemblyName; //Field offset: 0x2C

	public virtual string CodeBase
	{
		 get { } //Length: 16
	}

	public virtual string FullName
	{
		 get { } //Length: 16
	}

	public virtual string Location
	{
		 get { } //Length: 35
	}

	internal virtual IntPtr MonoAssembly
	{
		internal get { } //Length: 11
	}

	[ComVisible(False)]
	public virtual bool ReflectionOnly
	{
		 get { } //Length: 16
	}

	protected RuntimeAssembly() { }

	public virtual bool Equals(object o) { }

	private static string get_code_base(Assembly a, bool escaped) { }

	public virtual string get_CodeBase() { }

	internal static string get_fullname(Assembly a) { }

	public virtual string get_FullName() { }

	private string get_location() { }

	public virtual string get_Location() { }

	internal virtual IntPtr get_MonoAssembly() { }

	public virtual bool get_ReflectionOnly() { }

	internal static Byte[] GetAotId() { }

	internal static bool GetAotIdInternal(Byte[] aotid) { }

	internal static string GetCodeBase(Assembly a, bool escaped) { }

	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual Object[] GetCustomAttributes(bool inherit) { }

	public virtual int GetHashCode() { }

	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	public virtual String[] GetManifestResourceNames() { }

	public virtual Stream GetManifestResourceStream(string name) { }

	public virtual Module GetModule(string name) { }

	public virtual Module[] GetModules(bool getResourceModules) { }

	internal virtual Module[] GetModulesInternal() { }

	public virtual AssemblyName GetName(bool copiedName) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual AssemblyName[] GetReferencedAssemblies() { }

	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	public virtual string ToString() { }

}

