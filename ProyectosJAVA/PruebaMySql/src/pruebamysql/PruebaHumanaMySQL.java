package pruebamysql;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.ooia.gest_atencion.dao.CitaDAO;
import pe.edu.pucp.ooia.gest_atencion.dao.CodigoAtencionDAO;
import pe.edu.pucp.ooia.gest_atencion.dao.HorarioDAO;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;
import pe.edu.pucp.ooia.gest_atencion.model.CodigoAtencion;
import pe.edu.pucp.ooia.gest_atencion.model.Horario;
import pe.edu.pucp.ooia.gest_atencion.mysql.CitaMySQL;
import pe.edu.pucp.ooia.gest_atencion.mysql.CodigoAtencionMySQL;
import pe.edu.pucp.ooia.gest_atencion.mysql.HorarioMySQL;
import pe.edu.pucp.ooia.gest_humana.dao.AlumnoDAO;
import pe.edu.pucp.ooia.gest_humana.dao.ProfesorDAO;
import pe.edu.pucp.ooia.gest_humana.dao.PsicologoDAO;
import pe.edu.pucp.ooia.gest_humana.model.Alumno;
import pe.edu.pucp.ooia.gest_humana.model.Especialidad;
import pe.edu.pucp.ooia.gest_humana.model.Profesor;
import pe.edu.pucp.ooia.gest_humana.model.Psicologo;
import pe.edu.pucp.ooia.gest_humana.mysql.AlumnoMySQL;
import pe.edu.pucp.ooia.gest_humana.mysql.PsicologoMySQL;


/**
 *
 * @author PC
 */
public class PruebaHumanaMySQL {
    private static AlumnoDAO daoAlumno;
    private static ProfesorDAO daoProfesor;
    private static PsicologoDAO daoPsicologo;
    private static HorarioDAO daoHorario;
    private static CitaDAO daoCita;
    private static CodigoAtencionDAO daoCodigo;
    
    public static void main(String[] args) throws Exception{
        daoAlumno = new AlumnoMySQL();
        daoPsicologo = new PsicologoMySQL();
        daoHorario = new HorarioMySQL();
        daoCita = new CitaMySQL();
        daoCodigo= new CodigoAtencionMySQL();
        //insertarHorario();
        //listarHorario();
        //listarAlumno();
        //System.out.println(psicologos.get(0).getId_miembro_pucp());
        //insertarCita();
        listarCitas();
        //insertarPsicologo();
        //listarPsicologo();
    }
     public static void listarCitas(){
        ArrayList<Cita> citas = new ArrayList<>();
        citas = daoCita.listarPendiente(124);
        for(Cita a : citas){
//            System.out.println("Entro");
            System.out.println(a.getAsesor().getNombre()+ " " + a.getFecha()+  " " + a.getHorario().getHoraInicio()
            + " " + a.getHorario().getHoraFin());
        }
    }
    public static void insertarCita() throws Exception{
       
        Cita cita = new Cita();
        ArrayList<Alumno> alumnos = new ArrayList<>();
        alumnos = daoAlumno.listar();
        
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        psicologos = daoPsicologo.listar();
        
        ArrayList<Horario> horarios = new ArrayList<>();
        horarios = daoHorario.listar();
        
        ArrayList<CodigoAtencion> codigos = new ArrayList<>();
        codigos = daoCodigo.listar();
        
        
        cita.setAlumno(alumnos.get(26)); //alumno con cuenta en visual
        cita.setAsesor(psicologos.get(1));
        cita.setTipo_asesor(1);
        cita.setHorario(horarios.get(0));
        cita.setMotivo("No puedo organizarme con todos los cursos");
        //cita.setAsistio(true);
        cita.setCompromiso("");
        cita.setCodigo_atencion(codigos.get(1));
        SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");
        cita.setFecha(format.parse("29-06-2021")); //cita pasada
        
        int resultado = daoCita.insertar(cita);
        if(resultado !=0){
            System.out.println("Se registro la cita exitosamente"+ resultado);
        }else{
            System.out.println("Ocurrio un error al momento de insertar");
        }
    }
    
    public static void listarPsicologo(){
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        psicologos = daoPsicologo.listar();
        for(Psicologo a : psicologos){
//            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCorreo()  +  " " + a.getUsuario());
        }
    }
    
    public static void listarHorario(){
        ArrayList<Horario> horarios = new ArrayList<>();
        horarios = daoHorario.listar();
        for(Horario a : horarios){
//            System.out.println("Entro");
            System.out.println(a.getDia()+ " " + a.getHoraInicio()+  " " + a.getHoraFin());
        }
    }
    public static void insertarHorario() throws Exception{
       
        Horario horario = new Horario();
       
        horario.setDia(1);
        SimpleDateFormat format = new SimpleDateFormat("hh:mm");
        horario.setHoraInicio(format.parse("10:30"));
        horario.setHoraFin(format.parse("11:00"));
        int resultado = daoHorario.insertar(horario);
        if(resultado !=0){
            System.out.println("Se registro el horario exitosamente"+ resultado);
        }else{
            System.out.println("Ocurrio un error al momento de insertar");
        }
    }
    
     public static void insertarPsicologo(){
       
        Psicologo psicologo = new Psicologo();
        //Insertar
        //Atributos persona
        psicologo.setDni("06292910");
        psicologo.setNombre("Jorge Gonzales");
        psicologo.setDireccion("Lima");
        psicologo.setCorreo("a10303919@pucp.edu");
        
        //Atributos miembro pucp
        psicologo.setUsuario("2083123@pucp.edu.pe");
        psicologo.setPassword("password");
        psicologo.setFecha_inclusion(new Date());
     

        int resultado = daoPsicologo.insertar(psicologo);//no lo pobre, falta modificar el mySQL
        if(resultado !=0){
            System.out.println("Se registro al psicologo exitosamente"+ resultado);
        }else{
            System.out.println("Ocurrio un error al momento de insertar");
        }
    }
     
    public static void listarProfesor(){
        ArrayList<Profesor> profesores = new ArrayList<>();
        profesores = daoProfesor.listar();
        for(Profesor a : profesores){
//            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCorreo()  + " " + 
                    a.getFacultad() + " " + a.getUsuario() + " " + a.getCategoria());
        }
    }
    public static void listarAlumno(){
        ArrayList<Alumno> alumnos = new ArrayList<>();
        alumnos = daoAlumno.listar();
        for(Alumno a : alumnos){
            System.out.println("Entro");
            System.out.println(a.getId_alumno() + " " + a.getNombre() + " " + a.getCorreo() + " " + a.getCodigo() + " " + 
                    a.getCraest());
        }
    }
    public static void insertarAlumno(){
        Alumno alum = new Alumno();
        
        //Insertar
        //Atributos persona
        alum.setDni("66666666");
        alum.setNombre("Jorge Basadre");
        alum.setDireccion("jr. banhio de los incas, urb manco capac");
        alum.setCorreo("dasjdjasdjasjdas@pucp.edu.pe");
        
        //Atributos miembro pucp
        alum.setUsuario("2083123@pucp.edu.pe");
        alum.setPassword("password");
        alum.setFecha_inclusion(new Date());
        
        //Atributos Alumno
        alum.setCodigo("20203212");
        Especialidad esp = new Especialidad();
        esp.setId_especialidad(3);
      
        alum.setEspecialidad(esp);
        alum.setCraest(54.5);

        int resultado = daoAlumno.insertar(alum);//no lo pobre, falta modificar el mySQL
        if(resultado !=0){
            System.out.println("Se registro al alumno exitosamente"+ resultado);
        }else{
            System.out.println("Ocurrio un error al momento de insertar");
        }
    }
}
