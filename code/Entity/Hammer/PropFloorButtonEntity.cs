using Sandbox;
using Editor;

namespace Indiegesindel.PortalS2;

// TODO: Add Model, Add Logic
[Library( "prop_floor_button" ), HammerEntity]
[Title( "Floor Button" ), Category( "Gameplay" )]
public partial class PropFloorButtonEntity : AnimatedEntity
{
	#region OUTPUTS
	/// <summary>
	/// Called when the button has been pressed.
	/// </summary>
	protected Output OnPressed { get; set; }
	
	/// <summary>
	/// Called when the button has been unpressed.
	/// </summary>
	protected Output OnUnpressed { get; set; }
	#endregion
}
