using System;

namespace Checkers
{
    public static class Extensions
    {
        public static Coordinate ToCoordinate(this (int x, int y) value)
        {
            return new Coordinate(value.x, value.y);
        }

        public static string ToSerializable(this string value, PlayableSide side, Command command, string destination = "")
        {
            var playerSide = side.CurrentSide == ColorType.Black ? "1" : "2";
            
            switch (command)
            {
                case Command.Click:
                    return $"Player {playerSide} {command} to {value}";

                case Command.Move:
                    return $"Player {playerSide} {command} from {value} to {destination}";

                case Command.Remove:
                    return $"Player {playerSide} {command} chip at {value}";
                    
                default:
                    throw new ArgumentOutOfRangeException(nameof(command), command, null);

            }
        }
    }

}
