
namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 力软信息技术（苏州）有限公司
    /// 创 建：超级管理员
    /// 日 期：2021-08-30 19:50
    /// 描 述：安卓游戏分类友情链接
    /// </summary>
    public class Jw_AzGameClassLinks 
    {
        #region 实体成员
   
        public int Id { get; set; }
        /// <summary>
        /// IsNofollow
        /// </summary>
        /// <returns></returns>
       
        public bool IsNofollow { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        /// <returns></returns>
       
        public string Title { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        /// <returns></returns>
      
        public string CoverMap { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        /// <returns></returns>
       
        public string LinkAddress { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        /// <returns></returns>
     
        public int Sort { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        /// <returns></returns>
      
        public DateTime F_CreateDate { get; set; }
       
        #endregion

       
    }
}

