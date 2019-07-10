using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphical_user_interface
{
    public partial class coffee : DevExpress.XtraEditors.XtraForm
    {
        private ImageCollection imgStyle;

        public coffee()
        {
            InitializeComponent();
            loadLookAndFeelIntoICB();
        }

        public void loadLookAndFeelIntoICB()
        {
            imgStyle = new ImageCollection();
            icbStyle.Properties.SmallImages = imgStyle;
            for (int i = 0; i < SkinManager.Default.Skins.Count; i++)
            {
                string skinName = SkinManager.Default.Skins[i].SkinName;
                imgStyle.AddImage(SkinCollectionHelper.GetSkinIcon(skinName, SkinIconsSize.Small), skinName);
                icbStyle.Properties.Items.Add(new ImageComboBoxItem(skinName, i));
                if (skinName == Properties.Settings.Default.Theme) icbStyle.SelectedIndex = i;
            }
            dlafStyle.LookAndFeel.SetSkinStyle(Properties.Settings.Default.Theme);
        }

        private void icbStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit edit = sender as DevExpress.XtraEditors.ComboBoxEdit;
            dlafStyle.LookAndFeel.SetSkinStyle(edit.EditValue.ToString());
            Properties.Settings.Default.Theme = edit.EditValue.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
