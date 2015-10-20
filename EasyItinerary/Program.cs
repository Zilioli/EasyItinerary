using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EasyItinerary
{
    class Program
    {
        //next_page_token
        static void Main(string[] args)
        {

            WebRequest request;
            WebResponse response;
            Stream dataStream;
            StreamReader reader;
            foreach (string place in LoadTypes())
            {
                request = WebRequest.Create("https://maps.googleapis.com/maps/api/place/nearbysearch/xml?location=-23.550634,-46.6704821&radius=500000&types=" + place + "&key=AIzaSyDzS98V-pYiz5NJ7ErRgQ5Y_XypaY9-9n0");
                request.Credentials = CredentialCache.DefaultCredentials;
                response = request.GetResponse();
                dataStream =  response.GetResponseStream();
                reader =  new StreamReader(dataStream);

                File.WriteAllText("C:\\Projetos\\" + place + ".xml", reader.ReadToEnd(), Encoding.UTF8);

                reader.Close();
                response.Close();

                request = null;
                response = null;
                dataStream = null;
                reader = null;
            }
        }

        private static List<string> LoadTypes()
        {
            List<string> types = new List<string>();
            types.Add("accounting");
            types.Add("airport");
            types.Add("amusement_park");
            types.Add("aquarium");
            types.Add("art_gallery");
            types.Add("atm");
            types.Add("bakery");
            types.Add("bank");
            types.Add("bar");
            types.Add("beauty_salon");
            types.Add("bicycle_store");
            types.Add("book_store");
            types.Add("bowling_alley");
            types.Add("bus_station");
            types.Add("cafe");
            types.Add("campground");
            types.Add("car_dealer");
            types.Add("car_rental");
            types.Add("car_repair");
            types.Add("car_wash");
            types.Add("casino");
            types.Add("cemetery");
            types.Add("church");
            types.Add("city_hall");
            types.Add("clothing_store");
            types.Add("convenience_store");
            types.Add("courthouse");
            types.Add("dentist");
            types.Add("department_store");
            types.Add("doctor");
            types.Add("electrician");
            types.Add("electronics_store");
            types.Add("embassy");
            types.Add("establishment");
            types.Add("finance");
            types.Add("fire_station");
            types.Add("florist");
            types.Add("food");
            types.Add("funeral_home");
            types.Add("furniture_store");
            types.Add("gas_station");
            types.Add("general_contractor");
            types.Add("grocery_or_supermarket");
            types.Add("gym");
            types.Add("hair_care");
            types.Add("hardware_store");
            types.Add("health");
            types.Add("hindu_temple");
            types.Add("home_goods_store");
            types.Add("hospital");
            types.Add("insurance_agency");
            types.Add("jewelry_store");
            types.Add("laundry");
            types.Add("lawyer");
            types.Add("library");
            types.Add("liquor_store");
            types.Add("local_government_office");
            types.Add("locksmith");
            types.Add("lodging");
            types.Add("meal_delivery");
            types.Add("meal_takeaway");
            types.Add("mosque");
            types.Add("movie_rental");
            types.Add("movie_theater");
            types.Add("moving_company");
            types.Add("museum");
            types.Add("night_club");
            types.Add("painter");
            types.Add("park");
            types.Add("parking");
            types.Add("pet_store");
            types.Add("pharmacy");
            types.Add("physiotherapist");
            types.Add("place_of_worship");
            types.Add("plumber");
            types.Add("police");
            types.Add("post_office");
            types.Add("real_estate_agency");
            types.Add("restaurant");
            types.Add("roofing_contractor");
            types.Add("rv_park");
            types.Add("school");
            types.Add("shoe_store");
            types.Add("shopping_mall");
            types.Add("spa");
            types.Add("stadium");
            types.Add("storage");
            types.Add("store");
            types.Add("subway_station");
            types.Add("synagogue");
            types.Add("taxi_stand");
            types.Add("train_station");
            types.Add("travel_agency");
            types.Add("university");
            types.Add("veterinary_care");
            types.Add("zoo");

            return types;
        }
    }
}
