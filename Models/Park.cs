using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LocalPark.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Trails { get; set; }
    public string Notes {  get; set; }

    public static List<Park> GetParks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert
        .DeserializeObject<JObject>
        (result);
      List<Park> parkList = JsonConvert
        .DeserializeObject<List<Park>>
        (jsonResponse.ToString());
      
      return parkList;
    }
  }
}