namespace MarcinSzymanski.Lifereg.Controls
{
    partial class ModelControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelControl));
            this.radioModelType1 = new System.Windows.Forms.RadioButton();
            this.radioModelType2 = new System.Windows.Forms.RadioButton();
            this.groupModelType = new System.Windows.Forms.GroupBox();
            this.txtCensors = new System.Windows.Forms.TextBox();
            this.groupSpecification = new System.Windows.Forms.GroupBox();
            this.lblSCALE1 = new System.Windows.Forms.Label();
            this.lblSCALE = new System.Windows.Forms.Label();
            this.lblINTERCEPT = new System.Windows.Forms.Label();
            this.lblINITIAL = new System.Windows.Forms.Label();
            this.lblDIST = new System.Windows.Forms.Label();
            this.lblALPHA = new System.Windows.Forms.Label();
            this.chkNOSHAPE1 = new System.Windows.Forms.CheckBox();
            this.txtSHAPE1 = new System.Windows.Forms.TextBox();
            this.chkNOSCALE = new System.Windows.Forms.CheckBox();
            this.txtSCALE = new System.Windows.Forms.TextBox();
            this.chkNOINT = new System.Windows.Forms.CheckBox();
            this.txtINTERCEPT = new System.Windows.Forms.TextBox();
            this.txtINITIAL = new System.Windows.Forms.TextBox();
            this.chkNOLOG = new System.Windows.Forms.CheckBox();
            this.cmbDIST = new System.Windows.Forms.ComboBox();
            this.txtALPHA = new System.Windows.Forms.TextBox();
            this.groupFitting = new System.Windows.Forms.GroupBox();
            this.lblSINGULAR = new System.Windows.Forms.Label();
            this.lblMAXITER = new System.Windows.Forms.Label();
            this.txtSINGULAR = new System.Windows.Forms.TextBox();
            this.txtMAXITER = new System.Windows.Forms.TextBox();
            this.lblCONVERGE = new System.Windows.Forms.Label();
            this.txtCONVERGE = new System.Windows.Forms.TextBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.chkITPRINT = new System.Windows.Forms.CheckBox();
            this.chkCOVB = new System.Windows.Forms.CheckBox();
            this.chkCORRB = new System.Windows.Forms.CheckBox();
            this.groupModelType.SuspendLayout();
            this.groupSpecification.SuspendLayout();
            this.groupFitting.SuspendLayout();
            this.groupOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioModelType1
            // 
            resources.ApplyResources(this.radioModelType1, "radioModelType1");
            this.radioModelType1.Name = "radioModelType1";
            this.radioModelType1.TabStop = true;
            this.radioModelType1.UseVisualStyleBackColor = true;
            // 
            // radioModelType2
            // 
            resources.ApplyResources(this.radioModelType2, "radioModelType2");
            this.radioModelType2.Name = "radioModelType2";
            this.radioModelType2.TabStop = true;
            this.radioModelType2.UseVisualStyleBackColor = true;
            // 
            // groupModelType
            // 
            resources.ApplyResources(this.groupModelType, "groupModelType");
            this.groupModelType.Controls.Add(this.txtCensors);
            this.groupModelType.Controls.Add(this.radioModelType1);
            this.groupModelType.Controls.Add(this.radioModelType2);
            this.groupModelType.Name = "groupModelType";
            this.groupModelType.TabStop = false;
            // 
            // txtCensors
            // 
            resources.ApplyResources(this.txtCensors, "txtCensors");
            this.txtCensors.Name = "txtCensors";
            // 
            // groupSpecification
            // 
            resources.ApplyResources(this.groupSpecification, "groupSpecification");
            this.groupSpecification.Controls.Add(this.lblSCALE1);
            this.groupSpecification.Controls.Add(this.lblSCALE);
            this.groupSpecification.Controls.Add(this.lblINTERCEPT);
            this.groupSpecification.Controls.Add(this.lblINITIAL);
            this.groupSpecification.Controls.Add(this.lblDIST);
            this.groupSpecification.Controls.Add(this.lblALPHA);
            this.groupSpecification.Controls.Add(this.chkNOSHAPE1);
            this.groupSpecification.Controls.Add(this.txtSHAPE1);
            this.groupSpecification.Controls.Add(this.chkNOSCALE);
            this.groupSpecification.Controls.Add(this.txtSCALE);
            this.groupSpecification.Controls.Add(this.chkNOINT);
            this.groupSpecification.Controls.Add(this.txtINTERCEPT);
            this.groupSpecification.Controls.Add(this.txtINITIAL);
            this.groupSpecification.Controls.Add(this.chkNOLOG);
            this.groupSpecification.Controls.Add(this.cmbDIST);
            this.groupSpecification.Controls.Add(this.txtALPHA);
            this.groupSpecification.Name = "groupSpecification";
            this.groupSpecification.TabStop = false;
            // 
            // lblSCALE1
            // 
            resources.ApplyResources(this.lblSCALE1, "lblSCALE1");
            this.lblSCALE1.Name = "lblSCALE1";
            // 
            // lblSCALE
            // 
            resources.ApplyResources(this.lblSCALE, "lblSCALE");
            this.lblSCALE.Name = "lblSCALE";
            // 
            // lblINTERCEPT
            // 
            resources.ApplyResources(this.lblINTERCEPT, "lblINTERCEPT");
            this.lblINTERCEPT.Name = "lblINTERCEPT";
            // 
            // lblINITIAL
            // 
            resources.ApplyResources(this.lblINITIAL, "lblINITIAL");
            this.lblINITIAL.Name = "lblINITIAL";
            // 
            // lblDIST
            // 
            resources.ApplyResources(this.lblDIST, "lblDIST");
            this.lblDIST.Name = "lblDIST";
            // 
            // lblALPHA
            // 
            resources.ApplyResources(this.lblALPHA, "lblALPHA");
            this.lblALPHA.Name = "lblALPHA";
            // 
            // chkNOSHAPE1
            // 
            resources.ApplyResources(this.chkNOSHAPE1, "chkNOSHAPE1");
            this.chkNOSHAPE1.Name = "chkNOSHAPE1";
            this.chkNOSHAPE1.UseVisualStyleBackColor = true;
            // 
            // txtSHAPE1
            // 
            resources.ApplyResources(this.txtSHAPE1, "txtSHAPE1");
            this.txtSHAPE1.Name = "txtSHAPE1";
            // 
            // chkNOSCALE
            // 
            resources.ApplyResources(this.chkNOSCALE, "chkNOSCALE");
            this.chkNOSCALE.Name = "chkNOSCALE";
            this.chkNOSCALE.UseVisualStyleBackColor = true;
            // 
            // txtSCALE
            // 
            resources.ApplyResources(this.txtSCALE, "txtSCALE");
            this.txtSCALE.Name = "txtSCALE";
            // 
            // chkNOINT
            // 
            resources.ApplyResources(this.chkNOINT, "chkNOINT");
            this.chkNOINT.Name = "chkNOINT";
            this.chkNOINT.UseVisualStyleBackColor = true;
            // 
            // txtINTERCEPT
            // 
            resources.ApplyResources(this.txtINTERCEPT, "txtINTERCEPT");
            this.txtINTERCEPT.Name = "txtINTERCEPT";
            // 
            // txtINITIAL
            // 
            resources.ApplyResources(this.txtINITIAL, "txtINITIAL");
            this.txtINITIAL.Name = "txtINITIAL";
            // 
            // chkNOLOG
            // 
            resources.ApplyResources(this.chkNOLOG, "chkNOLOG");
            this.chkNOLOG.Name = "chkNOLOG";
            this.chkNOLOG.UseVisualStyleBackColor = true;
            // 
            // cmbDIST
            // 
            resources.ApplyResources(this.cmbDIST, "cmbDIST");
            this.cmbDIST.FormattingEnabled = true;
            this.cmbDIST.Items.AddRange(new object[] {
            resources.GetString("cmbDIST.Items"),
            resources.GetString("cmbDIST.Items1"),
            resources.GetString("cmbDIST.Items2"),
            resources.GetString("cmbDIST.Items3"),
            resources.GetString("cmbDIST.Items4"),
            resources.GetString("cmbDIST.Items5"),
            resources.GetString("cmbDIST.Items6")});
            this.cmbDIST.Name = "cmbDIST";
            // 
            // txtALPHA
            // 
            resources.ApplyResources(this.txtALPHA, "txtALPHA");
            this.txtALPHA.Name = "txtALPHA";
            // 
            // groupFitting
            // 
            resources.ApplyResources(this.groupFitting, "groupFitting");
            this.groupFitting.Controls.Add(this.lblSINGULAR);
            this.groupFitting.Controls.Add(this.lblMAXITER);
            this.groupFitting.Controls.Add(this.txtSINGULAR);
            this.groupFitting.Controls.Add(this.txtMAXITER);
            this.groupFitting.Controls.Add(this.lblCONVERGE);
            this.groupFitting.Controls.Add(this.txtCONVERGE);
            this.groupFitting.Name = "groupFitting";
            this.groupFitting.TabStop = false;
            // 
            // lblSINGULAR
            // 
            resources.ApplyResources(this.lblSINGULAR, "lblSINGULAR");
            this.lblSINGULAR.Name = "lblSINGULAR";
            // 
            // lblMAXITER
            // 
            resources.ApplyResources(this.lblMAXITER, "lblMAXITER");
            this.lblMAXITER.Name = "lblMAXITER";
            // 
            // txtSINGULAR
            // 
            resources.ApplyResources(this.txtSINGULAR, "txtSINGULAR");
            this.txtSINGULAR.Name = "txtSINGULAR";
            // 
            // txtMAXITER
            // 
            resources.ApplyResources(this.txtMAXITER, "txtMAXITER");
            this.txtMAXITER.Name = "txtMAXITER";
            // 
            // lblCONVERGE
            // 
            resources.ApplyResources(this.lblCONVERGE, "lblCONVERGE");
            this.lblCONVERGE.Name = "lblCONVERGE";
            // 
            // txtCONVERGE
            // 
            resources.ApplyResources(this.txtCONVERGE, "txtCONVERGE");
            this.txtCONVERGE.Name = "txtCONVERGE";
            // 
            // groupOutput
            // 
            resources.ApplyResources(this.groupOutput, "groupOutput");
            this.groupOutput.Controls.Add(this.chkITPRINT);
            this.groupOutput.Controls.Add(this.chkCOVB);
            this.groupOutput.Controls.Add(this.chkCORRB);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.TabStop = false;
            // 
            // chkITPRINT
            // 
            resources.ApplyResources(this.chkITPRINT, "chkITPRINT");
            this.chkITPRINT.Name = "chkITPRINT";
            this.chkITPRINT.UseVisualStyleBackColor = true;
            // 
            // chkCOVB
            // 
            resources.ApplyResources(this.chkCOVB, "chkCOVB");
            this.chkCOVB.Name = "chkCOVB";
            this.chkCOVB.UseVisualStyleBackColor = true;
            // 
            // chkCORRB
            // 
            resources.ApplyResources(this.chkCORRB, "chkCORRB");
            this.chkCORRB.Name = "chkCORRB";
            this.chkCORRB.UseVisualStyleBackColor = true;
            // 
            // ModelControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupFitting);
            this.Controls.Add(this.groupSpecification);
            this.Controls.Add(this.groupModelType);
            this.Name = "ModelControl";
            this.groupModelType.ResumeLayout(false);
            this.groupModelType.PerformLayout();
            this.groupSpecification.ResumeLayout(false);
            this.groupSpecification.PerformLayout();
            this.groupFitting.ResumeLayout(false);
            this.groupFitting.PerformLayout();
            this.groupOutput.ResumeLayout(false);
            this.groupOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioModelType1;
        private System.Windows.Forms.RadioButton radioModelType2;
        private System.Windows.Forms.GroupBox groupModelType;
        private System.Windows.Forms.GroupBox groupSpecification;
        private System.Windows.Forms.GroupBox groupFitting;
        private System.Windows.Forms.GroupBox groupOutput;
        private System.Windows.Forms.CheckBox chkCOVB;
        private System.Windows.Forms.CheckBox chkCORRB;
        private System.Windows.Forms.CheckBox chkITPRINT;
        private System.Windows.Forms.Label lblSINGULAR;
        private System.Windows.Forms.Label lblMAXITER;
        private System.Windows.Forms.TextBox txtSINGULAR;
        private System.Windows.Forms.TextBox txtMAXITER;
        private System.Windows.Forms.Label lblCONVERGE;
        private System.Windows.Forms.TextBox txtCONVERGE;
        private System.Windows.Forms.CheckBox chkNOSHAPE1;
        private System.Windows.Forms.TextBox txtSHAPE1;
        private System.Windows.Forms.CheckBox chkNOSCALE;
        private System.Windows.Forms.TextBox txtSCALE;
        private System.Windows.Forms.CheckBox chkNOINT;
        private System.Windows.Forms.TextBox txtINTERCEPT;
        private System.Windows.Forms.TextBox txtINITIAL;
        private System.Windows.Forms.CheckBox chkNOLOG;
        private System.Windows.Forms.ComboBox cmbDIST;
        private System.Windows.Forms.TextBox txtALPHA;
        private System.Windows.Forms.Label lblDIST;
        private System.Windows.Forms.Label lblALPHA;
        private System.Windows.Forms.Label lblINITIAL;
        private System.Windows.Forms.Label lblINTERCEPT;
        private System.Windows.Forms.Label lblSCALE;
        private System.Windows.Forms.Label lblSCALE1;
        private System.Windows.Forms.TextBox txtCensors;
    }
}
