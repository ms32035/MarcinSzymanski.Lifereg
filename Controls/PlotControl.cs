using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MarcinSzymanski.Shared.Classess;

namespace MarcinSzymanski.Lifereg.Controls
{
    public partial class PlotControl : TaskControl
    {
        public PlotControl()
        {
            InitializeComponent();
        }

        private void chkPPLOT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPPLOT.Checked == true)
                groupPlot.Enabled = true;
            else
                groupPlot.Enabled = false;
        }

        private void chkINSET_CheckedChanged(object sender, EventArgs e)
        {
            if (chkINSET.Checked == true)
                groupInset.Enabled = true;
            else
                groupInset.Enabled = false;
        }

        public override List<TaskSettingItem> GetSettings()
        {

            List<TaskSettingItem> setttingItems = new List<TaskSettingItem>();

            TaskSettingItem setttingItem;

            setttingItem = new TaskSettingItem("Plot", "Enable", chkPPLOT.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Plot", "Options", txtPlotOptions.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset", "Enable", chkINSET.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "CONFIDENCE", chkCONFIDENCE.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "DIST", chkDIST.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "INTERVAL", chkINTERVAL.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "LEFT", chkLEFT.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "NOBS", chkNOBS.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "NMISS", chkNMISS.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "RIGHT", chkRIGHT.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "SCALE", chkSCALE.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "SHAPE", chkSHAPE.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset-OptionCheck", "UNCENSORED", chkUNCENSORED.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Inset", "Options", txtInsetOptions.Text);
            setttingItems.Add(setttingItem);

            return setttingItems;

        }

        public override void RestoreSettings(List<TaskSettingItem> settingsList)
        {

            try
            {
                chkPPLOT.Checked = settingsList.Find(o => o.Group == "Plot" && o.Setting == "Enable").Checked();
                groupPlot.Enabled = settingsList.Find(o => o.Group == "Plot" && o.Setting == "Enable").Checked();

                txtPlotOptions.Text = settingsList.Find(o => o.Group == "Plot" && o.Setting == "Options").Value;

                chkINSET.Checked = settingsList.Find(o => o.Group == "Inset" && o.Setting == "Enable").Checked();
                groupInset.Enabled = settingsList.Find(o => o.Group == "Inset" && o.Setting == "Enable").Checked();

                chkCONFIDENCE.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "CONFIDENCE").Checked();
                chkDIST.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "DIST").Checked();
                chkINTERVAL.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "INTERVAL").Checked();
                chkLEFT.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "LEFT").Checked();
                chkNOBS.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "NOBS").Checked();
                chkNMISS.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "NMISS").Checked();
                chkRIGHT.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "RIGHT").Checked();
                chkSCALE.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "SCALE").Checked();
                chkSHAPE.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "SHAPE").Checked();
                chkUNCENSORED.Checked = settingsList.Find(o => o.Group == "Inset-OptionCheck" && o.Setting == "UNCENSORED").Checked();
                txtInsetOptions.Text = settingsList.Find(o => o.Group == "Inset" && o.Setting == "Options").Value;


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " " + e.StackTrace,"PlotControl");
            }

        }

    }
}
