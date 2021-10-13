﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProjectDLyn
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public static int productCount;

        //public BindingList<Part> AssociatedPart = new BindingList<Part>();

        public static BindingList<Product> productStockPile = new BindingList<Product>();
        private int v1;
        private string text;
        private int v2;
        private decimal v3;
        private int v4;
        private int v5;
        private int v;

        public Product(int pID, System.Windows.Forms.TextBox addProductNameTextBox, string n, int inS, decimal price, int max, int min)
        {
            ProductID = pID;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;


        }

        public Product(string n, int inS, decimal price, int max, int min)
        {
            ProductID = productCount++;
            Name = n;
            InStock = inS;
            Price = price;
            Max = max;
            Min = min;
        }

        public Product(int v1, string text, int v2, decimal v3, int v4, int v5)
        {
            this.v1 = v1;
            this.text = text;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public Product(int v)
        {
            this.v = v;
        }
    }
}
