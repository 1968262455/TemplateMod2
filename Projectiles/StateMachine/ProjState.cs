﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMod2.Projectiles.StateMachine {
    public abstract class ProjState {
        public abstract void AI(SMProjectile proj);
    }
}
