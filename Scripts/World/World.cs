using Godot;

public partial class World : Node3D
{
	private double _elapsedTime = 0;

	public override void _Process(double delta)
	{
		_elapsedTime += delta;

		if (_elapsedTime >= 1)
		{
			GD.Print("1 saniye geçti");
			_elapsedTime = 0;
		}
	}
}
