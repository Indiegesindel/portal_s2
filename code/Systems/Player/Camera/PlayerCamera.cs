using Sandbox;

namespace Indiegesindel.PortalS2;

public partial class PlayerCamera
{
	public virtual void BuildInput( Player player )
	{
		//
	}

	public virtual void Update( Player player )
	{
		Camera.Position = player.EyePosition;
		Camera.Rotation = player.EyeRotation;
		Camera.FieldOfView = Game.Preferences.FieldOfView + 15.0f;
		Camera.FirstPersonViewer = player;
		Camera.ZNear = 0.5f;

		UpdatePostProcess();
	}
}
