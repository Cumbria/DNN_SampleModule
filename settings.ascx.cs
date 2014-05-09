using System; 
using DotNetNuke.Entities.Modules; 
using DotNetNuke.Services.Exceptions; 

Namespace MikeRidyard.SampleModule
{

    public partial class Settings : ModuleSettingsBase 
    {  

        public override void LoadSettings() 
        { 
            try 
                { 

                    if (Page.IsPostBack == false) 
                    { 

                    if(Settings.Contains("VariableName")) 
                        txtVariableName.Text = Settings["VariableName"].ToString(); 

                    } 

                } 

                catch (Exception exc) //Module failed to load 
                { 
                    Exceptions.ProcessModuleLoadException(this, exc); 

                } 
            } 

        public override void UpdateSettings()
        { 
            try 
                { 
                    ModuleController modules = new ModuleController(); 

                 // modules.UpdateModuleSetting(ModuleId, "VariableName", txtVariableName.Text); 
                    modules.UpdateTabModuleSetting(TabModuleId, "VariableName", txtVariableName.Text); 

                } 

            catch (Exception exc) //Module failed to load 
                { 
                    Exceptions.ProcessModuleLoadException(this, exc); 

                }
        }
    }
}