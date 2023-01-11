using Sandbox;
using Editor;

namespace Indiegesindel.PortalS2;

// TODO: Add Model, Add Logic
[Library( "prop_indicator_panel" ), HammerEntity]
[Title( "Indicator Panel" ), Category( "Gameplay" )]
public partial class PropIndicatorPanelEntity : AnimatedEntity
{
	#region PROPERTIES
	
	/// <summary>
	/// Amount of time the counter will count down
	/// </summary>
	[Property]
	public int TimerDuration { get; set; } = 0;
	
	/// <summary>
	/// Whether the indicator is active.
	/// </summary>
	[Property]
	public bool Enabled { get; set; } = true;
	
	/// <summary>
	/// Whether the indicator is a timer. If yes, displays a countdown, if no, displays check/cross
	/// </summary>
	[Property]
	public bool IsTimer { get; set; } = false;
	
	/// <summary>
	/// Whether the indicator is checked.
	/// </summary>
	[Property]
	public bool IsChecked { get; set; } = false;

	#endregion
	
	#region INPUTS

	/// <summary>
	/// Enables the entity.
	/// </summary>
	[Input]
	public void Enable()
	{
		Enabled = true;
	}

	/// <summary>
	/// Disables the entity, so that it would not fire any outputs.
	/// </summary>
	[Input]
	public void Disable()
	{
		Enabled = false;
	}

	/// <summary>
	/// Toggles the enabled state of the entity.
	/// </summary>
	[Input]
	public void Toggle()
	{
		Enabled = !Enabled;
	}

	/// <summary>
	/// Sets the indicator state to be 'checked', switching the screen to tick/cross mode.
	/// </summary>
	[Input]
	public void Check()
	{
		IsTimer = false;
		IsChecked = true;
	}

	/// <summary>
	/// Sets the indicator state to be 'unchecked', switching the screen to tick/cross mode.
	/// </summary>
	[Input]
	public void UnCheck()
	{
		IsTimer = false;
		IsChecked = false;
	}

	/// <summary>
	/// Start counting down, switching the screen to timer mode.
	/// </summary>
	[Input]
	public void Start()
	{
		IsTimer = true;
		IsChecked = false;
	}

	/// <summary>
	/// Stop the counter at its current value.
	/// </summary>
	[Input]
	public void Stop()
	{
		IsTimer = true;
		IsChecked = false;
	}

	/// <summary>
	/// Reset the timer back to its default value.
	/// </summary>
	[Input]
	public void Reset()
	{
		IsTimer = true;
		IsChecked = false;
	}
	
	#endregion
}
