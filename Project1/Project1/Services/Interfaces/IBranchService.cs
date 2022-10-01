using Project1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Services.Interfaces
{
    public interface IBranchService:IBankService<Branch>
    {
        void HireEmployee();
        void GetProfit();
        void TransferMoney();
        void TransferEmployee();
    }
}
