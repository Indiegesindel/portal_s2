using Sandbox;
using System;

namespace Indiegesindel.PortalS2;

public partial class PortalGun : BaseViewModel
{
	[Net, Predicted] public TimeSince TimeSincePrimaryShoot { get; set; }
	[Net, Predicted] public TimeSince TimeSinceSecondaryShoot { get; set; }

	/// <summary>
	/// The state of the Portalgun. None = No Portal gun, Single = Only Primary, Full = Primary and Secondary
	/// </summary>
	public enum State { None, Single, Full };
	public State CurrentState { get; protected set; } = State.Full;

	public static Model PortalgunModel = Model.Load( "models/v_portal_gun/v_portal_gun.vmdl" );

	float walkBob = 0;

	public override void Spawn()
	{
		base.Spawn();

		EnableViewmodelRendering = true;
		Model = PortalgunModel;

		Tags.Add( "player" );
	}

	public override void PlaceViewmodel()
	{
		// Override original movement
	}

	public void UpdateCamera()
	{
		var rotationDistance = Rotation.Distance( Camera.Rotation );

		Position = Camera.Position;
		Rotation = Rotation.Lerp( Rotation, Camera.Rotation, RealTime.Delta * rotationDistance * 2f );

		if ( Game.LocalPawn.LifeState == LifeState.Dead )
			return;

		//
		// Bob up and down based on our walk movement
		//
		var speed = Game.LocalPawn.Velocity.Length.LerpInverse( 0, 400 );
		var left = Camera.Rotation.Left;
		var up = Camera.Rotation.Up;

		if ( Game.LocalPawn.GroundEntity != null )
		{
			walkBob += Time.Delta * 2.0f * speed;
		}

		Position += up * MathF.Sin( walkBob ) * speed * -0.6f;
		Position += left * MathF.Sin( walkBob * 0.5f ) * speed * -0.3f;

		SetAnimParameter( "fizzle", true );
	}

	public void Fizzle()
	{
		Log.Info( "PortalGun > Fizzle" );
		SetAnimParameter( "fizzle", true );
	}

	public void Shoot(bool isPrimary)
	{
		TimeSincePrimaryShoot = 0;
		TimeSinceSecondaryShoot = 0;
	}
}
