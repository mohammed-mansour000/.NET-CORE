using System;

namespace Entities
{
    public class Params_Delete_Court //COMPLEX
    {
        //Priitive types: int, long, datetime
        public int COURT_ID { get; set; }
    }
    public class Court
    {
        public int COURT_ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
    }
}
