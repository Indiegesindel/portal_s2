using Editor;
using Sandbox;

namespace Indiegesindel.PortalS2;

// TODO: Add Logic, Add Model
[Library( "player_portalgun_state" ), HammerEntity]
[Title( "Player Portalgun State" ), Category( "Gameplay" )]
public partial class PlayerPortalgunState : Entity
{
	#region INPUTS

	/// <summary>
	/// Sets the players Portalgun State to none
	/// </summary>
	[Input]
	public void Disable()
	{
		// TODO
	}

	/// <summary>
	/// Sets the players Portalgun State to only blue
	/// </summary>
	[Input]
	public void EnableBlue()
	{
		// TODO
	}

	/// <summary>
	/// Sets the players Portalgun State to both blue and orange
	/// </summary>
	[Input]
	public void EnableBoth()
	{
		// TODO
	}
	
	#endregion
}
