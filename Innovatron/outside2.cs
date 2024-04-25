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
    public partial class outside2 : BaseForm
    {
        public override List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new() { newWorld, gloves };
            city.Visible = true;
            return interactionObjects;
        }

        public override void DefineActions()
        {
            ActionObject(gloves, "take", "press");
            Door(newWorld, new HappyEnd(), "press");
        }
    }
}
