namespace Live2D.Cubism.Rendering.Masking;

public interface ICubismMaskCommandSource
{

	public int CountOfCommandBuffers
	{
		 get { } //Length: 0
	}

	public void AddToCommandBuffer(CommandBuffer buffer, bool isUsingMultipleBuffer, int bufferIndex) { }

	public int get_CountOfCommandBuffers() { }

}

