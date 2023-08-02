using DialogSample.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DialogSample.ViewModels
{
    public class UserEditViewModel : BindableBase, IDialogAware
    {
        public string Title { get; set; }

        public event Action<IDialogResult> RequestClose;

        private User userModel;

        public User UserModel
        {
            get { return userModel; }
            set { userModel = value; RaisePropertyChanged(); }
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            User user = new User()
            {
                Id = UserModel.Id,
                LoginName = UserModel.LoginName,
                Password = UserModel.Password,
                Logo = UserModel.Logo,
                Phone = UserModel.Phone,
                CreateTime = DateTime.Now,
                UpdateTime = UserModel.UpdateTime,
            };
            DialogParameters dialogParameters = new DialogParameters();
            dialogParameters.Add("UserModel", user);
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, dialogParameters));
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            if (parameters.ContainsKey("UserModel"))
            {
                UserModel = parameters.GetValue<User>("UserModel");
            }

            if (parameters.ContainsKey("Title"))
            {
                Title = parameters.GetValue<string>("Title");
            }
        }

        public DelegateCommand CancelCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }

        public UserEditViewModel()
        {
            CancelCommand = new DelegateCommand(() =>
            {
                RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));

            });
            SaveCommand = new DelegateCommand(() =>
            {
                OnDialogClosed();
            });
        }
    }
}
