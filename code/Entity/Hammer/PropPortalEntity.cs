using Sandbox;
using Editor;

namespace Indiegesindel.PortalS2;

// TODO: Add Model, Add Logic, Add Rendering
[Library( "prop_portal" ), HammerEntity]
[Title( "Portal" ), Category( "Gameplay" )]
public partial class PropPortalEntity : AnimatedEntity
{
	public enum Type { Blue, Orange };
	
	#region PROPERTIES

	/// <summary>
	/// Whether the indicator is active.
	/// </summary>
	[Property]
	public bool Enabled { get; set; } = true;

	/// <summary>
	/// Which portal is is?
	/// </summary>
	[Property]
	public Type PortalType { get; set; } = Type.Blue;

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
	/// Fizzle and remove.
	/// </summary>
	[Input]
	public void Fizzle()
	{
		// TODO
	}
	
	#endregion

	#region OUTPUTS

	/// <summary>
	///
	/// </summary>
	protected Output OnPlacedSuccessfully { get; set; }

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
}
