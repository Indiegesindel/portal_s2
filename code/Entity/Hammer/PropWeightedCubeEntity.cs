using Sandbox;
using Editor;

namespace Indiegesindel.PortalS2;

// TODO: Add Model
[Library( "prop_weighted_cube" ), HammerEntity]
[Title( "Weighted Cube" ), Category( "Gameplay" )]
public partial class PropWeightedCubeEntity : Entity
{
	public enum Type { Standard, Companion, Sphere };
	
	#region PROPERTIES
	/// <summary>
	/// Cube model type.
	/// </summary>
	[Property]
	public Type CubeType { get; set; } = Type.Standard;
	#endregion
	
	#region INPUTS
	/// <summary>
	/// Dissolves the cube.
	/// </summary>
	[Input]
	public void Dissolve()
	{
		// TODO
	}
	/// <summary>
	/// Kills the cube and fires its OnFizzled output.
	/// </summary>
	[Input]
	public void SilentDissolve()
	{
		// TODO
	}
	#endregion
	
	#region OUTPUTS
	/// <summary>
	/// Fired when a cube is fizzled.
	/// </summary>
	protected Output OnFizzled { get; set; }
	
	/// <summary>
	/// Player picked up the cube.
	/// </summary>
	protected Output OnPlayerPickup { get; set; }
	
	/// <summary>
	/// Player dropped the cube.
	/// </summary>
	protected Output OnPlayerDrop { get; set; }
	#endregion
}
