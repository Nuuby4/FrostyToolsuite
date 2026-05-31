
namespace LevelEditorPlugin.Entities
{
#if SWBF2 || MASS_EFFECT

	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GroupTransformLayerData))]
	public class GroupTransformLayer : TransformLayer, IEntityData<FrostySdk.Ebx.GroupTransformLayerData>
	{
		public new FrostySdk.Ebx.GroupTransformLayerData Data => data as FrostySdk.Ebx.GroupTransformLayerData;
		public override string DisplayName => "GroupTransformLayer";

		public GroupTransformLayer(FrostySdk.Ebx.GroupTransformLayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
#endif
}

