/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ooia.gest_humana.dao;

import java.sql.Date;
import pe.edu.pucp.ooia.gest_atencion.model.Cita;

/**
 *
 * @author PC
 */
public interface AutenticarPersonaDAO {
    public int autenticarPersona(int dni);
    public int autenticarUsuarioUnico(String usuario);
    public int validarUnicoRegistroAEvento(int id_alumno,int id_evento);
    public int validarRegistroACita(int id_alumno,int id_horario,Cita cita);
    public int validarUnicaOpinionCita(int id_alumno,int fid_asesor,int fid_cita);
}
