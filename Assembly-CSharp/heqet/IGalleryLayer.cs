namespace Heqet;

internal interface IGalleryLayer
{

	public UniTask Open(bool is_open) { }

	public void SetTopLayer(GalleryTopLayer topLayer) { }

}

