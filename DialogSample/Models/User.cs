using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogSample.Models
{
    public class User : BindableBase
    {
        private int id;

        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; RaisePropertyChanged(); }
        }

        private string loginName;

        /// <summary>
        /// 用户名
        /// </summary>
        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; RaisePropertyChanged(); }
        }

        private string password;

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(); }
        }

        private string logo;

        /// <summary>
        /// 头像
        /// </summary>
        public string Logo
        {
            get { return logo; }
            set { logo = value; RaisePropertyChanged(); }
        }

        private string phone;

        /// <summary>
        /// 手机
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; RaisePropertyChanged(); }
        }

        private DateTime createTime;

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; RaisePropertyChanged(); }
        }

        private DateTime updateTime;

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; RaisePropertyChanged(); }
        }
    }
}
