using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Mods;
using MassiveStorageMod;

namespace MSMod
{

	public sealed class MSMod : DataOnlyMod
	{

		public override string Name => "Massive Storage Mod";
		public override int Version => 1;

		public MSMod(CoreMod coreMod, BaseMod baseMod)
		{

		}


		public override void RegisterPrototypes(ProtoRegistrator registrator)
		{
			registrator.RegisterData<MassiveStorages>();
		}

	}
}