using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global_Store_Admin.Entity;
namespace Global_Store_Admin.WebInteraction
{
    public class WebInteraction
    {
        public string BASIC_WEB = "https://localhost:";
        public string GETFEEDBACKS = "getFeedback";

        public WebInteraction()
        { 
        
        }
        public List<Feedback> getListFeedback()
        {
            List<Feedback> listOFFeedbacks = new List<Feedback>();


            return listOFFeedbacks;
        }
    }
}
