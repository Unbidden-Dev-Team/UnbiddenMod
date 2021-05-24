using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ProvidenceMod.Items.Placeable
{
  public class Anorthosite : ModItem
  {
    public override void SetStaticDefaults()
		{
      DisplayName.SetDefault("Anorthosite");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}
		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.Anorthosite>();
			item.width = 16;
			item.height = 16;
			item.value = 30;
      item.rare = ItemRarityID.Orange;
		}
  }
}