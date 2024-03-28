using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatron
{
    internal class room2 : BaseForm
    {
        public override PictureBox[] InteractionObjects()
        {
            PictureBox[] interactionObjects = { cupboard, glasses };
            return interactionObjects;
        }

        public override void DefineActions()
        {
            ActionObject(cupboard, "take", "read");
            //Door(door1, new room2());
            //InformationObject(name, "text");
        }
    }
}
