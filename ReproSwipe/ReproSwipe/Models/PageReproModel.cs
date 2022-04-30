using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReproSwipe.Models
{ 
    public class PageReproModel : BindableObject
    {
        private ObservableCollection<Sight> mSights; 
        public ObservableCollection<Sight> MySights 
        { 
            get
            {
                return mSights;
            }
            set
            {
                mSights = value;
                OnPropertyChanged();
            }
        } 

        public ICommand DeleteCommand {get;}
        public ICommand AddCommand {get;}

        public PageReproModel()
        {
            DeleteCommand = new Command<Sight>(model =>
            {
                DisplayAlert("This one:", model.UTCTimeTaken.ToString(), "OK");
                MySights.Remove(model);
            });

            AddCommand = new Command<Sight>(model =>
            {
                //TO DO - fo real app, add logic to pull deg min from user
                Sight newTest = new Sight(DateTime.Now, 77, 77);
                if (MySights == null)
                {
                    MySights = new ObservableCollection<Sight>();
                }
                MySights.Add(newTest);  
            });
        } //ctor
       
        private void DisplayAlert(string v1, string v2, string v3)
        {
             Application.Current.MainPage.DisplayAlert(v1, v2, v3);
        }
    } //class PageReproModel
}//ns
