using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final_Project.Data
{
    public class FoodsContextDAO : IFoodsContextDAO
    {
        private FavoriteFoodsContext _context;
        public FoodsContextDAO(FavoriteFoodsContext context) 
        {
            _context = context;
        }

        public int? AddFood(FavoriteFoods personsFood)
        {
            var personsFoods = _context.FavoriteFood.Where(x => x.Id.Equals(personsFood.Id) && x.FavSnack.Equals(personsFood.FavSnack)).FirstOrDefault();

            if (personsFoods == null)
            {
                return null;
            }

            try
            {
                _context.FavoriteFood.Add(personsFood);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception) { return 0; }
        }



        //implements IFoodsContext
        public List<FavoriteFoods> GetAllFoods()
        {
           return _context.FavoriteFood.ToList();
        }

        public FavoriteFoods GetFoodById(int id)
        {
            return _context.FavoriteFood.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveFoodById(int id)
        {
            var result =  this.GetFoodById(id);

            if (result == null) 
            {
                return null;
            }
            try
            {
                _context.FavoriteFood.Remove(result);
                _context.SaveChanges();
                return 1;
            }

            catch (Exception)
            {
                return 0;
            }
        }

        public int? UpdateFood(FavoriteFoods personsFood)
        {
           var personsFoodToUpdate = this.GetFoodById(personsFood.Id);
            if (personsFoodToUpdate == null)
            {
                return null;
            }

            personsFoodToUpdate.FavBreakfast = personsFood.FavBreakfast;
            personsFoodToUpdate.FavLunch = personsFood.FavLunch;
            personsFoodToUpdate.FavSnack = personsFood.FavSnack;
            personsFoodToUpdate.FavDinner = personsFood.FavDinner;

            try
            {
                _context.FavoriteFood.Update(personsFoodToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

          
        }
    }
}
