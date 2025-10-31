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
    public partial class outside1 : BaseForm
    {
        public outside1()
        {
            paper.Location = new Point(552, 317);
        }

        public override List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new() { paper, paper2, door3 };
            city.Visible = true;
            return interactionObjects;
        }

        public override void DefineActions()
        {
            Door(door3, new outside2());
            InformationObject(paper2, "Badener Tagblatt ~ 11. 04.2031\r\nKriegsbeitritt der USA\r\nAm 10. April haben die USA den Kriegsbeitritt bekannt gegeben. Was einige schon vermutet haben,\r\nist jetzt geschehen: Der dritte Weltkrieg ist angebrochen.\r\n");
            InformationObject(paper, "Badener Tagblatt ~ 02.05.2031\r\nErste Atombomben eingeschlagen\r\nDie Lage ist völlig ausser Kontrolle geraten. In den USA und Russland sind die ersten Atombomben\r\neingeschlagen, weitere werden folgen. Die Bevölkerung wird gebeten, sich schnellstmöglich in\r\nBunkern in Sicherheit zu bringen. \r\nGleich nach dem Beenden dieses Artikels werde ich kündigen und meine Zeit im Bunker dem\r\nSchreiben von Fantasy-Romanen widmen. Auf dass jemand sie wird lesen können.\r\n");
        }
    }
}
