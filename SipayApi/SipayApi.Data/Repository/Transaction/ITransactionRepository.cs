using SipayApi.Data.Domain;
using System.Linq.Expressions;

namespace SipayApi.Data.Repository;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    List<Transaction> GetByReference(string reference);
    
    //belirli bir parametreye göre işlemleri getirir
    List<Transaction> GetByParameter(Expression<Func<Transaction, bool>> expression);

}
