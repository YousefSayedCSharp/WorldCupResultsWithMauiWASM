namespace WorldCupResultsWithMauiWASM.ViewModels;
//CollectionVM
public partial class HomeVM
{
    private List<ColectionViewGroup> _Group;
    public List<ColectionViewGroup> Group
    {
        get => _Group;
        set { SetValue(ref _Group, value); }
    }

    //private AppModel _selectedItem;
    //public AppModel selectedItem
    //{
    //    get => _selectedItem;
    //    set
    //    {
    //        if (value == null)
    //            return;

    //        SetValue(ref _selectedItem, value);

    //        if (selectedItem.Id == 0)
    //        {
    //            ButtonsIsEnabled(false);
    //            return;
    //        }

    //        appNameId= selectedItem.AppId;
    //        appName = selectedItem.AppName;
    //        appDescription = selectedItem.AppDescription;
    //        appUrl = selectedItem.AppUrl;
    //        appVersion = Convert.ToInt32(selectedItem.AppVersion.Split('.')[0]);
    //        appFinish = Convert.ToDateTime(selectedItem.AppFinish);
    //        appIsActive= selectedItem.IsActive;

    //        ButtonsIsEnabled(true);

    //        if (!show)
    //        {
    //            show = true;
    //            txtShow = "\uf078";
    //            txtRead = "مفتوح";
    //        }

    //        //SetValue(ref _selectedItem, null);
    //        //end
    //    }
    //}

}
