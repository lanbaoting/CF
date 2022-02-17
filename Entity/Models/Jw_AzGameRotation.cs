
namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 力软信息技术（苏州）有限公司
    /// 创 建：超级管理员
    /// 日 期：2021-08-30 19:51
    /// 描 述：安卓游戏首页轮播
    /// </summary>
    public class Jw_AzGameRotation 
    {
        
        /// <summary>
        /// Id
        /// </summary>
        /// <returns></returns> 
        public int Id { get; set; }
 
        public string Title { get; set; }
 
        public string CoverMap { get; set; }
 
        public string LinkAddress { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        /// <returns></returns> 
        public int? Sort { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        /// <returns></returns> 
        public DateTime? F_CreateDate { get; set; }
        
    }
}

