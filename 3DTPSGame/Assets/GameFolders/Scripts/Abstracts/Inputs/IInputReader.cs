﻿using UnityEngine;

namespace TPSGame.Abstracts.Inputs
{
    public interface IInputReader
    {
        Vector3 Direction { get; }
    }
}