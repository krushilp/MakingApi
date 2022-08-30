using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Configuration;
using MakingApi.Models;
using System.Data;

namespace MakingApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlBeepzDB"].ConnectionString);
        fetchCarsList carsList = new fetchCarsList();


        public List<fetchCarsList> Get()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("fetchcarlist",sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            List<fetchCarsList> getCarList = new List<fetchCarsList>();
            Console.WriteLine(dt.Rows.Count);
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    fetchCarsList carsList = new fetchCarsList();
                    carsList.carName = dt.Rows[i]["name"].ToString();
                    carsList.carDesc = dt.Rows[i]["description"].ToString();
                    carsList.carBrandName = dt.Rows[i]["carbrandname"].ToString();
                    carsList.carUserName = dt.Rows[i]["firstname"].ToString();
                    carsList.carUserID = Int32.Parse(dt.Rows[i]["userid"].ToString());
                    carsList.carUserCity = dt.Rows[i]["cityName"].ToString();
                    carsList.carType = Int32.Parse(dt.Rows[i]["cartype"].ToString());
                    carsList.carMPG = (int)decimal.Parse(dt.Rows[i]["milespergallon"].ToString());
                    carsList.carFuelType = Int32.Parse(dt.Rows[i]["fueltype"].ToString());
                    carsList.carGearBox = Int32.Parse(dt.Rows[i]["gearbox"].ToString());
                    carsList.carCapacity = Int32.Parse(dt.Rows[i]["capacity"].ToString());
                    carsList.carYear = Int32.Parse(dt.Rows[i]["year"].ToString());
                    carsList.carCondition = Int32.Parse(dt.Rows[i]["condition"].ToString());
                    carsList.carMileage = Int32.Parse(dt.Rows[i]["mileage"].ToString());
                    carsList.carPrice = (int)decimal.Parse(dt.Rows[i]["price"].ToString());
                    carsList.carIsActive = dt.Rows[i]["isactive"].ToString();
                    carsList.carViews = dt.Rows[i]["views"].ToString();
                    carsList.carCreatedDate = dt.Rows[i]["createddate"].ToString();
                    carsList.carVin = dt.Rows[i]["vin"].ToString();
                    getCarList.Add(carsList);
                }
            }
            if(getCarList.Count > 0)
            {
                return getCarList;
            }
            else
            {
                return null;
            }
        }

        // GET api/values/5
        public fetchCarsList Get(int id)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("fetchcar", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@userid", id);
            //sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@usercityname", userCityName);
            //sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@highercarprice", carPrice);
            //sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@carcondition", carCondition);
            //sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@caryear", carYear);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            fetchCarsList carsList = new fetchCarsList();
            if (dt.Rows.Count > 0)
            {
                
                carsList.carName = dt.Rows[0]["name"].ToString();
                carsList.carDesc = dt.Rows[0]["description"].ToString();
                carsList.carBrandName = dt.Rows[0]["carbrandname"].ToString();
                carsList.carUserName = dt.Rows[0]["firstname"].ToString();
                carsList.carUserID = Int32.Parse(dt.Rows[0]["userid"].ToString());
                carsList.carUserCity = dt.Rows[0]["cityName"].ToString();
                carsList.carType = Int32.Parse(dt.Rows[0]["cartype"].ToString());
                carsList.carMPG = (int)decimal.Parse(dt.Rows[0]["milespergallon"].ToString());
                carsList.carFuelType = Int32.Parse(dt.Rows[0]["fueltype"].ToString());
                carsList.carGearBox = Int32.Parse(dt.Rows[0]["gearbox"].ToString());
                carsList.carCapacity = Int32.Parse(dt.Rows[0]["capacity"].ToString());
                carsList.carYear = Int32.Parse(dt.Rows[0]["year"].ToString());
                carsList.carCondition = Int32.Parse(dt.Rows[0]["condition"].ToString());
                carsList.carMileage = Int32.Parse(dt.Rows[0]["mileage"].ToString());
                carsList.carPrice = (int)decimal.Parse(dt.Rows[0]["price"].ToString());
                carsList.carIsActive = dt.Rows[0]["isactive"].ToString();
                carsList.carViews = dt.Rows[0]["views"].ToString();
                carsList.carCreatedDate = dt.Rows[0]["createddate"].ToString();
                carsList.carVin = dt.Rows[0]["vin"].ToString();
                


            }
            if (carsList != null)
            {
                return carsList;
            }
            else
            {
                return null;
            }

        }


        

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
