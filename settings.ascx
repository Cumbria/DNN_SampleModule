<%@ Control Language="C#" AutoEventWireup="false" Inherits="MikeRidyard.SampleModule.Settings" CodeFile="Settings.ascx.cs" %>
<%@ Register TagName="label" TagPrefix="dnn" Src="~/controls/labelcontrol.ascx" %> 

<h2 id="dnnSitePanel-SampleModuleSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"></a></h2> 
<fieldset> 
    <div class="dnnFormItem"> 
        <dnn:Label ID="lblVariableName" runat="server" Text="Value for VariableName"/> 
        <asp:TextBox ID="txtVariableName" runat="server" /> 
    </div> 
</fieldset>