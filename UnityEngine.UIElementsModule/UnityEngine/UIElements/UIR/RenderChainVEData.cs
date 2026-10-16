namespace UnityEngine.UIElements.UIR;

internal struct RenderChainVEData
{
	public VisualElement prev; //Field offset: 0x0
	public VisualElement next; //Field offset: 0x4
	public VisualElement groupTransformAncestor; //Field offset: 0x8
	public VisualElement boneTransformAncestor; //Field offset: 0xC
	public VisualElement prevDirty; //Field offset: 0x10
	public VisualElement nextDirty; //Field offset: 0x14
	public RenderDataFlags flags; //Field offset: 0x18
	public int hierarchyDepth; //Field offset: 0x1C
	public RenderDataDirtyTypes dirtiedValues; //Field offset: 0x20
	public uint dirtyID; //Field offset: 0x24
	public RenderChainCommand firstHeadCommand; //Field offset: 0x28
	public RenderChainCommand lastHeadCommand; //Field offset: 0x2C
	public RenderChainCommand firstTailCommand; //Field offset: 0x30
	public RenderChainCommand lastTailCommand; //Field offset: 0x34
	public bool localFlipsWinding; //Field offset: 0x38
	public bool localTransformScaleZero; //Field offset: 0x39
	public bool worldFlipsWinding; //Field offset: 0x3A
	public bool worldTransformScaleZero; //Field offset: 0x3B
	public ClipMethod clipMethod; //Field offset: 0x3C
	public int childrenStencilRef; //Field offset: 0x40
	public int childrenMaskDepth; //Field offset: 0x44
	public MeshHandle headMesh; //Field offset: 0x48
	public MeshHandle tailMesh; //Field offset: 0x4C
	public Matrix4x4 verticesSpace; //Field offset: 0x50
	public BMPAlloc transformID; //Field offset: 0x90
	public BMPAlloc clipRectID; //Field offset: 0x98
	public BMPAlloc opacityID; //Field offset: 0xA0
	public BMPAlloc textCoreSettingsID; //Field offset: 0xA8
	public BMPAlloc colorID; //Field offset: 0xB0
	public BMPAlloc backgroundColorID; //Field offset: 0xB8
	public BMPAlloc borderLeftColorID; //Field offset: 0xC0
	public BMPAlloc borderTopColorID; //Field offset: 0xC8
	public BMPAlloc borderRightColorID; //Field offset: 0xD0
	public BMPAlloc borderBottomColorID; //Field offset: 0xD8
	public BMPAlloc tintColorID; //Field offset: 0xE0
	public float compositeOpacity; //Field offset: 0xE8
	public float backgroundAlpha; //Field offset: 0xEC
	public BasicNode<TextureEntry> textures; //Field offset: 0xF0
	public bool pendingRepaint; //Field offset: 0xF4
	public bool pendingHierarchicalRepaint; //Field offset: 0xF5

	public bool hasExtraData
	{
		 get { } //Length: 16
	}

	public bool hasExtraMeshes
	{
		 get { } //Length: 16
	}

	public bool isGroupTransform
	{
		 get { } //Length: 15
	}

	public bool isIgnoringDynamicColorHint
	{
		 get { } //Length: 16
	}

	public bool isInChain
	{
		 get { } //Length: 13
	}

	public RenderChainCommand lastTailOrHeadCommand
	{
		 get { } //Length: 22
	}

	public static bool AllocatesID(BMPAlloc alloc) { }

	public bool get_hasExtraData() { }

	public bool get_hasExtraMeshes() { }

	public bool get_isGroupTransform() { }

	public bool get_isIgnoringDynamicColorHint() { }

	public bool get_isInChain() { }

	public RenderChainCommand get_lastTailOrHeadCommand() { }

	public static bool InheritsID(BMPAlloc alloc) { }

}

