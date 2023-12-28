﻿using MarsRoverComplete.Directions;

namespace MarsRoverComplete
{
    public class MarsRover : Position
    {
        private readonly string _initialState;
        private Position _position;
        private IDirection _direction;

        public MarsRover(string initialState)
        {
            _initialState = initialState;
            _position = new Position();
        }

        public string Execute(string commands)
        {
            var states = _initialState.Split(":");
            var x = int.Parse(states[0]);
            var y = int.Parse(states[1]);
            _position = new Position(x, y);
            var directionStringCommands = states[2];
            _direction = DirectionFactory.CreateDirectionFrom(directionStringCommands);

            commands.ToCharArray().ToList().ForEach(c =>
            {
                if (c == 'M')
                {
                    _position = _direction.MoveForward(_position);
                }
                if (c == 'R')
                {
                    _direction = _direction.ToRight();
                }
                if (c == 'L')
                {
                    _direction = _direction.ToLeft();
                }
            });            

            return $"{_position.X}:{_position.Y}:{_direction.AsStringCommand()}";
        }
    }
}
