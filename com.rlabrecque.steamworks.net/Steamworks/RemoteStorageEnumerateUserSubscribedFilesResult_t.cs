namespace Steamworks;

[CallbackIdentity(1314)]
public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
{
	public EResult m_eResult; //Field offset: 0x0
	public int m_nResultsReturned; //Field offset: 0x4
	public int m_nTotalResultCount; //Field offset: 0x8
	public PublishedFileId_t[] m_rgPublishedFileId; //Field offset: 0xC
	public UInt32[] m_rgRTimeSubscribed; //Field offset: 0x10

}

