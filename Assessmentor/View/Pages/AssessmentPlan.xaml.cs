using Assessmentor.Controller;
using Assessmentor.Templates;

namespace Assessmentor.View.Pages
{
    /// <summary>
    /// AssessmentPlan.xaml 的交互逻辑
    /// </summary>
    public partial class AssessmentPlan : AnimatedPage
    {
        public AssessmentPlan()
        {
            InitializeComponent();
            LoadAssessments();
        }

        /// <summary>
        /// 加载所有评估计划
        /// </summary>
        private void LoadAssessments()
        {
            AssessmentList.ItemsSource = AssessmentController.All();
        }
    }
}
