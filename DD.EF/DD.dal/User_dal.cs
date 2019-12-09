using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.dal
{
    public class User_dal
    {
        public static List<Login_Info> getlist()
        {
            user_model model = new user_model();
            List<Login_Info> list = model.Login_Info.ToList();
            return list;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int AddUser(Login_Info model)
        {
            user_model Umodel = new user_model();
            Umodel.Login_Info.Add(model);
            return Umodel.SaveChanges();
        }
        /// <summary>
        /// 根据id详情
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public static Login_Info details(int id)
        {
            user_model Umodel = new user_model();

            return Umodel.Login_Info.FirstOrDefault(p => p.UserId == id);

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int Update(Login_Info model)
        {
            user_model Umodel = new user_model();
            Umodel.Entry(model).State = System.Data.Entity.EntityState.Modified;
            return Umodel.SaveChanges();
        }
        /// <summary>
        /// 查询角色表
        /// </summary>
        /// <returns></returns>
        public static List<Login_role> Roleslist()
        {
            user_model Umodel = new user_model();
            return Umodel.Login_role.ToList();
        }
       
    }
}
