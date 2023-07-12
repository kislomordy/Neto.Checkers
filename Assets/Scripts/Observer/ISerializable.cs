using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public interface ISerializable
    {
        public event Action ObjectMoved;

        public event Action<ColorType> GameEnded;

        public event Action<BaseClickComponent> ChipDestroyed;

        public event Action StepFinished;
    }
}
