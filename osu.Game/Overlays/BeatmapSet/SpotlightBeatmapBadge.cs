// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Allocation;
using osu.Game.Graphics;
using osu.Game.Resources.Localisation.Web;

#nullable enable

namespace osu.Game.Overlays.BeatmapSet
{
    public class SpotlightBeatmapBadge : BeatmapBadge
    {
        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            BadgeText = BeatmapsetsStrings.SpotlightBadgeLabel;
            BadgeColour = colours.Pink1;
        }
    }
}
