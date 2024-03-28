using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatron
{
    public partial class room3 : BaseForm
    {
        public override List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new() { door1, glasses, door3 };
            return interactionObjects;
        }

        public override void DefineActions()
        {
            ActionObject(glasses, "take", "read");
            Door(door1, Program.room1);
            //InformationObject(name, "text");
            //RevealObject(cupboard, "open", wireCutter, "..\\..\\..\\pictures\\cabinet-open.png");
        }
    }
}
