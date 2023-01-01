using Editor;
using Sandbox;

namespace Indiegesindel.PortalS2;

/// <summary>
/// A volume that cleans players Portals and Objects
/// </summary>
[Library( "trigger_fizzler" ), HammerEntity, Solid]
[Title( "Trigger Fizzler" ), Category( "Triggers" ), Icon( "done_all" )]
public partial class TriggerMultiple : BaseTrigger
{
	/// <summary>
	/// Amount of time, in seconds, after the trigger_fizzler has triggered before it can be triggered again. If set to -1, it will never trigger again. This affects OnTrigger output.
	/// </summary>
	[Property( "wait" ), Title( "Delay before reset" )]
	public float Cooldown { get; set; } = 1;

	TimeSince TimeSinceTriggered;

	public override void Spawn()
	{
		base.Spawn();

		EnableTouchPersists = true;

		if ( Cooldown <= 0 ) Cooldown = 0.2f;
	}

	/// <summary>
	/// Called every "Delay before reset" seconds as long as at least one entity that passes filters is touching this trigger
	/// </summary>
	protected Output OnTrigger { get; set; }

	/// <summary>
	/// The trigger has been... triggered. The entity passed all the filters, and the timeout has passed.
	/// </summary>
	protected virtual void OnTriggered( Entity other )
	{
		if(other is Player)
		{
			if ( Game.IsClient )
			{
				Player player = other as Player;
				player.PortalGun.Fizzle();
			}
		}

		Log.Info( "TRIGGER_FIZZLER " + other.GetType() );

		OnTrigger.Fire( other );
	}

	public override void Touch( Entity other )
	{
		base.Touch( other );

		if ( !Enabled ) return;
		if ( TimeSinceTriggered < Cooldown ) return;
		if ( TouchingEntityCount < 1 ) return;

		TimeSinceTriggered = 0;
		OnTriggered( other );
	}
}
