using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POIApp
{
    public class POIJsonService:IPOIDataService
    {
        public POIJsonService()
        {

        }

        #region IPOIDateService implementarion
        
        public void RefreshCache()
        {
            throw new NotImplementedException();
        }

        public PointOfInterest GetPOI (int id)
        {
            throw new NotImplementedException();
        }

        public void SavePOI (PointOfInterest poi)
        {
            throw new NotImplementedException();
        }

        public void DeletePOI (PointOfInterest poi)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IReadOnlyList<PointOfInterest> POIs
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}