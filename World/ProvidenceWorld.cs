using Microsoft.Xna.Framework;
using ProvidenceMod.Dusts;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ProvidenceMod
{
	public class ProvidenceWorld : ModWorld
	{
		// Downed Bosses
		public static bool downedFireAncient;
		public static bool downedAirElemental;

		// Difficulty Modifiers
		public bool ascension;
		public bool torment;

		// Sparkly Boss Treasure
		public List<Item> itemList = new List<Item>();
		public int dustDelay = 30;

		public override void PostUpdate()
		{
			if (itemList != null)
			{
				foreach (Item item in itemList.ToArray())
				{
					if (item != null)
					{
						if (item.beingGrabbed || item.isBeingGrabbed)
						{
							itemList.Remove(item);
						}
						else
						{
							SparklyBossTreaure(item);
						}
					}
				}
			}
		}
		public void SparklyBossTreaure(Item item)
		{
			dustDelay--;
			if (dustDelay == 0)
			{
				Dust.NewDust(new Vector2(item.Hitbox.X + Main.rand.NextFloat(0, item.Hitbox.Width + 1), item.Hitbox.Y + Main.rand.NextFloat(0, item.Hitbox.Height + 1)), 6, 6, DustType<SparkleDust>(), Main.rand.NextFloat(-0.25f, 0.5f), Main.rand.NextFloat(-0.25f, 0.5f), default, Color.White, 3f);
				dustDelay = 30;
			}
		}
	}
}
