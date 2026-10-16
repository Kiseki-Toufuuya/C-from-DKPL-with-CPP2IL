namespace CriWare;

public static class CriAtomExDebug
{
	internal struct ResourcesInfo
	{
		public ResourceUsage virtualVoiceUsage; //Field offset: 0x0
		public ResourceUsage sequenceUsage; //Field offset: 0x8
		public ResourceUsage sequenceTrackUsage; //Field offset: 0x10
		public ResourceUsage sequenceTrackItemUsage; //Field offset: 0x18
		public ResourceUsage parameterBlock; //Field offset: 0x20
		public ResourceUsage beatSyncInfo; //Field offset: 0x28
		public ResourceUsage beatSyncTransitionSetting; //Field offset: 0x30
		public ResourceUsage beatSyncJob; //Field offset: 0x38

	}


	private static void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo) { }

	public static void GetResourcesInfo(out ResourcesInfo resourcesInfo) { }

}

