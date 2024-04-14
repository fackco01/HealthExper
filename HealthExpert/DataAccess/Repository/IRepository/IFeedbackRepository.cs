using BussinessObject.Model.ModelCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IFeedbackRepository
    {
        public void AddFeedback(Feedback feedback);
        public void DeleteFeedback(Guid feedbackId);
        public List<Feedback> GetFeedbacks();
        public Feedback GetFeedbackById(Guid feedbackId);
        public void UpdateFeedback(Feedback feedback);
        //public void AddFeedback(Guid accountId, string courseId, Feedback feedback);
    }
}
