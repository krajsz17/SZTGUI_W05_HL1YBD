using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows;

namespace WPFClient
{
    public class MainWindowsViewModel : ObservableRecipient
    {

        public ICommand SendMessageCommand { get; set; }
        public RestCollection<MessageModels> MSG2 { get; set; }
        private string msg;
        public string MSG
        { 
            get { return msg; }
            set { SetProperty(ref msg, value); }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }
        public static bool IsInDesignMode
        {
            get
            {
                var property = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(property, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowsViewModel()
        {
            if(!IsInDesignMode)
            {
                MSG2 = new RestCollection<MessageModels>("http://localhost:44339/", "msg", "hub");
                SendMessageCommand = new RelayCommand(() => { MSG2.Add(new MessageModels(){ UID = Username, Message = MSG, Timespan = DateTime.Now });});
            }
        }

    }
}
