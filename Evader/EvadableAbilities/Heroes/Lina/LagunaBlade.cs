﻿namespace Evader.EvadableAbilities.Heroes
{
    using System.Linq;

    using Base;

    using Ensage;

    using static Core.Abilities;

    internal class LagunaBlade : LinearTarget
    {
        #region Constructors and Destructors

        public LagunaBlade(Ability ability)
            : base(ability)
        {
            BlinkAbilities.AddRange(BlinkAbilityNames);
            DisableAbilities.AddRange(DisableAbilityNames);

            CounterAbilities.Add(PhaseShift);
            CounterAbilities.Add(BallLightning);
            CounterAbilities.Add(Eul);
            CounterAbilities.Add(Manta);
            CounterAbilities.Add(SleightOfFist);
            CounterAbilities.Add(TricksOfTheTrade);
            CounterAbilities.AddRange(VsDamage);
            CounterAbilities.AddRange(VsMagic);
            CounterAbilities.AddRange(Invul);
            CounterAbilities.Add(SnowBall);
            CounterAbilities.Add(Lotus);
            CounterAbilities.Add(NetherWard);
            CounterAbilities.AddRange(Invis);

            AdditionalDelay = Ability.AbilitySpecialData.First(x => x.Name == "damage_delay").Value;
        }

        #endregion
    }
}