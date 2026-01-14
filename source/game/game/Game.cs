public static class Game {
	public static Engine Engine {get; private set;} = new();

	public static void Main() {
		Log.Info("SKULL DRILL");
		Engine.Init();
		Scene.Active.Add<GameManager>();
		Engine.Run();
	}
}