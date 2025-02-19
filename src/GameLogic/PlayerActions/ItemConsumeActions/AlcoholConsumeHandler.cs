﻿// -----------------------------------------------------------------------
// <copyright file="AlcoholConsumeHandler.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace MUnique.OpenMU.GameLogic.PlayerActions.ItemConsumeActions;

using MUnique.OpenMU.GameLogic.Views;

/// <summary>
/// The alcohol consume handler.
/// </summary>
public class AlcoholConsumeHandler : BaseConsumeHandler
{
    /// <inheritdoc/>
    public override bool ConsumeItem(Player player, Item item, Item? targetItem, FruitUsage fruitUsage)
    {
        if (base.ConsumeItem(player, item, targetItem, fruitUsage))
        {
            player.ViewPlugIns.GetPlugIn<IDrinkAlcoholPlugIn>()?.DrinkAlcohol();
            return true;
        }

        return false;
    }
}