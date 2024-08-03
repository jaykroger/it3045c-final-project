using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Interfaces
{
    public interface IFoodsContextDAO
    {
        List<FavoriteFoods> GetAllFoods();
        FavoriteFoods GetFoodsById(int id);
        FavoriteFoods RemoveFoodById(int id);
    }
}
