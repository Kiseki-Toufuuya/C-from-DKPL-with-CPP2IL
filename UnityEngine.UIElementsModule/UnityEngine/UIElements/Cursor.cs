namespace UnityEngine.UIElements;

public struct Cursor : IEquatable<Cursor>
{
	public class PropertyBag : ContainerPropertyBag<Cursor>
	{
		private class DefaultCursorIdProperty : Property<Cursor, Int32>
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

			public DefaultCursorIdProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual int GetValue(ref Cursor container) { }

			public virtual void SetValue(ref Cursor container, int value) { }

		}

		private class HotspotProperty : Property<Cursor, Vector2>
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

			public HotspotProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual Vector2 GetValue(ref Cursor container) { }

			public virtual void SetValue(ref Cursor container, Vector2 value) { }

		}

		private class TextureProperty : Property<Cursor, Texture2D>
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

			public virtual Texture2D GetValue(ref Cursor container) { }

			public virtual void SetValue(ref Cursor container, Texture2D value) { }

		}


		public PropertyBag() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Texture2D <texture>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <hotspot>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <defaultCursorId>k__BackingField; //Field offset: 0xC

	internal int defaultCursorId
	{
		[CompilerGenerated]
		[IsReadOnly]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public Vector2 hotspot
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 39
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public Texture2D texture
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 10
		[CompilerGenerated]
		 set { } //Length: 23
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(Cursor other) { }

	[CompilerGenerated]
	[IsReadOnly]
	internal int get_defaultCursorId() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Vector2 get_hotspot() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Texture2D get_texture() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Cursor style1, Cursor style2) { }

	[CompilerGenerated]
	internal void set_defaultCursorId(int value) { }

	[CompilerGenerated]
	public void set_hotspot(Vector2 value) { }

	[CompilerGenerated]
	public void set_texture(Texture2D value) { }

	public virtual string ToString() { }

}

