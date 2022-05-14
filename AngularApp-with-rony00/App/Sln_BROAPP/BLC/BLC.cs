using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLC
{
    // BLC : Business Logic Component.
    public class BLC
    {
        public string connStr = "";
        public List<Court> GetAllCourts()
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            List<Court> oList = oDALC.GetAllCourts();
            oList = oList.OrderByDescending(e => e.COURT_ID).ToList();
            oList.RemoveAll(e => e.ADDRESS == "Tripoli");
            return oList;
        }

        //You should always create a complex type (Class) which has properties matching parameters
        public void Delete_Court(Params_Delete_Court i_Params_Delete_Court)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Delete_Court(i_Params_Delete_Court);
        }


        public void Add_Court(Court i_COURT)
        {
            DALC.DALC oDALC = new DALC.DALC();
            oDALC.connStr = this.connStr;
            oDALC.Add_Court(i_COURT);
        }
    }

    
}
