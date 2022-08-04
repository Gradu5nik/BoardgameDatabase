using BoardgameDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameDatabase.Services
{
    public class EFRepoService : IRepoService
    {
        private BoardgameDBContext context;

        public EFRepoService(BoardgameDBContext service)
        {
            context = service;
        }
        #region Boardgame Crud
        public Boardgame AddBoardgame(Boardgame boardgame)
        {
            context.Boardgames.Add(boardgame);
            context.SaveChanges();
            return boardgame;
        }
        public Boardgame DeleteBoardgame(int id)
        {
            Boardgame boardgame = context.Boardgames.Find(id);
            context.Boardgames.Remove(boardgame);
            context.SaveChanges();
            return boardgame;
        }
        public Boardgame GetBoardgameById(int id)
        {
            Boardgame boardgame = context.Boardgames.Find(id);
            return boardgame;
        }
        public List<Boardgame> GetBoardgames()
        {
            return context.Boardgames.ToList();
        }
        public Boardgame UpdateBoardgame(Boardgame boardgame)
        {
            context.Boardgames.Update(boardgame);
            context.SaveChanges();
            return boardgame;
        }

        #endregion



        #region Adress Crud
        public Adress AddAdress(Adress adress)
        {
            context.Adresses.Add(adress);
            context.SaveChanges();
            return adress;
        }
        public Adress DeleteAdress(int id)
        {
            Adress adress = context.Adresses.Find(id);
            context.Adresses.Remove(adress);
            context.SaveChanges();
            return adress;
        }
        public Adress GetAdressById(int id)
        {
            Adress adress = context.Adresses.Find(id);
            return adress;
        }
        public List<Adress> GetAdresses()
        {
            return context.Adresses.ToList();
        }
        public Adress UpdateAdress(Adress adress)
        {
            context.Adresses.Update(adress);
            context.SaveChanges();
            return adress;
        }
        #endregion
    }
}
