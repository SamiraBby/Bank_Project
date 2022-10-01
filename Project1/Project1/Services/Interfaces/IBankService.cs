using Project1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Services.Interfaces
{
    public interface IBankService<T> where T : SameProperties
    {
        void Create();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
}
