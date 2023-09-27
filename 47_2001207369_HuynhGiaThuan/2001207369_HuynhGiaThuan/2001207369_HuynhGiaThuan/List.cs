using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001207369_HuynhGiaThuan
{
    class List
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public float PRICE { get; set; }
        public List(int id, string name,float price)
        {
            ID=id;
            NAME=name;
            PRICE = price;
        }
        List<List> danhsach = new List<List> { 
          
        
        };


    }
}
