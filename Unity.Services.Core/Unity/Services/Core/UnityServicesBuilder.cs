namespace Unity.Services.Core;

internal static class UnityServicesBuilder
{
	public sealed class CreationDelegate : MulticastDelegate
	{

		public CreationDelegate(object object, IntPtr method) { }

		public override IUnityServices Invoke(string servicesId) { }

	}

	[CompilerGenerated]
	private static CreationDelegate <InstanceCreationDelegate>k__BackingField; //Field offset: 0x0

	internal static CreationDelegate InstanceCreationDelegate
	{
		[CompilerGenerated]
		internal set { } //Length: 64
	}

	[CompilerGenerated]
	internal static void set_InstanceCreationDelegate(CreationDelegate value) { }

}

