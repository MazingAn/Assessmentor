using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentor.Config
{
    

    /// <summary>
    /// 主菜单配置类，提供基本的主菜单
    /// </summary>
    class MainMenuConfiguration
    {
        public static List<MainMenuItem> MainMenuItems = new List<MainMenuItem>(){
            new MainMenuItem("系统管理", "Home", "Pages/SystemManagement.xaml"),
            new MainMenuItem("评估计划", "DateRange", "Pages/AssessmentPlan.xaml"),
            new MainMenuItem("理论考核", "LanguageXaml", "Pages/Exam.xaml"),
            new MainMenuItem("单位配置", "Building", "Pages/DepartmentConfig.xaml"),
            new MainMenuItem("档案管理", "Dictionary", "Pages/DocumentManagement.xaml"),
            new MainMenuItem("资料下载", "Download", "Pages/DocumentDownload.xaml"),
            new MainMenuItem("文件查询", "File", "Pages/DepartmentConfiguration.xaml"),
            new MainMenuItem("学习提高", "Video", "Pages/Learning.xaml"),
            new MainMenuItem("系统帮助", "Help", "Pages/Help.xaml")
        };
        public static int DefaultSelectedMenuIndex = 0;
    }

    /// <summary>
    /// 主菜单内单个菜单的模型
    /// </summary>
    class MainMenuItem
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">菜单名称</param>
        /// <param name="kind">菜单图标类型（对应metarialDesign图标）</param>
        /// <param name="pagePath">菜单链接的页面路径</param>
        public MainMenuItem(string name, string kind, string pagePath)
        {
            Name = name;
            Kind = kind;
            PagePath = pagePath;
        }

        /// <summary>
        /// 菜单显示的文字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜单的类型
        /// </summary>
        public string Kind { get; set; }
        /// <summary>
        /// 菜单所对应的地址（页面路径）
        /// </summary>
        public string PagePath { get; set; }
    }
}
