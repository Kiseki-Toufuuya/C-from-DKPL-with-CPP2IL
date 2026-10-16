namespace UnityEngine.AddressableAssets;

public class AssetLabelReference : IKeyEvaluator
{
	[FormerlySerializedAs("m_labelString")]
	[SerializeField]
	private string m_LabelString; //Field offset: 0x8

	public string labelString
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override object RuntimeKey
	{
		 get { } //Length: 46
	}

	public AssetLabelReference() { }

	public string get_labelString() { }

	public override object get_RuntimeKey() { }

	public virtual int GetHashCode() { }

	public override bool RuntimeKeyIsValid() { }

	public void set_labelString(string value) { }

}

