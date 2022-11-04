using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using TripLog.ViewModels;

namespace TripLog.services
{
    public interface INavService
    {
        bool CanGoBack { get; }
        Task GoBack();
        Task NavigateTo<TVM>()
        where TVM : BaseViewModel;
        Task NavigateTo<TVM, TParameter>(TParameter parameter)
        where TVM : BaseViewModel;
        void RemoveLastView();
        void ClearBackStack();
        void NavigateToUri(Uri uri);
        event PropertyChangedEventHandler CanGoBackChanged;
    }
}
