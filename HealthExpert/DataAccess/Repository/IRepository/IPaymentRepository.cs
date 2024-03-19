using BussinessObject.Model.ModelPayment;

namespace DataAccess.Repository.IRepository
{
    public interface IPaymentRepository
    {
        List<Payment> GetAllPayments();
        Payment GetPaymentById(int id);
        void InsertPayment(Payment payment);
        void UpdatePayment(int id, Payment payment);
        void DeletePayment(int id);
    }
}
