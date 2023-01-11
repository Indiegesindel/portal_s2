using Sandbox;
using Editor;

namespace Indiegesindel.PortalS2;

// TODO: Add Logic, Add Model
[Library( "weapon_portalgun" ), HammerEntity]
[Title( "Portalgun" ), Category( "Gameplay" )]
public partial class WeaponPortalgunEntity : Entity
{
	#region PROPERTIES

	/// <summary>
	/// Can this portalgun create blue portals?
	/// </summary>
	[Property]
	public bool CanFireBluePortal { get; set; } = true;

	/// <summary>
	/// Can this portalgun create orange portals?
	/// </summary>
	[Property]
	public bool CanFireOrangePortal { get; set; } = true;

	#endregion

	#region OUTPUTS

	/// <summary>
	/// The blue portal was fired
	/// </summary>
	protected Output OnFireBlue { get; set; }

	/// <summary>
	/// The orange portal was fired
	/// </summary>
	protected Output OnFireOrange { get; set; }

	/// <summary>
	/// The player has picked up the portalgun
	/// </summary>
	protected Output OnPickup { get; set; }

	#endregion
}
