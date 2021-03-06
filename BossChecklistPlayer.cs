﻿using BossChecklist.UI;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

namespace BossChecklist
{
	class BossChecklistPlayer : ModPlayer
	{
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (BossChecklist.ToggleChecklistHotKey.JustPressed)
			{
				if (!BossChecklistUI.visible)
				{
					BossChecklist.instance.bossChecklistUI.UpdateCheckboxes();
				}
				BossChecklistUI.visible = !BossChecklistUI.visible;
			}
		}
	}
}
