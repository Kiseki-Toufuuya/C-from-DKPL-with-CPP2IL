namespace UnityEngine.ParticleSystemJobs;

internal struct NativeParticleData
{
	public struct Array3
	{
		internal Single* x; //Field offset: 0x0
		internal Single* y; //Field offset: 0x4
		internal Single* z; //Field offset: 0x8

	}

	public struct Array4
	{
		internal Single* x; //Field offset: 0x0
		internal Single* y; //Field offset: 0x4
		internal Single* z; //Field offset: 0x8
		internal Single* w; //Field offset: 0xC

	}

	internal int count; //Field offset: 0x0
	internal Array3 positions; //Field offset: 0x4
	internal Array3 velocities; //Field offset: 0x10
	internal Array3 axisOfRotations; //Field offset: 0x1C
	internal Array3 rotations; //Field offset: 0x28
	internal Array3 rotationalSpeeds; //Field offset: 0x34
	internal Array3 sizes; //Field offset: 0x40
	internal Void* startColors; //Field offset: 0x4C
	internal Void* aliveTimePercent; //Field offset: 0x50
	internal Void* inverseStartLifetimes; //Field offset: 0x54
	internal Void* randomSeeds; //Field offset: 0x58
	internal Array4 customData1; //Field offset: 0x5C
	internal Array4 customData2; //Field offset: 0x6C
	internal Void* meshIndices; //Field offset: 0x7C

}

