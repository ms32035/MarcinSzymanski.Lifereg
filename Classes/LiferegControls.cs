using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Resources;
using MarcinSzymanski.Shared.Classess;
using MarcinSzymanski.Shared;
using MarcinSzymanski.Lifereg.Controls;
using SAS.Shared.AddIns;
using SAS.EG.Controls;

namespace MarcinSzymanski.Lifereg.Classes
{
    class LiferegControls
    {
        public List<TaskControl> TaskControlList { get; set; }
        private ResourceManager RMString;
        private Assembly AsmTask;
        private ISASTaskConsumer3 SASConsumer;

        public LiferegControls(ISASTaskConsumer3 sasConsumer)
        {
            TaskControlList = new List<TaskControl>();
            AsmTask = this.GetType().Assembly;
            RMString = new ResourceManager("MarcinSzymanski.Lifereg.Resources.Strings", AsmTask);
            SASConsumer = sasConsumer;

            InitializeControls();

        }

        private void InitializeControls()
        {
            TaskControl LiferegTaskControl = InitializeDataControl();
            LiferegTaskControl.SetTree("TreeNodeData", RMString.GetString("STreeNodeData"));
            TaskControlList.Add(LiferegTaskControl);

            LiferegTaskControl = new ModelControl();
            LiferegTaskControl.SetTree("TreeNodeModel", RMString.GetString("STreeNodeModel"));
            TaskControlList.Add(LiferegTaskControl);

            LiferegTaskControl = new PlotControl();
            LiferegTaskControl.SetTree("TreeNodePlot", RMString.GetString("STreeNodePlot"));
            TaskControlList.Add(LiferegTaskControl);

            LiferegTaskControl = new OutputControl();
            LiferegTaskControl.SetTree("TreeNodeOutput", RMString.GetString("STreeNodeOutput"));
            TaskControlList.Add(LiferegTaskControl);

            LiferegTaskControl = new OptionsControl();
            LiferegTaskControl.SetTree("TreeNodeOptions", RMString.GetString("STreeNodeOptions"));
            TaskControlList.Add(LiferegTaskControl);

        }

        private DataControl InitializeDataControl()
        {
            DataControl LiferegDataControl = new DataControl();
            LiferegDataControl.getSourceColumns(SASConsumer.ActiveData as ISASTaskData2);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarTargetResponse"), "RoleTargetResponse", SASVariableSelector.ROLETYPE.Numeric, 0, 1, true);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarTargetCensor"), "RoleTargetCensor", SASVariableSelector.ROLETYPE.Numeric, 0, 1, true);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarTargetLower"), "RoleTargetLower", SASVariableSelector.ROLETYPE.Numeric, 0, 1, true);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarTargetUpper"), "RoleTargetUpper", SASVariableSelector.ROLETYPE.Numeric, 0, 1, true);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarEffects"), "RoleEffect", SASVariableSelector.ROLETYPE.Numeric, 0, 0, true);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarClass"), "RoleClass", SASVariableSelector.ROLETYPE.All, 0, 0, true);
            LiferegDataControl.addColumnRole(RMString.GetString("SVarBy"), "RoleBy", SASVariableSelector.ROLETYPE.All, 0, 1, true);
            LiferegDataControl.SourceDataset = SASConsumer.ActiveData.Library + "." + SASConsumer.ActiveData.Member;
            return LiferegDataControl;
        }
    }
}
