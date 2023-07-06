using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp3.Pages.Company
{
    public partial class Index
    {
        CompanyModel DataModel = new CompanyModel();
        protected override void OnInitialized()
        {
            if (Model != null)
                DataModel = (CompanyModel)Model;
            base.OnInitialized();
        }

        async Task SendData(MouseEventArgs args)
        {
            await GetModel.InvokeAsync(DataModel);
        }
    }
}
