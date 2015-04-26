using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Resources;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using MarcinSzymanski.Shared.Classess;

namespace MarcinSzymanski.Lifereg.Controls
{
    public partial class ModelControl : TaskControl
    {
        Assembly AsmTask;
        ResourceManager RMString;

        public ModelControl()
        {
            InitializeComponent();
            AsmTask = this.GetType().Assembly;
            RMString = new ResourceManager("MarcinSzymanski.Lifereg.Resources.Strings", AsmTask);

        }



        public override List<TaskSettingItem> GetSettings()
        {

            List<TaskSettingItem> setttingItems = new List<TaskSettingItem>();

            TaskSettingItem setttingItem = new TaskSettingItem("Model", "Type1", radioModelType1.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model", "Type2", radioModelType2.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model", "Censors", txtCensors.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "ALPHA", txtALPHA.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "DIST", cmbDIST.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "INITIAL", txtINITIAL.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "NOLOG", chkNOLOG.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "INTERCEPT", txtINTERCEPT.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "NOINT", chkNOINT.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "SCALE", txtSCALE.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "NOSCALE", chkNOSCALE.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "SHAPE1", txtSHAPE1.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "NOSHAPE1", chkNOSHAPE1.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "CONVERGE", txtCONVERGE.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "MAXITER", txtMAXITER.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionText", "SINGULAR", txtSINGULAR.Text);
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "CORRB", chkCORRB.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "COVB", chkCOVB.Checked.ToString());
            setttingItems.Add(setttingItem);

            setttingItem = new TaskSettingItem("Model-OptionCheck", "ITPRINT", chkITPRINT.Checked.ToString());
            setttingItems.Add(setttingItem);

            return setttingItems;

        }

        public override void RestoreSettings(List<TaskSettingItem> settingsList)
        {

            try
            {
                radioModelType1.Checked = settingsList.Find(o => o.Group == "Model" && o.Setting == "Type1").Checked();
                radioModelType2.Checked = settingsList.Find(o => o.Group == "Model" && o.Setting == "Type2").Checked();
                txtCensors.Text = settingsList.Find(o => o.Group == "Model" && o.Setting == "Censors").Value;

                txtALPHA.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "ALPHA").Value;
                cmbDIST.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "DIST").Value;
                txtINITIAL.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "INITIAL").Value;

                chkNOLOG.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "NOLOG").Checked();
                txtINTERCEPT.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "INTERCEPT").Value;
                chkNOINT.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "NOINT").Checked();

                txtSCALE.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "SCALE").Value;
                chkNOSCALE.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "NOSCALE").Checked();
                txtSHAPE1.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "SHAPE1").Value;
                chkNOSHAPE1.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "NOSHAPE1").Checked();
                txtCONVERGE.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "CONVERGE").Value;
                txtMAXITER.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "MAXITER").Value;
                txtSINGULAR.Text = settingsList.Find(o => o.Group == "Model-OptionText" && o.Setting == "SINGULAR").Value;
                chkCORRB.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "CORRB").Checked();
                chkCOVB.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "COVB").Checked();
                chkITPRINT.Checked = settingsList.Find(o => o.Group == "Model-OptionCheck" && o.Setting == "ITPRINT").Checked();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " " + e.StackTrace, "ModelControl");
            }

        }

    }
}
