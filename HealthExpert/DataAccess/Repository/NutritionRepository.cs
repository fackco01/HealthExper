using BussinessObject.Model.ModelNutrition;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class NutritionRepository : INutritionRepository
    {
        public void AddNutrition(Nutrition nutrition) => NutritionDAO.AddNutrition(nutrition);

        public void CreateNutritionBySessonId(string lessonId, Nutrition nutrition)
        {
            NutritionDAO.AddNutrition(lessonId, nutrition);
        }

        public void DeleteNutrition(string id) => NutritionDAO.DeleteNutrition(id);

        public List<Nutrition> GetAllNutritions() => NutritionDAO.GetAllNutritions();

        public Nutrition GetNutritionById(string id) => NutritionDAO.GetNutritionById(id);

        public Nutrition GetNutritionByTitle(string title) => NutritionDAO.GetNutritionByTitle(title);

        public void UpdateNutrition(string id, Nutrition nutrition) => NutritionDAO.UpdateNutrition(id, nutrition);
    }
}
