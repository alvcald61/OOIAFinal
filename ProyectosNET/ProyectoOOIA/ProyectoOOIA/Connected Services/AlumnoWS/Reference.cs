﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.AlumnoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="AlumnoWS.AlumnoWS")]
    public interface AlumnoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/insertarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/insertarAlumnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.AlumnoWS.insertarAlumnoResponse insertarAlumno(ProyectoOOIA.AlumnoWS.insertarAlumnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/insertarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/insertarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.insertarAlumnoResponse> insertarAlumnoAsync(ProyectoOOIA.AlumnoWS.insertarAlumnoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/modificarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/modificarAlumnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.AlumnoWS.modificarAlumnoResponse modificarAlumno(ProyectoOOIA.AlumnoWS.modificarAlumnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/modificarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/modificarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.modificarAlumnoResponse> modificarAlumnoAsync(ProyectoOOIA.AlumnoWS.modificarAlumnoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/listarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/listarAlumnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.AlumnoWS.listarAlumnoResponse listarAlumno(ProyectoOOIA.AlumnoWS.listarAlumnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/listarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/listarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.listarAlumnoResponse> listarAlumnoAsync(ProyectoOOIA.AlumnoWS.listarAlumnoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/eliminarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/eliminarAlumnoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.AlumnoWS.eliminarAlumnoResponse eliminarAlumno(ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/AlumnoWS/eliminarAlumnoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/AlumnoWS/eliminarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.eliminarAlumnoResponse> eliminarAlumnoAsync(ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class alumno : miembroPUCP {
        
        private bool activoField;
        
        private string codigoField;
        
        private double craestField;
        
        private double creditos_aprobadosField;
        
        private especialidad especialidadField;
        
        private int id_alumnoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double craest {
            get {
                return this.craestField;
            }
            set {
                this.craestField = value;
                this.RaisePropertyChanged("craest");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public double creditos_aprobados {
            get {
                return this.creditos_aprobadosField;
            }
            set {
                this.creditos_aprobadosField = value;
                this.RaisePropertyChanged("creditos_aprobados");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public especialidad especialidad {
            get {
                return this.especialidadField;
            }
            set {
                this.especialidadField = value;
                this.RaisePropertyChanged("especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int id_alumno {
            get {
                return this.id_alumnoField;
            }
            set {
                this.id_alumnoField = value;
                this.RaisePropertyChanged("id_alumno");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class especialidad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private int id_especialidadField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool activo {
            get {
                return this.activoField;
            }
            set {
                this.activoField = value;
                this.RaisePropertyChanged("activo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id_especialidad {
            get {
                return this.id_especialidadField;
            }
            set {
                this.id_especialidadField = value;
                this.RaisePropertyChanged("id_especialidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(miembroPUCP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(alumno))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public abstract partial class persona : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string correoField;
        
        private string direccionField;
        
        private string dniField;
        
        private System.DateTime fecha_nacimientoField;
        
        private bool fecha_nacimientoFieldSpecified;
        
        private int id_personaField;
        
        private string nombreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
                this.RaisePropertyChanged("correo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string dni {
            get {
                return this.dniField;
            }
            set {
                this.dniField = value;
                this.RaisePropertyChanged("dni");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime fecha_nacimiento {
            get {
                return this.fecha_nacimientoField;
            }
            set {
                this.fecha_nacimientoField = value;
                this.RaisePropertyChanged("fecha_nacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fecha_nacimientoSpecified {
            get {
                return this.fecha_nacimientoFieldSpecified;
            }
            set {
                this.fecha_nacimientoFieldSpecified = value;
                this.RaisePropertyChanged("fecha_nacimientoSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int id_persona {
            get {
                return this.id_personaField;
            }
            set {
                this.id_personaField = value;
                this.RaisePropertyChanged("id_persona");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(alumno))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class miembroPUCP : persona {
        
        private System.DateTime fecha_inclusionField;
        
        private bool fecha_inclusionFieldSpecified;
        
        private int id_miembro_pucpField;
        
        private byte[] imagenDePerfilField;
        
        private string passwordField;
        
        private string usuarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public System.DateTime fecha_inclusion {
            get {
                return this.fecha_inclusionField;
            }
            set {
                this.fecha_inclusionField = value;
                this.RaisePropertyChanged("fecha_inclusion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fecha_inclusionSpecified {
            get {
                return this.fecha_inclusionFieldSpecified;
            }
            set {
                this.fecha_inclusionFieldSpecified = value;
                this.RaisePropertyChanged("fecha_inclusionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int id_miembro_pucp {
            get {
                return this.id_miembro_pucpField;
            }
            set {
                this.id_miembro_pucpField = value;
                this.RaisePropertyChanged("id_miembro_pucp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=2)]
        public byte[] imagenDePerfil {
            get {
                return this.imagenDePerfilField;
            }
            set {
                this.imagenDePerfilField = value;
                this.RaisePropertyChanged("imagenDePerfil");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
                this.RaisePropertyChanged("usuario");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarAlumno", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarAlumnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.AlumnoWS.alumno alumno;
        
        public insertarAlumnoRequest() {
        }
        
        public insertarAlumnoRequest(ProyectoOOIA.AlumnoWS.alumno alumno) {
            this.alumno = alumno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarAlumnoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarAlumnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarAlumnoResponse() {
        }
        
        public insertarAlumnoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarAlumno", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarAlumnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.AlumnoWS.alumno alumno;
        
        public modificarAlumnoRequest() {
        }
        
        public modificarAlumnoRequest(ProyectoOOIA.AlumnoWS.alumno alumno) {
            this.alumno = alumno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarAlumnoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarAlumnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarAlumnoResponse() {
        }
        
        public modificarAlumnoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarAlumno", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarAlumnoRequest {
        
        public listarAlumnoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarAlumnoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarAlumnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.AlumnoWS.alumno[] @return;
        
        public listarAlumnoResponse() {
        }
        
        public listarAlumnoResponse(ProyectoOOIA.AlumnoWS.alumno[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarAlumno", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarAlumnoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_alumno;
        
        public eliminarAlumnoRequest() {
        }
        
        public eliminarAlumnoRequest(int id_alumno) {
            this.id_alumno = id_alumno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarAlumnoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarAlumnoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarAlumnoResponse() {
        }
        
        public eliminarAlumnoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AlumnoWSChannel : ProyectoOOIA.AlumnoWS.AlumnoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.AlumnoWS.AlumnoWS>, ProyectoOOIA.AlumnoWS.AlumnoWS {
        
        public AlumnoWSClient() {
        }
        
        public AlumnoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.AlumnoWS.insertarAlumnoResponse ProyectoOOIA.AlumnoWS.AlumnoWS.insertarAlumno(ProyectoOOIA.AlumnoWS.insertarAlumnoRequest request) {
            return base.Channel.insertarAlumno(request);
        }
        
        public int insertarAlumno(ProyectoOOIA.AlumnoWS.alumno alumno) {
            ProyectoOOIA.AlumnoWS.insertarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.insertarAlumnoRequest();
            inValue.alumno = alumno;
            ProyectoOOIA.AlumnoWS.insertarAlumnoResponse retVal = ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).insertarAlumno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.insertarAlumnoResponse> ProyectoOOIA.AlumnoWS.AlumnoWS.insertarAlumnoAsync(ProyectoOOIA.AlumnoWS.insertarAlumnoRequest request) {
            return base.Channel.insertarAlumnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.insertarAlumnoResponse> insertarAlumnoAsync(ProyectoOOIA.AlumnoWS.alumno alumno) {
            ProyectoOOIA.AlumnoWS.insertarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.insertarAlumnoRequest();
            inValue.alumno = alumno;
            return ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).insertarAlumnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.AlumnoWS.modificarAlumnoResponse ProyectoOOIA.AlumnoWS.AlumnoWS.modificarAlumno(ProyectoOOIA.AlumnoWS.modificarAlumnoRequest request) {
            return base.Channel.modificarAlumno(request);
        }
        
        public int modificarAlumno(ProyectoOOIA.AlumnoWS.alumno alumno) {
            ProyectoOOIA.AlumnoWS.modificarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.modificarAlumnoRequest();
            inValue.alumno = alumno;
            ProyectoOOIA.AlumnoWS.modificarAlumnoResponse retVal = ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).modificarAlumno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.modificarAlumnoResponse> ProyectoOOIA.AlumnoWS.AlumnoWS.modificarAlumnoAsync(ProyectoOOIA.AlumnoWS.modificarAlumnoRequest request) {
            return base.Channel.modificarAlumnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.modificarAlumnoResponse> modificarAlumnoAsync(ProyectoOOIA.AlumnoWS.alumno alumno) {
            ProyectoOOIA.AlumnoWS.modificarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.modificarAlumnoRequest();
            inValue.alumno = alumno;
            return ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).modificarAlumnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.AlumnoWS.listarAlumnoResponse ProyectoOOIA.AlumnoWS.AlumnoWS.listarAlumno(ProyectoOOIA.AlumnoWS.listarAlumnoRequest request) {
            return base.Channel.listarAlumno(request);
        }
        
        public ProyectoOOIA.AlumnoWS.alumno[] listarAlumno() {
            ProyectoOOIA.AlumnoWS.listarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.listarAlumnoRequest();
            ProyectoOOIA.AlumnoWS.listarAlumnoResponse retVal = ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).listarAlumno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.listarAlumnoResponse> ProyectoOOIA.AlumnoWS.AlumnoWS.listarAlumnoAsync(ProyectoOOIA.AlumnoWS.listarAlumnoRequest request) {
            return base.Channel.listarAlumnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.listarAlumnoResponse> listarAlumnoAsync() {
            ProyectoOOIA.AlumnoWS.listarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.listarAlumnoRequest();
            return ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).listarAlumnoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.AlumnoWS.eliminarAlumnoResponse ProyectoOOIA.AlumnoWS.AlumnoWS.eliminarAlumno(ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest request) {
            return base.Channel.eliminarAlumno(request);
        }
        
        public int eliminarAlumno(int id_alumno) {
            ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest();
            inValue.id_alumno = id_alumno;
            ProyectoOOIA.AlumnoWS.eliminarAlumnoResponse retVal = ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).eliminarAlumno(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.eliminarAlumnoResponse> ProyectoOOIA.AlumnoWS.AlumnoWS.eliminarAlumnoAsync(ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest request) {
            return base.Channel.eliminarAlumnoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.AlumnoWS.eliminarAlumnoResponse> eliminarAlumnoAsync(int id_alumno) {
            ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest inValue = new ProyectoOOIA.AlumnoWS.eliminarAlumnoRequest();
            inValue.id_alumno = id_alumno;
            return ((ProyectoOOIA.AlumnoWS.AlumnoWS)(this)).eliminarAlumnoAsync(inValue);
        }
    }
}
