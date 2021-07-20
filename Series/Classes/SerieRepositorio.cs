using System;
using System.Collections.Generic;
using CadastroDeSeries.Interfaces;

namespace CadastroDeSeries
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie objeto)
    {
      listaSerie[id] = objeto;

    }
    public void Exclui(int id)
    {
      //listaSerie.RemoveAt(id); não usar esse método pois ele atualiza os ids da lista
      listaSerie[id].Excluir();
    }

    public void Insere(Serie objeto)
    {
      listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }
    public int ProximoId()
    {
      return listaSerie.Count;
    }
    public Serie RetornaPorId(int id)
    {
      return listaSerie[id];
    }
  }
}