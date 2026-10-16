namespace Mono.Security.Interface;

public sealed class MonoTlsSettings
{
	private static MonoTlsSettings defaultSettings; //Field offset: 0x0
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private String[] <CertificateSearchPaths>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private String[] <ClientCertificateIssuers>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; //Field offset: 0x40
	private bool cloned; //Field offset: 0x44
	private bool checkCertName; //Field offset: 0x45
	private bool checkCertRevocationStatus; //Field offset: 0x46
	private Nullable<Boolean> useServicePointManagerCallback; //Field offset: 0x47
	private bool skipSystemValidators; //Field offset: 0x49
	private bool callbackNeedsChain; //Field offset: 0x4A
	private ICertificateValidator certificateValidator; //Field offset: 0x4C

	public bool CallbackNeedsCertificateChain
	{
		 get { } //Length: 11
	}

	internal String[] CertificateSearchPaths
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public Nullable<DateTime> CertificateValidationTime
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator
	{
		 get { } //Length: 11
	}

	public String[] ClientCertificateIssuers
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public static MonoTlsSettings DefaultSettings
	{
		 get { } //Length: 99
	}

	public bool DisallowUnauthenticatedCertificateRequest
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Nullable<TlsProtocols> EnabledProtocols
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	internal bool SendCloseNotify
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public X509CertificateCollection TrustAnchors
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public object UserSettings
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Nullable<Boolean> UseServicePointManagerCallback
	{
		 get { } //Length: 12
		 set { } //Length: 16
	}

	private MonoTlsSettings(MonoTlsSettings other) { }

	public MonoTlsSettings() { }

	public MonoTlsSettings Clone() { }

	[Obsolete("Do not use outside System.dll!")]
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	public static MonoTlsSettings CopyDefaultSettings() { }

	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	internal String[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	public Nullable<DateTime> get_CertificateValidationTime() { }

	public ICertificateValidator get_CertificateValidator() { }

	[CompilerGenerated]
	public String[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	public static MonoTlsSettings get_DefaultSettings() { }

	[CompilerGenerated]
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGenerated]
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	public object get_UserSettings() { }

	public Nullable<Boolean> get_UseServicePointManagerCallback() { }

	[CompilerGenerated]
	internal void set_CertificateSearchPaths(String[] value) { }

	[CompilerGenerated]
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	public void set_ClientCertificateIssuers(String[] value) { }

	[CompilerGenerated]
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	[CompilerGenerated]
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	[CompilerGenerated]
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGenerated]
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	public void set_UserSettings(object value) { }

	public void set_UseServicePointManagerCallback(Nullable<Boolean> value) { }

}

