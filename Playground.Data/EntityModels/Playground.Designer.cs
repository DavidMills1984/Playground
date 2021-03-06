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

[assembly: EdmRelationshipAttribute("PlaygroundModel", "FK_MenuSubItem_MenuItem1", "MenuItem", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Playground.Data.EntityModels.EFMenuItem), "MenuSubItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Playground.Data.EntityModels.EFMenuSubItem), true)]
[assembly: EdmRelationshipAttribute("PlaygroundModel", "FK_MenuItem_MenuGroups", "MenuGroup", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Playground.Data.EntityModels.EFMenuGroup), "MenuItem", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Playground.Data.EntityModels.EFMenuItem), true)]

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
        public ObjectSet<EFMenuItem> EFMenuItems
        {
            get
            {
                if ((_EFMenuItems == null))
                {
                    _EFMenuItems = base.CreateObjectSet<EFMenuItem>("EFMenuItems");
                }
                return _EFMenuItems;
            }
        }
        private ObjectSet<EFMenuItem> _EFMenuItems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EFMenuSubItem> EFMenuSubItems
        {
            get
            {
                if ((_EFMenuSubItems == null))
                {
                    _EFMenuSubItems = base.CreateObjectSet<EFMenuSubItem>("EFMenuSubItems");
                }
                return _EFMenuSubItems;
            }
        }
        private ObjectSet<EFMenuSubItem> _EFMenuSubItems;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EFMenuGroup> EFMenuGroups
        {
            get
            {
                if ((_EFMenuGroups == null))
                {
                    _EFMenuGroups = base.CreateObjectSet<EFMenuGroup>("EFMenuGroups");
                }
                return _EFMenuGroups;
            }
        }
        private ObjectSet<EFMenuGroup> _EFMenuGroups;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EFMenuItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEFMenuItems(EFMenuItem eFMenuItem)
        {
            base.AddObject("EFMenuItems", eFMenuItem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EFMenuSubItems EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEFMenuSubItems(EFMenuSubItem eFMenuSubItem)
        {
            base.AddObject("EFMenuSubItems", eFMenuSubItem);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EFMenuGroups EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEFMenuGroups(EFMenuGroup eFMenuGroup)
        {
            base.AddObject("EFMenuGroups", eFMenuGroup);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlaygroundModel", Name="EFMenuGroup")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EFMenuGroup : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EFMenuGroup object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="groupName">Initial value of the GroupName property.</param>
        public static EFMenuGroup CreateEFMenuGroup(global::System.Int32 id, global::System.String groupName)
        {
            EFMenuGroup eFMenuGroup = new EFMenuGroup();
            eFMenuGroup.Id = id;
            eFMenuGroup.GroupName = groupName;
            return eFMenuGroup;
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
        public global::System.String GroupName
        {
            get
            {
                return _GroupName;
            }
            set
            {
                OnGroupNameChanging(value);
                ReportPropertyChanging("GroupName");
                _GroupName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("GroupName");
                OnGroupNameChanged();
            }
        }
        private global::System.String _GroupName;
        partial void OnGroupNameChanging(global::System.String value);
        partial void OnGroupNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ControllerName
        {
            get
            {
                return _ControllerName;
            }
            set
            {
                OnControllerNameChanging(value);
                ReportPropertyChanging("ControllerName");
                _ControllerName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ControllerName");
                OnControllerNameChanged();
            }
        }
        private global::System.String _ControllerName;
        partial void OnControllerNameChanging(global::System.String value);
        partial void OnControllerNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlaygroundModel", "FK_MenuItem_MenuGroups", "MenuItem")]
        public EntityCollection<EFMenuItem> MenuItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EFMenuItem>("PlaygroundModel.FK_MenuItem_MenuGroups", "MenuItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EFMenuItem>("PlaygroundModel.FK_MenuItem_MenuGroups", "MenuItem", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlaygroundModel", Name="EFMenuItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EFMenuItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EFMenuItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static EFMenuItem CreateEFMenuItem(global::System.Int32 id, global::System.String name)
        {
            EFMenuItem eFMenuItem = new EFMenuItem();
            eFMenuItem.Id = id;
            eFMenuItem.Name = name;
            return eFMenuItem;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> MenuGroup
        {
            get
            {
                return _MenuGroup;
            }
            set
            {
                OnMenuGroupChanging(value);
                ReportPropertyChanging("MenuGroup");
                _MenuGroup = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MenuGroup");
                OnMenuGroupChanged();
            }
        }
        private Nullable<global::System.Int32> _MenuGroup;
        partial void OnMenuGroupChanging(Nullable<global::System.Int32> value);
        partial void OnMenuGroupChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlaygroundModel", "FK_MenuSubItem_MenuItem1", "MenuSubItem")]
        public EntityCollection<EFMenuSubItem> MenuSubItems
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EFMenuSubItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuSubItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EFMenuSubItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuSubItem", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("PlaygroundModel", "FK_MenuItem_MenuGroups", "MenuGroup")]
        public EFMenuGroup ItemMenuGroup
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EFMenuGroup>("PlaygroundModel.FK_MenuItem_MenuGroups", "MenuGroup").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EFMenuGroup>("PlaygroundModel.FK_MenuItem_MenuGroups", "MenuGroup").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EFMenuGroup> ItemMenuGroupReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EFMenuGroup>("PlaygroundModel.FK_MenuItem_MenuGroups", "MenuGroup");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EFMenuGroup>("PlaygroundModel.FK_MenuItem_MenuGroups", "MenuGroup", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PlaygroundModel", Name="EFMenuSubItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EFMenuSubItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EFMenuSubItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="parentId">Initial value of the ParentId property.</param>
        public static EFMenuSubItem CreateEFMenuSubItem(global::System.Int32 id, global::System.String name, global::System.Int32 parentId)
        {
            EFMenuSubItem eFMenuSubItem = new EFMenuSubItem();
            eFMenuSubItem.Id = id;
            eFMenuSubItem.Name = name;
            eFMenuSubItem.ParentId = parentId;
            return eFMenuSubItem;
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
        public EFMenuItem MenuItem
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EFMenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EFMenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EFMenuItem> MenuItemReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EFMenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EFMenuItem>("PlaygroundModel.FK_MenuSubItem_MenuItem1", "MenuItem", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
