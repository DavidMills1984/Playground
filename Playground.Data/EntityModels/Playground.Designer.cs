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

[assembly: EdmRelationshipAttribute("PlaygroundModel", "FK_MenuSubItem_MenuItem1", "MenuItem", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Playground.Data.EntityModels.MenuItem), "MenuSubItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Playground.Data.EntityModels.MenuSubItem), true)]

#endregion

namespace Playground.Data.EntityModels
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PlaygroundEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PlaygroundEntities object using the connection string found in the 'PlaygroundEntities' section of the application configuration file.
        /// </summary>
        public PlaygroundEntities() : base("name=PlaygroundEntities", "PlaygroundEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PlaygroundEntities object.
        /// </summary>
        public PlaygroundEntities(string connectionString) : base(connectionString, "PlaygroundEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PlaygroundEntities object.
        /// </summary>
        public PlaygroundEntities(EntityConnection connection) : base(connection, "PlaygroundEntities")
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
        public ObjectSet<MenuItem> MenuItems
        {
            get
            {
                if ((_MenuItems == null))
                {
                    _MenuItems = base.CreateObjectSet<MenuItem>("MenuItems");
                }
                return _MenuItems;
            }
        }
        private ObjectSet<MenuItem> _MenuItems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MenuSubItem> MenuSubItems
        {
            get
            {
                if ((_MenuSubItems == null))
                {
                    _MenuSubItems = base.CreateObjectSet<MenuSubItem>("MenuSubItems");
                }
                return _MenuSubItems;
            }
        }
        private ObjectSet<MenuSubItem> _MenuSubItems;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MenuItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMenuItems(MenuItem menuItem)
        {
            base.AddObject("MenuItems", menuItem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MenuSubItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMenuSubItems(MenuSubItem menuSubItem)
        {
            base.AddObject("MenuSubItems", menuSubItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlaygroundModel", Name="MenuItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MenuItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MenuItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static MenuItem CreateMenuItem(global::System.Int32 id, global::System.String name)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.Id = id;
            menuItem.Name = name;
            return menuItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Link
        {
            get
            {
                return _Link;
            }
            set
            {
                OnLinkChanging(value);
                ReportPropertyChanging("Link");
                _Link = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Link");
                OnLinkChanged();
            }
        }
        private global::System.String _Link;
        partial void OnLinkChanging(global::System.String value);
        partial void OnLinkChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlaygroundModel", "FK_MenuSubItem_MenuItem1", "MenuSubItem")]
        public EntityCollection<MenuSubItem> MenuSubItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MenuSubItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuSubItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MenuSubItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuSubItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlaygroundModel", Name="MenuSubItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MenuSubItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MenuSubItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="parentId">Initial value of the ParentId property.</param>
        public static MenuSubItem CreateMenuSubItem(global::System.Int32 id, global::System.String name, global::System.Int32 parentId)
        {
            MenuSubItem menuSubItem = new MenuSubItem();
            menuSubItem.Id = id;
            menuSubItem.Name = name;
            menuSubItem.ParentId = parentId;
            return menuSubItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Link
        {
            get
            {
                return _Link;
            }
            set
            {
                OnLinkChanging(value);
                ReportPropertyChanging("Link");
                _Link = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Link");
                OnLinkChanged();
            }
        }
        private global::System.String _Link;
        partial void OnLinkChanging(global::System.String value);
        partial void OnLinkChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ParentId
        {
            get
            {
                return _ParentId;
            }
            set
            {
                OnParentIdChanging(value);
                ReportPropertyChanging("ParentId");
                _ParentId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ParentId");
                OnParentIdChanged();
            }
        }
        private global::System.Int32 _ParentId;
        partial void OnParentIdChanging(global::System.Int32 value);
        partial void OnParentIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlaygroundModel", "FK_MenuSubItem_MenuItem1", "MenuItem")]
        public MenuItem MenuItem_1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<MenuItem> MenuItem_1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<MenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<MenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}