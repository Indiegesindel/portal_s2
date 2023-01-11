using Editor;
using Sandbox;

namespace Indiegesindel.PortalS2;

[Library( "linked_portal_door" ), HammerEntity]
[VisGroup( VisGroup.Logic )]
[EditorSprite( "editor/ent_logic.vmat" )]
[Title( "Linked Portal Door" ), Category( "Gameplay" ), Icon( "calculate" )]
public partial class LinkedPortalDoorEntity : Entity
{
	#region PROPERTIES
	
	/// <summary>
	/// Another <see cref="LinkedPortalDoorEntity">linked_portal_door</see> entity which will link to this one. (You do not have to set this up on the other entity.)
	/// </summary>
	[Property( "Linked Partner" )]
	public EntityTarget LinkedPartner { get; set; }
	
	/// <summary>
	/// Width of the desired portal.
	/// </summary>
	[Property]
	public int Width { get; set; } = 0;
	
	/// <summary>
	/// Height of the desired portal.
	/// </summary>
	[Property]
	public int Height { get; set; } = 0;
	
	/// <summary>
	/// Whether the link is active.
	/// </summary>
	[Property]
	public bool Enabled { get; set; } = true;

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

	#endregion

	#region OUTPUTS

	/// <summary>
	///
	/// </summary>
	protected Output OnClose { get; set; }

	/// <summary>
	///
	/// </summary>
	protected Output OnOpen { get; set; }

	/// <summary>
	///
	/// </summary>
	protected Output OnEntityTeleportFromMe { get; set; }

	/// <summary>
	///
	/// </summary>
	protected Output OnEntityTeleportToMe { get; set; }

	/// <summary>
	///
	/// </summary>
	protected Output OnPlayerTeleportFromMe { get; set; }

	/// <summary>
	///
	/// </summary>
	protected Output OnPlayerTeleportToMe { get; set; }

	#endregion

	/// <summary>
	/// The other portal instance linked.
	/// </summary>
	[Net]
	public LinkedPortalDoorEntity TargetLinkedPortalDoorEntity { get; set; }

	public override void Spawn()
	{
		base.Spawn();

		TargetLinkedPortalDoorEntity = LinkedPartner.GetTarget<LinkedPortalDoorEntity>();
	}
}
