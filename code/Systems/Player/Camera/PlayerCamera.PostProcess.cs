using Sandbox;

namespace Indiegesindel.PortalS2;

public partial class PlayerCamera
{
	protected void UpdatePostProcess()
	{
		var postProcess = Camera.Main.FindOrCreateHook<Sandbox.Effects.ScreenEffects>();
		postProcess.Vignette.Intensity = 0.2f;
		postProcess.Vignette.Roundness = 1f;
		postProcess.Vignette.Smoothness = 0.3f;
		postProcess.Vignette.Color = Color.Black.WithAlpha( 1f );
	}
}
