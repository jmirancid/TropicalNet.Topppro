//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Xml.Serialization;


namespace Topppro.Entities
{
    [Serializable]
    public partial class Assn_CategorySerieProduct
    {
        #region Primitive Properties
    
        public virtual int AssnCategorySerieProductId
        {
            get;
            set;
        }
    
        public virtual int AssnCategorySerieId
        {
            get { return _assnCategorySerieId; }
            set
            {
                if (_assnCategorySerieId != value)
                {
                    if (Assn_CategorySerie != null && Assn_CategorySerie.AssnCategorySerieId != value)
                    {
                        Assn_CategorySerie = null;
                    }
                    _assnCategorySerieId = value;
                }
            }
        }
        private int _assnCategorySerieId;
    
        public virtual int ProductId
        {
            get { return _productId; }
            set
            {
                if (_productId != value)
                {
                    if (Product != null && Product.ProductId != value)
                    {
                        Product = null;
                    }
                    _productId = value;
                }
            }
        }
        private int _productId;
    
        public virtual Nullable<int> Priority
        {
            get;
            set;
        }
    
        public virtual bool Enabled
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Product Product
        {
            get { return _product; }
            set
            {
                if (!ReferenceEquals(_product, value))
                {
                    var previousValue = _product;
                    _product = value;
                    FixupProduct(previousValue);
                }
            }
        }
        private Product _product;
    
        public virtual Assn_CategorySerie Assn_CategorySerie
        {
            get { return _assn_CategorySerie; }
            set
            {
                if (!ReferenceEquals(_assn_CategorySerie, value))
                {
                    var previousValue = _assn_CategorySerie;
                    _assn_CategorySerie = value;
                    FixupAssn_CategorySerie(previousValue);
                }
            }
        }
        private Assn_CategorySerie _assn_CategorySerie;

        #endregion
        #region Association Fixup
    
        private void FixupProduct(Product previousValue)
        {
            if (previousValue != null && previousValue.Assn_CategorySerieProduct.Contains(this))
            {
                previousValue.Assn_CategorySerieProduct.Remove(this);
            }
    
            if (Product != null)
            {
                if (!Product.Assn_CategorySerieProduct.Contains(this))
                {
                    Product.Assn_CategorySerieProduct.Add(this);
                }
                if (ProductId != Product.ProductId)
                {
                    ProductId = Product.ProductId;
                }
            }
        }
    
        private void FixupAssn_CategorySerie(Assn_CategorySerie previousValue)
        {
            if (previousValue != null && previousValue.Assn_CategorySerieProduct.Contains(this))
            {
                previousValue.Assn_CategorySerieProduct.Remove(this);
            }
    
            if (Assn_CategorySerie != null)
            {
                if (!Assn_CategorySerie.Assn_CategorySerieProduct.Contains(this))
                {
                    Assn_CategorySerie.Assn_CategorySerieProduct.Add(this);
                }
                if (AssnCategorySerieId != Assn_CategorySerie.AssnCategorySerieId)
                {
                    AssnCategorySerieId = Assn_CategorySerie.AssnCategorySerieId;
                }
            }
        }

        #endregion
    }
}
