namespace Live2D.Cubism.Framework.UserData;

[CubismDontMoveOnReimport]
public class CubismUserDataTag : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private string _value; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private CubismUserDataBody _body; //Field offset: 0x14

	private CubismUserDataBody Body
	{
		private get { } //Length: 14
		private set { } //Length: 34
	}

	public string Value
	{
		 get { } //Length: 71
		 set { } //Length: 27
	}

	public CubismUserDataTag() { }

	private CubismUserDataBody get_Body() { }

	public string get_Value() { }

	public void Initialize(CubismUserDataBody body) { }

	private void set_Body(CubismUserDataBody value) { }

	public void set_Value(string value) { }

}

