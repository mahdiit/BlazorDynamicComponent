namespace BlazorApp3.Pages
{
    public partial class Index
    {
        List<BaseComponent> BaseComponents = new()
        {
            new Company.Index(),
            new Person.Index()
        };
        
        Company.CompanyModel CompanyModel;

        void OnCallback(object item)
        {
            CompanyModel = (Company.CompanyModel)item;
        }
    }
}
