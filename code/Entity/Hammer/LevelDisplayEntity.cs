using Sandbox;
using Editor;

namespace Indiegesindel.PortalS2;

// TODO: Add Model, Add Rendering
[Library( "level_display" ), HammerEntity]
[Title( "Level Display" ), Category( "Gameplay" )]
public partial class LevelDisplayEntity : Entity
{
	#region PROPERTIES

	/// <summary>
	/// Whether this display is active.
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
	/// Called when the display has been activated
	/// </summary>
	protected Output OnEnabled { get; set; }

	/// <summary>
	/// Called when the display has been deactivated
	/// </summary>
	protected Output OnDisabled { get; set; }

	#endregion
}
