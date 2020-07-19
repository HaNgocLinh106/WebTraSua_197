using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTraSua_197.Common
{
    [Serializable]
    public class UserLogin
    {
        public long MaNguoiDung { set; get; }
        public string UserName { set; get; }
    }
}