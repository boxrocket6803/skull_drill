public class GameManager : Scene.Object {
	public Model Model;
	public override void OnCreate() {
		Model ??= Resource.Load<Model>("models/test/health_vial.bmdl");
		Scene.Active.MainCamera = new Scene.Camera.Perspective();
		base.OnCreate();
	}

	public override void Render() {
		if (Graphics.Stage == Graphics.RenderStage.Submit)
			Model.Draw(Transform.Indentity);
		base.Render();
	}
}