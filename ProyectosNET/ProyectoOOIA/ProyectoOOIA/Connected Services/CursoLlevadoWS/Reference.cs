﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoOOIA.CursoLlevadoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", ConfigurationName="CursoLlevadoWS.CursoLlevadoWS")]
    public interface CursoLlevadoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/listarCursoLlevadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/listarCursoLlevadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoResponse listarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/listarCursoLlevadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/listarCursoLlevadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoResponse> listarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/insertarCursoLlevadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/insertarCursoLlevadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoResponse insertarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/insertarCursoLlevadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/insertarCursoLlevadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoResponse> insertarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/modificarCursoLlevadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/modificarCursoLlevadoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(persona))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoResponse modificarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/modificarCursoLlevadoRequest", ReplyAction="http://services.OOIA.pucp.edu.pe/CursoLlevadoWS/modificarCursoLlevadoResponse")]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoResponse> modificarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class cursoLlevado : object, System.ComponentModel.INotifyPropertyChanged {
        
        private alumno alumnoField;
        
        private string cicloField;
        
        private curso cursoField;
        
        private string formulaCalificacionField;
        
        private int id_curso_llevadoField;
        
        private double notaFinalField;
        
        private bool retiradoField;
        
        private int vezField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public alumno alumno {
            get {
                return this.alumnoField;
            }
            set {
                this.alumnoField = value;
                this.RaisePropertyChanged("alumno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string ciclo {
            get {
                return this.cicloField;
            }
            set {
                this.cicloField = value;
                this.RaisePropertyChanged("ciclo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public curso curso {
            get {
                return this.cursoField;
            }
            set {
                this.cursoField = value;
                this.RaisePropertyChanged("curso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string formulaCalificacion {
            get {
                return this.formulaCalificacionField;
            }
            set {
                this.formulaCalificacionField = value;
                this.RaisePropertyChanged("formulaCalificacion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int id_curso_llevado {
            get {
                return this.id_curso_llevadoField;
            }
            set {
                this.id_curso_llevadoField = value;
                this.RaisePropertyChanged("id_curso_llevado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public double notaFinal {
            get {
                return this.notaFinalField;
            }
            set {
                this.notaFinalField = value;
                this.RaisePropertyChanged("notaFinal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool retirado {
            get {
                return this.retiradoField;
            }
            set {
                this.retiradoField = value;
                this.RaisePropertyChanged("retirado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int vez {
            get {
                return this.vezField;
            }
            set {
                this.vezField = value;
                this.RaisePropertyChanged("vez");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.OOIA.pucp.edu.pe/")]
    public partial class curso : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool activoField;
        
        private string codigoCursoField;
        
        private double creditosField;
        
        private int id_cursoField;
        
        private string nombreCursoField;
        
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
        public string codigoCurso {
            get {
                return this.codigoCursoField;
            }
            set {
                this.codigoCursoField = value;
                this.RaisePropertyChanged("codigoCurso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public double creditos {
            get {
                return this.creditosField;
            }
            set {
                this.creditosField = value;
                this.RaisePropertyChanged("creditos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int id_curso {
            get {
                return this.id_cursoField;
            }
            set {
                this.id_cursoField = value;
                this.RaisePropertyChanged("id_curso");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombreCurso {
            get {
                return this.nombreCursoField;
            }
            set {
                this.nombreCursoField = value;
                this.RaisePropertyChanged("nombreCurso");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarCursoLlevado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarCursoLlevadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_alumno;
        
        public listarCursoLlevadoRequest() {
        }
        
        public listarCursoLlevadoRequest(int id_alumno) {
            this.id_alumno = id_alumno;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarCursoLlevadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarCursoLlevadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.CursoLlevadoWS.cursoLlevado[] @return;
        
        public listarCursoLlevadoResponse() {
        }
        
        public listarCursoLlevadoResponse(ProyectoOOIA.CursoLlevadoWS.cursoLlevado[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarCursoLlevado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarCursoLlevadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso;
        
        public insertarCursoLlevadoRequest() {
        }
        
        public insertarCursoLlevadoRequest(ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso) {
            this.curso = curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarCursoLlevadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarCursoLlevadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarCursoLlevadoResponse() {
        }
        
        public insertarCursoLlevadoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCursoLlevado", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarCursoLlevadoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso;
        
        public modificarCursoLlevadoRequest() {
        }
        
        public modificarCursoLlevadoRequest(ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso) {
            this.curso = curso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCursoLlevadoResponse", WrapperNamespace="http://services.OOIA.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarCursoLlevadoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.OOIA.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarCursoLlevadoResponse() {
        }
        
        public modificarCursoLlevadoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CursoLlevadoWSChannel : ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CursoLlevadoWSClient : System.ServiceModel.ClientBase<ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS>, ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS {
        
        public CursoLlevadoWSClient() {
        }
        
        public CursoLlevadoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CursoLlevadoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoLlevadoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CursoLlevadoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoResponse ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS.listarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest request) {
            return base.Channel.listarCursoLlevado(request);
        }
        
        public ProyectoOOIA.CursoLlevadoWS.cursoLlevado[] listarCursoLlevado(int id_alumno) {
            ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest inValue = new ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest();
            inValue.id_alumno = id_alumno;
            ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoResponse retVal = ((ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS)(this)).listarCursoLlevado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoResponse> ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS.listarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest request) {
            return base.Channel.listarCursoLlevadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoResponse> listarCursoLlevadoAsync(int id_alumno) {
            ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest inValue = new ProyectoOOIA.CursoLlevadoWS.listarCursoLlevadoRequest();
            inValue.id_alumno = id_alumno;
            return ((ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS)(this)).listarCursoLlevadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoResponse ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS.insertarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest request) {
            return base.Channel.insertarCursoLlevado(request);
        }
        
        public int insertarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso) {
            ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest inValue = new ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest();
            inValue.curso = curso;
            ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoResponse retVal = ((ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS)(this)).insertarCursoLlevado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoResponse> ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS.insertarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest request) {
            return base.Channel.insertarCursoLlevadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoResponse> insertarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso) {
            ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest inValue = new ProyectoOOIA.CursoLlevadoWS.insertarCursoLlevadoRequest();
            inValue.curso = curso;
            return ((ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS)(this)).insertarCursoLlevadoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoResponse ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS.modificarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest request) {
            return base.Channel.modificarCursoLlevado(request);
        }
        
        public int modificarCursoLlevado(ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso) {
            ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest inValue = new ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest();
            inValue.curso = curso;
            ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoResponse retVal = ((ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS)(this)).modificarCursoLlevado(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoResponse> ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS.modificarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest request) {
            return base.Channel.modificarCursoLlevadoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoResponse> modificarCursoLlevadoAsync(ProyectoOOIA.CursoLlevadoWS.cursoLlevado curso) {
            ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest inValue = new ProyectoOOIA.CursoLlevadoWS.modificarCursoLlevadoRequest();
            inValue.curso = curso;
            return ((ProyectoOOIA.CursoLlevadoWS.CursoLlevadoWS)(this)).modificarCursoLlevadoAsync(inValue);
        }
    }
}
