using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MarcinSzymanski.Shared.Classess;
using MarcinSzymanski.Shared;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit.Controls;

namespace MarcinSzymanski.Lifereg.Controls
{
    public partial class OutputControl : TaskControl
    {
        public OutputControl()
        {
            InitializeComponent();
        }

        private void btnOUT_Click(object sender, EventArgs e)
        {
            MSzTaskForm mszTaskForm = (this.ParentForm as MSzTaskForm);

            string cookie = "";
            ISASTaskConsumer3 Consumer = mszTaskForm.Consumer;
            ISASTaskDataName name = Consumer.ShowOutputDataSelector(this,
                 ServerAccessMode.OneServer,
                 Consumer.AssignedServer,
                 "", "", ref cookie);

            // if the user closes the dialog without making a selection,
            // the name will be null.
            if (name != null)
            {
                txtOUT.Text =
                    string.Format("{0}.{1}", name.Library, name.Member);
            }
        }


        private void ckhOutputEnable_Click(object sender, EventArgs e)
        {
            if (chkOutputEnable.Checked == true)
                groupOutput.Enabled = true;
            else
                groupOutput.Enabled = false;
        }

        public override List<TaskSettingItem> GetSettings()
        {

            List<TaskSettingItem> setttingItems = new List<TaskSettingItem>();

            TaskSettingItem setttingItem;

            setttingItem = new TaskSettingItem("Output", "OUT", txtOUT.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "CENSORED", txtCENSORED.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "CDF", txtCDF.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "CONTROL", txtCONTROL.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "CRES", txtCRES.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "SRES", txtSRES.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "PREDICTED", txtPREDICTED.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "QUANTILE", txtQUANTILE.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "STD", txtSTD.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output-OptionText", "XBETA", txtXBETA.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Output", "Enable", chkOutputEnable.Checked.ToString());
            setttingItems.Add(setttingItem);

            return setttingItems;

        }

        public override void RestoreSettings(List<TaskSettingItem> settingsList)
        {

            try
            {
                txtOUT.Text = settingsList.Find(o => o.Group == "Output" && o.Setting == "OUT").Value;
                txtCENSORED.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "CENSORED").Value;
                txtCDF.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "CDF").Value;
                txtCONTROL.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "CONTROL").Value;
                txtCRES.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "CRES").Value;
                txtSRES.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "SRES").Value;
                txtPREDICTED.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "PREDICTED").Value;
                txtQUANTILE.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "QUANTILE").Value;
                txtSTD.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "STD").Value;
                txtXBETA.Text = settingsList.Find(o => o.Group == "Output-OptionText" && o.Setting == "XBETA").Value;
                if (settingsList.Find(o => o.Group == "Output" && o.Setting == "Enable").Value == "True")
                {
                    chkOutputEnable.Checked = true;
                    groupOutput.Enabled = true;
                }
                else
                {
                    chkOutputEnable.Checked = false;
                    groupOutput.Enabled = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " " + e.StackTrace, "OutputControl");
            }

        }
    }
}
