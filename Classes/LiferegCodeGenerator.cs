using System;
using System.Collections.Generic;
using MarcinSzymanski.Shared.Classess;
using SAS.Tasks.Toolkit.Helpers;
using System.Windows.Forms;

namespace MarcinSzymanski.Lifereg.Classes
{
    class LiferegCodeGenerator : TaskCodeGenerator
    {

        public override string GenerateSasCode(List<TaskSettingItem> TaskSettingsList)
        {

            string SASCode = UtilityFunctions.ReadFileFromAssembly("MarcinSzymanski.Lifereg.Lifereg.sas");
            string TmpString;

            try
            {
                SASCode = SASCode.Replace("{v_precode}", TaskSettingsList.Find(o => o.Group == "Options" && o.Setting == "Pre-code").Value);
                SASCode = SASCode.Replace("{v_data}", TaskSettingsList.Find(o => o.Group == "Data" && o.Setting == "Input").Value);

                TmpString = "";
                foreach (TaskSettingItem SettingItem in TaskSettingsList.FindAll(o => o.Group == "Variables" && o.Setting == "RoleClass"))
                {
                    TmpString += SettingItem.Value + " ";
                }
                SASCode = SASCode.Replace("{v_class}", TmpString);

                if (TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Type1").Checked() == true)
                {
                    try
                    {
                        TmpString = TaskSettingsList.Find(o => o.Group == "Variables" && o.Setting == "RoleTargetResponse").Value;
                        try
                        {
                            TmpString += " * " + TaskSettingsList.Find(o => o.Group == "Variables" && o.Setting == "RoleTargetCensor").Value + " ( "
                                + TaskSettingsList.Find(o => o.Group == "Model" && o.Setting == "Censors").Value + " )" ;

                        }
                        catch (Exception)
                        {
                        }
                    }
                    catch (Exception)
                    {
                        TmpString = "";
                    }
                    SASCode = SASCode.Replace("{v_model}", TmpString);
                }
                else
                {
                    try
                    {
                        TmpString = "(" + TaskSettingsList.Find(o => o.Group == "Variables" && o.Setting == "RoleTargetLower").Value +
                        " , " + TaskSettingsList.Find(o => o.Group == "Variables" && o.Setting == "RoleTargetUpper").Value + ")";
                    }
                    catch (Exception)
                    {
                        TmpString = "";
                    }
                    SASCode = SASCode.Replace("{v_model}", TmpString);
                }

                /*
                * 
                * Model effects
                * 
                */

                TmpString = "";
                foreach (TaskSettingItem SettingItem in TaskSettingsList.FindAll(o => o.Group == "Variables" && o.Setting == "RoleEffect"))
                {
                    TmpString += SettingItem.Value + " ";
                }
                SASCode = SASCode.Replace("{v_effects}", TmpString);


                /*
                 * 
                 * Model options
                 * 
                 */

                TmpString = "";

                foreach (TaskSettingItem SettingItem in TaskSettingsList.FindAll(o => o.Group == "Model-OptionText" ))
                {
                    if (SettingItem.Value != "")
                        TmpString += SettingItem.Setting + " = " + SettingItem.Value + " ";
                }

                foreach (TaskSettingItem SettingItem in TaskSettingsList.FindAll(o => o.Group == "Model-OptionCheck"))
                {
                    if (SettingItem.Checked())
                        TmpString += SettingItem.Setting  + " ";
                }

 
                SASCode = SASCode.Replace("{v_model_options}", TmpString);

                /*
                * 
                * PLOT
                * 
                */

                TmpString = "";
                if (TaskSettingsList.Find(o => o.Group == "Plot" && o.Setting == "Enable").Checked())
                {
                    TmpString = "PROBPLOT " + TaskSettingsList.Find(o => o.Group == "Plot" && o.Setting == "Options").Value;
                }
                SASCode = SASCode.Replace("{v_probplot}", TmpString);

                /*
                * 
                * INSET
                * 
                */

                TmpString = "";
                if (TaskSettingsList.Find(o => o.Group == "Inset" && o.Setting == "Enable").Checked())
                {
                    TmpString = "INSET ";
                    foreach (TaskSettingItem SettingItem in TaskSettingsList.FindAll(o => o.Group == "Inset-OptionCheck"))
                    {
                        if (SettingItem.Checked())
                            TmpString += SettingItem.Setting + " ";
                    }
                    TmpString += TaskSettingsList.Find(o => o.Group == "Plot" && o.Setting == "Options").Value;
                }

                SASCode = SASCode.Replace("{v_inset}", TmpString);

                /*
                * 
                * OUTPUT
                * 
                */
                TmpString = "";
                if (TaskSettingsList.Find(o => o.Group == "Output" && o.Setting == "Enable").Checked())
                {
                    TmpString = "OUTPUT OUT = " + TaskSettingsList.Find(o => o.Group == "Output" && o.Setting == "OUT").Value; ;

                    foreach (TaskSettingItem SettingItem in TaskSettingsList.FindAll(o => o.Group == "Output-OptionText"))
                    {
                        if (SettingItem.Checked())
                            TmpString += SettingItem.Setting + " ";
                    }
                    
                }

                SASCode = SASCode.Replace("{v_output}", TmpString);

                /*
                * 
                * BY
                * 
                */

                try
                {
                    TmpString = "BY " + TaskSettingsList.Find(o => o.Group == "Variables" && o.Setting == "RoleBy").Value;
                }
                catch (Exception)
                {
                    TmpString = "";
                }

                SASCode = SASCode.Replace("{v_by}", TmpString);


                /*
                * 
                * POST CODE
                * 
                */
                
                SASCode = SASCode.Replace("{v_postcode}", TaskSettingsList.Find(o => o.Group == "Options" && o.Setting == "Post-code").Value);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return SASCode;
        }


    }
}
