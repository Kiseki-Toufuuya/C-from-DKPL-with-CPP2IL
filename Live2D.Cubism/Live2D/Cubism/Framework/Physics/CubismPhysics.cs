namespace Live2D.Cubism.Framework.Physics;

public static class CubismPhysics
{
	public static Vector2 Gravity; //Field offset: 0x0
	public const float MovementThreshold = 0.001; //Field offset: 0x0
	public const float MaxDeltaTime = 5; //Field offset: 0x0
	public static Vector2 Wind; //Field offset: 0x8
	public static float AirResistance; //Field offset: 0x10
	public static float MaximumWeight; //Field offset: 0x14
	public static bool UseFixedDeltaTime; //Field offset: 0x18
	public static bool UseAngleCorrection; //Field offset: 0x19

	private static CubismPhysics() { }

}

