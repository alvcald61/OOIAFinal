/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.gestion_eventos.dao;

import java.sql.Date;
import java.util.ArrayList;
import pe.edu.pucp.gestion_eventos.model.Evento;

/**
 *
 * @author PC
 */
public interface EventoDAO {
    public ArrayList<Evento> listar(String nombreCategoria);
    public ArrayList<Evento> listar_tres_eventos_proximos();
    public ArrayList<Evento> listar_x_fecha(Date fecha);
    public int insertar(Evento evento);
    public int modificar(Evento evento);
    public int eliminar(int id_evento);
}
