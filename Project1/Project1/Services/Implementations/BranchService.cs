using Project1.Data;
using Project1.Models;
using Project1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Services.Implementations
{
   
    public class BranchService : IBranchService,IBankService<Branch>
    {
        public Bank<Branch> info;
        public BranchService()
        {
            info = new Bank<Branch>();
        }
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get(string choice)
        {
            try
            {
                Branch br = info.Datas.Find(x => x.name.Contains(choice.ToUpper().Trim()) || x.address.Contains(choice.ToUpper().Trim()));
                Console.WriteLine(br.address + " " + br.name);

            }
            catch (Exception)
            {

                Console.WriteLine("Data can't found");
            }
        }

       
        public void GetAll()
        {
           
        }

        public void GetProfit()
        {
            
        }

        public void HireEmployee(Employee employee)
        {
            Branch ;
        }

        public void TransferEmployee()
        {
            throw new NotImplementedException();
        }

        public void TransferMoney()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
