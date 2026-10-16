namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
public sealed class AppDomain : MarshalByRefObject
{
	[ThreadStatic]
	private static Dictionary<String, Object> type_resolve_in_progress; //Field offset: 0x80000000
	[ThreadStatic]
	private static Dictionary<String, Object> assembly_resolve_in_progress; //Field offset: 0x80000004
	[ThreadStatic]
	private static Dictionary<String, Object> assembly_resolve_in_progress_refonly; //Field offset: 0x80000008
	private static string _process_guid; //Field offset: 0x0
	private IntPtr _mono_app_domain; //Field offset: 0xC
	private object _evidence; //Field offset: 0x10
	private object _granted; //Field offset: 0x14
	private int _principalPolicy; //Field offset: 0x18
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x1C
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x20
	[CompilerGenerated]
	private EventHandler DomainUnload; //Field offset: 0x24
	[CompilerGenerated]
	private EventHandler ProcessExit; //Field offset: 0x28
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; //Field offset: 0x2C
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; //Field offset: 0x30
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x34
	[CompilerGenerated]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; //Field offset: 0x38
	private object _domain_manager; //Field offset: 0x3C
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x40
	private object _activation; //Field offset: 0x44
	private object _applicationIdentity; //Field offset: 0x48
	private List<String> compatibility_switch; //Field offset: 0x4C

	public override event EventHandler DomainUnload
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public override event EventHandler ProcessExit
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public override event UnhandledExceptionEventHandler UnhandledException
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public static AppDomain CurrentDomain
	{
		 get { } //Length: 5
	}

	public override string FriendlyName
	{
		 get { } //Length: 16
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		 get { } //Length: 3
	}

	[MonoTODO]
	public bool IsHomogenous
	{
		 get { } //Length: 3
	}

	private AppDomain() { }

	[CompilerGenerated]
	public override void add_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	public override void add_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	public override void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	private void DoAssemblyLoad(Assembly assembly) { }

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	private void DoDomainUnload() { }

	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	internal Assembly DoTypeResolve(string name) { }

	public static AppDomain get_CurrentDomain() { }

	public override string get_FriendlyName() { }

	public bool get_IsFullyTrusted() { }

	public bool get_IsHomogenous() { }

	public override Assembly[] GetAssemblies() { }

	private Assembly[] GetAssemblies(bool refOnly) { }

	private static AppDomain getCurDomain() { }

	public override object GetData(string name) { }

	private int getDomainID() { }

	private string getFriendlyName() { }

	internal Byte[] GetMarshalledDomainObjRef() { }

	internal static string GetProcessGuid() { }

	public virtual object InitializeLifetimeService() { }

	internal static Context InternalGetContext() { }

	internal static Context InternalGetDefaultContext() { }

	internal static string InternalGetProcessGuid(string newguid) { }

	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	internal static void InternalPopDomainRef() { }

	internal static void InternalPushDomainRefByID(int domain_id) { }

	internal static Context InternalSetContext(Context context) { }

	private static AppDomain InternalSetDomain(AppDomain context) { }

	private static AppDomain InternalSetDomainByID(int domain_id) { }

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, Object[] args) { }

	[Intrinsic]
	internal static bool IsAppXModel() { }

	public bool IsFinalizingForUnload() { }

	public override Assembly Load(string assemblyString) { }

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark) { }

	internal void ProcessMessageInDomain(Byte[] arrRequest, CADMethodCallMessage cadMsg, out Byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGenerated]
	public override void remove_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	public virtual string ToString() { }

}

