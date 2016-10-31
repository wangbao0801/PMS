﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Model;
using System.Collections.Specialized;
using Quartz.Impl;
using Quartz;

namespace QuartzServiceLib
{
    public class JobService:IJobService
    {
        IScheduler sche { get; set; }

        public JobService()
        {
            if (sche != null)
            {
                sche= new SchedulerFactory().GetScheduler();
            }
        }

        /// <summary>
        /// 根据工作对象 添加任务计划
        /// </summary>
        /// <param name="jobInfo"></param>
        /// <returns></returns>
        public bool AddScheduleJob(J_JobInfo jobInfo)
        {
            //1 根据Job的类名通过反射的方式创建IJobDetial
            var job= JobFactory.CreateJobInstance(jobInfo);

            //2 创建定时器
            var trigger = JobFactory.CreateTrigger(jobInfo);

            //3 将定时器加入job中
            //放在构造函数中
            //var sche=new SchedulerFactory().GetScheduler();
            sche.ScheduleJob(job, trigger);

            //4 启动工作
            sche.Start();
            return true;
        }

        public void ResumeAllJob()
        {
            //var scheduler_temp = new SchedulerFactory().GetScheduler();

            if (!sche.IsStarted) { sche.Start(); }
            sche.ResumeAll();
        }

        /// <summary>
        /// 根据作业名及群组名暂停指定作业
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobGroup"></param>
        public void PauseJob(string jobName,string jobGroup)
        {
            sche.PauseJob(JobKey.Create(jobName, jobGroup));
        }

        public void SaveScheduleInDB()
        {
            #region 已在配置文件中配置
            ////1.首先创建一个作业调度池
            //var properties = new NameValueCollection();
            ////存储类型
            //properties["quartz.jobStore.type"] = "Quartz.Impl.AdoJobStore.JobStoreTX, Quartz";
            ////表明前缀
            //properties["quartz.jobStore.tablePrefix"] = "QRTZ_";
            ////驱动类型
            //properties["quartz.jobStore.driverDelegateType"] = "Quartz.Impl.AdoJobStore.SqlServerDelegate, Quartz";                //数据源名称
            //properties["quartz.jobStore.dataSource"] = "myDS";
            ////连接字符串
            //properties["quartz.dataSource.myDS.connectionString"] = Config.QuartzConnStr;
            ////sqlserver版本
            //properties["quartz.dataSource.myDS.provider"] = "SqlServer-20";
            //最大链接数
            //properties["quartz.dataSource.myDS.maxConnections"] = "5";
            #endregion
            //ISchedulerFactory sf = new StdSchedulerFactory(properties);
            //IScheduler sched = sf.GetScheduler();
            
            IScheduler sched = StdSchedulerFactory.GetDefaultScheduler();
        }
    }
}
