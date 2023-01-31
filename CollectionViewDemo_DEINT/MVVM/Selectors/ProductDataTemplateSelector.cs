using CollectionViewDemo_DEINT.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo_DEINT.MVVM.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Product producto = (Product) item;
            if (!producto.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ProductStyle",out var producStyle);
                return producStyle as DataTemplate;
            }

            Application.Current.Resources.TryGetValue("OfferStyle", out var offerStyle);
            return offerStyle as DataTemplate;
        }
    }
}
