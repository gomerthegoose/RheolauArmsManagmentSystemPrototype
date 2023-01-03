using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    internal class StaffMenu
    {
        public Panel mainStaffMenu()
        {
            Panel mainPanel = new Panel();

            mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(177, 0);
            mainPanel.Name = "ActionsPanel";
            mainPanel.Size = new System.Drawing.Size(623, 450);
            mainPanel.TabIndex = 1;


            return mainPanel;
        }


    }
}
