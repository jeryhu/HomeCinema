using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeCinema.Data.Repositories;
using HomeCinema.Entities;

namespace HomeCinema.Data.Extensions
{
    public static class StockExtensions
    {
        public static IEnumerable<Stock> GetAvailableItems(this IEntityBaseRepository<Stock> stocksRepository, int movieId)
        {
            IEnumerable<Stock> availableItems = stocksRepository.GetAll().Where(s => s.MovieId == movieId && s.IsAvailable);

            return availableItems;
        }

        //public static IEnumerable<Stock> GetAllItems(this IEntityBaseRepository<Stock> stocksRepository, int movieId)
        //{
        //    IEnumerable<Stock> _allItems;

        //    _allItems = stocksRepository.GetAll().Where(s => s.MovieId == movieId);

        //    return _allItems;
        //}
    }
}
