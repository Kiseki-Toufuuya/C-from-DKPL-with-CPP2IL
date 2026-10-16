namespace Live2D.Cubism.Framework.Json;

public sealed class CubismModel3Json
{
	internal sealed class LoadAssetAtPathHandler : MulticastDelegate
	{

		public LoadAssetAtPathHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Type assetType, string assetPath, AsyncCallback callback, object object) { }

		public override object EndInvoke(IAsyncResult result) { }

		public override object Invoke(Type assetType, string assetPath) { }

	}

	internal sealed class MaterialPicker : MulticastDelegate
	{

		public MaterialPicker(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CubismModel3Json sender, CubismDrawable drawable, AsyncCallback callback, object object) { }

		public override Material EndInvoke(IAsyncResult result) { }

		public override Material Invoke(CubismModel3Json sender, CubismDrawable drawable) { }

	}

	internal struct SerializableExpression
	{
		[SerializeField]
		public string Name; //Field offset: 0x0
		[SerializeField]
		public string File; //Field offset: 0x4
		[SerializeField]
		public float FadeInTime; //Field offset: 0x8
		[SerializeField]
		public float FadeOutTime; //Field offset: 0xC

	}

	internal struct SerializableFileReferences
	{
		[SerializeField]
		public string Moc; //Field offset: 0x0
		[SerializeField]
		public String[] Textures; //Field offset: 0x4
		[SerializeField]
		public string Pose; //Field offset: 0x8
		[SerializeField]
		public SerializableExpression[] Expressions; //Field offset: 0xC
		[SerializeField]
		public SerializableMotions Motions; //Field offset: 0x10
		[SerializeField]
		public string Physics; //Field offset: 0x18
		[SerializeField]
		public string UserData; //Field offset: 0x1C
		[SerializeField]
		public string DisplayInfo; //Field offset: 0x20

	}

	internal struct SerializableGroup
	{
		[SerializeField]
		public string Target; //Field offset: 0x0
		[SerializeField]
		public string Name; //Field offset: 0x4
		[SerializeField]
		public String[] Ids; //Field offset: 0x8

	}

	internal struct SerializableHitArea
	{
		[SerializeField]
		public string Name; //Field offset: 0x0
		[SerializeField]
		public string Id; //Field offset: 0x4

	}

	internal struct SerializableMotion
	{
		[SerializeField]
		public string File; //Field offset: 0x0
		[SerializeField]
		public string Sound; //Field offset: 0x4
		[SerializeField]
		public float FadeInTime; //Field offset: 0x8
		[SerializeField]
		public float FadeOutTime; //Field offset: 0xC

	}

	internal struct SerializableMotions
	{
		[SerializeField]
		public String[] GroupNames; //Field offset: 0x0
		[SerializeField]
		public SerializableMotion[][] Motions; //Field offset: 0x4

	}

	internal sealed class TexturePicker : MulticastDelegate
	{

		public TexturePicker(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CubismModel3Json sender, CubismDrawable drawable, AsyncCallback callback, object object) { }

		public override Texture2D EndInvoke(IAsyncResult result) { }

		public override Texture2D Invoke(CubismModel3Json sender, CubismDrawable drawable) { }

	}

	[CompilerGenerated]
	private string <AssetPath>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private LoadAssetAtPathHandler <LoadAssetAtPath>k__BackingField; //Field offset: 0xC
	[SerializeField]
	public int Version; //Field offset: 0x10
	[SerializeField]
	public SerializableFileReferences FileReferences; //Field offset: 0x14
	[SerializeField]
	public SerializableGroup[] Groups; //Field offset: 0x38
	[SerializeField]
	public SerializableHitArea[] HitAreas; //Field offset: 0x3C
	private CubismPose3Json _pose3Json; //Field offset: 0x40
	private CubismExp3Json[] _expression3Jsons; //Field offset: 0x44
	private Texture2D[] _textures; //Field offset: 0x48

	public private string AssetPath
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public string DisplayInfo3Json
	{
		 get { } //Length: 79
	}

	public CubismExp3Json[] Expression3Jsons
	{
		 get { } //Length: 270
	}

	private LoadAssetAtPathHandler LoadAssetAtPath
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public Byte[] Moc3
	{
		 get { } //Length: 55
	}

	public string Physics3Json
	{
		 get { } //Length: 79
	}

	public CubismPose3Json Pose3Json
	{
		 get { } //Length: 111
	}

	public Texture2D[] Textures
	{
		 get { } //Length: 223
	}

	public string UserData3Json
	{
		 get { } //Length: 79
	}

	private CubismModel3Json() { }

	private static object BuiltinLoadAssetAtPath(Type assetType, string assetPath) { }

	[CompilerGenerated]
	public string get_AssetPath() { }

	public string get_DisplayInfo3Json() { }

	public CubismExp3Json[] get_Expression3Jsons() { }

	[CompilerGenerated]
	private LoadAssetAtPathHandler get_LoadAssetAtPath() { }

	public Byte[] get_Moc3() { }

	public string get_Physics3Json() { }

	public CubismPose3Json get_Pose3Json() { }

	public Texture2D[] get_Textures() { }

	public string get_UserData3Json() { }

	private int GetBodyIndexById(CubismUserDataBody[] bodies, string id) { }

	private bool IsParameterInGroup(CubismParameter parameter, string groupName) { }

	public static CubismModel3Json LoadAtPath(string assetPath, LoadAssetAtPathHandler loadAssetAtPath) { }

	public static CubismModel3Json LoadAtPath(string assetPath) { }

	private T LoadReferencedAsset(string referencedFile) { }

	[CompilerGenerated]
	private void set_AssetPath(string value) { }

	[CompilerGenerated]
	private void set_LoadAssetAtPath(LoadAssetAtPathHandler value) { }

	public CubismModel ToModel(bool shouldImportAsOriginalWorkflow = false) { }

	public CubismModel ToModel(MaterialPicker pickMaterial, TexturePicker pickTexture, bool shouldImportAsOriginalWorkflow = false) { }

}

