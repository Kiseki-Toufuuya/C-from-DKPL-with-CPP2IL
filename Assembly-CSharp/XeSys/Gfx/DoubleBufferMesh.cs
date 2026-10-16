namespace XeSys.Gfx;

public class DoubleBufferMesh
{
	private Mesh[] mMesh; //Field offset: 0x8
	private int mCurrentId; //Field offset: 0xC

	public DoubleBufferMesh() { }

	public void Destroy() { }

	public Mesh GetActiveMesh() { }

	public void Swap() { }

}

