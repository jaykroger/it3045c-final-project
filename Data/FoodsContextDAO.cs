using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Data
{
    public class FoodsContextDAO : IFoodsContextDAO
    {
        private FavoriteFoodsContext _context;
        public FoodsContextDAO(FavoriteFoodsContext context) 
        {
            _context = context;
        }

        public List<FavoriteFoods> GetAllFoods()
        {
           return _context.FavoriteFoods.ToList();
        }

        public FavoriteFoods GetFoodsById(int id)
        {
            return _context.FavoriteFoods.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public FavoriteFoods RemoveFoodById(int id)
        {
            var food = this.GetFoodsById(id);
            if (food == null)  return null; 
            try
            { 
                _context.FavoriteFoods.Remove(food);
                return food;
            }
            catch (Exception) 
            {
                return new FavoriteFoods();
            }
           
        }
    }
}
