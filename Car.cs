using System;
namespace EndOfWeek5
{
	public class Araba
	{
		public Araba()
		{
			UretimTarihi = DateTime.Now;
		}
		public string SeriNumarasi { get; set; }
		public string Marka { get; set; }
		public string Renk { get; set; }
        public int KapiSayisi
        {
            get
			{
				if (KapiSayisi != 2 || KapiSayisi != 4)
					return KapiSayisi = -1;
				else
					return KapiSayisi;

			}
			set
			{												
			}
		}
		public DateTime UretimTarihi { get; set; }
	}
}
