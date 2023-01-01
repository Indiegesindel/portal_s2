using Sandbox;
using System;

namespace Indiegesindel.PortalS2.Mechanics;

/// <summary>
/// The basic sprinting mechanic for players.
/// It shouldn't, though.
/// </summary>
public partial class SprintMechanic : PlayerControllerMechanic
{
	/// <summary>
	/// Sprint has a higher priority than other mechanics.
	/// </summary>
	public override int SortOrder => 10;
	public override float? WishSpeed => 320f;

	protected override bool ShouldStart()
	{
		if ( !Input.Down( InputButton.Run ) ) return false;
		if ( Player.MoveInput.x <= 0f ) return false;
		if ( Controller.Velocity.Length < 180f ) return false;
		if ( Player.MoveInput.Length == 0 ) return false;

		return true;
	}

	public override Vector3? MoveInputScale => new( 1, 0.5f, 0 );
}
