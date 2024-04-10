using Mafi;
using Mafi.Base;
using Mafi.Core.Buildings.Storages;
using Mafi.Core.Entities;
using Mafi.Core.Factory;
using Mafi.Core.Mods;
using Mafi.Core.Prototypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveStorageMod
{
    internal class MassiveStorages : IModData
    {
        const int desiredCapacity = 1000;

        public void RegisterData(ProtoRegistrator registrator)
        {
            ProtosDb protosDb = registrator.PrototypesDb;

            protosDb.RemoveOrThrow(Ids.Buildings.StorageFluid);
            protosDb.RemoveOrThrow(Ids.Buildings.StorageLoose);
            protosDb.RemoveOrThrow(Ids.Buildings.StorageUnit);

            registrator.StorageProtoBuilder
                .Start("Massive Storage Fluid", Ids.Buildings.StorageFluid)
                .Description("Massive Storage Mod: Fluid Storage")
                .SetCost(Costs.Build.CP(1))
                .SetNoTransferLimit()
                .SetLayout(
                "A@>[4][4][4][4][4]>@V",
                "B@>[4][4][4][4][4]>@W",
                "C@>[4][4][4][4][4]>@X",
                "D@>[4][4][4][4][4]>@Y",
                "E@>[4][4][4][4][4]>@Z")
                .SetCapacity(desiredCapacity)
                .SetCategories(Ids.ToolbarCategories.Storages)
                .SetPrefabPath("Assets/Base/Buildings/Storages/GasT1.prefab")
                .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageFluid.png")
                .SetFluidIndicatorGfxParams("part1/icon", "part1/liquid", new FluidIndicatorGfxParams(1f, 1.3f, 2f))
                .BuildAsFluidAndAdd()
                .AddParam(new DrawArrowWileBuildingProtoParam(4f));

            registrator.StorageProtoBuilder
                .Start("Massive Storage Loose", Ids.Buildings.StorageLoose)
                .Description("Massive Storage Mod: Loose Storage")
                .SetCost(Costs.Build.CP(1))
                .SetNoTransferLimit()
                .SetLayout(
                "A~>[4][4][4][4][4]>~V",
                "B~>[4][4][4][4][4]>~W",
                "C~>[4][4][4][4][4]>~X",
                "D~>[4][4][4][4][4]>~Y",
                "E~>[4][4][4][4][4]>~Z")
                .SetCapacity(desiredCapacity)
                .SetCategories(Ids.ToolbarCategories.Storages)
                .SetPrefabPath("Assets/Base/Buildings/Storages/LooseT1.prefab")
                .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageLoose.png")
                .SetPileGfxParams("Pile_Soft", "Pile_Soft", new LoosePileTextureParams(1.4f))
                .BuildAsLooseAndAdd()
                .AddParam(new DrawArrowWileBuildingProtoParam(4f));

            registrator.StorageProtoBuilder
                .Start("Massive Storage Unit", Ids.Buildings.StorageUnit)
                .Description("Massive Storage Mod: Unit Storage")
                .SetCost(Costs.Build.CP(1))
                .SetNoTransferLimit()
                .SetLayout(
                "A#>[4][4][4][4][4]>#V",
                "B#>[4][4][4][4][4]>#W",
                "C#>[4][4][4][4][4]>#X",
                "D#>[4][4][4][4][4]>#Y",
                "E#>[4][4][4][4][4]>#Z")
                .SetCapacity(desiredCapacity)
                .SetCategories(Ids.ToolbarCategories.Storages)
                .SetPrefabPath("Assets/Base/Buildings/Storages/UnitT1.prefab")
                .SetCustomIconPath("Assets/Unity/Generated/Icons/LayoutEntity/StorageUnit.png")
                .BuildUnitAndAdd(new UnitStorageRackData[1]
                {
                new UnitStorageRackData(3, 6, -4f)
                }, "Assets/Base/Buildings/Storages/UnitT1_rack.prefab");
        }
    }
}