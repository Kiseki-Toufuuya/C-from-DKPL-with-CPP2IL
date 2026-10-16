namespace Live2D.Cubism.Rendering.Masking;

public interface ICubismMaskTextureCommandSource : ICubismMaskCommandSource
{

	public int GetNecessaryTileCount() { }

	public void SetTiles(CubismMaskTile[] value) { }

}

