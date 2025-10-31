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
        public override List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new() { door1, cupboard };
            trumpPicture.Visible = true;
            return interactionObjects;
        }

        public override void DefineActions()
        {
            ActionObject(wireCutter, "take", "wire cutter");
            Door(door1, Program.room1);
            RevealObject(cupboard, "open", wireCutter, Properties.Resources.cabinet_open);
        }
    }
}
