using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

 public class ClientesBLL
{
    private Contexto _Contexto;

    public ClientesBLL(Contexto contexto){
        _Contexto= contexto;
    }

    public bool Existe(int clientesId){

        return _Contexto.clientes.Any(o=> o.ClienteId==clientesId);
    }

    private bool Insertar( clientes cliente){
        _Contexto.clientes.Add(cliente);

        return _Contexto.SaveChanges()>0;
    }

    private bool Modificar(clientes cliente){
        _Contexto.Entry(cliente).State = EntityState.Modified;

        return _Contexto.SaveChanges()>0;

    }

    public bool Guardar(clientes clientes){
        if(!Existe(clientes.ClienteId)){
            return this.Insertar(clientes);
        }
        else{
            return this.Modificar(clientes);
        }
    }

    public bool Eliminar (clientes clientes){
        _Contexto.Entry(clientes).State= EntityState.Deleted;

        return _Contexto.SaveChanges()>0;
    }

    public clientes? Buscar( int clienteId){
     return _Contexto.clientes.Where(o=> o.ClienteId == clienteId).AsTracking().SingleOrDefault();
    }

    public List<clientes> GetList(Expression<Func<clientes,bool>>criterio){

        return _Contexto.clientes.AsNoTracking().Where(criterio).ToList();
    }

    
}