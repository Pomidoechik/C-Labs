using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAA2
{
  interface IUserBehaviour
  {
    void blockCard(int id);
    void unblockCard(int id);
  }
}
