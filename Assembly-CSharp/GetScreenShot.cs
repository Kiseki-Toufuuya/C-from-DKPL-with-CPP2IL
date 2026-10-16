//Type is in global namespace

public class GetScreenShot : MonoBehaviour
{
	private bool doScreenshot; //Field offset: 0x10
	public Byte[] screenShotBytes; //Field offset: 0x14

	public bool IsWaiting
	{
		 get { } //Length: 11
	}

	public GetScreenShot() { }

	public void DoScreenShot() { }

	public bool get_IsWaiting() { }

	private void LateUpdate() { }

}

