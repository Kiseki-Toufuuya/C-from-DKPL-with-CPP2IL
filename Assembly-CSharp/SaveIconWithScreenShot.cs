//Type is in global namespace

public class SaveIconWithScreenShot : MonoBehaviour
{
	private bool doScreenshot; //Field offset: 0x10
	private MountPoint currentMP; //Field offset: 0x14

	public SaveIconWithScreenShot() { }

	public void DoScreenShot(MountPoint mp) { }

	private void LateUpdate() { }

	public void SaveIcon(MountPoint mp, Byte[] pngBytes) { }

}

