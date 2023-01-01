using Sandbox;
using Sandbox.Diagnostics;
using System.Linq;

namespace Indiegesindel.PortalS2;

public partial class Player
{
	static string realm = Game.IsServer ? "server" : "client";
	static Logger eventLogger = new Logger( $"player/GameEvent/{realm}" );

	public void RunGameEvent( string eventName )
	{
		eventName = eventName.ToLowerInvariant();

		Controller.Mechanics.ToList()
			.ForEach( x => x.OnGameEvent( eventName ) );

		OnGameEvent( eventName );
	}

	public void OnGameEvent( string eventName )
	{
		eventLogger.Trace( $"OnGameEvent ({eventName})" );
	}
}
