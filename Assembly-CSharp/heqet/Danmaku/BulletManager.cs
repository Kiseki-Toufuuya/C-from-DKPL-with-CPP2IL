namespace Heqet.Danmaku;

public class BulletManager
{
	internal class ActiveBulletInfo
	{
		public Vector3 position; //Field offset: 0x8

		public ActiveBulletInfo() { }

	}

	internal enum ControlType
	{
		Unknown = 0,
		Player = 1,
		Boss = 2,
		Enemy = 3,
	}

	internal enum EffectBullets
	{
		vertical_shot_3way = 0,
		all_around_spread_shot = 1,
		all_around_spread_shot_18way = 2,
		cross_shot = 3,
		loop_around_shoot_anticlockwise_rotation = 4,
		loop_around_shoot_clockwise_rotation = 5,
		loop_crescent_shot_l_to_r = 6,
		loop_crescent_shot_r_to_l = 7,
		snipe_shot = 8,
		snipe_shot_on_ignition = 9,
		snipe_shotgun = 10,
		spread_and_chase = 11,
		snipe_shot_2way_red = 12,
		snipe_shot_2way_blue = 13,
		snipe_winder_shot_5 = 14,
		all_around_shot_anticlockwise = 15,
		all_around_shot_clockwise = 16,
		BULLET_ENEMY_18 = 17,
		BULLET_ENEMY_19 = 18,
		BULLET_ENEMY_20 = 19,
		POINT_SMALL_SHOT = 20,
	}

	public static Int32[] ToEffectDefine; //Field offset: 0x0
	private List<BulletController> bullets; //Field offset: 0x8
	private List<BulletController> updateList; //Field offset: 0xC
	private bool removeLock; //Field offset: 0x10

	private static BulletManager() { }

	public BulletManager() { }

	public void Add(BulletController bullet) { }

	public void AllPause(bool enable) { }

	public void AllStop() { }

	public void DoLateUpdate() { }

	public bool GetAllBulletInfo(out List<ActiveBulletInfo>& infoList, bool stopBullet, bool eraseParticle, List<ControlType> targetControlType) { }

	public List<BulletController> GetBullets() { }

	public void Initialize() { }

	private static void RecursiveBulletsToPoint(List<ActiveBulletInfo> infoList, GameObject parentObject, bool eraseParticle) { }

	public void Remove(BulletController bullet) { }

	public void Terminate() { }

}

