using System;
using System.Collections.Generic;
using System.Text;
using TripLog.Models;
using TripLog.services;

namespace TripLog.ViewModels
{
    public class DetailViewModel : BaseViewModel<TripLogEntry>
    {
        //Property
        TripLogEntry _entry;
        public TripLogEntry Entry
        {
            get => _entry;
            set
            {
                _entry = value;
                OnPropertyChanged();
            }
        }
        public DetailViewModel(INavService navService) : base(navService) 
        {
        }
        //public DetailViewModel(TripLogEntry entry)
        //{
        //    Entry = entry;
        //}

        public override void Init(TripLogEntry parameter)
        {
            Entry = parameter;
        }
    }
}
