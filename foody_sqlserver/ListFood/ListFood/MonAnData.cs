using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFood
{
    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int price { get; set; }
        public int num_order { get; set; } = 0;
        public int total
        {
            get
            {
                return num_order * price;
            }
        }

        public static List<Food> GetFoods()
        {
            return null;// VBSQLHelper.SQLHelper.ExecQueryData<Food>("SELECT * FROM TBL_FOOD").ToList();
        }
        //public class FoodData
        //{
        //    public List<Food> getDataExample()
        //    {
        //        var listFood = new List<Food>();                
        //        listFood.Add(new Food() { id = 1, name = "Bánh mỳ Tuấn Mập", url = "mon1.jpg", price = 15000 });
        //        listFood.Add(new Food() { id = 2, name = "Mì xào hải sản", url = "mon2.jpg", price = 350000 });
        //        listFood.Add(new Food() { id = 3, name = "Cua chiên giòn", url = "mon3.jpg", price = 157000 });
        //        listFood.Add(new Food() { id = 4, name = "Lẩu dê", url = "mon4.jpg", price = 120000 });
        //        listFood.Add(new Food() { id = 5, name = "Gà bó xôi", url = "mon5.jpg", price = 135000 });
        //        listFood.Add(new Food() { id = 6, name = "Cánh gà chiên nước mắm", url = "mon6.jpg", price = 75000 });
        //        listFood.Add(new Food() { id = 7, name = "Gỏi ngó sen", url = "mon7.jpg", price = 35000 });
        //        listFood.Add(new Food() { id = 8, name = "Tôm hấp nước dừa", url = "mon8.jpg", price = 205000 });
        //        listFood.Add(new Food() { id = 9, name = "Bò la gu", url = "mon9.jpg", price = 425000 });
        //        listFood.Add(new Food() { id = 10, name = "Cháo bồ câu", url = "mon10.jpg", price = 355000 });
        //        listFood.Add(new Food() { id = 11, name = "Chân gà hấp hành", url = "mon11.jpg", price = 180000 });
        //        listFood.Add(new Food() { id = 12, name = "Bánh tráng miệng", url = "mon12.jpg", price = 120000 });
        //        listFood.Add(new Food() { id = 13, name = "Lẩu hải sản", url = "mon13.jpg", price = 58000 });
        //        listFood.Add(new Food() { id = 14, name = "Dê hấp", url = "mon14.jpg", price = 972000 });
        //        listFood.Add(new Food() { id = 15, name = "Bạch tuột nướng muối ớt", url = "mon15.jpg", price = 125000 });
        //        listFood.Add(new Food() { id = 16, name = "Cánh gà hấp hành", url = "mon16.jpg", price = 110000 });
        //        listFood.Add(new Food() { id = 17, name = "Vịt quay", url = "mon17.jpg", price = 255000 });
        //        listFood.Add(new Food() { id = 18, name = "Dồi trường hấp gừng", url = "mon18.jpg", price = 345000 });
        //        listFood.Add(new Food() { id = 19, name = "Trứng cút chiên bột", url = "mon19.jpg", price = 285000 });
        //        listFood.Add(new Food() { id = 20, name = "Gà tiềm thuốc bắc", url = "mon20.jpg", price = 75000 });
        //        listFood.Add(new Food() { id = 21, name = "Rau muống xào", url = "mon21.jpg", price = 65000 });
        //        listFood.Add(new Food() { id = 22, name = "Gà hấp hành", url = "mon22.jpg", price = 505000 });
        //        listFood.Add(new Food() { id = 23, name = "Lẩu ớt hiểm", url = "mon23.jpg", price = 305000 });
        //        listFood.Add(new Food() { id = 24, name = "Ốc nước mỡ hành", url = "mon24.jpg", price = 85000 });
        //        listFood.Add(new Food() { id = 25, name = "Bánh bao", url = "mon25.jpg", price = 15000 });
        //        listFood.Add(new Food() { id = 26, name = "Tôm hấp bia", url = "mon26.jpg", price = 245000 });
        //        listFood.Add(new Food() { id = 27, name = "Xôi chiên", url = "mon27.jpg", price = 375000 });
        //        listFood.Add(new Food() { id = 28, name = "Cơm chiên hải sản", url = "mon28.jpg", price = 215000 });
        //        listFood.Add(new Food() { id = 29, name = "Bò lúc lắc", url = "mon29.jpg", price = 185000 });
        //        listFood.Add(new Food() { id = 30, name = "Cá chép hầm xương", url = "mon30.jpg", price = 95000 });
        //        listFood.Add(new Food() { id = 31, name = "Bia Tiger", url = "mon32.jpg", price = 13500 });
        //        listFood.Add(new Food() { id = 32, name = "Bia Hà Nội", url = "mon33.jpg", price = 10000 });


        //        return listFood;

        //    }
        //}
    }
}
