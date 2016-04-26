﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PMS.Model;

namespace PMS.BLL
{
   public partial class P_GroupBLL
    {
        /// <summary>
        /// 查询指定联系人id的所属群组集合
        /// </summary>
        /// <param name="pid">联系人id</param>
        /// <returns></returns>
        public List<P_Group> GetListByPerson(int pid)
        {
            //1 根据pid查询人员对象
            var person= this.CurrentDBSession.P_PersonInfoDAL.GetListBy(p => p.PID==pid).FirstOrDefault();

           return person.P_Group.ToList();
        }

        /// <summary>
        /// 从数据库中根据id集合查询返回指定的GroupInfo集合
        /// </summary>
        /// <param name="list_ids"></param>
        /// <returns></returns>
        public List<P_Group> GetListByIds(List<int> list_ids)
        {

            return GetListBy(a => list_ids.Contains(a.GID)).ToList();

        }

        /// <summary>
        /// 根据群组GID删除指定PID的联系人
        /// </summary>
        /// <param name="gid"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public bool DelPersonInfoByGID(int gid,int pid)
        {
            //2 根据gid找到对应的群组对象
            var group = this.CurrentDBSession.P_GroupDAL.GetListBy(g => g.GID == gid).FirstOrDefault();
            //2.2将该群组对象中的指定联系人删除

            var person_bygroup = group.P_PersonInfo.Where(p => p.PID == pid).FirstOrDefault();
            bool state = group.P_PersonInfo.Remove(person_bygroup);
           return this.CurrentDBSession.SaveChanges();
        }

        /// <summary>
        /// 修改指定的GroupId 的对象集合的删除标记为删除
        /// </summary>
        /// <param name="list_ids"></param>
        /// <returns></returns>
        public bool DelSoftRoleInfos(List<int> list_ids)
        {
            List<P_Group> list = new List<P_Group>();
            //遍历需要查找的Action集合
            foreach (var item in this.GetListByIds(list_ids))
            {
                //修改其中的删除标记
                item.isDel = true;
                //并添加至新创建的集合中
                list.Add(item);
            }
            try
            {
                this.UpdateByList(list);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}