using FrooxEngine;
using NeosModLoader;

namespace CreateNewAdditions
{
    public class CreateNewAdditions : NeosMod
    {
        public override string Name => "CreateNewAdditions";
        public override string Author => "badhaloninja";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/badhaloninja/CreateNewAdditions";
        public override void OnEngineInit()
        {
            Engine.Current.RunPostInit(AddActions); // Run after DevCreateNewForm has been initialized
        }

        private void AddActions()
        {
            DevCreateNewForm.AddAction("3DModel", "Ramp", (s) => DevCreateNewForm.SpawnMesh(s, typeof(RampMesh)));
            DevCreateNewForm.AddAction("3DModel", "IcoSphere", (s) => DevCreateNewForm.SpawnMesh(s, typeof(IcoSphereMesh)));
            DevCreateNewForm.AddAction("3DModel", "Hollow Cone", (s) => DevCreateNewForm.SpawnMesh(s, typeof(HollowConeMesh)));
            DevCreateNewForm.AddAction("3DModel", "Circle", (s) => DevCreateNewForm.SpawnMesh(s, typeof(CircleMesh)));
            DevCreateNewForm.AddAction("3DModel", "Arrow", (s) => DevCreateNewForm.SpawnMesh(s, typeof(ArrowMesh)));
            DevCreateNewForm.AddAction("3DModel", "Cross", (s) => DevCreateNewForm.SpawnMesh(s, typeof(CrossMesh)));
            DevCreateNewForm.AddAction("3DModel", "Curved plane", (s) => DevCreateNewForm.SpawnMesh(s, typeof(CurvedPlaneMesh)));
            // Ramp
            // IcoSphere
            // Hollow Cone
            // Circle
            // Arrow
            // Cross
            // Curved plane 
        }
    }
}