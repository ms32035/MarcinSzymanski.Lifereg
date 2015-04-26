using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarcinSzymanski.Shared.Classess;
using MarcinSzymanski.Shared;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using SAS.Shared.AddIns;
using SAS.EG.Controls;

namespace MarcinSzymanski.Lifereg.Classes
{

    public class LiferegSettings : TaskSettings
    {

        public ResourceManager RMString;
        public Assembly AsmTask;

        public LiferegSettings(ISASTaskConsumer3 SASConsumer)
            : base()
        {

            AsmTask = this.GetType().Assembly;
            RMString = new ResourceManager("MarcinSzymanski.Lifereg.Resources.Strings", AsmTask);

            InitializeGlobals();

        }

        private void InitializeGlobals()
        {
            this.TaskName = RMString.GetString("STaskName");
            this.TaskCategory = RMString.GetString("STaskCategory");
            this.TaskDescription = RMString.GetString("STaskDescription");
            this.TaskXmlName = "MSzLifereg";
        }

        public override int OutputDataCount()
        {
            return -1;
        }

        public override bool ValidateTask()
        {
            if (TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Type1").Checked() == false &&
                TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Type2").Checked() == false)
            {
                MessageBox.Show(RMString.GetString("SErrorNoModelType"), RMString.GetString("SError"));
                return false;
            }

            if (TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Type1").Checked())
            {
                if (TaskSettingsList.Exists(o => o.Group == "Variables" && o.Setting == "RoleTargetResponse") == false)
                {
                    MessageBox.Show(RMString.GetString("SErrorNoTarget"), RMString.GetString("SError"));
                    return false;
                }
                else if (TaskSettingsList.Exists(o => o.Group == "Variables" && o.Setting == "RoleTargetCensor") &&
                  TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Censors").Value == "")
                {
                    MessageBox.Show(RMString.GetString("SErrorNoCensor"), RMString.GetString("SError"));
                    return false;
                }

            }

            if (TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Type2").Checked())
            {
                if (TaskSettingsList.Exists(o => o.Group == "Variables" && o.Setting == "RoleTargetLower") == false)
                {
                    MessageBox.Show(RMString.GetString("SErrorNoTargetLower"), RMString.GetString("SError"));
                    return false;
                }
                else if (TaskSettingsList.Exists(o => o.Group == "Variables" && o.Setting == "RoleTargetUpper") == false)
                {
                    MessageBox.Show(RMString.GetString("SErrorNoTargetUpper"), RMString.GetString("SError"));
                    return false;
                }

            }


            return true;
        }

    }
}
