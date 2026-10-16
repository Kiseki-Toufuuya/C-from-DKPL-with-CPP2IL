namespace Live2D.Cubism.Rendering;

public interface ICubismDrawOrderHandler
{

	public void OnDrawOrderDidChange(CubismRenderController controller, CubismDrawable drawable, int newDrawOrder) { }

}

