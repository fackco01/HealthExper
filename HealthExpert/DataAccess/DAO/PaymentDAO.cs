using BussinessObject.ContextData;
using BussinessObject.Model.ModelPayment;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO
{
    public class PaymentDAO
    {
        //Get payment by id
        public static Payment GetPaymentById(int id)
        {
            var payment = new Payment();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    payment = ctx.payments.FirstOrDefault(payment => payment.paymentId == id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return payment;
        }

        //Get all payments
        public static List<Payment> GetAllPayments()
        {
            var listPayment = new List<Payment>();
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    listPayment = ctx.payments.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listPayment;
        }

        //Insert payment
        public static void InsertPayment(Payment payment)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    ctx.payments.Add(payment);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Update payment
        public static void UpdatePayment(int id,Payment payment)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    if(GetPaymentById(id) != null)
                    {
                        ctx.payments.Add(payment);
                        ctx.Entry(payment).State = EntityState.Modified;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Delete payment
        public static void DeletePayment(int id)
        {
            try
            {
                using (var ctx = new HealthExpertContext())
                {
                    var payment = ctx.payments.FirstOrDefault(payment => payment.paymentId == id);
                    ctx.payments.Remove(payment);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
