namespace UnityEngine.UIElements;

public struct Background : IEquatable<Background>
{
	public class PropertyBag : ContainerPropertyBag<Background>
	{
		private class RenderTextureProperty : Property<Background, RenderTexture>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0xC
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

			public virtual bool IsReadOnly
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public virtual string Name
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public RenderTextureProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual RenderTexture GetValue(ref Background container) { }

			public virtual void SetValue(ref Background container, RenderTexture value) { }

		}

		private class SpriteProperty : Property<Background, Sprite>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0xC
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

			public virtual bool IsReadOnly
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public virtual string Name
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public SpriteProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual Sprite GetValue(ref Background container) { }

			public virtual void SetValue(ref Background container, Sprite value) { }

		}

		private class TextureProperty : Property<Background, Texture2D>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0xC
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

			public virtual bool IsReadOnly
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public virtual string Name
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public TextureProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual Texture2D GetValue(ref Background container) { }

			public virtual void SetValue(ref Background container, Texture2D value) { }

		}

		private class VectorImageProperty : Property<Background, VectorImage>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly string <Name>k__BackingField; //Field offset: 0xC
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

			public virtual bool IsReadOnly
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public virtual string Name
			{
				[CompilerGenerated]
				 get { } //Length: 11
			}

			public VectorImageProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual VectorImage GetValue(ref Background container) { }

			public virtual void SetValue(ref Background container, VectorImage value) { }

		}


		public PropertyBag() { }

	}

	private Texture2D m_Texture; //Field offset: 0x0
	private Sprite m_Sprite; //Field offset: 0x4
	private RenderTexture m_RenderTexture; //Field offset: 0x8
	private VectorImage m_VectorImage; //Field offset: 0xC

	public RenderTexture renderTexture
	{
		 get { } //Length: 11
		 set { } //Length: 151
	}

	public Sprite sprite
	{
		 get { } //Length: 11
		 set { } //Length: 151
	}

	public Texture2D texture
	{
		 get { } //Length: 10
		 set { } //Length: 150
	}

	public VectorImage vectorImage
	{
		 get { } //Length: 11
		 set { } //Length: 151
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Background other) { }

	internal static Background FromObject(object obj) { }

	public static Background FromRenderTexture(RenderTexture rt) { }

	public static Background FromSprite(Sprite s) { }

	public static Background FromTexture2D(Texture2D t) { }

	public static Background FromVectorImage(VectorImage vi) { }

	public RenderTexture get_renderTexture() { }

	public Sprite get_sprite() { }

	public Texture2D get_texture() { }

	public VectorImage get_vectorImage() { }

	public virtual int GetHashCode() { }

	public bool IsEmpty() { }

	public static bool op_Equality(Background lhs, Background rhs) { }

	public static Background op_Implicit(Texture2D v) { }

	public static bool op_Inequality(Background lhs, Background rhs) { }

	public void set_renderTexture(RenderTexture value) { }

	public void set_sprite(Sprite value) { }

	public void set_texture(Texture2D value) { }

	public void set_vectorImage(VectorImage value) { }

	public virtual string ToString() { }

}

