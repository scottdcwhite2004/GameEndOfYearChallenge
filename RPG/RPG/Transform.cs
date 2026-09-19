using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RPG
{
    internal class Transform
    {
        private Vector2 _position;
        private float _rotation;
        private Vector2 _scale;

        public Transform(Vector2 position, float rotation, Vector2 scale)
        {
            _position = position;
            _rotation = rotation;
            _scale = scale;
        }

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public float Rotation
            {
            get { return _rotation; }
            set { _rotation = value; }
        }

        public Vector2 Scale
            {
            get { return _scale; }
            set { _scale = value; }
        }
    }
}
