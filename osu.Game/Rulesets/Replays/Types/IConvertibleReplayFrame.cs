﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Beatmaps;
using osu.Game.Rulesets.Replays.Legacy;

namespace osu.Game.Rulesets.Replays.Types
{
    /// <summary>
    /// A type of <see cref="ReplayFrame"/> which can be converted from a <see cref="LegacyReplayFrame"/>.
    /// </summary>
    public interface IConvertibleReplayFrame
    {
        /// <summary>
        /// Populates this <see cref="ReplayFrame"/> using values from a <see cref="LegacyReplayFrame"/>.
        /// </summary>
        /// <param name="legacyFrame">The <see cref="LegacyReplayFrame"/> to extract values from.</param>
        /// <param name="beatmap">The beatmap.</param>
        void ConvertFrom(LegacyReplayFrame legacyFrame, Beatmap beatmap);
    }
}
