﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuartzProxy.ServiceReference_QuartzService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference_QuartzService.IJobService")]
    public interface IJobService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/AddScheduleJob", ReplyAction="http://tempuri.org/IJobService/AddScheduleJobResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.QueryJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.BaseJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.SendJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.Message.BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsStorage))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsTracker))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo[]))]
        object AddScheduleJob(PMS.Model.J_JobInfo jobInfo, object data_temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/AddScheduleJob", ReplyAction="http://tempuri.org/IJobService/AddScheduleJobResponse")]
        System.Threading.Tasks.Task<object> AddScheduleJobAsync(PMS.Model.J_JobInfo jobInfo, object data_temp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/AddListener", ReplyAction="http://tempuri.org/IJobService/AddListenerResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.QueryJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.BaseJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.SendJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.Message.BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsStorage))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsTracker))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo[]))]
        void AddListener(object jobListener, string JobName, string GroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/AddListener", ReplyAction="http://tempuri.org/IJobService/AddListenerResponse")]
        System.Threading.Tasks.Task AddListenerAsync(object jobListener, string JobName, string GroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/ResumeAllJob", ReplyAction="http://tempuri.org/IJobService/ResumeAllJobResponse")]
        void ResumeAllJob();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/ResumeAllJob", ReplyAction="http://tempuri.org/IJobService/ResumeAllJobResponse")]
        System.Threading.Tasks.Task ResumeAllJobAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/ResumeTargetJob", ReplyAction="http://tempuri.org/IJobService/ResumeTargetJobResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.QueryJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.BaseJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.SendJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.Message.BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsStorage))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsTracker))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo[]))]
        object ResumeTargetJob(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/ResumeTargetJob", ReplyAction="http://tempuri.org/IJobService/ResumeTargetJobResponse")]
        System.Threading.Tasks.Task<object> ResumeTargetJobAsync(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/RemovceJob", ReplyAction="http://tempuri.org/IJobService/RemovceJobResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.QueryJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.BaseJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.SendJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.Message.BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsStorage))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsTracker))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo[]))]
        object RemovceJob(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/RemovceJob", ReplyAction="http://tempuri.org/IJobService/RemovceJobResponse")]
        System.Threading.Tasks.Task<object> RemovceJobAsync(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/PauseJob", ReplyAction="http://tempuri.org/IJobService/PauseJobResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.QueryJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.BaseJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.SendJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.Message.BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsStorage))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsTracker))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo[]))]
        object PauseJob(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/PauseJob", ReplyAction="http://tempuri.org/IJobService/PauseJobResponse")]
        System.Threading.Tasks.Task<object> PauseJobAsync(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/RemoveJob", ReplyAction="http://tempuri.org/IJobService/RemoveJobResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.QueryJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.BaseJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.JobDataModel.SendJobDataModel))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.Message.BaseResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobTemplate))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.J_JobInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.RoleInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_ActionInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.N_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_News))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_DepartmentInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.P_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Group_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_Department_Mission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_SMSMission))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsStorage))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.FdfsTracker))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_Current))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSRecord_History))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.S_SMSMsgContent))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_Group))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.R_UserInfo_PersonInfo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PMS.Model.UserInfo[]))]
        object RemoveJob(PMS.Model.J_JobInfo job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobService/RemoveJob", ReplyAction="http://tempuri.org/IJobService/RemoveJobResponse")]
        System.Threading.Tasks.Task<object> RemoveJobAsync(PMS.Model.J_JobInfo job);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobServiceChannel : QuartzProxy.ServiceReference_QuartzService.IJobService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobServiceClient : System.ServiceModel.ClientBase<QuartzProxy.ServiceReference_QuartzService.IJobService>, QuartzProxy.ServiceReference_QuartzService.IJobService {
        
        public JobServiceClient() {
        }
        
        public JobServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object AddScheduleJob(PMS.Model.J_JobInfo jobInfo, object data_temp) {
            return base.Channel.AddScheduleJob(jobInfo, data_temp);
        }
        
        public System.Threading.Tasks.Task<object> AddScheduleJobAsync(PMS.Model.J_JobInfo jobInfo, object data_temp) {
            return base.Channel.AddScheduleJobAsync(jobInfo, data_temp);
        }
        
        public void AddListener(object jobListener, string JobName, string GroupName) {
            base.Channel.AddListener(jobListener, JobName, GroupName);
        }
        
        public System.Threading.Tasks.Task AddListenerAsync(object jobListener, string JobName, string GroupName) {
            return base.Channel.AddListenerAsync(jobListener, JobName, GroupName);
        }
        
        public void ResumeAllJob() {
            base.Channel.ResumeAllJob();
        }
        
        public System.Threading.Tasks.Task ResumeAllJobAsync() {
            return base.Channel.ResumeAllJobAsync();
        }
        
        public object ResumeTargetJob(PMS.Model.J_JobInfo job) {
            return base.Channel.ResumeTargetJob(job);
        }
        
        public System.Threading.Tasks.Task<object> ResumeTargetJobAsync(PMS.Model.J_JobInfo job) {
            return base.Channel.ResumeTargetJobAsync(job);
        }
        
        public object RemovceJob(PMS.Model.J_JobInfo job) {
            return base.Channel.RemovceJob(job);
        }
        
        public System.Threading.Tasks.Task<object> RemovceJobAsync(PMS.Model.J_JobInfo job) {
            return base.Channel.RemovceJobAsync(job);
        }
        
        public object PauseJob(PMS.Model.J_JobInfo job) {
            return base.Channel.PauseJob(job);
        }
        
        public System.Threading.Tasks.Task<object> PauseJobAsync(PMS.Model.J_JobInfo job) {
            return base.Channel.PauseJobAsync(job);
        }
        
        public object RemoveJob(PMS.Model.J_JobInfo job) {
            return base.Channel.RemoveJob(job);
        }
        
        public System.Threading.Tasks.Task<object> RemoveJobAsync(PMS.Model.J_JobInfo job) {
            return base.Channel.RemoveJobAsync(job);
        }
    }
}
