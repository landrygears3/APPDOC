using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Docapp
{
    public class MainListView
    {
        private Product _oldProduct;
        public ObservableCollection<Product> Products { get; set; }



        public MainListView()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Title = "Medicamento 1",

                    IsVisible =false
                },
                new Product
                {
                    Title = "Medicamento 2",
                    IsVisible = false
                },
                new Product
                {
                    Title = "Medicamento 3",
                    IsVisible = false
                },
                new Product
                {
                    Title = "Medicamento 4",
                    IsVisible =  false
                }
            };




        }
        public void ShoworHiddenProducts(Product product)
        {
            if (_oldProduct == product)
            {
                product.IsVisible = !product.IsVisible;
                UpDateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.IsVisible = false;
                    UpDateProducts(_oldProduct);

                }
                product.IsVisible = true;
                UpDateProducts(product);
            }
            _oldProduct = product;
        }

        private void UpDateProducts(Product product)
        {

            var Index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(Index, product);

        }
    }
}
