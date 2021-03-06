﻿#region using
using Gmail.DDD.IOC;
using Gmail.DDD.Repositorys;
using PM2.Models.Code030;
using PM2.Models.Code031;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace PM2.Repository.Code031
{
    public interface Iszrl125Repository_Facade : IEFRepository<szrl125>
    {
        #region 检测合同是否为初始化状态
        /// <summary>
        /// 检测合同是否为[初始化状态]
        /// </summary>
        /// <param name="pd00401">合同ID</param>
        /// <returns></returns>
        bool IsInitialize(string pd00401);
        #endregion


        #region 获取-[待支付确认]合同支付情况
        /// <summary>
        /// 获取-[待支付确认]合同支付情况
        /// </summary>
        /// <param name="rl12502">合同ID</param>
        /// <returns></returns>
        Task<szrl125> GetSzrl126s(string rl12502);
        #endregion
        #region 获取-[已支付确认]合同支付情况
        /// <summary>
        /// 获取-[已支付确认]合同支付情况
        /// </summary>
        /// <param name="rl12502">合同ID</param>
        /// <returns></returns>
        Task<szrl125> GetSzrl127s(string rl12502);
        #endregion

        #region 操作-[待支付确认]合同支付情况
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szrl126"></param>
        void Szrl126Add(szrl126 szrl126);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szrl126"></param>
        void Szrl126Remove(szrl126 szrl126);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szrl126"></param>
        void Szrl126RemoveRange(IEnumerable<szrl126> szrl126s);
        #endregion
        #region 操作-[待支付确认]临时备份[0,预付款, 1:验收款]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szrl126"></param>
        void Szrl140Add(szrl140 szrl140);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szrl126"></param>
        void Szrl140Remove(szrl140 szrl140);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="szrl126"></param>
        void Szrl140RemoveRange(IEnumerable<szrl140> szrl140s);
        #endregion

    }
}
