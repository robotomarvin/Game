﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.GameObjects
{
    public interface ICollisionReaction
    {
        void CollisionReaction(GameObject obj);
    }
}
