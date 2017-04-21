﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Common.Redis;
using PMS.Model.Enum;
using PMS.BLL;

namespace QueryWFLib
{

    public sealed class CheckMsgIdInRedist_Code : CodeActivity
    {
        

        // 定义一个字符串类型的活动输入参数
        public InArgument<string> Text { get; set; }

        public OutArgument<PMS.Model.Enum.ExistEnum> enum_Exist { get; set; }

        public InArgument<PMS.Model.SMSModel.SMSModel_QueryReceive> Item_Model { get; set; }

        //public InArgument<PMS.Model.SMSModel.MMSModel_QueryReceive> Item_Model_MMS { get; set; }

       // public InArgument<PMS.Model.Enum.MMS_Enum> isMMS { get; set; }

        // 如果活动返回值，则从 CodeActivity<TResult>
        // 并从 Execute 方法返回该值。
        //判断传入的msgid是否在redis中
        //liu
        protected override void Execute(CodeActivityContext context)
        {
            // 获取 Text 输入参数的运行时值
            string text = context.GetValue(this.Text);
            var item = context.GetValue(this.Item_Model);
            ExistEnum enum_exist = ExistEnum.isNotExist;
            //在redis中判断 item.msgId  item.phoneNumber是否已经存在于redis中
            if (CheckMsgIdExist(item.msgId))
            {
                //判断当前msgid是否含有对应的电话号码（从数据库中查取）
                enum_exist = CheckTargetMsgIdContainsPhone(item.msgId, item.phoneNumber);

            }

            context.SetValue(enum_Exist, enum_exist);

        }

        /// <summary>
        /// 判断指定的msgid是否存在于当前redis中
        /// </summary>
        /// <param name="msgid"></param>
        /// <returns></returns>
        private bool CheckMsgIdExist(string msgid)
        {
            //判断redis中的string中是否存有指定的msgid
            StringRedisHelper redis_string = new StringRedisHelper();

            var temp = redis_string.Get(msgid);
            if (temp != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msgid"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        private ExistEnum CheckTargetMsgIdContainsPhone(string msgid, string phone)
        {
            PMS.IBLL.IS_SMSContentBLL contentBLL = new S_SMSContentBLL();
            //根据指定msgid查询短信内容表
            var content_temp = contentBLL.GetListBy(c => c.msgId == msgid).FirstOrDefault();
            //根据msgid的短信（彩信）内容表查询对应的发送记录（短彩信共用一张表）
            var record_temp = from r in content_temp.S_SMSRecord_Current
                              where r.PhoneNum == phone
                              select r;
            //若存在记录，则返回存在，否则返回不存在
            if (record_temp != null)
            {
                return ExistEnum.isExist;
            }
            return ExistEnum.isNotExist;
        }
    }
}
