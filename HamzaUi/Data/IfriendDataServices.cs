using HamzaModel;
using System.Collections.Generic;

namespace HamzaUi.Data
{
    public interface IfriendDataServices
    {
        IEnumerable<Friend> GetAll();
    }
}
