using System;
using System.Collections.Generic;
using Frosty.Core;
using FrostySdk;
using FrostySdk.Ebx;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EnumLogicEntityBaseData))]
	public class EnumLogicEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.EnumLogicEntityBaseData>
	{
		public new FrostySdk.Ebx.EnumLogicEntityBaseData Data => data as FrostySdk.Ebx.EnumLogicEntityBaseData;
		public override string DisplayName => "EnumLogicEntityBase";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		protected Type enumType;

		public EnumLogicEntityBase(FrostySdk.Ebx.EnumLogicEntityBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
            if (Data.EnumTypeTypeInfoRef.Asset.Internal != null)
			{
                TypeInfoAsset a = Data.EnumTypeTypeInfoRef.Asset.Internal as TypeInfoAsset;
				if (a == null)
				{
					App.Logger.Log("EnumLogicEntity TypeInfoAsset was Null!");
				}
				else
				{
					enumType = TypeLibrary.GetType(a.TypeName);
				}
            }
        }
	}
}

