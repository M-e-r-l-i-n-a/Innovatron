﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatron
{
    internal class room1 : BaseForm
    {
        public room1()
        {
            player.Location = new Point(456, 350);
        }

        public override List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new() { key, door3, schloss };
            door1.Visible = true;
            return interactionObjects;
        }

        public override void DefineActions()
        {
            ActionObject(key, "take", "open");
            Door(door3, Program.room2);
            Door(door1, Program.room3);
            RevealObject(schloss, "wire cutter", door1, null);
        }
    }
}
