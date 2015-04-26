using System;
using System.Text;
using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;
using MarcinSzymanski.Shared;
using MarcinSzymanski.Shared.Classess;
using MarcinSzymanski.Lifereg.Classes;
using System.Windows.Forms;

namespace MarcinSzymanski.Lifereg
{
    [ClassId("a2eb055c-3f34-4141-aa5f-8b9ee5ea48e7")]
    // location of the task icon to show in the menu and process flow
    [IconLocation("MarcinSzymanski.Lifereg.Resources.msz.ico")]
    // does this task require input data? 
    // InputResourceType.Data for data set, or 
    // InputResourceType.None for none required
    [InputRequired(InputResourceType.Data)]
    [SASTaskCategory("Analysis")]
        
    public class Lifereg : SAS.Tasks.Toolkit.SasTask
    {


        private LiferegSettings LiferegInstanceSettings;
        private LiferegControls LiferegInstanceControls;
        private MSzTaskForm LiferegForm;


        public Lifereg()
        {

            LiferegInstanceSettings = new LiferegSettings(this.Consumer);
            LiferegInstanceSettings.setCodeGenerator(new LiferegCodeGenerator());

            InitializeComponent();

        }

        private void InitializeComponent()
        {

            this.TaskName = LiferegInstanceSettings.TaskName;
            this.TaskCategory = LiferegInstanceSettings.TaskCategory;
            this.TaskDescription = LiferegInstanceSettings.TaskDescription;
            this.ProcsUsed = "LIFEREG";
            this.ProductsRequired = "BASE, STAT";
            this.RequiresData = true;


        }



        #region overrides
        public override bool Initialize()
        {

            return true;
        }

        public override string GetXmlState()
        {
            return LiferegInstanceSettings.ToXml();
        }

        public override void RestoreStateFromXml(string xmlState)
        {
            LiferegInstanceSettings.FromXml(xmlState);
        }


        public override ShowResult Show(System.Windows.Forms.IWin32Window Owner)
        {

            // Definicja kontrolek
            LiferegInstanceControls = new LiferegControls(this.Consumer);

            // stworzenie formularza od (ustawienia instancji, lista kotrolek)
            LiferegForm = new MSzTaskForm(this.Consumer, (TaskSettings)LiferegInstanceSettings, LiferegInstanceControls.TaskControlList);
            LiferegForm.RestoreFromSettings();

            if (System.Windows.Forms.DialogResult.OK == LiferegForm.ShowDialog(Owner))
            {
                //Pobranie ustawień po wyniku
                LiferegForm.UpdateSettings();
                LiferegInstanceSettings = (LiferegSettings)LiferegForm.TaskInstanceSettings;
                return ShowResult.RunNow;
            }
            else
                return ShowResult.Canceled;
        }


        public override int OutputDataCount
        {
            get { return LiferegInstanceSettings.OutputDataCount(); }
        }

        public override string GetSasCode()
        {
            return LiferegInstanceSettings.GenerateSasCode();
        }
        #endregion

    }
}
