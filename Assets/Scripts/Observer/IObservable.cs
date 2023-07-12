using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Checkers
{
    public interface IObservable
    {
        public Task Serialize(string input);

        public event Action<Coordinate> NextStepReady;
    }
}