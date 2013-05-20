﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarehouseApp.BookStoreService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Stock", Namespace="http://schemas.datacontract.org/2004/07/ServiceDataTypes")]
    [System.SerializableAttribute()]
    public partial class Stock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarehouseApp.BookStoreService.Book BookField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CopiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarehouseApp.BookStoreService.Book Book {
            get {
                return this.BookField;
            }
            set {
                if ((object.ReferenceEquals(this.BookField, value) != true)) {
                    this.BookField = value;
                    this.RaisePropertyChanged("Book");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Copies {
            get {
                return this.CopiesField;
            }
            set {
                if ((this.CopiesField.Equals(value) != true)) {
                    this.CopiesField = value;
                    this.RaisePropertyChanged("Copies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StockID {
            get {
                return this.StockIDField;
            }
            set {
                if ((this.StockIDField.Equals(value) != true)) {
                    this.StockIDField = value;
                    this.RaisePropertyChanged("StockID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/ServiceDataTypes")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BookID {
            get {
                return this.BookIDField;
            }
            set {
                if ((this.BookIDField.Equals(value) != true)) {
                    this.BookIDField = value;
                    this.RaisePropertyChanged("BookID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/ServiceDataTypes")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarehouseApp.BookStoreService.Book BookField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarehouseApp.BookStoreService.Client ClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ExpDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid OrderIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarehouseApp.BookStoreService.OrderState StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarehouseApp.BookStoreService.Book Book {
            get {
                return this.BookField;
            }
            set {
                if ((object.ReferenceEquals(this.BookField, value) != true)) {
                    this.BookField = value;
                    this.RaisePropertyChanged("Book");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarehouseApp.BookStoreService.Client Client {
            get {
                return this.ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientField, value) != true)) {
                    this.ClientField = value;
                    this.RaisePropertyChanged("Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ExpDate {
            get {
                return this.ExpDateField;
            }
            set {
                if ((this.ExpDateField.Equals(value) != true)) {
                    this.ExpDateField = value;
                    this.RaisePropertyChanged("ExpDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid OrderID {
            get {
                return this.OrderIDField;
            }
            set {
                if ((this.OrderIDField.Equals(value) != true)) {
                    this.OrderIDField = value;
                    this.RaisePropertyChanged("OrderID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarehouseApp.BookStoreService.OrderState State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Client", Namespace="http://schemas.datacontract.org/2004/07/ServiceDataTypes")]
    [System.SerializableAttribute()]
    public partial class Client : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderState", Namespace="http://schemas.datacontract.org/2004/07/ServiceDataTypes")]
    public enum OrderState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WaitingExpedition = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dispatched = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FutureDispatch = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Delivery", Namespace="http://schemas.datacontract.org/2004/07/ServiceDataTypes")]
    [System.SerializableAttribute()]
    public partial class Delivery : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AcceptedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DeliveryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarehouseApp.BookStoreService.Order OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Accepted {
            get {
                return this.AcceptedField;
            }
            set {
                if ((this.AcceptedField.Equals(value) != true)) {
                    this.AcceptedField = value;
                    this.RaisePropertyChanged("Accepted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DeliveryID {
            get {
                return this.DeliveryIDField;
            }
            set {
                if ((this.DeliveryIDField.Equals(value) != true)) {
                    this.DeliveryIDField = value;
                    this.RaisePropertyChanged("DeliveryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarehouseApp.BookStoreService.Order Order {
            get {
                return this.OrderField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderField, value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookStoreService.IBookStoreService")]
    public interface IBookStoreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetStock", ReplyAction="http://tempuri.org/IBookStoreService/GetStockResponse")]
        WarehouseApp.BookStoreService.Stock[] GetStock();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAllBooks", ReplyAction="http://tempuri.org/IBookStoreService/GetAllBooksResponse")]
        WarehouseApp.BookStoreService.Book[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAllOrders", ReplyAction="http://tempuri.org/IBookStoreService/GetAllOrdersResponse")]
        WarehouseApp.BookStoreService.Order[] GetAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/UpdateOrderState", ReplyAction="http://tempuri.org/IBookStoreService/UpdateOrderStateResponse")]
        bool UpdateOrderState(WarehouseApp.BookStoreService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/SendDelivery", ReplyAction="http://tempuri.org/IBookStoreService/SendDeliveryResponse")]
        bool SendDelivery(WarehouseApp.BookStoreService.Delivery delivery);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/CreateOrder", ReplyAction="http://tempuri.org/IBookStoreService/CreateOrderResponse")]
        WarehouseApp.BookStoreService.Order CreateOrder(WarehouseApp.BookStoreService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAllOrdersByEmail", ReplyAction="http://tempuri.org/IBookStoreService/GetAllOrdersByEmailResponse")]
        WarehouseApp.BookStoreService.Order[] GetAllOrdersByEmail(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookStoreServiceChannel : WarehouseApp.BookStoreService.IBookStoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookStoreServiceClient : System.ServiceModel.ClientBase<WarehouseApp.BookStoreService.IBookStoreService>, WarehouseApp.BookStoreService.IBookStoreService {
        
        public BookStoreServiceClient() {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookStoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WarehouseApp.BookStoreService.Stock[] GetStock() {
            return base.Channel.GetStock();
        }
        
        public WarehouseApp.BookStoreService.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public WarehouseApp.BookStoreService.Order[] GetAllOrders() {
            return base.Channel.GetAllOrders();
        }
        
        public bool UpdateOrderState(WarehouseApp.BookStoreService.Order order) {
            return base.Channel.UpdateOrderState(order);
        }
        
        public bool SendDelivery(WarehouseApp.BookStoreService.Delivery delivery) {
            return base.Channel.SendDelivery(delivery);
        }
        
        public WarehouseApp.BookStoreService.Order CreateOrder(WarehouseApp.BookStoreService.Order order) {
            return base.Channel.CreateOrder(order);
        }
        
        public WarehouseApp.BookStoreService.Order[] GetAllOrdersByEmail(string email) {
            return base.Channel.GetAllOrdersByEmail(email);
        }
    }
}
