using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booklibrary.Abstractions
{
    public interface IRepository<T>
    {
        T GetData(int id);
        ObservableCollection<T> GetAllData();
        void InsertData(T data);
        void UpdateData(T data);    
        void DeleteData(T data);    

    }
}
