using DialogSample.Models;
using ImTools;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DialogSample.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<string> SearchCommand { get; set; }
        public DelegateCommand<string> AddCommand { get; set; }
        public DelegateCommand<int?> EditCommand { get; set; }

        private readonly IDialogService dialogService;

        public MainViewModel(IDialogService dialogService)
        {
            SearchCommand = new DelegateCommand<string>(Search);
            AddCommand = new DelegateCommand<string>(Add);
            EditCommand = new DelegateCommand<int?>(Edit);
            this.dialogService = dialogService;
            Search("");
        }

        private void Edit(int? Id)
        {
            User userModel = UserList.Find(x => x.Id == Id);
            DialogParameters parameters = new DialogParameters();
            parameters.Add("UserModel", userModel);
            parameters.Add("Title", "编辑用户");
            this.dialogService.ShowDialog("UserEdit", parameters, callback =>
            {
                if (callback.Parameters.ContainsKey("UserModel"))
                {
                    User saveUser = callback.Parameters.GetValue<User>("UserModel");
                    try
                    {
                        int index = UserList.FindIndex(s=>s.Id==saveUser.Id);
                        UserList[index] = saveUser;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            });
        }

        private List<User> InitData()
        {
            List<User> lists = new List<User>() {
                    new User(){Id=1,LoginName="test1",Password="123456",Logo="",Phone="13522228769",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                    new User(){Id=2,LoginName="test2",Password="123456",Logo="",Phone="13522228769",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                    new User(){Id=3,LoginName="test3",Password="123456",Logo="",Phone="13522228769",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                    new User(){Id=4,LoginName="test4",Password="123456",Logo="",Phone="13522228769",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                    new User(){Id=5,LoginName="test5",Password="123456",Logo="",Phone="13522228769",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                    new User(){Id=6,LoginName="test6",Password="123456",Logo="",Phone="13522228769",CreateTime=DateTime.Now,UpdateTime=DateTime.Now},
                };

            return lists;
        }

        private void Add(string page)
        {
            User user = new User();
            DialogParameters parameters = new DialogParameters();
            parameters.Add("UserModel", user);
            parameters.Add("Title", "添加用户");

            this.dialogService.ShowDialog(page, parameters, callback =>
            {
                if (callback.Parameters.ContainsKey("UserModel"))
                {
                    User saveUser = callback.Parameters.GetValue<User>("UserModel");
                    try
                    {
                        saveUser.Id = UserList.LastOrDefault().Id + 1;
                        saveUser.CreateTime = DateTime.Now;
                        saveUser.UpdateTime = DateTime.Now;

                        List<User> lists = InitData();
                        lists.Add(saveUser);

                        UserList = new List<User>();
                        lists.ForEach((s) =>
                        {
                            UserList.Add(s);
                        });

                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            });
        }

        private void Search(string loginName)
        {
            List<User> lists = InitData();
            List<User> models;
            if (!string.IsNullOrWhiteSpace(loginName))
            {
                models = lists.FindAll(x => x.LoginName.Contains(loginName));
            }
            else
            {
                models = lists;
            }

            UserList = new List<User>();
            models.ForEach((s) =>
            {
                UserList.Add(s);
            });
        }

        private List<User> userList;
        public List<User> UserList
        {
            get { return userList; }
            set { userList = value; RaisePropertyChanged(); }
        }
    }
}
