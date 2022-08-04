using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameDatabase
{
    public interface IRepoService
    {

    #region Boardgame Crud
    public Boardgame AddBoardgame(Boardgame boardgame);
    public Boardgame DeleteBoardgame(int id);
    public Boardgame GetBoardgameById(int id);
    public List<Boardgame> GetBoardgames();
    public Boardgame UpdateBoardgame(Boardgame boardgame);
    #endregion



    #region Adress Crud
    public Adress AddAdress(Adress adress);
    public Adress DeleteAdress(int id);
    public Adress GetAdressById(int id);
    public List<Adress> GetAdresses();
    public Adress UpdateAdress(Adress adress);
    #endregion
}
}
