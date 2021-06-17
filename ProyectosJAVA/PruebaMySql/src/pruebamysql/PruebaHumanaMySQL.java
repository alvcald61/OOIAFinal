package pruebamysql;

import java.util.ArrayList;
import java.util.Date;
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
    
    
    public static void main(String[] args) {
        daoAlumno = new AlumnoMySQL();
        daoPsicologo = new PsicologoMySQL();
        
        insertarPsicologo();
        listarPsicologo();
    }
    
    public static void listarPsicologo(){
        ArrayList<Psicologo> psicologos = new ArrayList<>();
        psicologos = daoPsicologo.listar();
        for(Psicologo a : psicologos){
//            System.out.println("Entro");
            System.out.println(a.getNombre() + " " + a.getCorreo()  +  " " + a.getUsuario());
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
