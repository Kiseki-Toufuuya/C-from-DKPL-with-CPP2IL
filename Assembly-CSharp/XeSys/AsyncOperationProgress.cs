namespace XeSys;

public class AsyncOperationProgress
{
	private int m_StepNum; //Field offset: 0x8
	private int m_CurrentStep; //Field offset: 0xC
	private bool m_InitFlg; //Field offset: 0x10
	private AsyncOperation m_CurrentOperation; //Field offset: 0x14

	public AsyncOperationProgress() { }

	public void Clear() { }

	public void End() { }

	public AsyncOperation GetCurrentOperation() { }

	public float GetProgress() { }

	public void InitStepNum(int stepNum) { }

	public void SetOperation(AsyncOperation operation) { }

}

