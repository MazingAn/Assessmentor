using Assessmentor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentor.Controller
{
    class AssessmentController
    {
        /// <summary>
        /// 获得所有评估对象
        /// </summary>
        /// <returns></returns>
        public static List<Assessment> All()
        {
            return TestGenerate(30);
        }

        private static List<Assessment> TestGenerate(int number)
        {
            List<Assessment> assessments = new List<Assessment>();
            Random rand = new Random();
            var areas = "东 南 西 北".Split();
            var baseNames = "昆仑 黄山 秦岭 北海".Split();
            for (int i = 0; i < number; i++)
            {
                Assessment item = new Assessment();
                item.DepartmentName = $"{i}旅";
                item.DepartmentLevel = DepartmentLevel.BRIGADE;
                item.HasAntichemecalUnit = rand.NextDouble() < 0.5 ? true : false;
                item.Method = AssessmentMethod.ALONY_AND_ONECE;
                item.Result = AssessmentResult.NOTDONE;
                item.Status = rand.Next() % 3 == 0 ? AssessmentStatus.UNDO : rand.Next() % 3 == 1 ? AssessmentStatus.DONE : AssessmentStatus.DOING;
                item.Rendezvous = "南京";
                item.StartTime = new DateTime();
                item.ParentDepartment = rand.NextDouble() > 0.3 ? $"{areas[rand.Next(0, areas.Length)]}部战区" : $"{baseNames[rand.Next(0, baseNames.Length)]}基地";
                assessments.Add(item);
            }
            return assessments;
        }
    }
}
