﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack.Redis;

namespace Common.Redis
{
    public abstract  class BaseRedisHelper : IDisposable
    {
       
        private bool _disposed = false;

        /// <summary>
        /// Redis客户端
        /// </summary>
        protected static RedisClient redis_client;

        /// <summary>
        /// 自定义的Redis配置对象
        /// </summary>
        private static readonly RedisConfig redis_config = RedisConfig.GetConfig();

        /// <summary>
        /// Redis缓冲池管理对象
        /// </summary>
        private static PooledRedisClientManager prc_Manager;

        //缓存过期时间
        private static int seconds_TimeOut = 30 * 60;

        // private static RedisClient redis;

        //Redis缓冲池
        // PooledRedisClientManager poolRedis = new PooledRedisClientManager();

        /// <summary>
        /// 创建Redis连接池管理对象
        /// </summary>
        /// <param name="readWriteUrl"></param>
        /// <param name="readOnlyUrl"></param>
        /// <returns></returns>
        public static void CreateManager(string[] readWriteUrl, string[] readOnlyUrl)
        {
            prc_Manager = new PooledRedisClientManager(readWriteUrl, readOnlyUrl);
            //return manager;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        static BaseRedisHelper()
        {
            //1 获取Redis配置的配置属性
            //6月24日 
            //1.1 只获取写入和读取ip数组
            var writeServerArray = SplitString(redis_config.WriteServerList, ",").ToArray();
            var readServerArray = SplitString(redis_config.ReadServerList, ",").ToArray();

            //2 执行创建缓存池对象
            CreateManager(writeServerArray, readServerArray);

            //3 通过缓存连接池获取Redis客户端对象，并赋给本类中定义的私有变量
            if (redis_client == null)
            {
                redis_client = prc_Manager.GetClient() as RedisClient;
            }
        }



        /// <summary>
        /// 将传入的字符串根据 第二个参数分隔返回数组
        /// </summary>
        /// <param name="source_str"></param>
        /// <param name="split_str"></param>
        /// <returns></returns>
        private static IEnumerable<string> SplitString(string source_str, string split_str)
        {
            return source_str.Split(split_str.ToArray());
        }


        private static IRedisClient GetClient()
        {
            //获取客户端缓存操作对象
            return prc_Manager.GetClient();
        }
       
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    redis_client.Dispose();
                    redis_client = null;
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// 保存数据DB文件到硬盘
        /// </summary>
        public void Save()
        {
            redis_client.Save();
        }
        /// <summary>
        /// 异步保存数据DB文件到硬盘
        /// </summary>
        public void SaveAsync()
        {
            redis_client.SaveAsync();
        }
    }
}
    