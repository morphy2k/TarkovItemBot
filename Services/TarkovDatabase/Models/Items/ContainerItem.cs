﻿using Discord;
using System.Collections.Generic;
using TarkovItemBot.Helpers;

namespace TarkovItemBot.Services
{
    public class ContainerItem : BaseItem
    {
        public List<ContainerGrid> Grids { get; set; }

        public override EmbedBuilder ToEmbedBuilder()
        {
            var builder = base.ToEmbedBuilder();

            builder.AddGrids(Grids);

            return builder;
        }
    }
}
