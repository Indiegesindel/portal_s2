using Indiegesindel.PortalS2;
using Sandbox;
using Sandbox.UI;

public partial class Hud : HudEntity<RootPanel>
{
	public Hud()
	{
		if ( !Game.IsClient )
			return;

		RootPanel.StyleSheet.Load( "/UI/Hud.scss" );
		RootPanel.AddChild<Info>();
	}
}
