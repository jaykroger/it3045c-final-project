using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Models;

namespace IT3045C_Final_Project.Interfaces
{
    public interface IFoodsContextDAO
    {
        int? AddFood(FavoriteFoods personsFood);
        List<FavoriteFoods> GetAllFoods();
        
        FavoriteFoods GetFoodById(int id);
        int? RemoveFoodById(int id);
        int? UpdateFood(FavoriteFoods personsFood);
    }
}


