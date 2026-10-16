//Type is in global namespace

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
{
	public string DisplayName; //Field offset: 0xC
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; //Field offset: 0x10

	public CinemachineShot() { }

	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

}

