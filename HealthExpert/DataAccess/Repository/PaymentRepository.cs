using BussinessObject.Model.ModelPayment;
using DataAccess.DAO;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        public void DeletePayment(int id) => PaymentDAO.DeletePayment(id);

        public List<Payment> GetAllPayments() => PaymentDAO.GetAllPayments();

        public Payment GetPaymentById(int id) => PaymentDAO.GetPaymentById(id);

        public void InsertPayment(Payment payment) => PaymentDAO.InsertPayment(payment);

        public void UpdatePayment(int id, Payment payment) => PaymentDAO.UpdatePayment(id, payment);
    }
}
