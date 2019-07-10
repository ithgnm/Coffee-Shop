using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coffee_shop
{
    public class ControlsProportion
    {
        private int top;
        private int left;
        private int width;
        private int height;

        public int Top { get => top; set => top = value; }
        public int Left { get => left; set => left = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public List<ControlsProportion> ControlsProportionList(Form frm)
        {
            List<ControlsProportion> CPropList = new List<ControlsProportion>();
            for (int i = 0; i < frm.Controls.Count; i++)
            {
                ControlsProportion cp = new ControlsProportion();
                cp.Top = frm.Controls[i].Top / frm.Size.Height;
                cp.Left = frm.Controls[i].Left / frm.Size.Width;
                cp.Width = frm.Controls[i].Width / frm.Size.Width;
                cp.Height = frm.Controls[i].Height / frm.Size.Height;
                CPropList.Add(cp);
            }
            return CPropList;
        }

        public void frmResize(List<ControlsProportion> cPropList, Form frm)
        {
            int i = 0;
            foreach (ControlsProportion cp in cPropList)
            {
                frm.Controls[i].Top = cp.Top * frm.Size.Height;
                frm.Controls[i].Left = cp.Left * frm.Size.Width;
                frm.Controls[i].Width = cp.Width * frm.Size.Width;
                frm.Controls[i].Height = cp.Height * frm.Size.Height;
                i++;
            }
        }
    }
}
