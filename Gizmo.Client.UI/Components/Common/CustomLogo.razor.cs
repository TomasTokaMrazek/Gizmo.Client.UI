using System;
using System.Net.Http;
using System.Threading.Tasks;
using Gizmo.Web.Components;
using Gizmo.Web.Components.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Gizmo.Client.UI.Components
{
    public partial class CustomLogo : CustomDOMComponentBase
    {
        [Inject] private HttpClient HttpClient { get; set; }

        private string? imageUrl;
        private bool isLoading = true;
        private bool hasError = false;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                // Fetch the image directly using HttpClient
                var response = await HttpClient.GetAsync("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTefezWXAr6IlRnwH76BPQyZreEF3tHByb9PQ&s");
                
                if (response.IsSuccessStatusCode)
                {
                    var imageBytes = await response.Content.ReadAsByteArrayAsync();
                    var base64 = Convert.ToBase64String(imageBytes);
                    imageUrl = $"data:image/jpeg;base64,{base64}";
                }
                else
                {
                    hasError = true;
                }
            }
            catch (Exception)
            {
                hasError = true;
            }
            finally
            {
                isLoading = false;
                StateHasChanged();
            }
        }
    }
}
