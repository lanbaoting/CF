using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    /// <summary>
    /// 版 本 Learun-ADMS V7.0.6 力软敏捷开发框架
    /// Copyright (c) 2013-2020 力软信息技术（苏州）有限公司
    /// 创 建：超级管理员
    /// 日 期：2022-03-28 09:47
    /// 描 述：库房信息
    /// </summary>
    public class Cf_StorageHouse
    {
         
        /// <summary>
        /// Id
        /// </summary>
        /// <returns></returns>
 
        public int Id { get; set; }
        /// <summary>
        /// CoverMap
        /// </summary>
        /// <returns></returns>
 
        public string CoverMap { get; set; }
        /// <summary>
        /// 产房名称
        /// </summary>
        /// <returns></returns>
 
        public string HousingName { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        /// <returns></returns>
  
        public string EnterpriseName { get; set; }
        /// <summary>
        /// 出售单价
        /// </summary>
        /// <returns></returns>
 
        public double? UnitPrice { get; set; }
        /// <summary>
        /// 出租单价
        /// </summary>
        /// <returns></returns>
 
        public double? HousingRent { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        /// <returns></returns>
 
        public double? HousingArea { get; set; }
        /// <summary>
        /// 出售单价
        /// </summary>
        /// <returns></returns>
 
        public double? Lng { get; set; }
        /// <summary>
        /// 出售单价
        /// </summary>
        /// <returns></returns>
  
        public double? Lat { get; set; }
        /// <summary>
        /// 省
        /// </summary>
        /// <returns></returns>
 
        public int? ProvinceId { get; set; }
        /// <summary>
        /// Pageviews
        /// </summary>
        /// <returns></returns>
   
        public int? Pageviews { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public int? CityId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string CityName { get; set; }
        /// <summary>
        /// 区id
        /// </summary>
        /// <returns></returns>
 
        public int? DistrictId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string DistrictName { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        /// <returns></returns>
 
        public int? StreetId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string StreetName { get; set; }
        /// <summary>
        /// IsEnable
        /// </summary>
        /// <returns></returns>
 
        public bool? IsEnable { get; set; }
        /// <summary>
        /// HousingtypeId
        /// </summary>
        /// <returns></returns>
 
        public int? HousingtypeId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string HousingtypeName { get; set; }
        /// <summary>
        /// HousingStructureId
        /// </summary>
        /// <returns></returns>
 
        public int? HousingStructureId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string HousingStructureName { get; set; }
        /// <summary>
        /// FloorTypeId
        /// </summary>
        /// <returns></returns>
 
        public int? FloorTypeId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string FloorTypeName { get; set; }
        /// <summary>
        /// ContactsTypeId
        /// </summary>
        /// <returns></returns>
 
        public int? ContactsTypeId { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        /// <returns></returns>
 
        public string ContactsTypeName { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        /// <returns></returns>
 
        public string FullAddress { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        /// <returns></returns>
 
        public string ContactsName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        /// <returns></returns>
 
        public string ContactNumber { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        /// <returns></returns>
 
        public string SourceName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        /// <returns></returns>
 
        public string SourceNumber { get; set; }
        /// <summary>
        /// 来源地址
        /// </summary>
        /// <returns></returns>
 
        public string SourceAddress { get; set; }
        /// <summary>
        /// 排序编号
        /// </summary>
        /// <returns></returns>
 
        public int? Sort { get; set; }
        /// <summary>
        /// Seo标题
        /// </summary>
        /// <returns></returns>
 
        public string SeoTitle { get; set; }
        /// <summary>
        /// Seo关键词
        /// </summary>
        /// <returns></returns>
 
        public string SeoKey { get; set; }
        /// <summary>
        /// Seo描述
        /// </summary>
        /// <returns></returns>
 
        public string SeoDesc { get; set; }
        /// <summary>
        /// SdPageId
        /// </summary>
        /// <returns></returns>
 
        public string SdPageId { get; set; }
        /// <summary>
        /// TransactionModeId
        /// </summary>
        /// <returns></returns>
 
        public int? TransactionModeId { get; set; }
 
        public DateTime? ReleaseTime { get; set; }
        /// <summary>
        /// 修改用户主键
        /// </summary>
        /// <returns></returns>
 
        public string F_ModifyUserId { get; set; }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <returns></returns>
 
        public string F_ModifyUserName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        /// <returns></returns>
 
        public DateTime? F_ModifyDate { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        /// <returns></returns>
 
        public DateTime? F_CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        /// <returns></returns>
 
        public string F_CreateUserId { get; set; }
     
     
        public string F_CreateUserName { get; set; }
     
    }
}
