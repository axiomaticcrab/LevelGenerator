﻿using LevelGenerator.ConsoleApp.Domain.Level;
using LevelGenerator.ConsoleApp.Render;

namespace LevelGenerator.ConsoleApp.Domain.Enemy
{
    public interface IEnemy
    {
        IRenderer Renderer { get; }
        string Name { get;  }
        Vector2 Position { get; }
    }
}