namespace UnityEngine.UIElements;

public struct TransformOrigin : IEquatable<TransformOrigin>
{
	public class PropertyBag : ContainerPropertyBag<TransformOrigin>
	{
		private class XProperty : Property<TransformOrigin, Length>
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

			public XProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual Length GetValue(ref TransformOrigin container) { }

			public virtual void SetValue(ref TransformOrigin container, Length value) { }

		}

		private class YProperty : Property<TransformOrigin, Length>
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

			public YProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual Length GetValue(ref TransformOrigin container) { }

			public virtual void SetValue(ref TransformOrigin container, Length value) { }

		}

		private class ZProperty : Property<TransformOrigin, Single>
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

			public ZProperty() { }

			[CompilerGenerated]
			public virtual bool get_IsReadOnly() { }

			[CompilerGenerated]
			public virtual string get_Name() { }

			public virtual float GetValue(ref TransformOrigin container) { }

			public virtual void SetValue(ref TransformOrigin container, float value) { }

		}


		public PropertyBag() { }

	}

	private Length m_X; //Field offset: 0x0
	private Length m_Y; //Field offset: 0x8
	private float m_Z; //Field offset: 0x10

	public Length x
	{
		 get { } //Length: 13
		 set { } //Length: 19
	}

	public Length y
	{
		 get { } //Length: 14
		 set { } //Length: 20
	}

	public float z
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public TransformOrigin(Length x, Length y, float z) { }

	internal TransformOrigin(Vector3 vector) { }

	public override bool Equals(TransformOrigin other) { }

	public virtual bool Equals(object obj) { }

	public Length get_x() { }

	public Length get_y() { }

	public float get_z() { }

	public virtual int GetHashCode() { }

	public static TransformOrigin Initial() { }

	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	public void set_x(Length value) { }

	public void set_y(Length value) { }

	public void set_z(float value) { }

	public virtual string ToString() { }

}

