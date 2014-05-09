using System; 
using DotNetNuke.Entities.Modules; 
using DotNetNuke.Services.Exceptions; 

namespace MikeRidyard.SampleModule 
    { 
    
    public partial class View : PortalModuleBase 
    {

        public override void OnLoad(EventArgs e)
        { 
            try
            {

                if (base.Settings["VariableName"] != null)
                {

                    string VariableName = base.Settings["VariableName"].ToString(); 
                    LabelName.Text = VariableName.ToString();
                }
                else
                {

                    LabelName.Text = "<div class=\"dnnFormMessage dnnFormInfo\">Please Configure with <b>Settings</b> tab </div>";
                }
            }
            
            catch (Exception exc) //Module failed to load
            {

                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }
    }
}