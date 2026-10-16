namespace UnityEngine;

[UsedByNativeCode]
public struct Plane : IFormattable
{
	private Vector3 m_Normal; //Field offset: 0x0
	private float m_Distance; //Field offset: 0xC

	public Vector3 normal
	{
		 get { } //Length: 25
	}

	public Plane(Vector3 inNormal, Vector3 inPoint) { }

	public Plane(Vector3 a, Vector3 b, Vector3 c) { }

	public Vector3 get_normal() { }

	public bool Raycast(Ray ray, out float enter) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

