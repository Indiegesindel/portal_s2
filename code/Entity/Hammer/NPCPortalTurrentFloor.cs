using Editor;
using Sandbox;

namespace Indiegesindel.PortalS2;

// TODO: Add Model, Add Logic
[Library( "npc_portal_turret_floor" ), HammerEntity]
[Title( "Portal Turret" ), Category( "Gameplay" )]
public partial class NPCPortalTurrentFloor : AnimatedEntity
{
	#region PROPERTIES
	
	/// <summary>
	/// Turret will not speak any voice lines.
	/// </summary>
	[Property]
	public bool IsGagged { get; set; } = false;
	
	/// <summary>
	/// Disabled pickup by player.
	/// </summary>
	[Property]
	public bool IsPickupable { get; set; } = true;
	
	/// <summary>
	/// Turrets will not try to shoot through portals unless this is set.
	/// </summary>
	[Property]
	public bool CanShootThroughPortals { get; set; } = false;
	
	/// <summary>
	/// How far the turret will be able to see targets.
	/// </summary>
	[Property]
	public float MaxRange { get; set; } = 1024f;
	
	/// <summary>
	/// Whether this turret is active.
	/// </summary>
	[Property]
	public bool Enabled { get; set; } = true;
	
	/// <summary>
	/// Whether this turret can shoot bullets at the player.
	/// </summary>
	[Property]
	public bool OutOfAmmo { get; set; } = false;
	
	#endregion
	
	#region INPUTS
	/// <summary>
	/// Enables the entity.
	/// </summary>
	[Input]
	public void Enable()
	{
		Enabled = true;
	}

	/// <summary>
	/// Disables the entity, so that it would not fire any outputs.
	/// </summary>
	[Input]
	public void Disable()
	{
		Enabled = false;
	}

	/// <summary>
	/// Toggles the enabled state of the entity.
	/// </summary>
	[Input]
	public void Toggle()
	{
		Enabled = !Enabled;
	}

	/// <summary>
	/// Prevents the turret to speak.
	/// </summary>
	[Input]
	public void EnableGagging()
	{
		IsGagged = true;
	}

	/// <summary>
	/// Allows the turret to speak again.
	/// </summary>
	[Input]
	public void DisableGagging()
	{
		IsGagged = false;
	}

	/// <summary>
	/// Enables player pickup of the turret.
	/// </summary>
	[Input]
	public void EnablePickup()
	{
		IsPickupable = true;
	}

	/// <summary>
	/// Disables player pickup of the turret.
	/// </summary>
	[Input]
	public void DisablePickup()
	{
		IsPickupable = false;
	}

	/// <summary>
	/// Causes the turret to instantly fire at the specified entity.
	/// </summary>
	[Input]
	public void FireBullet()
	{
		// TODO: Find out how to set this mode
	}

	/// <summary>
	/// Cause the turret to explode immediately.
	/// </summary>
	[Input]
	public void SelfDestructImmediately()
	{
		// TODO: Find out how to set this mode
	}

	/// <summary>
	/// Emit a warning then self-destruct in a small explosion.
	/// </summary>
	[Input]
	public void SelfDestruct()
	{
		// TODO: Find out how to set this mode
	}
	#endregion
	
	#region OUTPUTS
	/// <summary>
	/// Turret has become active and dangerous
	/// </summary>
	protected Output OnDeploy { get; set; }
	
	/// <summary>
	/// Turret has become inactive and harmless
	/// </summary>
	protected Output OnRetire { get; set; }
	
	/// <summary>
	/// Turret has been tipped over and is inactive.
	/// </summary>
	protected Output OnTipped { get; set; }
	#endregion
}
