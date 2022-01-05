using System;
using System.Collections.Generic;
using System.Text;

namespace PraPazarMobile.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private DateTime date;
        private DateTime searchDate;
        private TimeSpan time;
        private TimeSpan searchTime;


        public DateTime Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public DateTime SearchDate
        {
            get => searchDate;
            set => SetProperty(ref date, value);
        }

        public TimeSpan Time
        {
            get => time;
            set => SetProperty(ref time, value);
        }

        public TimeSpan SearchTime
        {
            get => searchTime;
            set => SetProperty(ref time, value);
        }













    }
}
