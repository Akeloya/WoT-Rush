﻿namespace BattleTanks.Core.Interfaces
{
    public interface IDefenceCard : IGameCard
    {
        short Defence { get; }

        void DoDefence(IGameCard target);
    }
}
