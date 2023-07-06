
namespace BlazorApp3.Pages.Person
{
    public partial class Index
    {
        PersonModel DataModel = new PersonModel();
        protected override void OnInitialized()
        {
            if (Model != null)
                DataModel = (PersonModel)Model;
            base.OnInitialized();
        }

        void RefreshData()
        {
            if (Model != null)
                DataModel = (PersonModel)Model;
        }
    }
}
