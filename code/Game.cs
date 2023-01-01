using Sandbox;
using System;
using System.Linq;

namespace Indiegesindel.PortalS2;

public partial class PortalS2 : GameManager
{
	public PortalS2()
	{
		if ( Game.IsServer )
		{
			_ = new Hud();
		}
	}

	/// <summary>
	/// A client has joined the server. Make them a pawn to play with
	/// </summary>
	public override void ClientJoined( IClient client )
	{
		base.ClientJoined( client );

		var pawn = new Player();
		client.Pawn = pawn;
		pawn.Respawn();

		SpawnPlayer( pawn );
	}

	private Player SpawnPlayer(Player pawn)
	{

		// Get all of the spawnpoints
		var spawnpoints = Entity.All.OfType<SpawnPoint>();
		var randomSpawnPoint = spawnpoints.OrderBy( x => Guid.NewGuid() ).FirstOrDefault();
		if ( randomSpawnPoint != null )
		{
			var tx = randomSpawnPoint.Transform;
			tx.Position = tx.Position + Vector3.Up * 10.0f; // raise it up
			pawn.Transform = tx;
		}

		return pawn;
	}

	public override void DoPlayerDevCam( IClient client )
	{
		// do nothing
	}
}
