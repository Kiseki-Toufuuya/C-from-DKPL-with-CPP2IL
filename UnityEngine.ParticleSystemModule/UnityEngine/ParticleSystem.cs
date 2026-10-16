namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	[NativeType(CodegenOptions::Custom (1), "MonoBurst", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	internal struct Burst
	{
		private float m_Time; //Field offset: 0x0
		private MinMaxCurveBlittable m_Count; //Field offset: 0x4
		private int m_RepeatCount; //Field offset: 0x1C
		private float m_RepeatInterval; //Field offset: 0x20
		private float m_InvProbability; //Field offset: 0x24

		public int cycleCount
		{
			 get { } //Length: 12
			 set { } //Length: 125
		}

		public short maxCount
		{
			 get { } //Length: 20
			 set { } //Length: 24
		}

		public short minCount
		{
			 get { } //Length: 20
			 set { } //Length: 24
		}

		public float repeatInterval
		{
			 get { } //Length: 11
			 set { } //Length: 132
		}

		public int get_cycleCount() { }

		public short get_maxCount() { }

		public short get_minCount() { }

		public float get_repeatInterval() { }

		public void set_cycleCount(int value) { }

		public void set_maxCount(short value) { }

		public void set_minCount(short value) { }

		public void set_repeatInterval(float value) { }

	}

	internal struct CollisionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal CollisionModule(ParticleSystem particleSystem) { }

	}

	internal struct ColorBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ColorBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct ColorOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ColorOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct CustomDataModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal CustomDataModule(ParticleSystem particleSystem) { }

	}

	internal struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public int burstCount
		{
			 get { } //Length: 40
		}

		public bool enabled
		{
			 get { } //Length: 40
			[NativeThrows]
			 set { } //Length: 43
		}

		public MinMaxCurve rateOverTime
		{
			 set { } //Length: 177
		}

		[NativeName("RateOverTime")]
		private MinMaxCurveBlittable rateOverTimeBlittable
		{
			[NativeThrows]
			private set { } //Length: 44
		}

		public float rateOverTimeMultiplier
		{
			 get { } //Length: 47
		}

		internal EmissionModule(ParticleSystem particleSystem) { }

		public int get_burstCount() { }

		public bool get_enabled() { }

		public float get_rateOverTimeMultiplier() { }

		[NativeThrows]
		public Burst GetBurst(int index) { }

		private static void GetBurst_Injected(ref EmissionModule _unity_self, int index, out Burst ret) { }

		[NativeThrows]
		public void set_enabled(bool value) { }

		public void set_rateOverTime(MinMaxCurve value) { }

		[NativeThrows]
		private void set_rateOverTimeBlittable(MinMaxCurveBlittable value) { }

		private static void set_rateOverTimeBlittable_Injected(ref EmissionModule _unity_self, in MinMaxCurveBlittable value) { }

		[NativeThrows]
		public void SetBurst(int index, Burst burst) { }

		private static void SetBurst_Injected(ref EmissionModule _unity_self, int index, in Burst burst) { }

	}

	internal struct EmitParams
	{
		[NativeName("particle")]
		private Particle m_Particle; //Field offset: 0x0
		[NativeName("positionSet")]
		private bool m_PositionSet; //Field offset: 0x84
		[NativeName("velocitySet")]
		private bool m_VelocitySet; //Field offset: 0x85
		[NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[NativeName("rotationSet")]
		private bool m_RotationSet; //Field offset: 0x87
		[NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[NativeName("startSizeSet")]
		private bool m_StartSizeSet; //Field offset: 0x89
		[NativeName("startColorSet")]
		private bool m_StartColorSet; //Field offset: 0x8A
		[NativeName("randomSeedSet")]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[NativeName("meshIndexSet")]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

	}

	internal struct ExternalForcesModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ExternalForcesModule(ParticleSystem particleSystem) { }

	}

	internal struct ForceOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ForceOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct InheritVelocityModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal InheritVelocityModule(ParticleSystem particleSystem) { }

	}

	internal struct LifetimeByEmitterSpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct LightsModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LightsModule(ParticleSystem particleSystem) { }

	}

	internal struct LimitVelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct MainModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public float duration
		{
			 get { } //Length: 47
		}

		public float gravityModifierMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public bool loop
		{
			 get { } //Length: 40
			[NativeThrows]
			 set { } //Length: 43
		}

		public int maxParticles
		{
			 get { } //Length: 40
			[NativeThrows]
			 set { } //Length: 43
		}

		public bool playOnAwake
		{
			 get { } //Length: 40
			[NativeThrows]
			 set { } //Length: 43
		}

		public ParticleSystemScalingMode scalingMode
		{
			 get { } //Length: 40
			[NativeThrows]
			 set { } //Length: 43
		}

		public ParticleSystemSimulationSpace simulationSpace
		{
			 get { } //Length: 40
			[NativeThrows]
			 set { } //Length: 43
		}

		public float simulationSpeed
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public MinMaxGradient startColor
		{
			 get { } //Length: 276
			 set { } //Length: 149
		}

		[NativeName("StartColor")]
		private MinMaxGradientBlittable startColorBlittable
		{
			private get { } //Length: 61
			[NativeThrows]
			private set { } //Length: 44
		}

		public float startDelayMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public MinMaxCurve startLifetime
		{
			 get { } //Length: 245
		}

		[NativeName("StartLifetime")]
		private MinMaxCurveBlittable startLifetimeBlittable
		{
			private get { } //Length: 59
		}

		public float startLifetimeMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		[NativeName("StartRotationZMultiplier")]
		public float startRotationMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public float startRotationXMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public float startRotationYMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public float startRotationZMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		[NativeName("StartSizeXMultiplier")]
		public float startSizeMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		public float startSpeedMultiplier
		{
			 get { } //Length: 47
			[NativeThrows]
			 set { } //Length: 51
		}

		internal MainModule(ParticleSystem particleSystem) { }

		public float get_duration() { }

		public float get_gravityModifierMultiplier() { }

		public bool get_loop() { }

		public int get_maxParticles() { }

		public bool get_playOnAwake() { }

		public ParticleSystemScalingMode get_scalingMode() { }

		public ParticleSystemSimulationSpace get_simulationSpace() { }

		public float get_simulationSpeed() { }

		public MinMaxGradient get_startColor() { }

		private MinMaxGradientBlittable get_startColorBlittable() { }

		private static void get_startColorBlittable_Injected(ref MainModule _unity_self, out MinMaxGradientBlittable ret) { }

		public float get_startDelayMultiplier() { }

		public MinMaxCurve get_startLifetime() { }

		private MinMaxCurveBlittable get_startLifetimeBlittable() { }

		private static void get_startLifetimeBlittable_Injected(ref MainModule _unity_self, out MinMaxCurveBlittable ret) { }

		public float get_startLifetimeMultiplier() { }

		public float get_startRotationMultiplier() { }

		public float get_startRotationXMultiplier() { }

		public float get_startRotationYMultiplier() { }

		public float get_startRotationZMultiplier() { }

		public float get_startSizeMultiplier() { }

		public float get_startSpeedMultiplier() { }

		[NativeThrows]
		public void set_gravityModifierMultiplier(float value) { }

		[NativeThrows]
		public void set_loop(bool value) { }

		[NativeThrows]
		public void set_maxParticles(int value) { }

		[NativeThrows]
		public void set_playOnAwake(bool value) { }

		[NativeThrows]
		public void set_scalingMode(ParticleSystemScalingMode value) { }

		[NativeThrows]
		public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

		[NativeThrows]
		public void set_simulationSpeed(float value) { }

		public void set_startColor(MinMaxGradient value) { }

		[NativeThrows]
		private void set_startColorBlittable(MinMaxGradientBlittable value) { }

		private static void set_startColorBlittable_Injected(ref MainModule _unity_self, in MinMaxGradientBlittable value) { }

		[NativeThrows]
		public void set_startDelayMultiplier(float value) { }

		[NativeThrows]
		public void set_startLifetimeMultiplier(float value) { }

		[NativeThrows]
		public void set_startRotationMultiplier(float value) { }

		[NativeThrows]
		public void set_startRotationXMultiplier(float value) { }

		[NativeThrows]
		public void set_startRotationYMultiplier(float value) { }

		[NativeThrows]
		public void set_startRotationZMultiplier(float value) { }

		[NativeThrows]
		public void set_startSizeMultiplier(float value) { }

		[NativeThrows]
		public void set_startSpeedMultiplier(float value) { }

	}

	internal struct MinMaxCurve
	{
		[SerializeField]
		internal ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[SerializeField]
		internal float m_CurveMultiplier; //Field offset: 0x4
		[SerializeField]
		internal AnimationCurve m_CurveMin; //Field offset: 0x8
		[SerializeField]
		internal AnimationCurve m_CurveMax; //Field offset: 0xC
		[SerializeField]
		internal float m_ConstantMin; //Field offset: 0x10
		[SerializeField]
		internal float m_ConstantMax; //Field offset: 0x14

		public float constantMax
		{
			 get { } //Length: 11
		}

		public MinMaxCurve(float constant) { }

		public float get_constantMax() { }

		public static MinMaxCurve op_Implicit(float constant) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	public struct MinMaxCurveBlittable
	{
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		private float m_CurveMultiplier; //Field offset: 0x4
		private IntPtr m_CurveMin; //Field offset: 0x8
		private IntPtr m_CurveMax; //Field offset: 0xC
		internal float m_ConstantMin; //Field offset: 0x10
		internal float m_ConstantMax; //Field offset: 0x14

		internal static MinMaxCurveBlittable FromMixMaxCurve(in MinMaxCurve minMaxCurve) { }

		public static MinMaxCurve op_Implicit(MinMaxCurveBlittable minMaxCurveBlittable) { }

		public static MinMaxCurveBlittable op_Implicit(MinMaxCurve minMaxCurve) { }

		internal static MinMaxCurve ToMinMaxCurve(in MinMaxCurveBlittable minMaxCurveBlittable) { }

	}

	internal struct MinMaxGradient
	{
		[SerializeField]
		internal ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[SerializeField]
		internal Gradient m_GradientMin; //Field offset: 0x4
		[SerializeField]
		internal Gradient m_GradientMax; //Field offset: 0x8
		[SerializeField]
		internal Color m_ColorMin; //Field offset: 0xC
		[SerializeField]
		internal Color m_ColorMax; //Field offset: 0x1C

		public Color color
		{
			 get { } //Length: 18
		}

		public MinMaxGradient(Color color) { }

		public Color get_color() { }

		public static MinMaxGradient op_Implicit(Color color) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	public struct MinMaxGradientBlittable
	{
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		private IntPtr m_GradientMin; //Field offset: 0x4
		private IntPtr m_GradientMax; //Field offset: 0x8
		private Color m_ColorMin; //Field offset: 0xC
		private Color m_ColorMax; //Field offset: 0x1C

		internal static MinMaxGradientBlittable FromMixMaxGradient(in MinMaxGradient minMaxGradient) { }

		public static MinMaxGradient op_Implicit(MinMaxGradientBlittable minMaxGradientBlittable) { }

		public static MinMaxGradientBlittable op_Implicit(MinMaxGradient minMaxGradient) { }

		internal static MinMaxGradient ToMinMaxGradient(in MinMaxGradientBlittable minMaxGradientBlittable) { }

	}

	internal struct NoiseModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal NoiseModule(ParticleSystem particleSystem) { }

	}

	[RequiredByNativeCode("particleSystemParticle", Optional = True)]
	internal struct Particle
	{
		private Vector3 m_Position; //Field offset: 0x0
		private Vector3 m_Velocity; //Field offset: 0xC
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		private Vector3 m_Rotation; //Field offset: 0x3C
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		private Vector3 m_StartSize; //Field offset: 0x54
		private Color32 m_StartColor; //Field offset: 0x60
		private uint m_RandomSeed; //Field offset: 0x64
		private uint m_ParentRandomSeed; //Field offset: 0x68
		private float m_Lifetime; //Field offset: 0x6C
		private float m_StartLifetime; //Field offset: 0x70
		private int m_MeshIndex; //Field offset: 0x74
		private float m_EmitAccumulator0; //Field offset: 0x78
		private float m_EmitAccumulator1; //Field offset: 0x7C
		private uint m_Flags; //Field offset: 0x80

		public Vector3 angularVelocity3D
		{
			 set { } //Length: 69
		}

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
		public float lifetime
		{
			 set { } //Length: 18
		}

		public Vector3 position
		{
			 get { } //Length: 25
			 set { } //Length: 23
		}

		public uint randomSeed
		{
			 set { } //Length: 14
		}

		public float remainingLifetime
		{
			 set { } //Length: 18
		}

		public Vector3 rotation3D
		{
			 set { } //Length: 69
		}

		public Color32 startColor
		{
			 set { } //Length: 14
		}

		public float startLifetime
		{
			 set { } //Length: 18
		}

		public float startSize
		{
			 set { } //Length: 37
		}

		public Vector3 velocity
		{
			 set { } //Length: 24
		}

		public Vector3 get_position() { }

		public void set_angularVelocity3D(Vector3 value) { }

		public void set_lifetime(float value) { }

		public void set_position(Vector3 value) { }

		public void set_randomSeed(uint value) { }

		public void set_remainingLifetime(float value) { }

		public void set_rotation3D(Vector3 value) { }

		public void set_startColor(Color32 value) { }

		public void set_startLifetime(float value) { }

		public void set_startSize(float value) { }

		public void set_velocity(Vector3 value) { }

	}

	internal struct PlaybackState
	{
		public struct Collision
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Emission
		{
			public float m_ParticleSpacing; //Field offset: 0x0
			public float m_ToEmitAccumulator; //Field offset: 0x4
			public Seed m_Random; //Field offset: 0x8

		}

		public struct Force
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Initial
		{
			public Seed4 m_Random; //Field offset: 0x0

		}

		public struct Lights
		{
			public Seed m_Random; //Field offset: 0x0
			public float m_ParticleEmissionCounter; //Field offset: 0x10

		}

		public struct Noise
		{
			public float m_ScrollOffset; //Field offset: 0x0

		}

		public struct Seed
		{
			public uint x; //Field offset: 0x0
			public uint y; //Field offset: 0x4
			public uint z; //Field offset: 0x8
			public uint w; //Field offset: 0xC

		}

		public struct Seed4
		{
			public Seed x; //Field offset: 0x0
			public Seed y; //Field offset: 0x10
			public Seed z; //Field offset: 0x20
			public Seed w; //Field offset: 0x30

		}

		public struct Shape
		{
			public Seed4 m_Random; //Field offset: 0x0
			public float m_RadiusTimer; //Field offset: 0x40
			public float m_RadiusTimerPrev; //Field offset: 0x44
			public float m_ArcTimer; //Field offset: 0x48
			public float m_ArcTimerPrev; //Field offset: 0x4C
			public float m_MeshSpawnTimer; //Field offset: 0x50
			public float m_MeshSpawnTimerPrev; //Field offset: 0x54
			public int m_OrderedMeshVertexIndex; //Field offset: 0x58

		}

		public struct Trail
		{
			public float m_Timer; //Field offset: 0x0

		}

		internal float m_AccumulatedDt; //Field offset: 0x0
		internal float m_StartDelay; //Field offset: 0x4
		internal float m_PlaybackTime; //Field offset: 0x8
		internal int m_RingBufferIndex; //Field offset: 0xC
		internal Emission m_Emission; //Field offset: 0x10
		internal Initial m_Initial; //Field offset: 0x28
		internal Shape m_Shape; //Field offset: 0x68
		internal Force m_Force; //Field offset: 0xC4
		internal Collision m_Collision; //Field offset: 0x104
		internal Noise m_Noise; //Field offset: 0x144
		internal Lights m_Lights; //Field offset: 0x148
		internal Trail m_Trail; //Field offset: 0x15C

	}

	internal struct RotationBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal RotationBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct RotationOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal RotationOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct ShapeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal ShapeModule(ParticleSystem particleSystem) { }

	}

	internal struct SizeBySpeedModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SizeBySpeedModule(ParticleSystem particleSystem) { }

	}

	internal struct SizeOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal SizeOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	internal struct SubEmittersModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public int subEmittersCount
		{
			 get { } //Length: 40
		}

		internal SubEmittersModule(ParticleSystem particleSystem) { }

		public int get_subEmittersCount() { }

		[NativeThrows]
		public ParticleSystem GetSubEmitterSystem(int index) { }

		private static IntPtr GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index) { }

	}

	internal struct TextureSheetAnimationModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TextureSheetAnimationModule(ParticleSystem particleSystem) { }

	}

	internal struct TrailModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TrailModule(ParticleSystem particleSystem) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoParticleTrails")]
	internal struct Trails
	{
		internal List<Vector4> positions; //Field offset: 0x0
		internal List<Int32> frontPositions; //Field offset: 0x4
		internal List<Int32> backPositions; //Field offset: 0x8
		internal List<Int32> positionCounts; //Field offset: 0xC
		internal List<Single> textureOffsets; //Field offset: 0x10
		internal int maxTrailCount; //Field offset: 0x14
		internal int maxPositionsPerTrailCount; //Field offset: 0x18

		internal void Allocate() { }

	}

	internal struct TriggerModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		internal TriggerModule(ParticleSystem particleSystem) { }

	}

	internal struct VelocityOverLifetimeModule
	{
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		public MinMaxCurve orbitalOffsetX
		{
			 set { } //Length: 177
		}

		[NativeName("OrbitalOffsetX")]
		private MinMaxCurveBlittable orbitalOffsetXBlittable
		{
			[NativeThrows]
			private set { } //Length: 44
		}

		public MinMaxCurve orbitalOffsetY
		{
			 set { } //Length: 177
		}

		[NativeName("OrbitalOffsetY")]
		private MinMaxCurveBlittable orbitalOffsetYBlittable
		{
			[NativeThrows]
			private set { } //Length: 44
		}

		public MinMaxCurve orbitalOffsetZ
		{
			 set { } //Length: 1260
		}

		[NativeName("OrbitalOffsetZ")]
		private MinMaxCurveBlittable orbitalOffsetZBlittable
		{
			[NativeThrows]
			private set { } //Length: 44
		}

		internal VelocityOverLifetimeModule(ParticleSystem particleSystem) { }

		public void set_orbitalOffsetX(MinMaxCurve value) { }

		[NativeThrows]
		private void set_orbitalOffsetXBlittable(MinMaxCurveBlittable value) { }

		private static void set_orbitalOffsetXBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, in MinMaxCurveBlittable value) { }

		public void set_orbitalOffsetY(MinMaxCurve value) { }

		[NativeThrows]
		private void set_orbitalOffsetYBlittable(MinMaxCurveBlittable value) { }

		private static void set_orbitalOffsetYBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, in MinMaxCurveBlittable value) { }

		public void set_orbitalOffsetZ(MinMaxCurve value) { }

		[NativeThrows]
		private void set_orbitalOffsetZBlittable(MinMaxCurveBlittable value) { }

		private static void set_orbitalOffsetZBlittable_Injected(ref VelocityOverLifetimeModule _unity_self, in MinMaxCurveBlittable value) { }

	}


	[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", True)]
	public bool automaticCullingEnabled
	{
		 get { } //Length: 98
	}

	public CollisionModule collision
	{
		 get { } //Length: 27
	}

	public ColorBySpeedModule colorBySpeed
	{
		 get { } //Length: 27
	}

	public ColorOverLifetimeModule colorOverLifetime
	{
		 get { } //Length: 27
	}

	public CustomDataModule customData
	{
		 get { } //Length: 27
	}

	[Obsolete("duration property is deprecated. Use main.duration instead.", False)]
	public float duration
	{
		 get { } //Length: 75
	}

	public EmissionModule emission
	{
		 get { } //Length: 27
	}

	[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", False)]
	public float emissionRate
	{
		 get { } //Length: 75
		 set { } //Length: 169
	}

	[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
	public bool enableEmission
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public ExternalForcesModule externalForces
	{
		 get { } //Length: 27
	}

	public ForceOverLifetimeModule forceOverLifetime
	{
		 get { } //Length: 27
	}

	[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", False)]
	public float gravityModifier
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	public bool has3DParticleRotations
	{
		[NativeName("Has3DParticleRotations")]
		 get { } //Length: 98
	}

	public bool hasNonUniformParticleSizes
	{
		[NativeName("HasNonUniformParticleSizes")]
		 get { } //Length: 98
	}

	public InheritVelocityModule inheritVelocity
	{
		 get { } //Length: 27
	}

	public bool isEmitting
	{
		[NativeName("SyncJobs(false)->IsEmitting")]
		 get { } //Length: 98
	}

	public bool isPaused
	{
		[NativeName("SyncJobs(false)->IsPaused")]
		 get { } //Length: 98
	}

	public bool isPlaying
	{
		[NativeName("SyncJobs(false)->IsPlaying")]
		 get { } //Length: 98
	}

	public bool isStopped
	{
		[NativeName("SyncJobs(false)->IsStopped")]
		 get { } //Length: 98
	}

	public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed
	{
		 get { } //Length: 27
	}

	public LightsModule lights
	{
		 get { } //Length: 27
	}

	public LimitVelocityOverLifetimeModule limitVelocityOverLifetime
	{
		 get { } //Length: 27
	}

	[Obsolete("loop property is deprecated. Use main.loop instead.", False)]
	public bool loop
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public MainModule main
	{
		 get { } //Length: 27
	}

	[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", False)]
	public int maxParticles
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public NoiseModule noise
	{
		 get { } //Length: 27
	}

	public int particleCount
	{
		[NativeName("SyncJobs(false)->GetParticleCount")]
		 get { } //Length: 98
	}

	[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", False)]
	public float playbackSpeed
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", False)]
	public bool playOnAwake
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public bool proceduralSimulationSupported
	{
		 get { } //Length: 98
	}

	public uint randomSeed
	{
		[NativeName("GetRandomSeed")]
		 get { } //Length: 98
		[NativeName("SyncJobs(false)->SetRandomSeed")]
		 set { } //Length: 101
	}

	public RotationBySpeedModule rotationBySpeed
	{
		 get { } //Length: 27
	}

	public RotationOverLifetimeModule rotationOverLifetime
	{
		 get { } //Length: 27
	}

	[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", False)]
	public ParticleSystemScalingMode scalingMode
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public ShapeModule shape
	{
		 get { } //Length: 27
	}

	[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", False)]
	public ParticleSystemSimulationSpace simulationSpace
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public SizeBySpeedModule sizeBySpeed
	{
		 get { } //Length: 27
	}

	public SizeOverLifetimeModule sizeOverLifetime
	{
		 get { } //Length: 27
	}

	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	public Color startColor
	{
		 get { } //Length: 101
		 set { } //Length: 181
	}

	[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", False)]
	public float startDelay
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
	public float startLifetime
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", False)]
	public float startRotation
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", False)]
	public Vector3 startRotation3D
	{
		 get { } //Length: 278
		 set { } //Length: 174
	}

	[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", False)]
	public float startSize
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
	public float startSpeed
	{
		 get { } //Length: 75
		 set { } //Length: 80
	}

	public SubEmittersModule subEmitters
	{
		 get { } //Length: 27
	}

	public TextureSheetAnimationModule textureSheetAnimation
	{
		 get { } //Length: 27
	}

	public float time
	{
		[NativeName("SyncJobs(false)->GetSecPosition")]
		 get { } //Length: 102
		[NativeName("SyncJobs(false)->SetSecPosition")]
		 set { } //Length: 109
	}

	public float totalTime
	{
		[NativeName("SyncJobs(false)->GetTotalSecPosition")]
		 get { } //Length: 102
	}

	public TrailModule trails
	{
		 get { } //Length: 27
	}

	public TriggerModule trigger
	{
		 get { } //Length: 27
	}

	public bool useAutoRandomSeed
	{
		[NativeName("GetAutoRandomSeed")]
		 get { } //Length: 98
		[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
		 set { } //Length: 101
	}

	public VelocityOverLifetimeModule velocityOverLifetime
	{
		 get { } //Length: 27
	}

	public ParticleSystem() { }

	[NativeName("SetUsesAxisOfRotation")]
	public void AllocateAxisOfRotationAttribute() { }

	private static void AllocateAxisOfRotationAttribute_Injected(IntPtr _unity_self) { }

	[NativeName("SetUsesCustomData")]
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	private static void AllocateCustomDataAttribute_Injected(IntPtr _unity_self, ParticleSystemCustomData stream) { }

	[NativeName("SetUsesMeshIndex")]
	public void AllocateMeshIndexAttribute() { }

	private static void AllocateMeshIndexAttribute_Injected(IntPtr _unity_self) { }

	public void Clear() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	public void Clear(bool withChildren) { }

	private static void Clear_Injected(IntPtr _unity_self, bool withChildren) { }

	[ThreadSafe]
	internal static void CopyManagedJobData(Void* systemPtr, out NativeParticleData particleData) { }

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[RequiredByNativeCode]
	public void Emit(int count) { }

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count) { }

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	public void Emit(Particle particle) { }

	private static void Emit_Injected(IntPtr _unity_self, in EmitParams emitParams, int count) { }

	[NativeName("SyncJobs()->Emit")]
	private void Emit_Internal(int count) { }

	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	[NativeName("SyncJobs()->EmitParticleExternal")]
	private void EmitOld_Internal(ref Particle particle) { }

	private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref Particle particle) { }

	public bool get_automaticCullingEnabled() { }

	public CollisionModule get_collision() { }

	public ColorBySpeedModule get_colorBySpeed() { }

	public ColorOverLifetimeModule get_colorOverLifetime() { }

	public CustomDataModule get_customData() { }

	public float get_duration() { }

	public EmissionModule get_emission() { }

	public float get_emissionRate() { }

	public bool get_enableEmission() { }

	public ExternalForcesModule get_externalForces() { }

	public ForceOverLifetimeModule get_forceOverLifetime() { }

	public float get_gravityModifier() { }

	[NativeName("Has3DParticleRotations")]
	public bool get_has3DParticleRotations() { }

	private static bool get_has3DParticleRotations_Injected(IntPtr _unity_self) { }

	[NativeName("HasNonUniformParticleSizes")]
	public bool get_hasNonUniformParticleSizes() { }

	private static bool get_hasNonUniformParticleSizes_Injected(IntPtr _unity_self) { }

	public InheritVelocityModule get_inheritVelocity() { }

	[NativeName("SyncJobs(false)->IsEmitting")]
	public bool get_isEmitting() { }

	private static bool get_isEmitting_Injected(IntPtr _unity_self) { }

	[NativeName("SyncJobs(false)->IsPaused")]
	public bool get_isPaused() { }

	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	[NativeName("SyncJobs(false)->IsPlaying")]
	public bool get_isPlaying() { }

	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[NativeName("SyncJobs(false)->IsStopped")]
	public bool get_isStopped() { }

	private static bool get_isStopped_Injected(IntPtr _unity_self) { }

	public LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	public LightsModule get_lights() { }

	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	public bool get_loop() { }

	public MainModule get_main() { }

	public int get_maxParticles() { }

	public NoiseModule get_noise() { }

	[NativeName("SyncJobs(false)->GetParticleCount")]
	public int get_particleCount() { }

	private static int get_particleCount_Injected(IntPtr _unity_self) { }

	public float get_playbackSpeed() { }

	public bool get_playOnAwake() { }

	public bool get_proceduralSimulationSupported() { }

	private static bool get_proceduralSimulationSupported_Injected(IntPtr _unity_self) { }

	[NativeName("GetRandomSeed")]
	public uint get_randomSeed() { }

	private static uint get_randomSeed_Injected(IntPtr _unity_self) { }

	public RotationBySpeedModule get_rotationBySpeed() { }

	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	public ParticleSystemScalingMode get_scalingMode() { }

	public ShapeModule get_shape() { }

	public ParticleSystemSimulationSpace get_simulationSpace() { }

	public SizeBySpeedModule get_sizeBySpeed() { }

	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	public Color get_startColor() { }

	public float get_startDelay() { }

	public float get_startLifetime() { }

	public float get_startRotation() { }

	public Vector3 get_startRotation3D() { }

	public float get_startSize() { }

	public float get_startSpeed() { }

	public SubEmittersModule get_subEmitters() { }

	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	[NativeName("SyncJobs(false)->GetSecPosition")]
	public float get_time() { }

	private static float get_time_Injected(IntPtr _unity_self) { }

	[NativeName("SyncJobs(false)->GetTotalSecPosition")]
	public float get_totalTime() { }

	private static float get_totalTime_Injected(IntPtr _unity_self) { }

	public TrailModule get_trails() { }

	public TriggerModule get_trigger() { }

	[NativeName("GetAutoRandomSeed")]
	public bool get_useAutoRandomSeed() { }

	private static bool get_useAutoRandomSeed_Injected(IntPtr _unity_self) { }

	public VelocityOverLifetimeModule get_velocityOverLifetime() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	private static int GetCustomParticleData_Injected(IntPtr _unity_self, ref BlittableListWrapper customData, ParticleSystemCustomData streamIndex) { }

	internal Void* GetManagedJobData() { }

	private static Void* GetManagedJobData_Injected(IntPtr _unity_self) { }

	internal JobHandle GetManagedJobHandle() { }

	private static void GetManagedJobHandle_Injected(IntPtr _unity_self, out JobHandle ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	private static void GetParticleCurrentColor_Injected(IntPtr _unity_self, ref Particle particle, out Color32 ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	internal float GetParticleCurrentSize(ref Particle particle) { }

	private static float GetParticleCurrentSize_Injected(IntPtr _unity_self, ref Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = True)]
	internal Vector3 GetParticleCurrentSize3D(ref Particle particle) { }

	private static void GetParticleCurrentSize3D_Injected(IntPtr _unity_self, ref Particle particle, out Vector3 ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = True)]
	internal int GetParticleMeshIndex(ref Particle particle) { }

	private static int GetParticleMeshIndex_Injected(IntPtr _unity_self, ref Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	public int GetParticles(out Particle[] particles, int size, int offset) { }

	public int GetParticles(out Particle[] particles, int size) { }

	public int GetParticles(out Particle[] particles) { }

	public int GetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	public int GetParticles(out NativeArray<Particle> particles, int size) { }

	public int GetParticles(out NativeArray<Particle> particles) { }

	private static int GetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	private static int GetParticlesWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, int particlesLength, int size, int offset) { }

	public PlaybackState GetPlaybackState() { }

	private static void GetPlaybackState_Injected(IntPtr _unity_self, out PlaybackState ret) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = True)]
	private void GetTrailDataInternal(ref Trails trailData) { }

	private static void GetTrailDataInternal_Injected(IntPtr _unity_self, ref Trails trailData) { }

	public Trails GetTrails() { }

	public int GetTrails(ref Trails trailData) { }

	public bool IsAlive() { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	public bool IsAlive(bool withChildren) { }

	private static bool IsAlive_Injected(IntPtr _unity_self, bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	public void Pause(bool withChildren) { }

	public void Pause() { }

	private static void Pause_Injected(IntPtr _unity_self, bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	public void Play(bool withChildren) { }

	public void Play() { }

	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunction("ScheduleManagedJob", ThrowsException = True)]
	internal static JobHandle ScheduleManagedJob(ref JobScheduleParameters parameters, Void* additionalData) { }

	private static void ScheduleManagedJob_Injected(ref JobScheduleParameters parameters, Void* additionalData, out JobHandle ret) { }

	public void set_emissionRate(float value) { }

	public void set_enableEmission(bool value) { }

	public void set_gravityModifier(float value) { }

	public void set_loop(bool value) { }

	public void set_maxParticles(int value) { }

	public void set_playbackSpeed(float value) { }

	public void set_playOnAwake(bool value) { }

	[NativeName("SyncJobs(false)->SetRandomSeed")]
	public void set_randomSeed(uint value) { }

	private static void set_randomSeed_Injected(IntPtr _unity_self, uint value) { }

	public void set_scalingMode(ParticleSystemScalingMode value) { }

	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	public void set_startColor(Color value) { }

	public void set_startDelay(float value) { }

	public void set_startLifetime(float value) { }

	public void set_startRotation(float value) { }

	public void set_startRotation3D(Vector3 value) { }

	public void set_startSize(float value) { }

	public void set_startSpeed(float value) { }

	[NativeName("SyncJobs(false)->SetSecPosition")]
	public void set_time(float value) { }

	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	public void set_useAutoRandomSeed(bool value) { }

	private static void set_useAutoRandomSeed_Injected(IntPtr _unity_self, bool value) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	private static void SetCustomParticleData_Injected(IntPtr _unity_self, ref BlittableListWrapper customData, ParticleSystemCustomData streamIndex) { }

	internal void SetManagedJobHandle(JobHandle handle) { }

	private static void SetManagedJobHandle_Injected(IntPtr _unity_self, in JobHandle handle) { }

	[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	public void SetParticles(out NativeArray<Particle> particles) { }

	public void SetParticles(out NativeArray<Particle> particles, int size) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	public void SetParticles(out Particle[] particles, int size, int offset) { }

	public void SetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	public void SetParticles(out Particle[] particles) { }

	public void SetParticles(out Particle[] particles, int size) { }

	private static void SetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	private static void SetParticlesWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, int particlesLength, int size, int offset) { }

	public void SetPlaybackState(PlaybackState playbackState) { }

	private static void SetPlaybackState_Injected(IntPtr _unity_self, in PlaybackState playbackState) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = True)]
	public void SetTrails(Trails trailData) { }

	private static void SetTrails_Injected(IntPtr _unity_self, in Trails trailData) { }

	public void Simulate(float t) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	public void Simulate(float t, bool withChildren, bool restart) { }

	public void Simulate(float t, bool withChildren) { }

	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void Stop() { }

	public void Stop(bool withChildren) { }

	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	public void TriggerSubEmitter(int subEmitterIndex) { }

	public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles) { }

	public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForAllParticles", HasExplicitThis = True)]
	private void TriggerSubEmitterForAllParticles(int subEmitterIndex) { }

	private static void TriggerSubEmitterForAllParticles_Injected(IntPtr _unity_self, int subEmitterIndex) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = True)]
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) { }

	private static void TriggerSubEmitterForParticle_Injected(IntPtr _unity_self, int subEmitterIndex, in Particle particle) { }

	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticles", HasExplicitThis = True)]
	private void TriggerSubEmitterForParticles(int subEmitterIndex, List<Particle> particles) { }

	private static void TriggerSubEmitterForParticles_Injected(IntPtr _unity_self, int subEmitterIndex, ref BlittableListWrapper particles) { }

	internal static bool UserJobCanBeScheduled() { }

}

