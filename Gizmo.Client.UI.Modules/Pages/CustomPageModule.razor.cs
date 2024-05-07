using Gizmo.UI;
using Microsoft.AspNetCore.Components;

namespace Gizmo.Client.UI.Modules.Pages
{
    [ModuleGuid("c8b64460-0799-4145-8f09-84471a9ade69")] //module id guid, this value identifies the module globally and should be unique
    [PageUIModule(Title = "Custom module", Description = "Custom module description")] //module title and description
    [ModuleDisplayOrder(0)] //display order in client module menu
    [Route("/custom")] //module access route
    public partial class CustomPageModule : ComponentBase
    {
        public CustomPageModule() 
        {

        }
    }
}
