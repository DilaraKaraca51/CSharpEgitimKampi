using DevExpress.Utils.Serializing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp301.EFProject
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities1 db = new EgitimKampiEFTravelDbEntities1();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı 
            label2.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.Capacity)?.ToString("0.00");
            lblAvgLocationPrice.Text = db.Location.Average(x => x.Price)?.ToString("0.00") + "₺";
            
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountry.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.County).FirstOrDefault();

            lblCapadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            lblAvgTurkeyCapacity.Text = db.Location.Where(x => x.County == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault(); 
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.Location.Max(x => x.Price);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameDilaraKaraca = db.Guide.Where(x => x.GuideName == "Dilara" && x.GuideSurname == "Karaca").Select(y => y.GuideId).FirstOrDefault();
            lblDilaraLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameDilaraKaraca).Count().ToString();
            #endregion
        }

      
    }
}
