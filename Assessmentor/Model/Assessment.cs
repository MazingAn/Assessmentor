using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentor.Model
{
    /// <summary>
    /// 评估:模型类
    /// </summary>
    class Assessment
    {
        /// <summary>
        /// 评估单位名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 评估开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 评估单位级别
        /// </summary>
        public DepartmentLevel DepartmentLevel { get; set; }
        /// <summary>
        /// 评估状态
        /// </summary>
        public AssessmentStatus Status { get; set; }
        /// <summary>E:\评估系统单机版\Assessmentor\Assessmentor\Model\Assessment.cs
        /// 评估结果
        /// </summary>
        public AssessmentResult Result { get; set; }
        /// <summary>
        /// 评估方法
        /// </summary>
        public AssessmentMethod Method { get; set; }
        /// <summary>
        /// 是否有防化分队
        /// </summary>
        public bool HasAntichemecalUnit { get; set; }
        /// <summary>
        /// 评估人员集合点
        /// </summary>
        public string Rendezvous { get; set; }
        /// <summary>
        /// 单位隶属：战区，xx基地
        /// </summary>
        public string ParentDepartment { get; set; }
    }

    /// <summary>
    /// 评估进行状态
    /// </summary>
    public enum AssessmentStatus
    {
        UNDO, //未开始
        DOING,//进行中
        DONE,//已完成
    }

    /// <summary>
    /// 评估结果
    /// </summary>
    public enum AssessmentResult
    {
        PASS,//通过
        UNPASS,//未通过
        NOTDONE,//上次评估未完成
    }

    /// <summary>
    /// 单位级别
    /// </summary>
    public enum DepartmentLevel
    {
        /// <summary>
        /// 军级单位
        /// </summary>
        ARMY,
        /// <summary>
        /// 师级单位
        /// </summary>
        DIVISION,

        /// <summary>
        /// 旅级单位
        /// </summary>
        BRIGADE,

        /// <summary>
        /// 团级单位
        /// </summary>
        REGIMENT,

        /// <summary>
        /// 营级单位
        /// </summary>
        BATTALIONS,

        /// <summary>
        /// 连级单位
        /// </summary>
        COMPANY,

        /// <summary>
        /// 排级单位
        /// </summary>
        PLANTOON,

        /// <summary>
        /// 师级单位
        /// </summary>
        CLASS,
    }

    /// <summary>
    /// 评估方式
    /// </summary>
    public enum AssessmentMethod
    {
        /// <summary>
        /// 单组组织一次性评估
        /// </summary>
        ALONY_AND_ONECE,
        /// <summary>
        /// 区分层次分阶段评估
        /// </summary>
        LAYERED_AND_SPLITED,
        /// <summary>
        /// 依托基地融入式评估
        /// </summary>
        BASED_AND_JOINED,
        
    }
}
