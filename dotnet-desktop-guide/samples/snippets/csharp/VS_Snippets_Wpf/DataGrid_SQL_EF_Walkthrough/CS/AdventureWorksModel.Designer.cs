﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("AdventureWorksLT2008Model", "FK_Product_ProductCategory_ProductCategoryID", "ProductCategory", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(DataGridSQLExample.ProductCategory), "Product", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DataGridSQLExample.Product), true)]
[assembly: EdmRelationshipAttribute("AdventureWorksLT2008Model", "FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(DataGridSQLExample.ProductCategory), "ProductCategory1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DataGridSQLExample.ProductCategory), true)]

#endregion

namespace DataGridSQLExample
{
    #region Contexts

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdventureWorksLT2008Entities : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new AdventureWorksLT2008Entities object using the connection string found in the 'AdventureWorksLT2008Entities' section of the application configuration file.
        /// </summary>
        public AdventureWorksLT2008Entities() : base("name=AdventureWorksLT2008Entities", "AdventureWorksLT2008Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new AdventureWorksLT2008Entities object.
        /// </summary>
        public AdventureWorksLT2008Entities(string connectionString) : base(connectionString, "AdventureWorksLT2008Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new AdventureWorksLT2008Entities object.
        /// </summary>
        public AdventureWorksLT2008Entities(EntityConnection connection) : base(connection, "AdventureWorksLT2008Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products
        {
            get
            {
                if ((_Products == null))
                {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ProductCategory> ProductCategories
        {
            get
            {
                if ((_ProductCategories == null))
                {
                    _ProductCategories = base.CreateObjectSet<ProductCategory>("ProductCategories");
                }
                return _ProductCategories;
            }
        }
        private ObjectSet<ProductCategory> _ProductCategories;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ProductCategories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProductCategories(ProductCategory productCategory)
        {
            base.AddObject("ProductCategories", productCategory);
        }

        #endregion
    }


    #endregion

    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksLT2008Model", Name="Product")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Product : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productID">Initial value of the ProductID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="productNumber">Initial value of the ProductNumber property.</param>
        /// <param name="standardCost">Initial value of the StandardCost property.</param>
        /// <param name="listPrice">Initial value of the ListPrice property.</param>
        /// <param name="sellStartDate">Initial value of the SellStartDate property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Product CreateProduct(global::System.Int32 productID, global::System.String name, global::System.String productNumber, global::System.Decimal standardCost, global::System.Decimal listPrice, global::System.DateTime sellStartDate, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Product product = new Product();
            product.ProductID = productID;
            product.Name = name;
            product.ProductNumber = productNumber;
            product.StandardCost = standardCost;
            product.ListPrice = listPrice;
            product.SellStartDate = sellStartDate;
            product.rowguid = rowguid;
            product.ModifiedDate = modifiedDate;
            return product;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                if (_ProductID != value)
                {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ProductNumber
        {
            get
            {
                return _ProductNumber;
            }
            set
            {
                OnProductNumberChanging(value);
                ReportPropertyChanging("ProductNumber");
                _ProductNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductNumber");
                OnProductNumberChanged();
            }
        }
        private global::System.String _ProductNumber;
        partial void OnProductNumberChanging(global::System.String value);
        partial void OnProductNumberChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Color
        {
            get
            {
                return _Color;
            }
            set
            {
                OnColorChanging(value);
                ReportPropertyChanging("Color");
                _Color = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Color");
                OnColorChanged();
            }
        }
        private global::System.String _Color;
        partial void OnColorChanging(global::System.String value);
        partial void OnColorChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal StandardCost
        {
            get
            {
                return _StandardCost;
            }
            set
            {
                OnStandardCostChanging(value);
                ReportPropertyChanging("StandardCost");
                _StandardCost = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StandardCost");
                OnStandardCostChanged();
            }
        }
        private global::System.Decimal _StandardCost;
        partial void OnStandardCostChanging(global::System.Decimal value);
        partial void OnStandardCostChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal ListPrice
        {
            get
            {
                return _ListPrice;
            }
            set
            {
                OnListPriceChanging(value);
                ReportPropertyChanging("ListPrice");
                _ListPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ListPrice");
                OnListPriceChanged();
            }
        }
        private global::System.Decimal _ListPrice;
        partial void OnListPriceChanging(global::System.Decimal value);
        partial void OnListPriceChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Size
        {
            get
            {
                return _Size;
            }
            set
            {
                OnSizeChanging(value);
                ReportPropertyChanging("Size");
                _Size = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Size");
                OnSizeChanged();
            }
        }
        private global::System.String _Size;
        partial void OnSizeChanging(global::System.String value);
        partial void OnSizeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                OnWeightChanging(value);
                ReportPropertyChanging("Weight");
                _Weight = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Weight");
                OnWeightChanged();
            }
        }
        private Nullable<global::System.Decimal> _Weight;
        partial void OnWeightChanging(Nullable<global::System.Decimal> value);
        partial void OnWeightChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ProductCategoryID
        {
            get
            {
                return _ProductCategoryID;
            }
            set
            {
                OnProductCategoryIDChanging(value);
                ReportPropertyChanging("ProductCategoryID");
                _ProductCategoryID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProductCategoryID");
                OnProductCategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ProductCategoryID;
        partial void OnProductCategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnProductCategoryIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ProductModelID
        {
            get
            {
                return _ProductModelID;
            }
            set
            {
                OnProductModelIDChanging(value);
                ReportPropertyChanging("ProductModelID");
                _ProductModelID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProductModelID");
                OnProductModelIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ProductModelID;
        partial void OnProductModelIDChanging(Nullable<global::System.Int32> value);
        partial void OnProductModelIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime SellStartDate
        {
            get
            {
                return _SellStartDate;
            }
            set
            {
                OnSellStartDateChanging(value);
                ReportPropertyChanging("SellStartDate");
                _SellStartDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SellStartDate");
                OnSellStartDateChanged();
            }
        }
        private global::System.DateTime _SellStartDate;
        partial void OnSellStartDateChanging(global::System.DateTime value);
        partial void OnSellStartDateChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> SellEndDate
        {
            get
            {
                return _SellEndDate;
            }
            set
            {
                OnSellEndDateChanging(value);
                ReportPropertyChanging("SellEndDate");
                _SellEndDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SellEndDate");
                OnSellEndDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _SellEndDate;
        partial void OnSellEndDateChanging(Nullable<global::System.DateTime> value);
        partial void OnSellEndDateChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DiscontinuedDate
        {
            get
            {
                return _DiscontinuedDate;
            }
            set
            {
                OnDiscontinuedDateChanging(value);
                ReportPropertyChanging("DiscontinuedDate");
                _DiscontinuedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DiscontinuedDate");
                OnDiscontinuedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _DiscontinuedDate;
        partial void OnDiscontinuedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnDiscontinuedDateChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] ThumbNailPhoto
        {
            get
            {
                return StructuralObject.GetValidValue(_ThumbNailPhoto);
            }
            set
            {
                OnThumbNailPhotoChanging(value);
                ReportPropertyChanging("ThumbNailPhoto");
                _ThumbNailPhoto = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ThumbNailPhoto");
                OnThumbNailPhotoChanged();
            }
        }
        private global::System.Byte[] _ThumbNailPhoto;
        partial void OnThumbNailPhotoChanging(global::System.Byte[] value);
        partial void OnThumbNailPhotoChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ThumbnailPhotoFileName
        {
            get
            {
                return _ThumbnailPhotoFileName;
            }
            set
            {
                OnThumbnailPhotoFileNameChanging(value);
                ReportPropertyChanging("ThumbnailPhotoFileName");
                _ThumbnailPhotoFileName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ThumbnailPhotoFileName");
                OnThumbnailPhotoFileNameChanged();
            }
        }
        private global::System.String _ThumbnailPhotoFileName;
        partial void OnThumbnailPhotoFileNameChanging(global::System.String value);
        partial void OnThumbnailPhotoFileNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_Product_ProductCategory_ProductCategoryID", "ProductCategory")]
        public ProductCategory ProductCategory
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ProductCategory> ProductCategoryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "ProductCategory", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorksLT2008Model", Name="ProductCategory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ProductCategory : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new ProductCategory object.
        /// </summary>
        /// <param name="productCategoryID">Initial value of the ProductCategoryID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static ProductCategory CreateProductCategory(global::System.Int32 productCategoryID, global::System.String name, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            ProductCategory productCategory = new ProductCategory();
            productCategory.ProductCategoryID = productCategoryID;
            productCategory.Name = name;
            productCategory.rowguid = rowguid;
            productCategory.ModifiedDate = modifiedDate;
            return productCategory;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductCategoryID
        {
            get
            {
                return _ProductCategoryID;
            }
            set
            {
                if (_ProductCategoryID != value)
                {
                    OnProductCategoryIDChanging(value);
                    ReportPropertyChanging("ProductCategoryID");
                    _ProductCategoryID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductCategoryID");
                    OnProductCategoryIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductCategoryID;
        partial void OnProductCategoryIDChanging(global::System.Int32 value);
        partial void OnProductCategoryIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ParentProductCategoryID
        {
            get
            {
                return _ParentProductCategoryID;
            }
            set
            {
                OnParentProductCategoryIDChanging(value);
                ReportPropertyChanging("ParentProductCategoryID");
                _ParentProductCategoryID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ParentProductCategoryID");
                OnParentProductCategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _ParentProductCategoryID;
        partial void OnParentProductCategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnParentProductCategoryIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_Product_ProductCategory_ProductCategoryID", "Product")]
        public EntityCollection<Product> Products
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Product>("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "Product");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Product>("AdventureWorksLT2008Model.FK_Product_ProductCategory_ProductCategoryID", "Product", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory1")]
        public EntityCollection<ProductCategory> ProductCategory1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ProductCategory>("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ProductCategory>("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory1", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AdventureWorksLT2008Model", "FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory")]
        public ProductCategory ProductCategory2
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ProductCategory> ProductCategory2Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ProductCategory>("AdventureWorksLT2008Model.FK_ProductCategory_ProductCategory_ParentProductCategoryID_ProductCategoryID", "ProductCategory", value);
                }
            }
        }

        #endregion
    }

    #endregion

}