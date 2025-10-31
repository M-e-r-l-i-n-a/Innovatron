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
    public partial class room4 : BaseForm
    {
        public room4()
        {
            player.Location = new Point(456, 350);
        }

        public override List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new() { door1, paper, door3 };
            table.Visible = true;
            return interactionObjects;
        }

        public override void DefineActions()
        {
            Door(door1, new GameOver());
            Door(door3, new outside1());
            InformationObject(paper, "Wer ist für den 3. Weltkrieg verantwortlich? Für Putin nehme die linke Tür und für Trump die rechte.");
        }
    }
}
