﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PMS2016Entities : DbContext
    {
        public PMS2016Entities()
            : base("name=PMS2016Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActionInfo> ActionInfo { get; set; }
        public DbSet<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<P_DepartmentInfo> P_DepartmentInfo { get; set; }
        public DbSet<P_Group> P_Group { get; set; }
        public DbSet<P_PersonInfo> P_PersonInfo { get; set; }
        public DbSet<R_Department_Mission> R_Department_Mission { get; set; }
        public DbSet<R_Group_Mission> R_Group_Mission { get; set; }
        public DbSet<S_SMSMission> S_SMSMission { get; set; }
        public DbSet<R_UserInfo_Group> R_UserInfo_Group { get; set; }
        public DbSet<R_UserInfo_SMSMission> R_UserInfo_SMSMission { get; set; }
        public DbSet<S_SMSContent> S_SMSContent { get; set; }
        public DbSet<S_SMSRecord_Current> S_SMSRecord_Current { get; set; }
        public DbSet<R_UserInfo_DepartmentInfo> R_UserInfo_DepartmentInfo { get; set; }
        public DbSet<R_UserInfo_PersonInfo> R_UserInfo_PersonInfo { get; set; }
        public DbSet<S_SMSRecord_History> S_SMSRecord_History { get; set; }
        public DbSet<S_SMSMsgContent> S_SMSMsgContent { get; set; }
        public DbSet<R_UserInfo_News> R_UserInfo_News { get; set; }
        public DbSet<N_News> N_News { get; set; }
        public DbSet<WF_Query_StepInfo> WF_Query_StepInfo { get; set; }
        public DbSet<S_SMSType> S_SMSType { get; set; }
        public DbSet<WF_Query_Instance> WF_Query_Instance { get; set; }
        public DbSet<Quartz_Job> Quartz_Job { get; set; }
    }
}
