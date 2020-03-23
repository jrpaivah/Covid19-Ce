using System;
using System.Collections.Generic;
using COVID.Application.ViewModels;

namespace COVID.Application.Interfaces
{
  public interface ITotalRegiaoService : IDisposable
  {
    List<TotalRegiaoViewModel> Total();
  }
}
