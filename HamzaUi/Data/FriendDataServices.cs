using HamzaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamzaUi.Data
{
    class FriendDataServices
    {
        public IEnumerable<Friend> GetAll() 
        {

            yield return new Friend { firstName = "hamza", lastName = "aldaoud" };
            yield return new Friend { firstName = "mousa", lastName = "mohamed" };
            yield return new Friend { firstName = "omar", lastName = "khaled" };
            yield return new Friend { firstName = "monther", lastName = "fadi" };


        }
    }
}
