﻿namespace LevelGenerator.ConsoleApp.Domain.Enemy.Behaviours
{
    public interface ICanMove
    {
        float MovementSpeed { get; }
        Condition When { get; }
    }
}