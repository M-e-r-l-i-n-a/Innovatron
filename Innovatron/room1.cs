using System;
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
        public override PictureBox[] InteractionObjects()
        {
            PictureBox[] interactionObjects = { key, door1 };
            return interactionObjects;
        }

        public override void DefineActions()
        {
            ActionObject(key, "take", "open");
            Door(door1, new room2());
            //InformationObject(name, "text");
        }
    }
}
