using CollectionViewDemo_DEINT.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo_DEINT.MVVM.ViewModels
{
    public class DetalleVM
    {
        public Product Producto { get; set; }

        public DetalleVM(Product producto)
        {
            Producto = producto;
        }
    }
}
